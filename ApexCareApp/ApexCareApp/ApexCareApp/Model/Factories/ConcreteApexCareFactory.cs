
using ApexCare.Model.Clients;
using ApexCare.Model.ServiceContracts;
using ApexCare.Model.ServiceRequests;
using ApexCare.Model.Technicians;
using ApexCare.Model.Feedback;

namespace ApexCare.Model.Factories
{
    public class ConcreteApexCareFactory : IApexCareFactory
    {
        public Client CreateClient(int id, string name, string contactPerson, string contactNumber, string email)
        {
            return new Client(id, name, contactPerson, contactNumber, email);
        }
        public Technician CreateMaintenanceTechnician(int technicianID, string name, string phoneNum, string suburb, string city, string province, string type)
        {
            return new MaintenanceTechnician(technicianID, name, phoneNum, suburb, city, province, type);
        }
        public Technician CreateRepairTechnician(int technicianID, string name, string phoneNum, string suburb, string city, string province, string type, List<string> equipmentSpecialties)
        {
            return new RepairTechnician(technicianID, name, phoneNum, suburb, city, province, type, equipmentSpecialties);
        }
        public ServiceContract CreateBasicContract(int contractID, int clientID, DateTime contractStart, DateTime contractEnd, DateTime nextMaintenance,
                                                   string streetAddress, string suburb, string city, string province, List<string> equipment, string contractLevel,
                                                   int maxRepairs, int repairsUsed)
        {
            return new BasicContract(contractID, clientID, contractStart, contractEnd, nextMaintenance, streetAddress, suburb, city, province, equipment, contractLevel, maxRepairs, repairsUsed);
        }
        public ServiceContract CreatePremiumContract(int contractID, int clientID, DateTime contractStart, DateTime contractEnd, DateTime nextMaintenance,
                                                     string streetAddress, string suburb, string city, string province, List<string> equipment, string contractLevel,
                                                     int guaranteedResponseHours)
        {
            return new PremiumContract(contractID, clientID, contractStart, contractEnd, nextMaintenance, streetAddress, suburb, city, province, equipment, contractLevel, guaranteedResponseHours);
        }
        public ServiceContract CreatePriorityContract(int contractID, int clientID, DateTime contractStart, DateTime contractEnd, DateTime nextMaintenance,
                                                      string streetAddress, string suburb, string city, string province, List<string> equipment, string contractLevel,
                                                      int guaranteedResponseHours, int repairsUsed, int maxRepairs)
        {
            return new PriorityContract(contractID, clientID, contractStart, contractEnd, nextMaintenance, streetAddress, suburb, city, province, equipment, contractLevel, guaranteedResponseHours, repairsUsed, maxRepairs);
        }
        public ServiceRequest CreateMaintenanceRequest(int requestID, int contractID, int technicianID, string requestIssue, List<Dictionary<DateTime, string>> updates, bool completed)
        {
            return new Maintenance(requestID, contractID, technicianID, requestIssue, updates, completed);
        }
        public ServiceRequest CreateRepairRequest(int requestID, int contractID, int technicianID, string requestIssue, List<Dictionary<DateTime, string>> updates, bool completed,
                                                  List<string> problemEquipment, string issueDescription)
        {
            return new Repair(requestID, contractID, technicianID, requestIssue, updates, completed, problemEquipment, issueDescription);
        }
        public CustomerFeedback CreateCustomerFeedback(int feedbackID, int serviceRequestID, string feedbackText, int satisfactionRating, bool requiresFollowUp)
        {
            return new CustomerFeedback(feedbackID, serviceRequestID, feedbackText, satisfactionRating, requiresFollowUp);
        }
    }
}
