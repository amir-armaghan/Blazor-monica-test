using Microsoft.AspNetCore.Components;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace blzZmq1.Services.Github
{
    public class GitHubParameters : IGithubService
    {
        private readonly string _githubHeader = "armaghan-work";

        private readonly IGitHubClient _gitHubClient;

        public string RepoOwner { get; set; }

        public string RepoName { get; set; }

        //app settings
        //public string GithubUserName { get; set; }
        // public string GithubPassword { get; set; }
        //[Inject]
        //protected AppData AppData { get; set; }

        public GitHubParameters()
        {
            // var basicAuth = new Credentials("user", "pass"); 
            var basicAuth = new Credentials(AppData.GithubUserName, AppData.GithubPassword);
            _gitHubClient = new GitHubClient(new ProductHeaderValue(_githubHeader));
            _gitHubClient.Connection.Credentials = basicAuth;
        }

        public bool Login()
        {
            var basicAuth = new Credentials(AppData.GithubUserName, AppData.GithubPassword);
            var gitHubClient = new GitHubClient(new ProductHeaderValue(AppData.GithubUserName));
            gitHubClient.Connection.Credentials = basicAuth;
            

            try
            {
                var result = _gitHubClient.Organization.GetAllForUser(AppData.GithubUserName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerException != null && ex.InnerException.GetType() == typeof(AuthorizationException))
                {
                    return false;
                }
                else
                    throw ex;
            }
            AppData.GithubLoggedIn = true;
            return true;
        }

        public bool Logout()
        {
            if (AppData.GithubLoggedIn == true)
            {
                // delete credential
                AppData.GithubUserName = "Please Login";
                AppData.GithubPassword = "PASSWORD";
                AppData.GithubLoggedIn = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetRepoInfo(string repoPath)
        {
            var pathItems = repoPath.Split("/");
            RepoOwner = pathItems[3];
            RepoName = pathItems[4];
        }

        public void CreateFile()
        {
            var result = _gitHubClient.Repository.Content.CreateFile(RepoOwner, RepoName, "export.txt",
                new CreateFileRequest("Added by server", "Hello Github")).Result;
        }
        // try to export the CSV result on the user's repository
        public void CommitOnGit(string FileName, string JsonContent, string CsvContent)
        {
            RepoOwner = AppData.GithubUserName;
            RepoName = AppData.MonicaResultsPathOnGithub;

            var resultJson = _gitHubClient.Repository.Content.CreateFile(RepoOwner, RepoName, FileName + ".json",
                new CreateFileRequest("Json added by Blazor", JsonContent)).Result;
            var resultCsv = _gitHubClient.Repository.Content.CreateFile(RepoOwner, RepoName, FileName + ".csv",
               new CreateFileRequest("CSV added by Blazor", CsvContent)).Result;
        }

        public async Task<bool> IsExistPathAsync(string path)
        {
            return await _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path) != null;
        }

        public bool IsExistPath(string path)
        {
            if (AppData.GithubLoggedIn == true)
            {
                RepoOwner = AppData.GithubUserName;
                RepoName = AppData.MonicaResultsPathOnGithub;
                try
                {
                    var result = _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName).Result;
                    return result != null;
                }
                catch
                {
                    return false;
                }         
            }
            else
            {
                return false; // reconstruct later
            }
            
        }

        public async Task<IEnumerable<RepositoryContent>> GetContentsAsync(string path)
        {
            var contents = await _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path);
            return contents;
        }

        public IEnumerable<RepositoryContent> GetContents(string path)
        {
            var contents = _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path).Result;
            return contents;
        }

        public async Task<string> GetFileContentAsync(string path)
        {
            var contents = await _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path);
            return contents.Select(s => s.Content).FirstOrDefault();
        }

        public string GetFileContent(string path)
        {
            var contents = (_gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path)).Result;
            return contents.Select(s => s.Content).FirstOrDefault();
        }

        public async Task<string> GetDownloadPathAsync(string path)
        {
            var contents = await GetContentsAsync(path);

            if (contents == null)
                return path;

            return contents.Select(s => s.DownloadUrl).FirstOrDefault();
        }

        public string GetDownloadPath(string path)
        {
            var contents = GetContents(path);

            if (contents == null)
                return path;

            return contents.Select(s => s.DownloadUrl).FirstOrDefault();
        }
    }
}
