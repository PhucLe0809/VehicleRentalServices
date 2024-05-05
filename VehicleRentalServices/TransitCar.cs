using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public enum ECarLoad
    {
        [Display(Name = "1.25 ton")]
        W1dot25ton = 125,

        [Display(Name = "1.50 ton")]
        W1dot50ton = 150,

        [Display(Name = "1.90 ton")]
        W1dot90ton = 190,

        [Display(Name = "2.50 ton")]
        W2dot50ton = 250,

        [Display(Name = "3.50 ton")]
        W3dot50ton = 350,

        [Display(Name = "5.00 ton")]
        W5dot00ton = 500,

        [Display(Name = "8.00 ton")]
        W8dot00ton = 800,

        [Display(Name = "10.00 ton")]
        W10dot00ton = 1000,
    }
    public class TransitCar : Car
    {
        private ECarLoad eCarLoad;

        #region CONSTRUCTOR AND DESTRUCTOR
        public TransitCar() { }
        public TransitCar(string licensePlates, string businessCode,
        ECarCompany eCarCompany, ECarSeats eCarSeats, ECarClassification eCarClassification,
        DateTime purchaseDate, bool carInsurance, ECarLoad eCarLoad, EVehicles eVehicles = EVehicles.TransitCar)
        : base(licensePlates, businessCode, eCarCompany, eCarSeats, eCarClassification, purchaseDate, carInsurance, eVehicles)
        {
            try
            {
                if (!(eCarClassification == ECarClassification.RegularCar
                || eCarClassification == ECarClassification.FreezingCar))
                {
                    InvalidDataException error = new InvalidDataException($"Your vehicle model is not supported!");
                    throw error;
                }
            }
            catch (InvalidDataException error)
            {
                Console.WriteLine(error.Message);
                throw;
            }
            this.eCarLoad = eCarLoad;
        }
        ~TransitCar() { }
        #endregion

        public override ECarLoad GetECarLoad()
        {
            return this.eCarLoad;
        }

        #region METHOD
        public override double CalculateCarRentalCosts(DateTime startDate, DateTime endDate, int kilometer)
        {
            int weight = (int)this.eCarLoad;
            double increaseMinicharge = Math.Max(weight - (int)ECarLoad.W1dot90ton, 0) * 80000;
            double rateCosts = CalculateRateIncreaseCarRentalCosts();
            double increase = (1 + Math.Max(weight - (int)ECarLoad.W1dot90ton, 0) * rateCosts);

            double cost = 0;

            if (this.eCarClassification == ECarClassification.RegularCar)
            {
                if (kilometer <= 20) cost += 250000 + increaseMinicharge;
                if (kilometer > 20 && kilometer <= 30) cost += (250000 + (kilometer - 20) * 14500) * increase;
                if (kilometer > 30 && kilometer <= 50) cost += (250000 + (kilometer - 30) * 11000) * increase;
                if (kilometer > 50 && kilometer <= 100) cost += (250000 + (kilometer - 50) * 10000) * increase;
                if (kilometer > 100) cost += (250000 + (kilometer - 100) * 9500) * increase;
            }
            if (this.eCarClassification == ECarClassification.FreezingCar)
            {
                if (kilometer <= 20) cost += 313000 + increaseMinicharge;
                if (kilometer > 20 && kilometer <= 30) cost += (313000 + (kilometer - 20) * 18000) * increase;
                if (kilometer > 30 && kilometer <= 50) cost += (313000 + (kilometer - 30) * 14000) * increase;
                if (kilometer > 50 && kilometer <= 100) cost += (313000 + (kilometer - 50) * 12500) * increase;
                if (kilometer > 100) cost += (313000 + (kilometer - 100) * 11000) * increase;
            }
            return RoundToThousands(cost);
        }
        #endregion

        public override void OutputInformation()
        {
            Console.WriteLine($"License Plates : {this.licensePlates}");
            Console.WriteLine($"Business Code : {this.businessCode}");
            Console.WriteLine($"Car Company : {this.eCarCompany}");
            Console.WriteLine($"Car Seats : {this.eCarSeats}");
            Console.WriteLine($"Car Classification : {this.eCarClassification}");
            Console.WriteLine($"Year Of Purchase : {this.purchaseDate}");
            Console.WriteLine($"Kilometers Traveled : {this.kilometersTraveled}");
            Console.WriteLine($"Car Insurance : {this.carInsurance}");
            Console.WriteLine($"-------------------------------------------------------");
            Console.WriteLine($"Car Load : {this.eCarLoad}");
        }
    }
}
