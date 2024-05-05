using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public enum EVehicles
    {
        [Display(Name = "Passenger Car")]
        PassengerCar,

        [Display(Name = "Tourist Car")]
        TouristCar,

        [Display(Name = "Self-Driving Car")]
        SelfDrivingCar,

        [Display(Name = "Transit Car")]
        TransitCar
    }
    public enum ECarCompany
    {
        [Display(Name = "VinFast")]
        VinFast,

        [Display(Name = "Mazda")]
        Mazda,

        [Display(Name = "Toyota")]
        Toyota,

        [Display(Name = "Mercedes-Benz")]
        MercedesBenz,

        [Display(Name = "Lexus")]
        Lexus,

        [Display(Name = "Ford")]
        Ford,

        [Display(Name = "Hyundai")]
        Hyundai,

        [Display(Name = "Porsche")]
        Porsche,

        [Display(Name = "Honda")]
        Honda,

        [Display(Name = "Bentley")]
        Bentley,

        [Display(Name = "BMW")]
        BMW,

        [Display(Name = "Audi")]
        Audi,

        [Display(Name = "Bugatti")]
        Bugatti,

        [Display(Name = "Ferrari")]
        Ferrari,

        [Display(Name = "Lamborghini")]
        Lamborghini
    }
    public enum ECarSeats
    {
        [Display(Name = "2 Seats")]
        S2seats = 2,

        [Display(Name = "4 Seats")]
        S4seats = 4,

        [Display(Name = "7 Seats")]
        S7seats = 7,

        [Display(Name = "16 Seats")]
        S16seats = 16,

        [Display(Name = "24 Seats")]
        S24seats = 24,

        [Display(Name = "29 Seats")]
        S29seats = 29,

        [Display(Name = "36 Seats")]
        S36seats = 36,

        [Display(Name = "45 Seats")]
        S45seats = 45
    }
    public enum ECarAmenities
    {
        [Display(Name = "Transit Vehicle")]
        TransitVehicle,

        [Display(Name = "Escape Tools")]
        EscapeTools,

        [Display(Name = "Healthcare Box")]
        HealthcareBox,

        [Display(Name = "Seat Belt")]
        SeatBelt,

        [Display(Name = "Vehicle Disinfection")]
        VehicleDisinfection,

        [Display(Name = "Television")]
        Television,

        [Display(Name = "Wifi")]
        Wifi,

        [Display(Name = "Air Conditioning")]
        AirConditioning,

        [Display(Name = "Pillow")]
        Pillow,

        [Display(Name = "Blanket")]
        Blanket,

        [Display(Name = "Reading Lamp")]
        ReadingLamp,

        [Display(Name = "Massage Chair")]
        MassageChair,

        [Display(Name = "Hand Wash")]
        HandWash,

        [Display(Name = "Drinking Water")]
        DrinkingWater,

        [Display(Name = "Wet Towel")]
        WetTowel,

        [Display(Name = "Cake")]
        Cake,

        [Display(Name = "Carry-On Goods")]
        CarryOnGoods,

        [Display(Name = "Enclosed Goods")]
        EnclosedGoods,

        [Display(Name = "Pets Allowed")]
        PetsAllowed,

        [Display(Name = "Mini Refrigerator")]
        MiniRefrigerator,

        [Display(Name = "Power Socket")]
        PowerSocket,

        [Display(Name = "Curtain")]
        Curtain,

        [Display(Name = "Personal Speaker")]
        PersonalSpeaker,

        [Display(Name = "Staff")]
        Staff,

        [Display(Name = "Shock Resistance")]
        ShockResistance,

        [Display(Name = "Refrigerated Truck Trunk")]
        RefrigeratedTruckTrunk
    }
    public enum ECarClassification
    {
        [Display(Name = "Car Seats")]
        CarSeats,

        [Display(Name = "Sleeper Car")]
        SleeperCar,

        [Display(Name = "Limousine")]
        Limousine,

        [Display(Name = "Regular Car")]
        RegularCar,

        [Display(Name = "Freezing Car")]
        FreezingCar
    }
    public class Car : FeedbackRecipient
    {
        protected string licensePlates;
        protected string businessCode;
        protected ECarCompany eCarCompany;
        protected ECarSeats eCarSeats;
        protected ECarClassification eCarClassification;
        protected DateTime purchaseDate;
        protected double kilometersTraveled;
        protected bool carInsurance;
        protected List<ECarAmenities> eCarAmenities;
        protected EVehicles eVehicles;

        #region CONSTRUCTOR AND DESTRUCTOR
        public Car()
        {
            this.licensePlates = "";
            this.businessCode = "";
            this.eCarCompany = ECarCompany.Honda;
            this.eCarSeats = ECarSeats.S4seats;
            this.eCarClassification = ECarClassification.CarSeats;
            this.purchaseDate = DateTime.Now;
            this.kilometersTraveled = 0;
            this.carInsurance = false;
            this.eCarAmenities = new List<ECarAmenities>();
            this.eVehicles = EVehicles.PassengerCar;
        }
        public Car(string licensePlates, string businessCode, 
        ECarCompany eCarCompany, ECarSeats eCarSeats, ECarClassification eCarClassification,
        DateTime purchaseDate, bool carInsurance, EVehicles eVehicles)
        {
            this.licensePlates = licensePlates;
            this.businessCode = businessCode;
            this.eCarCompany = eCarCompany;
            this.eCarSeats = eCarSeats;
            this.eCarClassification = eCarClassification;
            this.purchaseDate = purchaseDate;
            this.kilometersTraveled = 0;
            this.carInsurance = carInsurance;
            this.eCarAmenities = new List<ECarAmenities>();
            this.eVehicles = eVehicles;
        }
        ~Car() {}
        #endregion

        #region PROPERTY
        public string LicensePlates
        {
            get { return this.licensePlates; }
        }
        public string BusinessCode
        {
            get { return this.businessCode; }
        }
        public ECarCompany GetECarCompany
        {
            get { return this.eCarCompany; }
        }
        public ECarClassification GetECarClassification
        {
            get { return this.eCarClassification; }
        }
        public ECarSeats GetECarSeats
        {
            get { return this.eCarSeats; }
        }
        public DateTime PurchaseDate
        {
            get { return this.purchaseDate;  }
        }
        public double KmTraveled
        {
            get { return this.kilometersTraveled; }
        }
        public bool CarInsurance
        {
            get { return this.carInsurance; }
        }
        public EVehicles GetEVehicles
        {
            get { return this.eVehicles; }
        }
        public List<ECarAmenities> GetECarAmenities
        {
            get { return this.eCarAmenities;  }
        }
        public override string FullName
        {
            get { return this.licensePlates; }
        }
        #endregion

        #region METHOD
        public void AddCarAmenities(ECarAmenities eCarAmenities)
        {
            this.eCarAmenities.Add(eCarAmenities);
        }
        public void AddRangeCarAmenities(List<ECarAmenities> eCarAmenities)
        {
            this.eCarAmenities.AddRange(eCarAmenities);
        }
        public void AddKilometersTraveled(double kilometersTraveled)
        {
            this.kilometersTraveled += kilometersTraveled;
        }
        public virtual double CalculateCarRentalCosts(DateTime startDate, DateTime endDate, int kilometer)
        {
            return 0;
        }
        public int CalculateTimeDistance(DateTime startDate, DateTime endDate)
        {
            TimeSpan timeDistance = endDate - startDate;
            try
            {
                if (timeDistance.Days > 3)
                {
                    InvalidDataException error = new InvalidDataException($"The number of days of the trip is too long!");
                    throw error;
                }
            }
            catch (InvalidDataException error)
            {
                Console.WriteLine(error.Message);
                throw;
            }
            return timeDistance.Days;
        }
        public int CalculateDayOfWeek(DateTime dateTime)
        {
            DayOfWeek dayOfWeek = dateTime.DayOfWeek;
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return 2;
                case DayOfWeek.Tuesday:
                    return 3;
                case DayOfWeek.Wednesday:
                    return 4;
                case DayOfWeek.Thursday:
                    return 5;
                case DayOfWeek.Friday:
                    return 6;
                case DayOfWeek.Saturday:
                    return 7;
                case DayOfWeek.Sunday:
                    return 8;
            }
            return -1;
        }
        public double CalculateRateIncreaseCarRentalCosts()
        {
            if (this is PassengerCar) return 0.015;
            if (this is TouristCar) return 0.02;
            if (this is SelfDrivingCar) return 0.045;
            if (this is TransitCar)
            {
                if (this.GetECarClassification == ECarClassification.RegularCar) return 0.065;
                if (this.GetECarClassification == ECarClassification.FreezingCar) return 0.095;
            }
            return 0;
        }
        public double RoundToThousands(double num)
        {
            double calc = num / 10000;
            calc = Math.Round(calc, 0);
            return calc * 10000;
        }
        public virtual ECarLoad GetECarLoad()
        {
            return ECarLoad.W1dot25ton;
        }
        #endregion

        public virtual void OutputInformation() {}
    }

}
