using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public class TouristCar : Car
    {
        #region CONSTRUCTOR AND DESTRUCTOR
        public TouristCar() { }
        public TouristCar(string licensePlates, string businessCode,
        ECarCompany eCarCompany, ECarSeats eCarSeats, ECarClassification eCarClassification,
        DateTime purchaseDate, bool carInsurance, EVehicles eVehicles = EVehicles.TouristCar)
        : base(licensePlates, businessCode, eCarCompany, eCarSeats, eCarClassification, purchaseDate, carInsurance, eVehicles)
        {
            try
            {
                if (!(eCarClassification == ECarClassification.CarSeats))
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
        }
        ~TouristCar() { }
        #endregion

        #region METHOD
        public override double CalculateCarRentalCosts(DateTime startDate, DateTime endDate, int kilometer)
        {
            int distance = CalculateTimeDistance(startDate, endDate);
            int valueDayOfWeek = CalculateDayOfWeek(startDate);
            double rateCosts = CalculateRateIncreaseCarRentalCosts();
            int seats = (int)this.GetECarSeats;
            double increase = (1 + (seats - (int)ECarSeats.S4seats) * rateCosts);

            double cost = 0;

            if (distance <= 1)
            {
                if (kilometer <= 100)
                {
                    if (valueDayOfWeek >= 2 && valueDayOfWeek <= 6)
                    {
                        cost += 1500000 * increase;
                    }
                    if (valueDayOfWeek >= 7 && valueDayOfWeek <= 8)
                    {
                        cost += 2000000 * increase;
                    }
                }
                if (kilometer > 100)
                {
                    if (valueDayOfWeek >= 2 && valueDayOfWeek <= 6)
                    {
                        cost += (1500000 + (kilometer - 100) * 10000) * increase;
                    }
                    if (valueDayOfWeek >= 7 && valueDayOfWeek <= 8)
                    {
                        cost += (2000000 + (kilometer - 100) * 15000) * increase;
                    }
                }
            }
            if (distance > 1 && distance < 3)
            {
                if (kilometer <= 100)
                {
                    if (valueDayOfWeek >= 2 && valueDayOfWeek <= 6)
                    {
                        cost += 2500000 * increase;
                    }
                    if (valueDayOfWeek >= 7 && valueDayOfWeek <= 8)
                    {
                        cost += 3000000 * increase;
                    }
                }
                if (kilometer > 100 && kilometer <= 200)
                {
                    if (valueDayOfWeek >= 2 && valueDayOfWeek <= 6)
                    {
                        cost += (2500000 + (kilometer - 100) * 12000) * increase;
                    }
                    if (valueDayOfWeek >= 7 && valueDayOfWeek <= 8)
                    {
                        cost += (3000000 + (kilometer - 100) * 15000) * increase;
                    }
                }
                if (kilometer > 200)
                {
                    if (valueDayOfWeek >= 2 && valueDayOfWeek <= 6)
                    {
                        cost += (2500000 + 100 * 12000 + (kilometer - 200) * 10000) * increase;
                    }
                    if (valueDayOfWeek >= 7 && valueDayOfWeek <= 8)
                    {
                        cost += (3000000 + 100 * 15000 + (kilometer - 200) * 10000) * increase;
                    }
                }
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
        }
    }
}
