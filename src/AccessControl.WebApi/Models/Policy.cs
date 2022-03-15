namespace AccessControl.WebApi.Models
{
    public class Policy
    {
        public string Group { get; set; }
        public string Domain { get; set; }
        public string Component { get; set; }
        public string Action { get; set; }
    }
}
