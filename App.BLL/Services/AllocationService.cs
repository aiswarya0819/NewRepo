using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.DAL.Models;
using App.DAL.Repositories.Contracts;
using App.BLL.Services.Contracts;

using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data;

namespace App.BLL.Services
{
    public class AllocationService : IAllocationService
    {
        private readonly IGenericRepository<Allocation> _repository;
        public AllocationService(IGenericRepository<Allocation> _repository)
        {
           this._repository = _repository;
        }
        public async Task<List<Allocation>> GetAllAllocation()
        {
            try
            {
                return await _repository.GetAllAllocations();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Allocation> GetAnAllocation(string id)
        {
            try
            {
                /*ConnectionString connection = new ConnectionString();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                connection.getcommand.CommandText = "select * from Student"; // CommandText to execute the query
                adapter.SelectCommand = connection.getcommand;
                adapter.Fill(ds);
                return ds;*/
                var result = await _repository.GetAnAllocation(id);
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
