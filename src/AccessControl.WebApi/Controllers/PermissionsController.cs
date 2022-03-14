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
        public async Task<IEnumerable<string>> GetPermissionsAsync()
        {
            await Task.Delay(1000);
            return new List<string> { "content" };
        }
    }
}
