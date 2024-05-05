using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public abstract class FeedbackRecipient
    {
        public List<Feedback> feedbackHistory;
        public FeedbackRecipient()
        {
            this.feedbackHistory = new List<Feedback>();
        }
        public List<Feedback> FeedbackHistory
        {
            get { return this.feedbackHistory; }
        }
        public virtual string FullName
        {
            get { return string.Empty; }
        }
        public void AddFeedback(Feedback feedback)
        {
            this.feedbackHistory.Add(feedback);
        }
        public double CalculateAverageFeedbackRating()
        {
            if (feedbackHistory.Count == 0)
            {
                return 0;
            }
            double totalRating = 0;
            foreach (var item in feedbackHistory)
            {
                totalRating += (int)item.Rating;
            }
            return totalRating / feedbackHistory.Count;
        }
    }
}
