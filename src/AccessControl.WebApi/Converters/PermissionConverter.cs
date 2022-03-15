using AccessControl.WebApi.Models;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AccessControl.WebApi.Converters
{
    public class PermissionConverter : IPropertyConverter
    {
        public object FromEntry(DynamoDBEntry entry)
        {
            return JsonConvert.DeserializeObject<IEnumerable<Permission>>(entry);
        }

        public DynamoDBEntry ToEntry(object value)
        {
            throw new System.NotImplementedException();
        }
    }
}
