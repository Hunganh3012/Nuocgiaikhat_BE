using Disability.Application.Interface;
using Disability.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Disability.Api.Controllers
{
   public class DisProductController: ControllerBase
    {
        private readonly IDisProductService _DisProductService;
        public DisProductController( IDisProductService DisProductService)
        {
            _DisProductService = DisProductService;
        }


        [Route("Get")]
        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] DisProductDtoFilter filter)
        {
            return Ok(await _DisProductService.GetDisProducts(filter));
        }
    }
}
