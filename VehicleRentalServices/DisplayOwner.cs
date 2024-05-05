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
    public partial class DisplayOwner : Form
    {
        public DisplayOwner()
        {
            InitializeComponent();
        }
        private void ClickRegister(object sender, EventArgs e)
        {
            DisplayOwnerRegister displayOwnerRegister = new DisplayOwnerRegister();
            displayOwnerRegister.Show();
            this.Close();
        }
        private void ClickBusinessInfo(object sender, EventArgs e)
        {
            DisplayBusinessInfo displayBusinessInfo = new DisplayBusinessInfo();
            displayBusinessInfo.Show();
            this.Close();
        }
        private void ClickFeedbackHistory(object sender, EventArgs e)
        {
            DisplayOwnerFeedbackHistory displayOwnerFeedbackHistory = new DisplayOwnerFeedbackHistory();
            displayOwnerFeedbackHistory.Show();
            this.Close();
        }
    }
}
