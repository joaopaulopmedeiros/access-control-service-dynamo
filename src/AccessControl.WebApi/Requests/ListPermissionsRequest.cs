using System.Collections.Generic;

namespace AccessControl.WebApi.Requests
{
    public class ListPermissionsRequest
    {
        public List<string> Subjects { get; set; }
    }
}
