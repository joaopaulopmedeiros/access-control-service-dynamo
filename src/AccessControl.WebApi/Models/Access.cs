using Amazon.DynamoDBv2.DataModel;
using System.Collections.Generic;

namespace AccessControl.WebApi.Models
{
    [DynamoDBTable("access-control", true)]
    public class Access
    {
        public string Group { get; set; }
        public string Domain { get; set; }
        public IEnumerable<Rule> Rules { get; set; }
    }

    public class Rule
    {
        public string Component { get; set; }
        public string Action { get; set; }
    }
}
