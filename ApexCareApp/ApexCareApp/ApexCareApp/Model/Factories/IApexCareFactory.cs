
using ApexCare.Model.Clients;
using ApexCare.Model.ServiceContracts;
using ApexCare.Model.ServiceRequests;
using ApexCare.Model.Technicians;
using ApexCare.Model.Feedback;

namespace ApexCare.Model.Factories
{
    public interface IApexCareFactory
    {
        Client CreateClient(int id, string name, string contactPerson, string contactNumber, string email);
        Technician CreateMaintenanceTechnician(int technicianID, string name, string phoneNum, string suburb, string city, string province, string type);
        Technician CreateRepairTechnician(int technicianID, string name, string phoneNum, string suburb, string city, string province, string type, List<string> equipmentSpecialties);
        ServiceContract CreateBasicContract(int contractID, int clientID, DateTime contractStart, DateTime contractEnd, DateTime nextMaintenance, string streetAddress,
                                            string suburb, string city, string province, List<string> equipment, string contractLevel, int maxRepairs, int repairsUsed);

        ServiceContract CreatePremiumContract(int contractID, int clientID, DateTime contractStart, DateTime contractEnd, DateTime nextMaintenance, string streetAddress,
                                              string suburb, string city, string province, List<string> equipment, string contractLevel, int guaranteedResponseHours);

        ServiceContract CreatePriorityContract(int contractID, int clientID, DateTime contractStart, DateTime contractEnd, DateTime nextMaintenance, string streetAddress,
                                               string suburb, string city, string province, List<string> equipment, string contractLevel, int guaranteedResponseHours,
                                               int repairsUsed, int maxRepairs);
        ServiceRequest CreateMaintenanceRequest(int requestID, int contractID, int technicianID, string requestIssue, List<Dictionary<DateTime, string>> updates, bool completed);

        ServiceRequest CreateRepairRequest(int requestID, int contractID, int technicianID, string requestIssue, List<Dictionary<DateTime, string>> updates, bool completed,
                                           List<string> problemEquipment, string issueDescription);
        CustomerFeedback CreateCustomerFeedback(int feedbackID, int serviceRequestID, string feedbackText, int satisfactionRating, bool requiresFollowUp);
    }
}
