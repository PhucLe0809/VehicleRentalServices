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
    public partial class DisplayAssistantSalary : Form
    {
        public DisplayAssistantSalary()
        {
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = Database.assistants;
            comboBox1.DisplayMember = "FullName";
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Assistant assistant = (Assistant)comboBox1.SelectedItem;
                assistant.CalculateSalary();
                label30.Text = assistant.FullName;
                label31.Text = assistant.JointDate.ToString("dd/MM/yyyy");
                label32.Text = (assistant.CalculatePercentageOnContract() * 100).ToString() + "%";
                label33.ForeColor = Color.Black;
                label33.Text = assistant.CalculateTotalContractValue().ToString() + "VND";
                label34.Text = (assistant.CalculatePercentageFeedbackBonus() * 100).ToString() + "%";
                label35.Text = assistant.AverageRating.ToString("N2");
                label36.ForeColor = Color.Black;
                label36.Text = assistant.CalculateBaseSalary().ToString() + "VND";
                label37.Text = assistant.CalculateYearsInBusiness().ToString() + "years";
                label38.ForeColor = Color.Black;
                label38.Text = assistant.MonthlySalary.ToString() + "VND";
            }
        }
        private void ClickSalaryPolicy(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DisplaySalaryPolicy displaySalaryPolicy = new DisplaySalaryPolicy(new List<Employee> { (Assistant)comboBox1.SelectedItem });
                displaySalaryPolicy.Show();
            }
        }
        private void CMSDetailsClick(object sender, EventArgs e)
        {
            DisplayAssistantDetails displayAssistantDetails = new DisplayAssistantDetails((Assistant)comboBox1.SelectedItem);
            displayAssistantDetails.Show();
        }
    }
}
