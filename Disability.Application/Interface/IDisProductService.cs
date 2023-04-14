using Disability.Application.ViewModel;
using Disability.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disability.Application.Interface
{
    public interface IDisProductService
    {
        Task<List<DisProductInformation>> GetDisProducts(DisProductDtoFilter filter);
    }
}
