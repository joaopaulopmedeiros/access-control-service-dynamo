using AccessControl.WebApi.Requests;
using AccessControl.WebApi.Responses;
using NetCasbin;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AccessControl.WebApi.Services
{
    public class ListPermissionsService
    {
        private readonly Enforcer _enforcer;

        public ListPermissionsService(Enforcer enforcer)
        {
            _enforcer = enforcer;
        }

        /// <summary>
        /// List permissions
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request)
        {
            var response = new ListPermissionsResponse();

            foreach (var subject in request.Subjects)
            {
                var list = await Task.Run(() => _enforcer.GetPermissionsForUser(subject));

                if (list.Any())
                {
                    foreach (var item in list)
                    {
                        if(!string.IsNullOrEmpty(item[0]))
                        {
                            response.Add(new PermissionResponse
                            {
                                Subject = item[0],
                                Component = item[2],
                                Action = item[3],
                            });
                        }
                    }
                }
            }

            return response;
        }
    }
}
