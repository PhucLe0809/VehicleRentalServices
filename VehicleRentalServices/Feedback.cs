using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public enum ECategory
    {
        [Display(Name = "Service Attitude")]
        ServiceAttitude,

        [Display(Name = "Vehicle Quality")]
        VehicleQuality,

        [Display(Name = "Commitment in Contract")]
        CommitmentInContract
    }

    public enum ERate
    {
        [Display(Name = "One")]
        One = 1,

        [Display(Name = "Two")]
        Two = 2,

        [Display(Name = "Three")]
        Three = 3,

        [Display(Name = "Four")]
        Four = 4,

        [Display(Name = "Five")]
        Five = 5
    }
    public class Feedback
	{
		private string id;
		private Renter sender;
		private FeedbackRecipient receiver;
		private ECategory eCategory;
		private ERate eRate;
		private string content;
		private DateTime sendDate;

		#region CONSTRUCTOR AND DESTRUCTOR
        public Feedback(Renter sender, FeedbackRecipient receiver, ECategory eCategory, ERate eRate, string content, DateTime sendDate)
		{
            this.id = Database.GenerateFeedbackCode();
            this.sender = sender;
			this.receiver = receiver;
			this.eCategory = eCategory;
			this.eRate = eRate;
			this.content = content;
			this.sendDate = sendDate;

			this.sender.AddFeedback(this);
			this.receiver.AddFeedback(this);
		}
		~Feedback() {}
		#endregion

		#region PROPERTY
		public string ID
		{ 
			get { return id; } 
		}
		public ERate Rating
		{
			get {return this.eRate; }
		}
		public Person Sender
		{
			get { return this.sender; }
		}
		public FeedbackRecipient Reciver
		{
			get { return this.receiver; }
		}
		public ECategory GetECategory
		{
			get { return this.eCategory; }
		}
		public ERate GetERate
		{
			get { return this.eRate; }
		}
		public string Content
		{
			get { return this.content; }
		}
		public DateTime SendDate
		{
			get { return this.sendDate; }
		}
        #endregion

        public void OutputInformation()
		{
			Console.WriteLine($"From: {this.sender.FullName}");
			if (this.receiver is Person){
				Person person = (Person)this.receiver;
				Console.WriteLine($"To: {person.FullName}");
			}
			else
			{
				Car car = (Car)this.receiver;
				Console.WriteLine($"To: {car.LicensePlates}");
			}
			Console.WriteLine($"Rates: {this.eRate}");
			Console.WriteLine($"Content: {this.content}");
		}
	}
}
