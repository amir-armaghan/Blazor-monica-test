using Octokit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blzZmq1.Services.Github
{
    public interface IGithubService
    {
        bool Login();
        bool Logout();
        string RepoName { get; set; }
        string RepoOwner { get; set; }
        void CreateFile();
        void CommitOnGit(string fileName, string jsonContent, string csvContent);
        Task<bool> IsExistPathAsync(string path);
        bool IsExistPath(string path);
        void SetRepoInfo(string repoPath);
        Task<IEnumerable<RepositoryContent>> GetContentsAsync(string path);
        IEnumerable<RepositoryContent> GetContents(string path);
        Task<string> GetFileContentAsync(string path);
        string GetFileContent(string path);
        Task<string> GetDownloadPathAsync(string path);
        string GetDownloadPath(string path);

    }
}