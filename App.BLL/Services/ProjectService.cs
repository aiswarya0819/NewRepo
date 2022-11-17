using App.BLL.Services.Contracts;
using App.DAL.Models;
using App.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IGenericRepository<Project> repository;
        public ProjectService(IGenericRepository<Project> repository)
        {
            this.repository = repository;
        }
        public async Task<List<Project>> GetAllProjects()
        {
            try
            {
                return await repository.GetAllProjects();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Project> GetAProject(string name)
        {
            try
            {
                var result = await repository.GetAProject(name);
                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
