using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApexCare.Model.Clients;

namespace ApexCare.Model.ServiceContracts
{
    public abstract class ServiceContract
    {
        private int contractID;
        private int clientID;
        private DateTime contractStart;
        private DateTime contractEnd;
        private DateTime nextMaintenance;
        private string streetAddress;
        private string suburb;
        private string city;
        private string province;
        private List<string> equipment;
        private string contractLevel;

        protected ServiceContract(int contractID, int clientID, DateTime contractStart, DateTime contractEnd, DateTime nextMaintenance, string streetAddress, string suburb, string city, string province, List<string> equipment, string contractLevel)
        {
            this.ContractID = contractID;
            this.ClientID = clientID;
            this.ContractStart = contractStart;
            this.ContractEnd = contractEnd;
            this.NextMaintenance = nextMaintenance;
            this.StreetAddress = streetAddress;
            this.Suburb = suburb;
            this.City = city;
            this.Province = province;
            this.Equipment = equipment;
            this.ContractLevel = contractLevel;
        }

        public int ContractID { get => contractID; set => contractID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public DateTime ContractStart { get => contractStart; set => contractStart = value; }
        public DateTime ContractEnd { get => contractEnd; set => contractEnd = value; }
        public DateTime NextMaintenance { get => nextMaintenance; set => nextMaintenance = value; }
        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }
        public List<string> Equipment { get => equipment; set => equipment = value; }
        public string ContractLevel { get => contractLevel; set => contractLevel = value; }

        public override string? ToString()
        {
            return $"Contract ID: {ContractID}, Client ID: {ClientID}, Contract Level: {ContractLevel}, " +
               $"Start Date: {ContractStart.ToShortDateString()}, End Date: {ContractEnd.ToShortDateString()}, " +
               $"Next Maintenance: {NextMaintenance.ToShortDateString()}, Location: {StreetAddress}, {Suburb}, {City}, {Province}, " +
               $"Equipment: {string.Join(", ", Equipment)}";
        }
    }
}
