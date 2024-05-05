using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public enum EDamage
    {
        [Display(Name = "Scratched")]
        Scratched,

        [Display(Name = "Accessible Wheels")]
        AccessibleWheels,

        [Display(Name = "Broken Glass")]
        BrokenGlass,

        [Display(Name = "Too Dirty")]
        TooDirty,

        [Display(Name = "Goods Not Allowed")]
        GoodsNotAllowed,

        [Display(Name = "Other Damage")]
        OtherDamage
    }
    public enum EPayments
    {
        [Display(Name = "COD")]
        COD,

        [Display(Name = "Visa")]
        Visa,

        [Display(Name = "ATM")]
        ATM
    }
    public class Contract
    {
        private string id;
        private Owner owner;
        private Renter renter;
        private Driver driver;
        private Assistant assistant;
        private Car car;
        private DateTime startDate;
        private DateTime endDate;
        private int kilometer;
        private double percentagePrepayment;
        private double prepayment;
        private double percentageDiscounted;
        private double preSettlementValue;
        private DateTime paymentDate;
        private EPayments ePayments;
        private List<EDamage> eDamages;
        private double damageCost;
        private double lateCost;
        private double afterSettlementValue;
        private bool paid;
        private bool hasTakenEffect;

        #region CONSTRUCTOR AND DESTRUCTOR
        public Contract()
        {
            this.id = "VRSxxx";
            this.owner = new Owner();
            this.renter = new Renter();
            this.driver = new Driver();
            this.assistant = new Assistant();
            this.car = new Car();
            this.startDate = DateTime.Now;
            this.endDate = DateTime.Now;
            this.kilometer = 0;
            this.preSettlementValue = 0;
            this.paymentDate = endDate;
            this.ePayments = EPayments.COD;
            this.eDamages = new List<EDamage>();
            this.damageCost = 0;
            this.lateCost = 0;
            this.afterSettlementValue = 0;
            this.paid = false;
            this.hasTakenEffect = false;
        }
        public Contract(Owner owner, Renter renter, Driver driver, Assistant assistant, Car car, DateTime startDate, DateTime endDate, int kilometer)
        {
            this.id = "VRSxxx";
            this.owner = owner;
            this.renter = renter;
            this.driver = driver;
            this.assistant = assistant;
            this.car = car;
            this.startDate = startDate;
            this.endDate = endDate;
            this.kilometer = kilometer;
            this.preSettlementValue = CalculatePreSettlementValue();
            this.paymentDate = endDate;
            this.ePayments = EPayments.COD;
            this.eDamages = new List<EDamage>();
            this.damageCost = 0;
            this.lateCost = 0;
            this.afterSettlementValue = 0;
            this.paid = false;
            this.hasTakenEffect = false;
        }
        ~Contract() { }
        #endregion

        #region PROPERTY
        public string ID
        {
            get { return this.id; }
        }
        public Owner GetOwner
        {
            get { return this.owner; }
        }
        public Renter GetRenter
        {
            get { return this.renter; }
        }
        public Driver GetDriver
        {
            get { return this.driver; }
        }
        public Assistant GetAssistant
        {
            get { return this.assistant; }
        }
        public Car GetCar
        {
            get { return this.car; }
        }
        public DateTime StartDate
        {
            get { return this.startDate; }
        }
        public DateTime EndDate
        {
            get { return this.endDate; }
        }
        public DateTime PaymentDate
        {
            get { return this.paymentDate; }
        }
        public int Kilometers
        {
            get {  return this.kilometer;  }
        }
        public double PercentagePrepayment
        {
            get { return this.percentagePrepayment; }
        }
        public double PercentageDiscounted
        {
            get { return this.percentageDiscounted; }
        }
        public double PrePayment
        {
            get { return this.prepayment;  }
        }
        public double PreSettlementValue
        {
            get { return this.preSettlementValue; }
        }
        public double AfterSettlementValue
        {
            get { return this.afterSettlementValue; }
        }
        public bool Paid
        {
            get { return this.paid; }
        }
        public bool HasTakenEffect
        {
            get { return this.hasTakenEffect; }
        }
        public List<EDamage> GetEDamages
        {
            get { return this.eDamages; }
        }
        public EPayments GetEPayments
        {
            get { return this.ePayments; }
        }
        #endregion

        #region METHOD
        public void AddPrepayment(double money)
        {
            try
            {
                if (money >= this.percentagePrepayment * this.preSettlementValue)
                {
                    this.id = "VRSxxx";
                    this.prepayment = money;
                    this.hasTakenEffect = true;
                }
                else
                {
                    InvalidDataException error = new InvalidDataException($"The required prepayment amount is at least {this.percentagePrepayment * 100}% of the contract value before settlement!");
                    throw error;
                }
            }
            catch (InvalidDataException error)
            {
                Console.WriteLine(error.Message);
                throw;
            }
        }
        public void AddDamage(EDamage eDamage)
        {
            this.eDamages.Add(eDamage);
        }
        public double CalculatePreSettlementValue()
        {
            this.percentagePrepayment = CalculatePercentagePrepayment();
            this.percentageDiscounted = CalculatePercentageDiscounted();
            this.preSettlementValue = this.car.CalculateCarRentalCosts(this.startDate, this.endDate, this.kilometer);
            this.preSettlementValue -= this.percentageDiscounted * this.preSettlementValue;
            return this.preSettlementValue;
        }
        public double CalculatePercentagePrepayment()
        {
            if (car is PassengerCar) return 0.5;
            if (car is TouristCar) return 0.5;
            if (car is SelfDrivingCar) return 0.9;
            if (car is TransitCar) return 0.7;
            return 0;
        }
        public double CalculatePercentageDiscounted()
        {
            int rentalCount = this.renter.ContractHistory.Count;
            if (rentalCount > 10) return 0.08;
            if (rentalCount > 7) return 0.07;
            if (rentalCount > 3) return 0.05;
            return 0;
        }
        public void ContractPayments(DateTime paymentDate, EPayments ePayments, double money)
        {
            this.paymentDate = paymentDate;
            this.ePayments = ePayments;
            this.damageCost = CalculateDamageCost();
            this.lateCost = CalculateLateCost();
            this.afterSettlementValue = this.preSettlementValue + this.damageCost + this.lateCost;

            try
            {
                if (money >= this.afterSettlementValue - this.prepayment)
                {
                    this.paid = true;

                    this.owner.AddContract(this);
                    this.renter.AddContract(this);
                    this.driver.AddContract(this);
                    this.assistant.AddContract(this);

                    this.car.AddKilometersTraveled(this.kilometer);
                }
                else
                {
                    InvalidDataException error = new InvalidDataException($"Your amount is not enough to make the transaction!");
                    throw error;
                }
            }
            catch (InvalidDataException error)
            {
                Console.WriteLine(error.Message);
                throw;
            }
        }
        public double CalculateDamageCost()
        {
            return this.eDamages.Count * 1000000;
        }
        public double CalculateLateCost()
        {
            TimeSpan timeSpan = this.paymentDate - this.endDate;
            return Math.Max(timeSpan.Days, 0) * 2000000;
        }
        public static double GetRankCustomer(Renter renter)
        {
            int rentalCount = renter.ContractHistory.Count;
            if (rentalCount > 10) return 0.08;
            if (rentalCount > 7) return 0.07;
            if (rentalCount > 3) return 0.05;
            return 0;
        }
        #endregion

        public void OutputInformation()
        {
            Console.WriteLine($"Owner : {this.owner.FullName}");
            Console.WriteLine($"Renter : {this.renter.FullName}");
            Console.WriteLine($"Driver : {this.driver.FullName}");
            Console.WriteLine($"Assistant : {this.assistant.FullName}");
            Console.WriteLine($"License Plates : {this.car.LicensePlates}");
            Console.WriteLine($"Start Date : {this.startDate}");
            Console.WriteLine($"End Date : {this.endDate}");
            Console.WriteLine($"Kilometers : {this.kilometer}");
            Console.WriteLine($"Percentage Prepayment : {this.percentagePrepayment}");
            Console.WriteLine($"Prepayment : {this.prepayment}");
            Console.WriteLine($"Percentage Discounted : {this.percentageDiscounted}");
            Console.WriteLine($"Pre-SettlementValue : {this.preSettlementValue}");
            Console.WriteLine($"-------------------------------------------------------");
            Console.WriteLine($"Payment Date : {this.paymentDate}");
            Console.WriteLine($"Payment Methods : {this.ePayments}");
            Console.WriteLine($"Damage Cost : {this.damageCost}");
            Console.WriteLine($"Late Cost : {this.lateCost}");
            Console.WriteLine($"After-SettlementValue : {this.afterSettlementValue}");
            Console.WriteLine($"-------------------------------------------------------");
            Console.WriteLine($"Is Paid : {this.paid}");
            Console.WriteLine($"Has Taken Effect : {this.hasTakenEffect}");
        }
    }
}