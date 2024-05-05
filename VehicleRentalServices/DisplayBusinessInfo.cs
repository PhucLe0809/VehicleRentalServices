using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentalServices
{
    public partial class DisplayBusinessInfo : Form
    {
        public DisplayBusinessInfo()
        {
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            Database.owner.ClearEmployeeList();
            Database.owner.ClearContractList();
            Database.owner.ClearRenterList();
            var list = new List<Employee>();
            list.AddRange(Database.drivers);
            list.AddRange(Database.assistants);
            Database.owner.AddRangeEmployee(list);
            Database.owner.AddRangeContract(Database.contracts);
            Database.owner.AddRangeRenter(Database.renter);

            Database.owner.CalculateMonthlyRevenue();
            label30.Text = Database.owner.MonthlyRevenue.ToString() + " VND";
            Database.owner.CalculateMonthlySalaryExpense();
            label31.Text = Database.owner.MonthlySalaryExpense.ToString() + " VND";

            label3.Text = "Total monthly salary expense is calculated up to date " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }
        private void ClickRentalPolicy(object sender, EventArgs e)
        {
            DisplayRentalPolicy displayRentalPolicy = new DisplayRentalPolicy(Database.cars);
            displayRentalPolicy.Show();
        }
        private void ClickSalaryPolicy(object sender, EventArgs e)
        {
            var list = new List<Employee>();
            list.AddRange(Database.drivers);
            list.AddRange(Database.assistants);
            DisplaySalaryPolicy displaySalaryPolicy = new DisplaySalaryPolicy(list);
            displaySalaryPolicy.Show();
        }
        private void ClickRenters(object sender, EventArgs e)
        {
            DisplayOwnerAllRenters displayOwnerAllRenters = new DisplayOwnerAllRenters();
            displayOwnerAllRenters.Show();
        }
        private void ClickContracts(object sender, EventArgs e)
        {
            DisplayOwnerAllContracts displayOwnerAllContracts = new DisplayOwnerAllContracts();
            displayOwnerAllContracts.Show();
        }
        private void ClickCars(object sender, EventArgs e)
        {
            DisplayOwnerAllCars displayOwnerAllCars = new DisplayOwnerAllCars();
            displayOwnerAllCars.Show();
        }
        private void ClickEmployees(object sender, EventArgs e)
        {
            DisplayOwnerAllEmployees displayOwnerAllEmployees = new DisplayOwnerAllEmployees();
            displayOwnerAllEmployees.Show();
        }
        private void ClickFeedbacks(object sender, EventArgs e)
        {
            DisplayOwnerAllFeedback displayOwnerAllFeedback = new DisplayOwnerAllFeedback();
            displayOwnerAllFeedback.Show();
        }
    }
}
