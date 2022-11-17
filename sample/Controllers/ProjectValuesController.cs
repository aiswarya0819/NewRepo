using App.BLL.Services;
using App.BLL.Services.Contracts;
using App.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectValuesController : ControllerBase
    {
        private readonly IProjectService projectService;
        public ProjectValuesController(IProjectService _projectService)
        {
            projectService = _projectService;
        }
        [HttpGet("Projects")]
        public async Task<List<Project>> ShowProjects()
        {
            List<Project> listProjects = await projectService.GetAllProjects();
            return listProjects;
        }
        [HttpGet("Projects/{name}")]
        public async Task<Project> ShowAProject(string name)
        {
            try
            {
                Project result = await projectService.GetAProject(name);
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
