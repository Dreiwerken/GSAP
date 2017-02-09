using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace GitlabSearchAcrossProjects
{
    public partial class MainForm : Form
    {
        public Dictionary<int, string> projectIds = new Dictionary<int, string>();
        public Dictionary<int, List<string>> projectFiles = new Dictionary<int, List<string>>();

        string cachePath = AppDomain.CurrentDomain.BaseDirectory + "/cache/";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(cachePath))
                Directory.CreateDirectory(cachePath);

            apiKey.Text = Properties.Settings.Default["LastAPIKey"].ToString();
            baseURL.Text = Properties.Settings.Default["LastBaseUrl"].ToString();
        }

        private void getProjects_Click(object sender, EventArgs e)
        {
            baseURL.Text = baseURL.Text.Trim();
            apiKey.Text = apiKey.Text.Trim();

            if (baseURL.Text == "" || apiKey.Text == "")
            {
                MessageBox.Show("Please fill the base url & api key textbox", this.Text);
                return;
            }

            this.Size = new System.Drawing.Size(555, 270);
            Properties.Settings.Default["LastAPIKey"] = apiKey.Text;
            Properties.Settings.Default["LastBaseUrl"] = baseURL.Text;
            Properties.Settings.Default.Save();
            try
            {
                getProjectsDownload();
            }
            catch(Exception ex)
            {
                downloadProgress.Visible = false;
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearCache_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(cachePath))
                Directory.Delete(cachePath, true);

            Directory.CreateDirectory(cachePath);
            MessageBox.Show("Cache cleared", this.Text);
        }

        private void getProjectsDownload(int page = 1, WebClient webWorker = null)
        {
            if(File.Exists(cachePath+"projectIds.json"))
            {
                projectIds = JsonConvert.DeserializeObject<Dictionary<int, string>>(File.ReadAllText(cachePath + "projectIds.json"));
                getProjectsFinish();
                return;
            }

            if (webWorker == null)
            {
                projectIds.Clear();
                webWorker = getNewWebClient();
            }

            string allProjectsUrl = baseURL.Text + Properties.Settings.Default.apiPath + "projects/all?private_token=" + apiKey.Text + "&per_page=100&page=";
            webWorker.DownloadStringCompleted += new DownloadStringCompletedEventHandler(delegate (object s, DownloadStringCompletedEventArgs a)
            {
                // fetch data
                List<GitlabProjectStruct> projectList = JsonConvert.DeserializeObject<List<GitlabProjectStruct>>(a.Result);

                // read data
                foreach(GitlabProjectStruct project in projectList)
                {
                    projectIds.Add(project.id, project.path_with_namespace);
                }

                if(projectList.Count > 0)
                {
                    // download next page
                    webWorker.DownloadStringAsync(new Uri(allProjectsUrl + ++page));
                }
                else
                {
                    // finish
                    getProjectsFinish(true);
                }
            });

            downloadProgress.Visible = true;
            webWorker.DownloadStringAsync(new Uri(allProjectsUrl + page));
        }

        private void getProjectsFinish(bool writeCache = false)
        {
            if(writeCache)
            {
                File.WriteAllText(cachePath + "projectIds.json", JsonConvert.SerializeObject(projectIds));
            }

            getProjectFilesDownload(new Stack<int>(projectIds.Keys));
        }

        private void getProjectFilesDownload(Stack<int> workList, WebClient webWorker = null)
        {
            if (File.Exists(cachePath + "projectFiles.json"))
            {
                projectFiles = JsonConvert.DeserializeObject<Dictionary<int, List<string>>>(File.ReadAllText(cachePath + "projectFiles.json"));
                getProjectFilesFinish();
                return;
            }

            if (workList.Count <= 0)
                return;

            if (webWorker == null)
            {
                projectFiles.Clear();
                webWorker = getNewWebClient();
            }

            string allFilesUrl = baseURL.Text + Properties.Settings.Default.apiPath + "projects/%s/repository/tree/?private_token=" + apiKey.Text + "&path=/&recursive=true";
            int projectId = workList.Pop();

            webWorker.DownloadStringCompleted += new DownloadStringCompletedEventHandler(delegate (object s, DownloadStringCompletedEventArgs a)
            {

                if (a.Error != null)
                {
                    // @TODO Add Error log
                    projectId = workList.Pop();
                    downloadProgress.Value++;
                    webWorker.DownloadStringAsync(new Uri(allFilesUrl.Replace("%s", projectId.ToString())));
                    return;
                }
                
                // fetch data
                List<GitlabFileStruct> fileList = JsonConvert.DeserializeObject<List<GitlabFileStruct>>(a.Result);

                // read data
                foreach (GitlabFileStruct file in fileList)
                {
                    if (file.type != "blob")
                        continue;

                    if(!projectFiles.ContainsKey(projectId))
                    {
                        projectFiles.Add(projectId, new List<string>());
                    }

                    projectFiles[projectId].Add(file.path);
                }

                if (workList.Count > 0)
                {
                    // download next page
                    projectId = workList.Pop();
                    downloadProgress.Value++;
                    webWorker.DownloadStringAsync(new Uri(allFilesUrl.Replace("%s", projectId.ToString())));
                }
                else
                {
                    // finish
                    getProjectFilesFinish(true);
                }
            });
            
            downloadProgress.Visible = true;
            downloadProgress.Style = ProgressBarStyle.Blocks;
            downloadProgress.Value = 0;
            downloadProgress.Maximum = workList.Count;

            webWorker.DownloadStringAsync(new Uri(allFilesUrl.Replace("%s", projectId.ToString())));
        }

        private void getProjectFilesFinish(bool writeCache = false)
        {
            if(writeCache)
            {
                File.WriteAllText(cachePath + "projectFiles.json", JsonConvert.SerializeObject(projectFiles));
            }

            downloadProgress.Visible = false;
            this.Size = new System.Drawing.Size(555, 530);
        }

        private WebClient getNewWebClient()
        {
            WebClient webClient = new WebClient();
            webClient.Headers["UserAgent"] = "GSAP/" + Application.ProductVersion;
            return webClient;
        }

        private void search_Click(object sender, EventArgs e)
        {
            search.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            new Thread(delegate () {
                searchRes.Invoke((Action)delegate
                {
                    searchRes.Nodes.Clear();
                });

                foreach(var project in projectFiles)
                {
                    string projectName = projectIds[project.Key];
                    foreach(string file in project.Value)
                    {
                        if ((!matchExact.Checked && file.Contains(searchText.Text)) || file == searchText.Text)
                        {
                            searchRes.Invoke((Action)delegate
                            {
                                if (!searchRes.Nodes.ContainsKey(projectName))
                                {
                                    searchRes.Nodes.Add(projectName, projectName);
                                }

                                searchRes.Nodes[projectName].Nodes.Add(file);
                            });
                        }
                    }
                }

                search.Invoke((Action)delegate
                {
                    search.Enabled = true;
                });

                this.Invoke((Action)delegate
                {
                    this.Cursor = Cursors.Default;
                });
            }).Start();
        }

        private void copyright_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.dreiwerken.de/?ref=GSAP");
        }
    }
}
