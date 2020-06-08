using Octokit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blzZmq1.Services.Github
{
    public interface IGithubService
    {
        string RepoName { get; set; }
        string RepoOwner { get; set; }

        void CommitOnGit(string FileName, string JsonContent, string CsvContent, string username, string password, string monicaResultsPathOnGithub);
        void CreateFile(string username, string password);
        IEnumerable<RepositoryContent> GetContents(string path, string username, string password);
        Task<IEnumerable<RepositoryContent>> GetContentsAsync(string path, string username, string password);
        List<string> GetContentsList(string path, string username, string monicaResultsPathOnGithub);
        string GetDownloadPath(string path, string username, string password);
        Task<string> GetDownloadPathAsync(string path, string username, string password);
        string GetFileContent(string path, string username, string password);
        Task<string> GetFileContentAsync(string path, string username, string password);
        bool IsExistPath(string path, string username, string passowrd, string monicaResultsPathOnGithub);
        Task<bool> IsExistPathAsync(string path, string username, string passowrd);
        bool Login(string username, string password);
        void SetRepoInfo(string repoPath);
    }
}