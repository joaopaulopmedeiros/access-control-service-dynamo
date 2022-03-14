using AccessControl.WebApi.Requests;
using AccessControl.WebApi.Responses;
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
        public async Task<ActionResult<ListPermissionsResponse>> GetPermissionsAsync
        (
            [FromQuery] ListPermissionsRequest request
        )
        {
            await Task.Delay(1000);
            var result = new ListPermissionsResponse();
            result.Add(new PermissionResponse() { Subject = request.Subjects[0], Component = "component1", Action = "read" });
            return Ok(result);
        }
    }
}
