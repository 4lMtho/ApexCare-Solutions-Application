using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCare.Model.ServiceContracts
{
    public class BasicContract : ServiceContract
    {
        private int repairsUsed;
        private int maxRepairs;

        public BasicContract(int contractID, int clientID, DateTime contractStart, DateTime contractEnd, DateTime nextMaintenance, string streetAddress,
            string suburb, string city, string province, List<string> equipment, string contractLevel, int maxRepairs, int repairsUsed)
            : base(contractID, clientID, contractStart, contractEnd, nextMaintenance, streetAddress, suburb, city, province, equipment, contractLevel)
        {
            this.MaxRepairs = maxRepairs;
            this.RepairsUsed = repairsUsed;
        }

        public int RepairsUsed { get => repairsUsed; set => repairsUsed = value; }
        public int MaxRepairs { get => maxRepairs; set => maxRepairs = value; }

        public override string? ToString()
        {
            return $"{base.ToString()}, Max Repairs: {MaxRepairs}, Repairs Used: {RepairsUsed}";
        }
    }
}
