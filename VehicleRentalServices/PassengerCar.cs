using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public class PassengerCar : Car
    {
        #region CONSTRUCTOR AND DESTRUCTOR
        public PassengerCar() { }
        public PassengerCar(string licensePlates, string businessCode,
        ECarCompany eCarCompany, ECarSeats eCarSeats, ECarClassification eCarClassification,
        DateTime purchaseDate, bool carInsurance, EVehicles eVehicles = EVehicles.PassengerCar)
        : base(licensePlates, businessCode, eCarCompany, eCarSeats, eCarClassification, purchaseDate, carInsurance, eVehicles)
        {
            try
            {
                if (!(eCarClassification == ECarClassification.CarSeats
                || eCarClassification == ECarClassification.SleeperCar
                || eCarClassification == ECarClassification.Limousine))
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
        ~PassengerCar() { }
        #endregion

        #region METHOD
        public override double CalculateCarRentalCosts(DateTime startDate, DateTime endDate, int kilometer)
        {
            int distance = CalculateTimeDistance(startDate, endDate);
            int valueDayOfWeek = CalculateDayOfWeek(startDate);
            double rateCosts = CalculateRateIncreaseCarRentalCosts();
            int seats = (int)this.GetECarSeats;
            double increase = (1 + (seats - (int)ECarSeats.S29seats) * rateCosts);

            double cost = 0;
            if (this.GetECarClassification == ECarClassification.SleeperCar) cost = seats * 20000;
            if (this.GetECarClassification == ECarClassification.Limousine) cost = seats * 80000;

            if (distance < 1)
            {
                if (kilometer <= 100)
                {
                    if (valueDayOfWeek >= 2 && valueDayOfWeek <= 6)
                    {
                        cost += 2000000 * increase;
                    }
                    if (valueDayOfWeek >= 7 && valueDayOfWeek <= 8)
                    {
                        cost += 2500000 * increase;
                    }
                }
                if (kilometer > 100)
                {
                    if (valueDayOfWeek >= 2 && valueDayOfWeek <= 6)
                    {
                        cost += (2000000 + (kilometer - 100) * 15000) * increase;
                    }
                    if (valueDayOfWeek >= 7 && valueDayOfWeek <= 8)
                    {
                        cost += (2500000 + (kilometer - 100) * 25000) * increase;
                    }
                }
            }
            if (distance >= 1 && distance < 3)
            {
                if (kilometer <= 100)
                {
                    if (valueDayOfWeek >= 2 && valueDayOfWeek <= 6)
                    {
                        cost += 3500000 * increase;
                    }
                    if (valueDayOfWeek >= 7 && valueDayOfWeek <= 8)
                    {
                        cost += 4000000 * increase;
                    }
                }
                if (kilometer > 100 && kilometer <= 200)
                {
                    if (valueDayOfWeek >= 2 && valueDayOfWeek <= 6)
                    {
                        cost += (3500000 + (kilometer - 100) * 15000) * increase;
                    }
                    if (valueDayOfWeek >= 7 && valueDayOfWeek <= 8)
                    {
                        cost += (4000000 + (kilometer - 100) * 20000) * increase;
                    }
                }
                if (kilometer > 200)
                {
                    if (valueDayOfWeek >= 2 && valueDayOfWeek <= 6)
                    {
                        cost += (3500000 + 100 * 15000 + (kilometer - 200) * 10000) * increase;
                    }
                    if (valueDayOfWeek >= 7 && valueDayOfWeek <= 8)
                    {
                        cost += (4000000 + 100 * 20000 + (kilometer - 200) * 15000) * increase;
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
