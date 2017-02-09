using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitlabSearchAcrossProjects
{
    class GitlabProjectStruct
    {
        public int id = 0;
        public string description = "";
        public string default_branch = "";
        public List<string> tag_list = null;
        public bool @public = false;
        public bool archived = false;
        public int visibility_level = 0;
        public string ssh_url_to_repo = "";
        public string http_url_to_repo = "";
        public string web_url = "";
        public string name = "";
        public string name_with_namespace = "";
        public string path = "";
        public string path_with_namespace = "";
        public string container_registry_enabled = "";
        public bool issues_enabled = false;
        public bool wiki_enabled = false;
        public bool builds_enabled = false;
        public bool snippets_enabled = false;
        public string created_at = "";
        public string last_activity_at = "";
        public bool shared_runners_enabled = false;
        public bool lfs_enabled = false;
        public int creator_id = 0;
        public Dictionary<string, string> @namespace = null;
        public string avatar_url = "";
        public int star_count = 0;
        public int forks_count = 0;
        public int open_issues_count = 0;
        public bool public_builds = false;
        public List<string> shared_with_groups = null;
        public bool only_allow_merge_if_build_succeeds = false;
        public bool request_access_enabled = false;
        public string only_allow_merge_if_all_discussions_are_resolved = "";
        public object permissions = null; // placeholder
    }

    class GitlabFileStruct
    {
        public string id = "";
        public string name = "";
        public string type = "";
        public string path = "";
        public string mode = "";

    }
}
