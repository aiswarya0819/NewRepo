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
    public class TeamService : ITeamService
    {
        private readonly IGenericRepository<Team> repository;
        public TeamService(IGenericRepository<Team> repository)
        {
            this.repository = repository;
        }
        public async Task<List<Team>> GetAllTeams()
        {
            try
            {
                return await repository.GetAllTeams();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Team> GetATeam(string name)
        {
            try
            {
                var result = await repository.GetATeam(name);
                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
