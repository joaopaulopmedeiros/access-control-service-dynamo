using NetCasbin.Model;
using NetCasbin.Persist;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccessControl.WebApi.Infrastructure.Adapters
{
    public class CasbinAdapter : IAdapter
    {
        public void AddPolicies(string sec, string ptype, IEnumerable<IList<string>> rules)
        {
            throw new System.NotImplementedException();
        }

        public Task AddPoliciesAsync(string sec, string ptype, IEnumerable<IList<string>> rules)
        {
            throw new System.NotImplementedException();
        }

        public void AddPolicy(string sec, string ptype, IList<string> rule)
        {
            throw new System.NotImplementedException();
        }

        public Task AddPolicyAsync(string sec, string ptype, IList<string> rule)
        {
            throw new System.NotImplementedException();
        }

        public void LoadPolicy(Model model)
        {
            throw new System.NotImplementedException();
        }

        public Task LoadPolicyAsync(Model model)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveFilteredPolicy(string sec, string ptype, int fieldIndex, params string[] fieldValues)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveFilteredPolicyAsync(string sec, string ptype, int fieldIndex, params string[] fieldValues)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePolicies(string sec, string ptype, IEnumerable<IList<string>> rules)
        {
            throw new System.NotImplementedException();
        }

        public Task RemovePoliciesAsync(string sec, string ptype, IEnumerable<IList<string>> rules)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePolicy(string sec, string ptype, IList<string> rule)
        {
            throw new System.NotImplementedException();
        }

        public Task RemovePolicyAsync(string sec, string ptype, IList<string> rule)
        {
            throw new System.NotImplementedException();
        }

        public void SavePolicy(Model model)
        {
            throw new System.NotImplementedException();
        }

        public Task SavePolicyAsync(Model model)
        {
            throw new System.NotImplementedException();
        }
    }
}
