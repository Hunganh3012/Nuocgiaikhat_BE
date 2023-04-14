using Disability.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disability.Data.IRepositories
{
    public interface IDisProductRepository 
    {
        Task<List<DisProductInformation>> GeDisProductInformation(string ProductCode, string Name);
    }
}
