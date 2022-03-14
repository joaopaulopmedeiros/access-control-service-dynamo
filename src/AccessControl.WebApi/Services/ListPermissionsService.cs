using AccessControl.WebApi.Requests;
using AccessControl.WebApi.Responses;
using System;
using System.Threading.Tasks;

namespace AccessControl.WebApi.Services
{
    public class ListPermissionsService
    {
        /// <summary>
        /// List permissions
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request)
        {
            await Task.Delay(1000);
            var result = new ListPermissionsResponse();
            result.Add(new PermissionResponse() { Subject = request.Subjects[0], Component = "component1", Action = "read" });
            return result;
        }
    }
}
