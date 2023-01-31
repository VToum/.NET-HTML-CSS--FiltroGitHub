using System.Xml.Linq;

namespace FiltroGitHubASP.Models
{
    public class RepositorioGitModel
    {
        public string Name { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return string.Format($"{Name})"); 
        }
    }
}
