using AccessControl.WebApi.Converters;
using Amazon.DynamoDBv2.DataModel;
using System.Collections.Generic;

namespace AccessControl.WebApi.Models
{
    [DynamoDBTable("example_access_control", true)]
    public class Access
    {
        public string User { get; set; }
        [DynamoDBProperty(typeof(PermissionConverter))]
        public IEnumerable<Permission> Permissions { get; set; }
    }
}
