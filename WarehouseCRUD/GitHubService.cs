using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseCRUD
{
    public class GitHubService
    {
        public async Task<Repository> getRepositoryData(string login, string password)
        {
            var client = new GitHubClient(new ProductHeaderValue("WareHouseCRUD"));
            var basicAuth = new Credentials(login, password);
            client.Credentials = basicAuth;

            var user = await client.User.Current();

            var repositories = await client.Repository.GetAllForCurrent();

            return repositories.Where(x => x.Name == "WareHouseCRUD").Single();
        }
    }
}
