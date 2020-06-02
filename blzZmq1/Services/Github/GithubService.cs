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
        private readonly IUserSettingsService _userSettingsService;

        private readonly IGitHubClient _gitHubClient;

        public string RepoOwner { get; set; }

        public string RepoName { get; set; }

        //app settings
        //public string GithubUserName { get; set; }
        // public string GithubPassword { get; set; }
        //[Inject]
        //protected AppData AppData { get; set; }

        public GitHubParameters(IUserSettingsService userSettingsService)
        {
            _userSettingsService = userSettingsService;
            // var basicAuth = new Credentials("user", "pass"); 
            _gitHubClient = new GitHubClient(new ProductHeaderValue(_githubHeader));
        }

        public bool Login()
        {
            var basicAuth = new Credentials(_userSettingsService.GithubUserName, _userSettingsService.GithubPassword);
            _gitHubClient.Connection.Credentials = basicAuth;
            

            try
            {
                var result = _gitHubClient.Organization.GetAllForUser(_userSettingsService.GithubUserName).Result;
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
            _userSettingsService.GithubLoggedIn = true;
            return true;
        }

        public bool Logout()
        {
            if (_userSettingsService.GithubLoggedIn == true)
            {
                // delete credential
                _userSettingsService.GithubUserName = "Please Login";
                _userSettingsService.GithubPassword = "PASSWORD";
                _userSettingsService.GithubLoggedIn = false;
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
            var basicAuth = new Credentials(_userSettingsService.GithubUserName, _userSettingsService.GithubPassword);
            _gitHubClient.Connection.Credentials = basicAuth;
            var result = _gitHubClient.Repository.Content.CreateFile(RepoOwner, RepoName, "export.txt",
                new CreateFileRequest("Added by server", "Hello Github")).Result;
        }
        // try to export the CSV result on the user's repository
        public void CommitOnGit(string FileName, string JsonContent, string CsvContent)
        {
            var basicAuth = new Credentials(_userSettingsService.GithubUserName, _userSettingsService.GithubPassword);
            _gitHubClient.Connection.Credentials = basicAuth;
            RepoOwner = _userSettingsService.GithubUserName;
            RepoName = _userSettingsService.MonicaResultsPathOnGithub;

            var resultJson = _gitHubClient.Repository.Content.CreateFile(RepoOwner, RepoName, FileName + ".json",
                new CreateFileRequest("Json added by Blazor", JsonContent)).Result;
            var resultCsv = _gitHubClient.Repository.Content.CreateFile(RepoOwner, RepoName, FileName + ".csv",
               new CreateFileRequest("CSV added by Blazor", CsvContent)).Result;
        }

        public async Task<bool> IsExistPathAsync(string path)
        {
            var basicAuth = new Credentials(_userSettingsService.GithubUserName, _userSettingsService.GithubPassword);
            _gitHubClient.Connection.Credentials = basicAuth;
            return await _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path) != null;
        }

        public bool IsExistPath(string path)
        {
            var basicAuth = new Credentials(_userSettingsService.GithubUserName, _userSettingsService.GithubPassword);
            _gitHubClient.Connection.Credentials = basicAuth;

            if (_userSettingsService.GithubLoggedIn == true)
            {
                RepoOwner = _userSettingsService.GithubUserName;
                RepoName = _userSettingsService.MonicaResultsPathOnGithub;
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
        public List<string> GetContentsList(string path)
        {
            RepoOwner = _userSettingsService.GithubUserName;
            RepoName = _userSettingsService.MonicaResultsPathOnGithub;
            List<string> result = new List<string>();
            //result = _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName).Result;
            return result;
        }

        public async Task<IEnumerable<RepositoryContent>> GetContentsAsync(string path)
        {
            var basicAuth = new Credentials(_userSettingsService.GithubUserName, _userSettingsService.GithubPassword);
            _gitHubClient.Connection.Credentials = basicAuth;

            var contents = await _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path);
            return contents;
        }

        public IEnumerable<RepositoryContent> GetContents(string path)
        {
            var basicAuth = new Credentials(_userSettingsService.GithubUserName, _userSettingsService.GithubPassword);
            _gitHubClient.Connection.Credentials = basicAuth;

            var contents = _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path).Result;
            return contents;
        }

        public async Task<string> GetFileContentAsync(string path)
        {
            var basicAuth = new Credentials(_userSettingsService.GithubUserName, _userSettingsService.GithubPassword);
            _gitHubClient.Connection.Credentials = basicAuth;

            var contents = await _gitHubClient.Repository.Content.GetAllContents(RepoOwner, RepoName, path);
            return contents.Select(s => s.Content).FirstOrDefault();
        }

        public string GetFileContent(string path)
        {
            var basicAuth = new Credentials(_userSettingsService.GithubUserName, _userSettingsService.GithubPassword);
            _gitHubClient.Connection.Credentials = basicAuth;

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
