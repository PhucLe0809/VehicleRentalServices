using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public class Renter : Person
    {
        private DateTime jointDate;
        public double TotalContractValue => contractHistory.Sum(contract => contract.AfterSettlementValue);

        #region CONSTRUCTOR AND DESTRUCTOR
        public Renter()
        {
            this.jointDate = DateTime.Now;
            this.contractHistory = new List<Contract>();
        }
        public Renter(string fullName, string id, DateTime dateOfBirth, string phoneNumber, DateTime joinDate)
        : base(fullName, id, dateOfBirth, phoneNumber, joinDate)
        {
            this.contractHistory = new List<Contract>();
        }
        ~Renter() {}
        #endregion

        public override void OutputInformation()
        {
            Console.WriteLine($"Full Name : {this.fullName}");
            Console.WriteLine($"ID : {this.id}");
            Console.WriteLine($"Date of Birth : {this.dateOfBirth}");
            Console.WriteLine($"Phone Number : {this.phoneNumber}");
        }
    }
}
