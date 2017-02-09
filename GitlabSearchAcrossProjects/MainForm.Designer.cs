namespace GitlabSearchAcrossProjects
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.baseURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apiKey = new System.Windows.Forms.TextBox();
            this.getProjects = new System.Windows.Forms.Button();
            this.clearCache = new System.Windows.Forms.Button();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchRes = new System.Windows.Forms.TreeView();
            this.matchExact = new System.Windows.Forms.CheckBox();
            this.copyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // baseURL
            // 
            this.baseURL.Location = new System.Drawing.Point(104, 117);
            this.baseURL.Name = "baseURL";
            this.baseURL.Size = new System.Drawing.Size(414, 20);
            this.baseURL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "GSAP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gitlab Search Across Projects";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gitlab Base URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gitlab API Key";
            // 
            // apiKey
            // 
            this.apiKey.Location = new System.Drawing.Point(104, 143);
            this.apiKey.Name = "apiKey";
            this.apiKey.Size = new System.Drawing.Size(414, 20);
            this.apiKey.TabIndex = 5;
            // 
            // getProjects
            // 
            this.getProjects.Location = new System.Drawing.Point(16, 180);
            this.getProjects.Name = "getProjects";
            this.getProjects.Size = new System.Drawing.Size(422, 23);
            this.getProjects.TabIndex = 8;
            this.getProjects.Text = "Get Project Data";
            this.getProjects.UseVisualStyleBackColor = true;
            this.getProjects.Click += new System.EventHandler(this.getProjects_Click);
            // 
            // clearCache
            // 
            this.clearCache.Location = new System.Drawing.Point(443, 180);
            this.clearCache.Name = "clearCache";
            this.clearCache.Size = new System.Drawing.Size(75, 23);
            this.clearCache.TabIndex = 9;
            this.clearCache.Text = "Clear Cache";
            this.clearCache.UseVisualStyleBackColor = true;
            this.clearCache.Click += new System.EventHandler(this.clearCache_Click);
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(16, 207);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(502, 10);
            this.downloadProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.downloadProgress.TabIndex = 10;
            this.downloadProgress.Visible = false;
            // 
            // logo
            // 
            this.logo.Image = global::GitlabSearchAcrossProjects.Properties.Resources.logo64;
            this.logo.Location = new System.Drawing.Point(124, 18);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(64, 64);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 11;
            this.logo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "File/Path";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(69, 241);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(368, 20);
            this.searchText.TabIndex = 12;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(443, 239);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 14;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(16, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 1);
            this.panel1.TabIndex = 15;
            // 
            // searchRes
            // 
            this.searchRes.Location = new System.Drawing.Point(16, 296);
            this.searchRes.Name = "searchRes";
            this.searchRes.Size = new System.Drawing.Size(502, 176);
            this.searchRes.TabIndex = 16;
            // 
            // matchExact
            // 
            this.matchExact.AutoSize = true;
            this.matchExact.Location = new System.Drawing.Point(16, 273);
            this.matchExact.Name = "matchExact";
            this.matchExact.Size = new System.Drawing.Size(114, 17);
            this.matchExact.TabIndex = 17;
            this.matchExact.Text = "Match exact name";
            this.matchExact.UseVisualStyleBackColor = true;
            // 
            // copyright
            // 
            this.copyright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(217, 86);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(153, 16);
            this.copyright.TabIndex = 18;
            this.copyright.Text = "Created by Dreiwerken GmbH (https://www.dreiwerken.de/)";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.copyright.Click += new System.EventHandler(this.copyright_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 227);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.matchExact);
            this.Controls.Add(this.searchRes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.getProjects);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.downloadProgress);
            this.Controls.Add(this.clearCache);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apiKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "GSAP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox baseURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox apiKey;
        private System.Windows.Forms.Button getProjects;
        private System.Windows.Forms.Button clearCache;
        private System.Windows.Forms.ProgressBar downloadProgress;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView searchRes;
        private System.Windows.Forms.CheckBox matchExact;
        private System.Windows.Forms.Label copyright;
    }
}

