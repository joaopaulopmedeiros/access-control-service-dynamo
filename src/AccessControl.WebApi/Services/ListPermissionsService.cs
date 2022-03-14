using AccessControl.WebApi.Requests;
using AccessControl.WebApi.Responses;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccessControl.WebApi.Services
{
    public class ListPermissionsService
    {
        private readonly DynamoDBContext _context;

        public ListPermissionsService(DynamoDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// List permissions from dynamodb
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request)
        {
            var conditions = new List<ScanCondition> 
            { 
                new ScanCondition("subject", ScanOperator.Contains, request.Subjects), 
            };

            var items = await _context.ScanAsync<PermissionResponse>(conditions).GetRemainingAsync();

            var response = new ListPermissionsResponse();
            
            response.AddRange(items);

            return response;
        }
    }
}
