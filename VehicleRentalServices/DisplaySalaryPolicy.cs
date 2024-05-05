using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VehicleRentalServices
{
    public partial class DisplaySalaryPolicy : Form
    {
        private List<Employee> employees;
        public DisplaySalaryPolicy(List<Employee> employees)
        {
            this.employees = employees;

            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = this.employees;
            comboBox1.DisplayMember = "FullName";
        }
        private void ClickDriver(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.imageSalaryDriver;
        }
        private void ClickAssistant(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.imageSalaryAssistant;
        }
        private void SelectedIndexChangedLabelCar(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Employee employee = (Employee)comboBox1.SelectedItem;

                if (employee is Driver)
                {
                    ClickDriver(sender, e);
                    textBox1.Text = "Driver";
                }
                if (employee is Assistant)
                {
                    ClickAssistant(sender, e);
                    textBox1.Text = "Assistant";
                }
            }
        }
        private void ClickContextMS(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Employee employee = (Employee)comboBox1.SelectedItem;
                if (employee is Driver)
                {
                    DisplayDriverDetails displayDriverDetails = new DisplayDriverDetails(employee);
                    displayDriverDetails.Show();
                }
                else
                {
                    DisplayAssistantDetails displayAssistantDetails = new DisplayAssistantDetails(employee);
                    displayAssistantDetails.Show();
                }
            }
        }
    }
}
