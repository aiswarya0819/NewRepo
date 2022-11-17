using App.BLL.Services.Contracts;
using App.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllocationValuesController : ControllerBase
    {
        private readonly IAllocationService allocationService;
        public AllocationValuesController(IAllocationService _allocationService)
        {
            allocationService = _allocationService;
        }
        [HttpGet("Allocations")]
        public async Task<List<Allocation>> ShowAllocation()
        {
            List<Allocation> listEmployees = await allocationService.GetAllAllocation();
            return listEmployees;
        }
        [HttpGet("Allocations/{id}")]
        public async Task<Allocation> ShowAnAllocation(string id)
        {
            try
            {
                Allocation result = await allocationService.GetAnAllocation(id);
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
