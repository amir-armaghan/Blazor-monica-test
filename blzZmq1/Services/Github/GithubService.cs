using Microsoft.AspNetCore.Components;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace blzZmq1.Services.Github
{
    public class GithubService : IGithubService
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

        public GithubService()
        {
            // var basicAuth = new Credentials("user", "pass"); 
            _gitHubClient = new GitHubClient(new ProductHeaderValue(_githubHeader));
        }

        public bool Login(string username, string password)
        {
            var basicAuth = new Credentials(username, password);
            _gitHubClient.Connection.Credentials = basicAuth;


            try
            {
                var result = _gitHubClient.Organization.GetAllForUser(username).Result;
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
            return true;
        }

        public void SetRepoInfo(string repoPath)
        {
            var pathItems = repoPath.Split("/");
            RepoOwner = pathItems[3];
            RepoName = pathItems[4];
        }

        public void CreateFile(string username, string password)
        {
            var basicAuth = new Credentials(username, password);
            _gitHubClient.Connection.Credentials = basicAuth;
            var result = _gitHubClient.Repository.Content.CreateFile(RepoOwner, RepoName, "export.txt",
                new CreateFileRequest("Added by server", "Hello Github")).Result;
        }
        // try to export the CSV result on the user's repository
        public void CommitOnGit(string FileName, string JsonContent, string CsvContent, string username, string password, string monicaResultsPathOnGithub)
        {
            var basicAuth = new Credentials(username, password);
            _gitHubClient.Connection.Credentials = basicAuth;
            RepoOwner = username;
            RepoName = monicaResultsPathOnGithub;

            var resultJson = _gitHubClient.Repository.Content.CreateFile(RepoOwner, RepoName, FileName + ".json",
                new CreateFileRequest("Json added by Blazor", JsonContent)).Result;
            var resultCsv = _gitHubClient.Repository.Content.CreateFile(RepoOwner, RepoName, FileName + ".csv",
               new CreateFileRequest("CSV added by Blazor", CsvContent)).Result;
        }

        public async Task<bool> IsExistPathAsync(string path, string username, string passowrd)
        {
            var basicAuth = new Credentials(username, passowrd);
            _gitHubClient.Connection.Credentials = basicAuth;
            return await _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path) != null;
        }

        public bool IsExistPath(string path, string username, string passowrd, string monicaResultsPathOnGithub)
        {
            var basicAuth = new Credentials(username, passowrd);
            _gitHubClient.Connection.Credentials = basicAuth;

            RepoOwner = username;
            RepoName = monicaResultsPathOnGithub;
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
        public List<string> GetContentsList(string path, string username, string monicaResultsPathOnGithub)
        {
            RepoOwner = username;
            RepoName = monicaResultsPathOnGithub;
            List<string> result = new List<string>();
            return result;
        }

        public async Task<IEnumerable<RepositoryContent>> GetContentsAsync(string path, string username, string password)
        {
            var basicAuth = new Credentials(username, password);
            _gitHubClient.Connection.Credentials = basicAuth;

            var contents = await _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path);
            return contents;
        }

        public IEnumerable<RepositoryContent> GetContents(string path, string username, string password)
        {
            var basicAuth = new Credentials(username, password);
            _gitHubClient.Connection.Credentials = basicAuth;

            var contents = _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path).Result;
            return contents;
        }

        public async Task<string> GetFileContentAsync(string path, string username, string password)
        {
            var basicAuth = new Credentials(username, password);
            _gitHubClient.Connection.Credentials = basicAuth;

            var contents = await _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path);
            return contents.Select(s => s.Content).FirstOrDefault();
        }

        public string GetFileContent(string path, string username, string password)
        {
            var basicAuth = new Credentials(username, password);
            _gitHubClient.Connection.Credentials = basicAuth;

            var contents = (_gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path)).Result;
            return contents.Select(s => s.Content).FirstOrDefault();
        }

        public async Task<string> GetDownloadPathAsync(string path, string username, string password)
        {
            var contents = await GetContentsAsync(path, username, password);

            if (contents == null)
                return path;

            return contents.Select(s => s.DownloadUrl).FirstOrDefault();
        }

        public string GetDownloadPath(string path, string username, string password)
        {
            var contents = GetContents(path, username, password);

            if (contents == null)
                return path;

            return contents.Select(s => s.DownloadUrl).FirstOrDefault();
        }
    }
}
