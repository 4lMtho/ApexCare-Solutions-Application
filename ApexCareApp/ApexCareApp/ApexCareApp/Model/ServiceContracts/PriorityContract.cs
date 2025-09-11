using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCare.Model.ServiceContracts
{
    public class PriorityContract : ServiceContract
    {
        int guaranteedResponseHours;
        private int repairsUsed;
        private int maxRepairs;

        public PriorityContract(int contractID, int clientID, DateTime contractStart, DateTime contractEnd, DateTime nextMaintenance, string streetAddress, string suburb, 
            string city, string province, List<string> equipment, string contractLevel, int guaranteedResponseHours, int repairsUsed, int maxRepairs) 
            : base(contractID, clientID, contractStart, contractEnd, nextMaintenance, streetAddress, suburb, city, province, equipment, contractLevel)
        {
            this.GuaranteedResponseHours = guaranteedResponseHours;
            this.RepairsUsed = repairsUsed;
            this.MaxRepairs = maxRepairs;
        }

        public int GuaranteedResponseHours { get => guaranteedResponseHours; set => guaranteedResponseHours = value; }
        public int RepairsUsed { get => repairsUsed; set => repairsUsed = value; }
        public int MaxRepairs { get => maxRepairs; set => maxRepairs = value; }

        public override string? ToString()
        {
            return $"{base.ToString()}, Guaranteed Response Hours: {GuaranteedResponseHours}, Repairs Used: {RepairsUsed}, Max Repairs: {MaxRepairs}";
        }
    }
}
