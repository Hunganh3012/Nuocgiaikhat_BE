using Disability.Data.IRepositories;
using Disability.Data.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disability.Ef.Repositories
{
    public class DisProductRepository : IDisProductRepository
    {
        DisabilityDbContext _context;
        public DisProductRepository(DisabilityDbContext context)
        {
            _context = context;
        }

        public async Task<List<DisProductInformation>> GeDisProductInformation(string ProductCode, string Name)
        {
            try 
            {
                List<DisProductInformation> result = await _context.DisProducts.FromSqlRaw(" EXEC DisProductInform " + "@name, @ProductCode",
                    new SqlParameter("@name", SqlDbType.NVarChar, 500) { Value = !string.IsNullOrEmpty(Name) ? Name : (object)DBNull.Value },
                    new SqlParameter("@ProductCode", SqlDbType.NVarChar, 50) { Value = !string.IsNullOrEmpty(ProductCode) ? ProductCode : (object)DBNull.Value }
                    ).ToListAsync();
                return await Task.FromResult(result);
            }   
            catch(Exception e)
            {
                throw;

            }
        }
    }
}
