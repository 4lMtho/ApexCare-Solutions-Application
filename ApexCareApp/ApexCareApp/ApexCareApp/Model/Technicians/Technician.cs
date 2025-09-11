using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCare.Model.Technicians
{
    public abstract class Technician
    {
        private int technicianID;
        private string name;
        private string type;
        private string phoneNum;
        private string suburb;
        private string city;
        private string province;

        protected Technician(int technicianID, string name, string phoneNum, string suburb, string city, string province, string type)
        {
            this.TechnicianID = technicianID;
            this.Name = name;
            this.PhoneNum = phoneNum;
            this.Suburb = suburb;
            this.City = city;
            this.Province = province;
            this.Type = type;
        }

        public int TechnicianID { get => technicianID; set => technicianID = value; }
        public string Name { get => name; set => name = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }
        public string Type { get => type; set => type = value; }

        public override string ToString()
        {
            return $"Technician ID: {TechnicianID}, Name: {Name}, Type: {Type}, Address & Contact: ***Hidden***";
        }
    }
}
