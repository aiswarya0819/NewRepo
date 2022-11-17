using App.DAL.Models;
using App.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.BLL.Services.Contracts;

namespace App.BLL.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IGenericRepository<Resource> repository;
        public ResourceService(IGenericRepository<Resource> repository)
        {
            this.repository = repository;
        }
        public async Task<List<Resource>> GetAllResources()
        {
            try
            {
                return await repository.GetAllResources();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Resource> GetAResource(string id)
        {
            try
            {
                var result = await repository.GetAResource(id);
                //if (result == null) return NotFound();
                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
