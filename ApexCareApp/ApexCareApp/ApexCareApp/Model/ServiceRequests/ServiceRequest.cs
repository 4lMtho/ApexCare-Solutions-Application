using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApexCare.Model.Clients;

namespace ApexCare.Model.ServiceRequests
{
    public abstract class ServiceRequest
    {
        private int requestID;
        private int contractID;
        private int technicianID;
        private string requestIssue;
        private List<Dictionary<DateTime, String>>  updates;
        private bool completed;

        protected ServiceRequest(int requestID, int contractID, int technicianID, string requestIssue, List<Dictionary<DateTime, string>> updates, bool completed)
        {
            this.RequestID = requestID;
            this.ContractID = contractID;
            this.TechnicianID = technicianID;
            this.RequestIssue = requestIssue;
            this.Updates = updates;
            this.Completed = completed;
        }

        public int RequestID { get => requestID; set => requestID = value; }
        public int ContractID { get => contractID; set => contractID = value; }
        public int TechnicianID { get => technicianID; set => technicianID = value; }
        public string RequestIssue { get => requestIssue; set => requestIssue = value; }
        public List<Dictionary<DateTime, string>> Updates { get => updates; set => updates = value; }
        public bool Completed { get => completed; set => completed = value; }

        public override string? ToString()
        {
            string updateDetails = string.Join(", ", Updates.Select(u => $"[{u.Keys.First().ToShortDateString()}: {u.Values.First()}]"));
            return $"Request ID: {RequestID}, Contract ID: {ContractID}, Technician ID: {TechnicianID}, Issue: {RequestIssue}, Updates: {updateDetails}, Completed: {Completed}";
        }
    }
}
