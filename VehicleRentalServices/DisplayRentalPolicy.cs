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
    public partial class DisplayRentalPolicy : Form
    {
        private List<Car> cars;
        public DisplayRentalPolicy(List<Car> cars)
        {
            this.cars = cars;

            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = this.cars;
            comboBox1.DisplayMember = "LicensePlates";
        }
        private void ClickPassenger(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.policyPassengerCar;
        }
        private void ClickTourist(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.policyTouristCarr;
        }
        private void ClickSelfDriving(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.policySelfDrivingCarr;
        }
        private void ClickTransit(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.policyTransitCar;
        }
        private void SelectedIndexChangedLabelCar(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Car car = (Car)comboBox1.SelectedItem;
                textBox1.Text = car.GetEVehicles.ToString();

                if (car.GetEVehicles == EVehicles.PassengerCar) ClickPassenger(sender, e);
                if (car.GetEVehicles == EVehicles.TouristCar) ClickTourist(sender, e);
                if (car.GetEVehicles == EVehicles.SelfDrivingCar) ClickSelfDriving(sender, e);
                if (car.GetEVehicles == EVehicles.TransitCar) ClickTransit(sender, e);
            }
        }
        private void ClickContextMSCar(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DisplayCarDetails displayCarDetails = new DisplayCarDetails((Car)comboBox1.SelectedItem);
                displayCarDetails.Show();
            }
        }
    }
}
