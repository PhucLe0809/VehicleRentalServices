using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public class Person : FeedbackRecipient
    {
        protected string fullName;
        protected string id;
        protected DateTime dateOfBirth;
        protected string phoneNumber;
        protected DateTime joinDate;
        protected List<Contract> contractHistory;

        #region CONSTRUCTOR AND DESTRUCTOR
        public Person()
        {
            this.fullName = "";
            this.id = "";
            this.dateOfBirth = DateTime.Now;
            this.phoneNumber = "";
            this.joinDate = DateTime.Now;
            this.contractHistory = new List<Contract>();
        }
        public Person(string fullName, string id, DateTime dateOfBirth, string phoneNumber, DateTime joinDate)
        {
            this.fullName = fullName;
            this.id = id;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.joinDate = joinDate;
            this.contractHistory = new List<Contract>();
        }
        ~Person() {}
        #endregion

        #region PROPERTY
        public override string FullName
        {
            get { return this.fullName; }
        }
        public string ID
        {
            get {  return this.id; }
        }
        public DateTime DateOfBirth
        { 
            get { return this.dateOfBirth; } 
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
        }
        public DateTime JointDate
        {
            get { return this.joinDate; }
        }
        public List<Contract> ContractHistory
        {
            get { return this.contractHistory; }
        }
        #endregion

        #region METHOD
        public void AddContract(Contract contract)
        {
            this.contractHistory.Add(contract);
        }
        public void AddRangeContract(List<Contract> contract)
        {
            this.contractHistory.AddRange(contract);
        }
        public void ClearContractList()
        {
            this.contractHistory.Clear();
        }
        #endregion

        public virtual void OutputInformation() {}
    }
}
