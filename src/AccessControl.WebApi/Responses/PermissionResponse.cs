namespace AccessControl.WebApi.Responses
{
    public class PermissionResponse
    {
        public string Subject { get; set; }
        public string Domain { get; set; }
        public string Component { get; set; }
        public string Action { get; set; }
    }
}