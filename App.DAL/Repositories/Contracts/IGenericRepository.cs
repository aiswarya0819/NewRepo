using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.DAL.Models;


namespace App.DAL.Repositories.Contracts
{
    public interface IGenericRepository<TModel> where TModel : class
    {
        Task<List<TModel>> GetAllAllocations();
        Task<Allocation> GetAnAllocation(string id);
        Task<List<TModel>> GetAllProjects();
        Task<Project> GetAProject(string name);
        Task<List<TModel>> GetAllResources();
        Task<Resource> GetAResource(string id);
        Task<List<TModel>> GetAllTeams();
        Task<Team> GetATeam(string name);
    }
}
