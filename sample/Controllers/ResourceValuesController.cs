using App.BLL.Services;
using App.BLL.Services.Contracts;
using App.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceValuesController : ControllerBase
    {
        private readonly IResourceService resourceService;
        public ResourceValuesController(IResourceService _resourceService)
        {
            resourceService = _resourceService;
        }
        [HttpGet("Resources")]
        public async Task<List<Resource>> ShowResources()
        {
            List<Resource> listResources = await resourceService.GetAllResources();
            return listResources;
        }

        [HttpGet("Resources/{id}")]
        public async Task<Resource> ShowAResource(string id)
        {
            try
            {
                Resource result = await resourceService.GetAResource(id);
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
