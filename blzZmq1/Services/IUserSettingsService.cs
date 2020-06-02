namespace blzZmq1.Services
{
    public interface IUserSettingsService
    {
        bool ChartIsRun { get; set; }
        bool GithubLoggedIn { get; set; }
        string GithubPassword { get; set; }
        string GithubUserName { get; set; }
        bool MonicaPathOnGitIsValid { get; set; }
        string MonicaResultsPathOnGithub { get; set; }
        bool SaveResultInGit { get; set; }
        string ServerPullAddress { get; set; }
        int ServerPullPort { get; set; }
        string ServerPushAddress { get; set; }
        int ServerPushPort { get; set; }
    }
}