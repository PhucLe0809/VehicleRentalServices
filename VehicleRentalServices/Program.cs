using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner lehongphuc = new Owner("LE HONG PHUC", "08077211828", new DateTime(1977, 9, 8), "0702569999", new DateTime(2000, 1, 1));
            PassengerCar passengerCar = new PassengerCar("29-L143883", "0x894", ECarCompany.VinFast, ECarSeats.S29seats, ECarClassification.CarSeats, DateTime.Now, true);
            TouristCar atouristCar = new TouristCar("63-K982556", "0x234", ECarCompany.BMW, ECarSeats.S4seats, ECarClassification.CarSeats, DateTime.Now, true);
            SelfDrivingCar aselfDrivingCar = new SelfDrivingCar("56-H677007", "0x561", ECarCompany.Toyota, ECarSeats.S4seats, ECarClassification.CarSeats, DateTime.Now, true, ECollateral.Movables);
            TransitCar atransitCar = new TransitCar("97-I859744", "0x846", ECarCompany.Hyundai, ECarSeats.S2seats, ECarClassification.FreezingCar, DateTime.Now, true, ECarLoad.W2dot50ton);
            
            Driver driver = new Driver("LE NHUT ANH", "1001", new DateTime(1981, 11, 29), "0126375598", new DateTime(2010, 1, 1));
            Assistant assistant = new Assistant("BUI KHAC DUY", "08765082394", new DateTime(2000, 2, 16), "0706748759", new DateTime(2020, 8, 15));
            Renter renter = new Renter("PHAM KHANH HUY", "2001", new DateTime(2004, 2, 16), "0705687899", DateTime.Now);
            Contract contract = new Contract(lehongphuc, renter, driver, assistant, passengerCar, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1), 100);
            
            lehongphuc.OutputInformation();
            Console.WriteLine();
            passengerCar.OutputInformation();
            Console.WriteLine();
            contract.OutputInformation();
            Console.WriteLine();
            contract.AddPrepayment(4000000);
            contract.ContractPayments(DateTime.Now, EPayments.ATM, 400000000);
            contract.OutputInformation();
        }
    }
}
