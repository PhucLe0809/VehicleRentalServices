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
    public partial class DisplayCarDetails : Form
    {
        private Car car;
        public DisplayCarDetails(Car car)
        {
            this.car = car;

            InitializeComponent();
        }
        private void LoadForm(object sender, EventArgs e)
        {
            label3.Text = "Update " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            label4.Text = Database.businessName + "'s Business";

            label30.Text = this.car.LicensePlates;
            label31.Text = this.car.BusinessCode;
            label32.Text = this.car.GetEVehicles.ToString();
            label33.Text = this.car.GetECarClassification.ToString();
            label34.Text = this.car.GetECarCompany.ToString();
            label35.Text = this.car.GetECarSeats.ToString();
            label36.Text = this.car.PurchaseDate.ToString("dd/MM/yyyy");
            label37.Text = this.car.KmTraveled.ToString() + " km";
            if (this.car.CarInsurance == true) label38.Text = "Yes"; else label38.Text = "No";
            label8.Text = this.car.CalculateAverageFeedbackRating().ToString("N2");

            foreach (var item in this.car.FeedbackHistory)
            {
                richTextBox1.Text = richTextBox1.Text + "   Feedback:" + item.Content + "\n";
            }

            int rate = Convert.ToInt32(Math.Round(this.car.CalculateAverageFeedbackRating()));
            if (rate >= 1) pictureBox1.Image = Properties.Resources.imageStarLight;
            if (rate >= 2) pictureBox2.Image = Properties.Resources.imageStarLight;
            if (rate >= 3) pictureBox3.Image = Properties.Resources.imageStarLight;
            if (rate >= 4) pictureBox4.Image = Properties.Resources.imageStarLight;
            if (rate >= 5) pictureBox5.Image = Properties.Resources.imageStarLight;
        }
    }
}
