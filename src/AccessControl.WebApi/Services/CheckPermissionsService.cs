using AccessControl.WebApi.Requests;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessControl.WebApi.Services
{
    public class CheckPermissionsService
    {
        private readonly ListPermissionsService _service;

        public CheckPermissionsService(ListPermissionsService service)
        {
            _service = service;
        }

        /// <summary>
        /// Check wether user has permission to perform action on component
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<bool> CheckPermissionsAsync(CheckPermissionsRequest request)
        {
            var permissions = await _service.ListPermissionsAsync
            (
                new ListPermissionsRequest { User = request.User }
            );

            return permissions.Any(p => 
                p.Action == request.Action && 
                p.Component == request.Component && 
                p.Domain == request.Domain
            );
        }
    }
}
