using filterandsearchdemo.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace filterandsearchdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpolyeeController : ControllerBase
    {
        private readonly IEmpolyeeServices _services;

        public EmpolyeeController(IEmpolyeeServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync(int pageIndex = 1, int itemsPerPage = 3, [FromQuery] Filter? filter = null)
        {
            try 
            {
                var res = await _services.GetAllAsync(pageIndex, itemsPerPage, filter);
                return Ok(res);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
