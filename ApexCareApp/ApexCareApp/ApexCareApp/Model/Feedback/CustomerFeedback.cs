using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApexCare.Model.Clients;
using ApexCare.Model.ServiceRequests;

namespace ApexCare.Model.Feedback
{
    public class CustomerFeedback
    {
        private int feedbackID;
        private int serviceRequestID;
        private string feedbackText;
        private int satisfactionRating;
        private bool requiresFollowUp;

        public CustomerFeedback(int feedbackID, int serviceRequestID, string feedbackText, int satisfactionRating, bool requiresFollowUp)
        {
            this.FeedbackID = feedbackID;
            this.ServiceRequestID = serviceRequestID;
            this.FeedbackText = feedbackText;
            this.SatisfactionRating = satisfactionRating;
            this.RequiresFollowUp = requiresFollowUp;
        }

        public int FeedbackID { get => feedbackID; set => feedbackID = value; }
        public int ServiceRequestID { get => serviceRequestID; set => serviceRequestID = value; }
        public string FeedbackText { get => feedbackText; set => feedbackText = value; }
        public int SatisfactionRating { get => satisfactionRating; set => satisfactionRating = value; }
        public bool RequiresFollowUp { get => requiresFollowUp; set => requiresFollowUp = value; }

        public override string? ToString()
        {
            return $"Feedback ID: {FeedbackID}, Service Request ID: {ServiceRequestID}, Feedback: {FeedbackText}, Satisfaction Rating: {SatisfactionRating}/5, Requires Follow-Up: {RequiresFollowUp}";
        }
    }
}
