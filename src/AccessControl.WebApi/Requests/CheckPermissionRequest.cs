namespace AccessControl.WebApi.Requests
{
    public class CheckPermissionRequest
    {
        public string User { get; set; }
        public string Area { get; set; }
        public string Component { get; set; }
        public string Action { get; set; }
    }
}
