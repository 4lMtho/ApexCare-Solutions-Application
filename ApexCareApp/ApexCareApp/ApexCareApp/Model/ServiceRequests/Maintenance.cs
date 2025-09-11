using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCare.Model.ServiceRequests
{
    public class Maintenance : ServiceRequest
    {
        public Maintenance(int requestID, int contractID, int technicianID, string requestIssue, List<Dictionary<DateTime, string>> updates, bool completed) 
            : base(requestID, contractID, technicianID, requestIssue, updates, completed)
        {
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
