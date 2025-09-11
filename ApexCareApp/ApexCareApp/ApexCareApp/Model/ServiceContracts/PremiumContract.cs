using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCare.Model.ServiceContracts
{
    public class PremiumContract : ServiceContract
    {
        private int guarenteedResponseHours;

        public PremiumContract(int contractID, int clientID, DateTime contractStart, DateTime contractEnd, DateTime nextMaintenance, string streetAddress, 
            string suburb, string city, string province, List<string> equipment, string contractLevel, int guarenteedResponseHours) 
            : base(contractID, clientID, contractStart, contractEnd, nextMaintenance, streetAddress, suburb, city, province, equipment, contractLevel)
        {
            this.GuarenteedResponseHours = guarenteedResponseHours;
        }
        public int GuarenteedResponseHours { get => guarenteedResponseHours; set => guarenteedResponseHours = value; }

        public override string? ToString()
        {
            return $"{base.ToString()}, Guaranteed Response Hours: {GuarenteedResponseHours}";
        }
    }
}
