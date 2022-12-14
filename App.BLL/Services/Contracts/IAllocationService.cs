using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL.Models;

namespace App.BLL.Services.Contracts
{
    public interface IAllocationService
    {
        Task<List<Allocation>> GetAllAllocation();
        Task<Allocation> GetAnAllocation(string id);
        //Task<List<Project>> GetAllProjects();
        //Task<List<Resource>> GetAllResources();
        //Task<List<Team>> GetAllTeams();
    }
}
