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
    public partial class DisplayRenter : Form
    {
        public DisplayRenter()
        {
            InitializeComponent();
        }
        private void ClickRegister(object sender, EventArgs e)
        {
            DisplayRenterRegister displayRenterRegister = new DisplayRenterRegister();
            displayRenterRegister.Show();
            this.Close();
        }
        private void ClickFindCar(object sender, EventArgs e)
        {
            DisplayRenterRentCar displayRenterFindCar = new DisplayRenterRentCar();
            displayRenterFindCar.Show();
            this.Close();
        }
        private void ClickContractHistory(object sender, EventArgs e)
        {
            DisplayRenterContractPayments displayRenterContractHistory = new DisplayRenterContractPayments();
            displayRenterContractHistory.Show();
            this.Close();
        }
        private void ClickRentalPolicy(object sender, EventArgs e)
        {
            DisplayRentalPolicy displayRenterRentalPolicy = new DisplayRentalPolicy(Database.cars);
            displayRenterRentalPolicy.Show();
            this.Close();
        }
        private void ClickFeedbackHistory(object sender, EventArgs e)
        {
            DisplayRenterFeedbackHistory displayRenterFeedbackHistory = new DisplayRenterFeedbackHistory();
            displayRenterFeedbackHistory.Show();
            this.Close();
        }
    }
}
