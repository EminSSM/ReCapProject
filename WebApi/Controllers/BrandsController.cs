using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandservice;

        public BrandsController(IBrandService brandservice)
        {
            _brandservice = brandservice;
        }
  
        [HttpGet]
        public IActionResult GetAllBrands()
        {
            var result = _brandservice.TGetAllBrands();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetBrands(int id)
        {
            var result = _brandservice.TGetBy(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost]
        public IActionResult Add(Brand brand)
        {
            var result = _brandservice.TAdd(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut]
        public IActionResult Update(Brand brand)
        {
            var result = _brandservice.TUpdate(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandservice.TDelete(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);  
        }

    }
}
