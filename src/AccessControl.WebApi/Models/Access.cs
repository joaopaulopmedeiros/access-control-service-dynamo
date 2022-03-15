using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AccessControl.WebApi.Models
{
    [DynamoDBTable("access-control", true)]
    public class Access
    {
        public string Group { get; set; }
        public string Domain { get; set; }
        [DynamoDBProperty(typeof(RuleConverter))]
        public IEnumerable<Rule> Rules { get; set; }
    }

    public class RuleConverter : IPropertyConverter
    {
        public object FromEntry(DynamoDBEntry entry)
        {
            return JsonConvert.DeserializeObject<IEnumerable<Rule>>(entry);
        }

        public DynamoDBEntry ToEntry(object value)
        {
            throw new System.NotImplementedException();
        }
    }

    public class Rule
    {
        public string Component { get; set; }
        public string Action { get; set; }
    }
}
