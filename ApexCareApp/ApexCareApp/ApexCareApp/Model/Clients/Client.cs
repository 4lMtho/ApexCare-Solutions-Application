using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ApexCare.Model.Clients
{
    public class Client
    {
        private int clientID;
        private string clientName;
        private string contactPerson;
        private string contactNumber;
        private string emailAddress;

        public Client(int clientID, string clientName, string contactPerson, string contactNumber, string emailAddress)
        {
            this.ClientID = clientID;
            this.ClientName = clientName;
            this.ContactPerson = contactPerson;
            this.ContactNumber = contactNumber;
            this.EmailAddress = emailAddress;
        }

        public int ClientID { get => clientID; set => clientID = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string ContactPerson { get => contactPerson; set => contactPerson = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }

        public override string? ToString()
        {
            return $"Client ID: {clientID}, Name: {clientName}, Contact Person: ***hidden***, Contact Number: ***hidden ***, Email: ***hidden***";
        }
    }
}

