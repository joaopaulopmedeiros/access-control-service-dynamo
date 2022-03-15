using AccessControl.WebApi.Requests;
using AccessControl.WebApi.Responses;
using AccessControl.WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccessControl.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PermissionsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ListPermissionsResponse>> ListPermissionsAsync
        (
            [FromServices] ListPermissionsService service,
            [FromQuery] ListPermissionsRequest request
        )
        {
            var result = await service.ListPermissionsAsync(request);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ListPermissionsResponse>> CheckPermissionsAsync
        (
            [FromServices] CheckPermissionsService service,
            [FromBody] CheckPermissionsRequest request
        )
        {
            var result = await service.CheckPermissionsAsync(request);
            return Ok(result);
        }
    }
}
