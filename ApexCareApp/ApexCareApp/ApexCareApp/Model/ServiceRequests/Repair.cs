using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCare.Model.ServiceRequests
{
    public class Repair : ServiceRequest
    {
        List<String> problemEquipment;
        string issueDescription;
        public Repair(int requestID, int contractID, int technicianID, string requestIssue, List<Dictionary<DateTime, string>> updates, bool completed, List<String> problemEquipment, string issueDescription) 
            : base(requestID, contractID, technicianID, requestIssue, updates, completed)
        {
            this.ProblemEquipment = problemEquipment;
            this.IssueDescription = issueDescription;
        }

        public string IssueDescription { get => issueDescription; set => issueDescription = value; }
        public List<string> ProblemEquipment { get => problemEquipment; set => problemEquipment = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
