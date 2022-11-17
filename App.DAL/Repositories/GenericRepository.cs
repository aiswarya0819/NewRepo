using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.DAL.DataContext;
using App.DAL.Models;
using App.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data.SqlClient;
using System.Data;
using App.DAL;

namespace App.DAL.Repositories
{
    public class GenericRepository<Tmodel> : IGenericRepository<Tmodel> where Tmodel : class
    {
        private readonly db2Context _db2Context;
        public GenericRepository(db2Context db2Context)
        {
            _db2Context = db2Context;
        }
        public async Task<List<Tmodel>> GetAllAllocations()
        {
            try
            {
                return await _db2Context.Set<Tmodel>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }
        /*Connection connection = new Connection();
        public DataSet GetAnAllocation(String id)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection.getCommand.CommandText = "select * from Allocations where Id = '" + id + "'";
            adapter.SelectCommand = connection.getCommand;
            adapter.Fill(ds);
            return (ds);
        }*/
        public async Task<Allocation> GetAnAllocation(String id) //Search based on EmployeeID
        {
            try
            {
                Allocation output = new Allocation();
                /*var allocations = from m in db2Context.Allocations select m;
                if (!String.IsNullOrEmpty(id))
                {
                    allocations = allocations.Where(s => s.Id!.Equals(id));
                }
                List<Tmodel> allocations1 = async allocations.ToListAsync();
                return allocations1;*/

                //var result = await _db2Context.Allocations.Single(a => );
                var result = await _db2Context.Set<Allocation>().ToListAsync();  //ToListAsync(id);// GetAnAllocation(id);
                foreach(var item in result)
                {
                    //Console.WriteLine(item.Id.ToString());
                    if(item.EmployeeId == id)
                    {
                        output = item;
                    }
                }
                /*var result = from m in db2Context.Allocations select m;
                if (!String.IsNullOrEmpty(id))
                {
                    result = result.Where(s => s[id]!.Equals(id));
                }*/
                //if (result == null) return NotFound();
                return output;
                //return await _db2Context.Set<Tmodel>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<Tmodel>> GetAllProjects()
        {
            try
            {
                return await _db2Context.Set<Tmodel>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task<Project> GetAProject(String name)//Search based on ProjectName
        {
            try
            {
                Project  output = new Project();
                var result = await _db2Context.Set<Project>().ToListAsync();
                foreach (var item in result)
                {
                    //Console.WriteLine(item.Id.ToString());
                    if (item.Name == name)
                    {
                        output = item;
                    }
                }
                return output;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<Tmodel>> GetAllResources()
        {
            try
            {
                return await _db2Context.Set<Tmodel>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task<List<Tmodel>> GetAllTeams()
        {
            try
            {
                return await _db2Context.Set<Tmodel>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task<Team> GetATeam(String name)//Search based on TeamName
        {
            try
            {
                Team output = new Team();
                var result = await _db2Context.Set<Team>().ToListAsync();
                foreach (var item in result)
                {
                    //Console.WriteLine(item.Id.ToString());
                    if (item.Name == name)
                    {
                        output = item;
                    }
                }
                return output;
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
                Resource output = new Resource();
                var result = await _db2Context.Set<Resource>().ToListAsync();
                foreach (var item in result)
                {
                    //Console.WriteLine(item.Id.ToString());
                    if (item.EmployeeId == id)
                    {
                        output = item;
                    }
                }
                return output;
            }
            catch
            {
                throw;
            }
        }
    }
}
