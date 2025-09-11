using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCare.Model.Technicians
{
    public class MaintenanceTechnician : Technician
    {
        public MaintenanceTechnician(int technicianID, string name, string phoneNum, string suburb, string city, string province, string type) : base(technicianID, name, phoneNum, suburb, city, province, type)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
