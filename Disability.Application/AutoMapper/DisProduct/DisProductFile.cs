using AutoMapper;
using Disability.Application.ViewModel;
using Disability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disability.Application.AutoMapper
{
   public class DisProductFile : Profile
    {
        public DisProductFile()
        {
            //1.Create:
            //CreateMap<DisProductDtoFilter, DisProduct>()
            //        .ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name))
            //        .ForMember(x => x.ProductCode, opt => opt.MapFrom(src => src.ProductCode);
        }
    }
}
