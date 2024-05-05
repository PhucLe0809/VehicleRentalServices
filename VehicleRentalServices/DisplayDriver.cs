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
    public partial class DisplayDriver : Form
    {
        public DisplayDriver()
        {
            InitializeComponent();
        }
        private void ClickRegister(object sender, EventArgs e)
        {
            DisplayDriverRegister displayDriverRegister = new DisplayDriverRegister();
            displayDriverRegister.Show();
            this.Close();
        }
        private void ClickContractHistory(object sender, EventArgs e)
        {
            DisplayDriverContractHistory displayDriverContractHistory = new DisplayDriverContractHistory();
            displayDriverContractHistory.Show();
            this.Close();
        }
        private void ClickFeedbackHistory(object sender, EventArgs e)
        {
            DisplayDriverFeedbackHistory displayDriverFeedbackHistory = new DisplayDriverFeedbackHistory();
            displayDriverFeedbackHistory.Show();
            this.Close();
        }
        private void ClickSalary(object sender, EventArgs e)
        {
            DisplayDriverSalary displayDriverSalary = new DisplayDriverSalary();
            displayDriverSalary.Show();
            this.Close();
        }
    }
}
