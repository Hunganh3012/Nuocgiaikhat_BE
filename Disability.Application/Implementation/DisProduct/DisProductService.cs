using Disability.Application.Interface;
using Disability.Application.ViewModel;
using Disability.Data.IRepositories;
using Disability.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disability.Application.Implementation
{
    public class DisProductService : IDisProductService
    {
        IDisProductRepository _DisRepository;
        public DisProductService( IDisProductRepository DisRepository)
        {
            _DisRepository = DisRepository;
        }

        public async Task<List<DisProductInformation>> GetDisProducts(DisProductDtoFilter filter)
        {
            List<DisProductInformation> data = new List<DisProductInformation>();
            data = await _DisRepository.GeDisProductInformation(filter.Name, filter.ProductCode);
;           return data;
        }
    }
}   
