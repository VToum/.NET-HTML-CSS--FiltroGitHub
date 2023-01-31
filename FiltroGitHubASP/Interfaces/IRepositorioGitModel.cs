using FiltroGitHubASP.Models;

namespace FiltroGitHubASP.Interfaces
{
    public interface IRepositorioGitModel
    {
        RepositorioGitModel GetOne(string name);
    }
}
