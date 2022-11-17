using App.BLL.Services.Contracts;
using App.BLL.Services;
using App.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace App.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamValuesController : ControllerBase
    {
        /*private readonly IAllocationService allocationService;
        public ValuesController(IAllocationService _allocationService)
        {
            allocationService = _allocationService;
        }
        [HttpGet("Allocations")]
        public async Task<List<Allocation>> ShowAllocation()
        {
            List<Allocation> listEmployees = await allocationService.GetAllAllocation();
            return listEmployees;
        }*/


        /*private readonly IProjectService projectService;
        public ValuesController(IProjectService _projectService)
        {
            projectService = _projectService;
        }
        [HttpGet("Projects")]
        public async Task<List<Project>> ShowProjects()
        {
            List<Project> listProjects = await projectService.GetAllProjects();
            return listProjects;
        }*/


        /*private readonly App.BLL.Services.Contracts.IResourceService resourceService;
        public ValuesController(App.BLL.Services.Contracts.IResourceService _resourceService)
        {
            resourceService = _resourceService;
        }
        [HttpGet("Resources")]
        public async Task<List<Resource>> ShowResources()
        {
            List<Resource> listResources = await resourceService.GetAllResources();
            return listResources;
        }*/

        private readonly ITeamService teamService;
        public TeamValuesController(ITeamService _teamService)
        {
            teamService = _teamService;
        }
        [HttpGet("Team")]
        public async Task<List<Team>> ShowTeams()
        {
            List<Team> listTeams = await teamService.GetAllTeams();
            return listTeams;
        }
        [HttpGet("Team/{name}")]
        public async Task<Team> ShowATeam(string name)
        {
            try
            {
                Team result = await teamService.GetATeam(name);
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
