using System.Collections.Generic;

namespace AccessControl.WebApi.Requests
{
    public class CheckPermissionsRequest
    {
        public IEnumerable<string> Subjects { get; set; }
        public string Domain { get; set; }
        public string Action { get; set; }
        public string Component { get; set; }
    }
}
