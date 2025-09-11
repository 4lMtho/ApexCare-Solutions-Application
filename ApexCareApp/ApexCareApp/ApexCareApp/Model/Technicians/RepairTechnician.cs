using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCare.Model.Technicians
{
    public class RepairTechnician : Technician
    {
        List<String> equimentSpecialties;

        public RepairTechnician(int technicianID, string name, string phoneNum, string suburb, string city, string province, 
            string type, List<String> equimentSpecialties) 
            : base(technicianID, name, phoneNum, suburb, city, province, type)
        {
            this.EquimentSpecialties = equimentSpecialties;
        }

        public List<string> EquimentSpecialties { get => equimentSpecialties; set => equimentSpecialties = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
