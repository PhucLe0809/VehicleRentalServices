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
    public partial class DisplayDriverSalary : Form
    {
        public DisplayDriverSalary()
        {
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = Database.drivers;
            comboBox1.DisplayMember = "FullName";
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Driver driver = (Driver)comboBox1.SelectedItem;
                driver.CalculateSalary();
                label30.Text = driver.FullName;
                label31.Text = driver.JointDate.ToString("dd/MM/yyyy");
                label32.Text = (driver.CalculatePercentageOnContract() * 100).ToString() + "%";
                label33.Text = driver.CalculateTotalContractValue().ToString() + "VND";
                label34.Text = (driver.CalculatePercentageFeedbackBonus() * 100).ToString() + "%";
                label35.Text = driver.AverageRating.ToString("N2");
                label36.Text = driver.CalculateBaseSalary().ToString() + "VND";
                label37.Text = driver.CalculateYearsInBusiness().ToString() + "years";
                label38.Text = driver.MonthlySalary.ToString() + "VND";
            }
        }
        private void ClickSalaryPolicy(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DisplaySalaryPolicy displaySalaryPolicy = new DisplaySalaryPolicy(new List<Employee> { (Driver)comboBox1.SelectedItem });
                displaySalaryPolicy.Show();
            }
        }
        private void CMSDetailsClick(object sender, EventArgs e)
        {
            DisplayDriverDetails displayDriverDetails = new DisplayDriverDetails((Driver)comboBox1.SelectedItem);
            displayDriverDetails.Show();
        }
    }
}
