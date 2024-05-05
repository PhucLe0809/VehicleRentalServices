using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public class Driver : Employee
    {
        #region CONSTRUCTOR AND DESTRUCTOR
        public Driver() { }
        public Driver(string fullName, string id, DateTime dateOfBirth, string phoneNumber, DateTime joinDate)
        : base(fullName, id, dateOfBirth, phoneNumber, joinDate) {}
        #endregion

        #region METHOD
        public override double CalculateBaseSalary()
        {
            int yearsInBusiness = CalculateYearsInBusiness();
            if (yearsInBusiness >= 0 && yearsInBusiness <= 2) return 5000000;
            if (yearsInBusiness >= 3 && yearsInBusiness <= 5) return 7000000;
            if (yearsInBusiness >= 5) return 10000000;
            return 0;
        }
        public override double CalculatePercentageOnContract()
        {
            int yearsInBusiness = CalculateYearsInBusiness();
            if (yearsInBusiness >= 0 && yearsInBusiness <= 2) return 0.2;
            if (yearsInBusiness >= 3 && yearsInBusiness <= 5) return 0.3;
            if (yearsInBusiness >= 5) return 0.4;
            return 0;
        }
        #endregion
    }
}
