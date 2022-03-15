using AccessControl.WebApi.Models;
using AccessControl.WebApi.Requests;
using AccessControl.WebApi.Responses;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using System.Collections.Generic;
using System.Linq;
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
            var conditions = new List<ScanCondition>()
            {
                new ScanCondition("User", ScanOperator.Equal, request.User)
            };

            var userAccess = await _context.ScanAsync<Access>(conditions).GetRemainingAsync();

            var response = new ListPermissionsResponse();

            response.AddRange(userAccess.SelectMany(a => a.Permissions));

            return response;
        }
    }
}
