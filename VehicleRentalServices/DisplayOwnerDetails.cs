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
    public partial class DisplayOwnerDetails : Form
    {
        private Person person;
        public DisplayOwnerDetails(Person person)
        {
            this.person = person;

            InitializeComponent();
        }
        private void LoadForm(object sender, EventArgs e)
        {
            label3.Text = "Update " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            label4.Text = Database.businessName + "'s Business";

            label30.Text = this.person.FullName;
            label31.Text = this.person.ID;
            label32.Text = this.person.PhoneNumber;
            label33.Text = this.person.DateOfBirth.ToString("dd/MM/yyyy");
            label34.Text = this.person.JointDate.ToString("dd/MM/yyyy");
            label35.Text = this.person.CalculateAverageFeedbackRating().ToString("N2");
            label36.Text = "Owner";
            label6.Text = (Database.drivers.Count + Database.assistants.Count).ToString() + " staffs";

            foreach (var item in this.person.FeedbackHistory)
            {
                richTextBox1.Text = richTextBox1.Text + "   Feedback:" + item.Content + "\n";
            }

            int rate = Convert.ToInt32(Math.Round(this.person.CalculateAverageFeedbackRating()));
            if (rate >= 1) pictureBox1.Image = Properties.Resources.imageStarLight;
            if (rate >= 2) pictureBox2.Image = Properties.Resources.imageStarLight;
            if (rate >= 3) pictureBox3.Image = Properties.Resources.imageStarLight;
            if (rate >= 4) pictureBox4.Image = Properties.Resources.imageStarLight;
            if (rate >= 5) pictureBox5.Image = Properties.Resources.imageStarLight;
        }
    }
}
