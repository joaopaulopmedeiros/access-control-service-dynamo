using AccessControl.WebApi.Requests;
using AccessControl.WebApi.Responses;
using AccessControl.WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AccessControl.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PermissionsController : ControllerBase
    {
        /// <summary>
        /// List permissions
        /// </summary>
        /// <param name="service"></param>
        /// <param name="request"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Check permission
        /// </summary>
        /// <param name="service"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("Check")]
        public async Task<ActionResult<bool>> CheckPermissionAsync
        (
            [FromServices] CheckPermissionService service,
            [FromQuery] CheckPermissionRequest request
        )
        {
            var result = await service.CheckPermissionAsync(request);
            return Ok(result);
        }
    }
}
