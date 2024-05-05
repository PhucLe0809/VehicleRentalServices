using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public class Owner : Person
    {
        private double monthlyRevenue;
        private double monthlySalaryExpense;
        private List<Car> cars;
        private List<Employee> employees;
        private List<Renter> renters;
        
        #region CONSTRUCTOR AND DESTRUCTOR
        public Owner()
        {
            this.monthlyRevenue = 0;
            this.monthlySalaryExpense = 0;
            this.cars = new List<Car>();
            this.employees = new List<Employee>();
            this.renters = new List<Renter>();
        }
        public Owner(string fullName, string id, DateTime dateOfBirth, string phoneNumber, DateTime joinDate)
        : base(fullName, id, dateOfBirth, phoneNumber, joinDate)
        {
            this.monthlyRevenue = 0;
            this.monthlySalaryExpense = 0;
            this.cars = new List<Car>();
            this.employees = new List<Employee>();
            this.renters = new List<Renter>();
        }
        ~Owner() {}
        #endregion

        #region PROPERTY
        public double MonthlyRevenue
        {
            get { return this.monthlyRevenue; }
        }
        public double MonthlySalaryExpense
        {
            get { return this.monthlySalaryExpense; }
        }
        public List<Car> Cars
        {
            get { return this.cars; }
        }
        public List<Employee> Employees
        {
            get { return this.employees; }
        }
        public List<Renter> Renters
        {
            get { return this.renters; }
        }
        #endregion

        #region METHOD
        public void AddCar(Car car)
        {
            this.cars.Add(car);
        }
        public void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }
        public void AddRenter(Renter renter)
        {
            this.renters.Add(renter);
        }
        public void AddRangeCar(List<Car> car)
        {
            this.cars.AddRange(car);
        }
        public void AddRangeEmployee(List<Employee> employee)
        {
            this.employees.AddRange(employee);
        }
        public void AddRangeRenter(List<Renter> renter)
        {
            this.renters.AddRange(renter);
        }
        public void ClearCarList()
        {
            this.cars.Clear();
        }
        public void ClearEmployeeList()
        {
            this.employees.Clear();
        }
        public void ClearRenterList()
        {
            this.renters.Clear();
        }
        public void CalculateMonthlyRevenue()
        {
            this.monthlyRevenue = 0;
            foreach (var item in contractHistory)
            {
                if (item.StartDate.Year == DateTime.Now.Year && item.StartDate.Month == DateTime.Now.Month)
                {
                    if (item.Paid)
                    {
                        this.monthlyRevenue += item.AfterSettlementValue;
                    }
                }
            }
        }
        public void CalculateMonthlySalaryExpense()
        {
            this.monthlySalaryExpense = 0;
            foreach (var item in employees)
            {
                item.CalculateSalary();
                this.monthlySalaryExpense += item.MonthlySalary;
            }
        }
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
