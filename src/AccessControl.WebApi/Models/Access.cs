using AccessControl.WebApi.Converters;
using Amazon.DynamoDBv2.DataModel;
using System.Collections.Generic;

namespace AccessControl.WebApi.Models
{
    [DynamoDBTable("access-control", true)]
    public class Access
    {
        public string Group { get; set; }
        public string Domain { get; set; }
        [DynamoDBProperty(typeof(PolicyConverter))]
        public IEnumerable<Policy> Policies { get; set; }
    }
}
