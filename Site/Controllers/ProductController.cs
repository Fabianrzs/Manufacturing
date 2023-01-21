using Aplication.Product.Dto;
using Aplication.Product.Main;
using Domain.Entities.Constant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;

namespace Site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<ActionResult> IncomingAsync(ProductDto product)
        {
            var request = await _service.Incoming(product);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }
        [HttpGet("{state}")]
        public async Task<ActionResult> Consult(int state = (int)ConstantsDomain.Stock)
        {
            
            var request = await _service.Consult(state);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entities);
        }
        [HttpPatch("MarkFaulty")]
        public async Task<ActionResult> MarkFaulty(string id)
        {
            Guid guid = new Guid(id); 
            var request = await _service.MarkFaulty(guid);
            return request.Error ? BadRequest(request.Message) : Ok(request.Message);
        }
        [HttpPatch("MarkOutlet")]
        public async Task<ActionResult> MarkOutlet(string id)
        {
            var guid = new Guid(id);
            var request = await _service.MarkOutlet(guid);
            return request.Error ? BadRequest(request.Message) : Ok(request.Message);
        }
    }
}
