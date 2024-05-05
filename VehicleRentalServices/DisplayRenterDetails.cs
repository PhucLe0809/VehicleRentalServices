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
    public partial class DisplayRenterDetails : Form
    {
        private Renter renter;
        public DisplayRenterDetails(Renter renter)
        {
            this.renter = renter;

            InitializeComponent();
        }
        private void LoadForm(object sender, EventArgs e)
        {
            label3.Text = "Update " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            label4.Text = Database.businessName + "'s Business";

            label30.Text = this.renter.FullName;
            label31.Text = this.renter.ID;
            label32.Text = this.renter.PhoneNumber;
            label33.Text = this.renter.DateOfBirth.ToString("dd/MM/yyyy");
            label34.Text = this.renter.JointDate.ToString("dd/MM/yyyy");
            label35.Text = this.renter.ContractHistory.Count.ToString() + "contracts";
            label36.Text = this.renter.TotalContractValue.ToString() + " VND";

            foreach (var item in this.renter.FeedbackHistory)
            {
                richTextBox1.Text = richTextBox1.Text + "   Feedback:" + item.Content + "\n";
            }

            double perDiscount = Contract.GetRankCustomer(this.renter);
            label8.Text = (perDiscount * 100).ToString("N2") + "%";

            int numberContract = this.renter.ContractHistory.Count;
            if (numberContract >= 0 && numberContract <= 3)
            {
                pictureBox1.Image = Properties.Resources.imageMember;
                label7.ForeColor = Color.Gray;
                label8.ForeColor = Color.Gray;
                label7.Text = "Member";
            }
            if (numberContract >= 4 && numberContract <= 7)
            {
                pictureBox1.Image = Properties.Resources.imageSilver;
                label7.ForeColor = Color.Gray;
                label8.ForeColor = Color.Gray;
                label7.Text = "Silver";
            }
            if (numberContract >= 7 && numberContract <= 10)
            {
                pictureBox1.Image = Properties.Resources.imageGold;
                label7.ForeColor = Color.Gold;
                label8.ForeColor = Color.Gray;
                label7.Text = "Gold";
            }
            if (numberContract > 10)
            {
                pictureBox1.Image = Properties.Resources.imagePlatinumm;
                label7.ForeColor = Color.LightCoral;
                label8.ForeColor = Color.Gray;
                label7.Text = "Platinum";
            }
        }
    }
}
