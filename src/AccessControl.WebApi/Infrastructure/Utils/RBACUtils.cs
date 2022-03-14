using NetCasbin.Model;
using System;

namespace AccessControl.WebApi.Infrastructure.Utils
{
    public static class RBACUtils
    {
        public static Model GetDefaultConfiguration()
        {
            return Model.CreateDefaultFromFile(Environment.GetEnvironmentVariable("RBAC_CONFIG_FILE"));
        }
    }
}
