using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public class Employee : Person
    {
        protected double monthlySalary;
        public double TotalContractValue => contractHistory.Sum(contract => contract.AfterSettlementValue);

        #region CONSTRUCTOR AND DESTRUCTOR
        public Employee()
        {
            this.contractHistory = new List<Contract>();
            this.monthlySalary = 0;
        }
        public Employee(string fullName, string id, DateTime dateOfBirth, string phoneNumber, DateTime joinDate)
        : base(fullName, id, dateOfBirth, phoneNumber, joinDate)
        {
            this.joinDate = joinDate;
            this.contractHistory = new List<Contract>();
            this.monthlySalary = 0;
        }
        ~Employee() {}
        #endregion

        #region PROPERTY
        public double MonthlySalary
        {
            get { return this.monthlySalary; }
        }
        public double AverageRating
        {
            get { return this.CalculateAverageFeedbackRating(); }
        }
        #endregion

        #region METHOD
        public void CalculateSalary()
        {
            double baseSalary = CalculateBaseSalary();
            double percentageOnContract = CalculatePercentageOnContract();
            double totalContractValue = CalculateTotalContractValue();
            double percentageFeedbackBonus = CalculatePercentageFeedbackBonus();
            this.monthlySalary = 0;
            this.monthlySalary += baseSalary + percentageOnContract * totalContractValue;
            this.monthlySalary += percentageFeedbackBonus * this.monthlySalary;
        }
        public int CalculateYearsInBusiness()
        {
            return DateTime.Now.Year - joinDate.Year;
        }
        public virtual double CalculateBaseSalary()
        {
            return 0;
        }
        public virtual double CalculatePercentageOnContract()
        {
            return 0;
        }
        public double CalculateTotalContractValue()
        {
            double totalContractValue = 0;
            foreach (var item in contractHistory)
            {
                if (item.Paid == true)
                {
                    totalContractValue += item.PreSettlementValue;
                }
            }
            return totalContractValue;
        }
        public double CalculatePercentageFeedbackBonus()
        {
            int yearsInBusiness = CalculateYearsInBusiness();
            double averageFeedbackRating = CalculateAverageFeedbackRating();
            if (yearsInBusiness >= 1 && yearsInBusiness <= 2){
                if (averageFeedbackRating >= 1 && averageFeedbackRating < 2) return -0.1;
                if (averageFeedbackRating >= 2 && averageFeedbackRating < 3) return -0.05;
                if (averageFeedbackRating >= 3 && averageFeedbackRating < 4) return 0.0;
                if (averageFeedbackRating >= 4 && averageFeedbackRating < 5) return 0.05;
                if (averageFeedbackRating >= 5) return 0.1;
            }
            if (yearsInBusiness >= 3 && yearsInBusiness <= 5){
                if (averageFeedbackRating >= 1 && averageFeedbackRating < 2) return -0.15;
                if (averageFeedbackRating >= 2 && averageFeedbackRating < 3) return -0.1;
                if (averageFeedbackRating >= 3 && averageFeedbackRating < 4) return 0.0;
                if (averageFeedbackRating >= 4 && averageFeedbackRating < 5) return 0.1;
                if (averageFeedbackRating >= 5) return 0.15;
            }
            if (yearsInBusiness >= 5){
                if (averageFeedbackRating >= 1 && averageFeedbackRating < 2) return -0.1;
                if (averageFeedbackRating >= 2 && averageFeedbackRating < 3) return -0.05;
                if (averageFeedbackRating >= 3 && averageFeedbackRating < 4) return 0.0;
                if (averageFeedbackRating >= 4 && averageFeedbackRating < 5) return 0.15;
                if (averageFeedbackRating >= 5) return 0.2;
            }
            return 0;
        }
        #endregion

        public override void OutputInformation()
        {
            Console.WriteLine($"Full Name : {this.fullName}");
            Console.WriteLine($"ID : {this.id}");
            Console.WriteLine($"Date of Birth : {this.dateOfBirth}");
            Console.WriteLine($"Phone Number : {this.phoneNumber}");
            Console.WriteLine($"-------------------------------------------------------");
            Console.WriteLine($"Joining Date : {this.joinDate}");
            Console.WriteLine($"Monthly Salary : {this.monthlySalary}");
            Console.WriteLine($"Average Rating : {this.AverageRating}");
        }
    }
}
