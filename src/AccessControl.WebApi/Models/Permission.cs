using System;

namespace AccessControl.WebApi.Models
{
    public class Permission
    {
        public string Role { get; set; }
        public string Area { get; set; }
        public string Component { get; set; }
        public bool Write  { get; set; }
        public bool Read { get; set; }

        public bool IsActionGranted(string action)
        {
            string formatedAction = action.ToLower();

            if (formatedAction.Equals("write") && Write) return true;

            if (formatedAction.Equals("read") && Read) return true;

            return false;
        }
    }
}
