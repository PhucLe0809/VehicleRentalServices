using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentalServices
{
    public partial class DisplayAdminCreateCar : Form
    {
        private bool havecarinsurance = false;
        public DisplayAdminCreateCar()
        {
            InitializeComponent();
            LoadForm();
            LoadChecklistCarAmenities();
        }

        #region LOAD
        private void LoadChecklistCarAmenities()
        {
            foreach (var enumValue in Enum.GetValues(typeof(ECarAmenities)))
            {
                checkedListBox1.Items.Add(enumValue);
            }
        }
        private void LoadForm()
        {
            havecarinsurance = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Refresh();
            comboBox2.Refresh();
            comboBox3.Refresh();
            comboBox4.Refresh();
            comboBox5.Refresh();
            comboBox6.Refresh();
            checkBox1.Refresh();
            checkedListBox1.Refresh();
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label6.Text = "";
            label14.Text = "";
            label16.Text = "";
            label19.Text = "";

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            checkBox1.Checked = false;
        }
        #endregion

        #region CHECK
        private bool CheckLabelCar(string input)
        {
            return !string.IsNullOrEmpty(input);
        }
        private bool CheckBusinessCode(string input)
        {
            return !string.IsNullOrEmpty(input);
        }
        private bool CheckVehicle()
        {
            if (comboBox1.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckCarCompany()
        {
            if (comboBox2.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckCarClassification()
        {
            if (comboBox3.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckPurchaseDate(DateTime input)
        {
            TimeSpan timeSpan = input.Date - DateTime.Now.Date;
            return timeSpan.Days >= 0;
        }
        private bool CheckKmTraveled(string input)
        {
            return !string.IsNullOrEmpty(input) && input.All(char.IsDigit) && input.Length < 10;
        }
        private bool CheckCarSeats()
        {
            if (comboBox6.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckCollateral()
        {
            if (comboBox4.Enabled == false) return true;
            if (comboBox4.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckCarLoad()
        {
            if (comboBox5.Enabled == false) return true;
            if (comboBox5.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckToRegister()
        {
            if (comboBox1.SelectedItem == null) return false;
            return CheckLabelCar(textBox1.Text) && CheckBusinessCode(textBox2.Text) && CheckVehicle() && CheckCarCompany()
                && CheckCarClassification() && CheckPurchaseDate(dateTimePicker2.Value) && CheckKmTraveled(textBox3.Text)
                && CheckCarSeats() && CheckCollateral() && CheckCarLoad();
        }
        #endregion

        #region CLICK
        private void ClickRegister(object sender, EventArgs e)
        {
            if (CheckToRegister())
            {
                label7.Text = "You have successfully created";
                notifyIcon1.ShowBalloonTip(2000, "Created successfully", "Welcome to VRS, let's start your first experiences", ToolTipIcon.None);

                Car car = new Car();
                EVehicles eVehicles = (EVehicles)comboBox1.SelectedItem;
                if (eVehicles == EVehicles.PassengerCar) car = CreatePassengerCar();
                if (eVehicles == EVehicles.TouristCar) car = CreateTouristCar();
                if (eVehicles == EVehicles.SelfDrivingCar) car = CreateSelfDrivingCar();
                if (eVehicles == EVehicles.TransitCar) car = CreateTransitCar();
                AddKilometersTraveled(ref car);
                AddAmenities(ref car);
                Database.cars.Add(car);

                ClickReset(sender, e);
            }
            else
            {
                MessageBox.Show("You have not entered enough information or the information is not available", "Warning",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                TextChangedLabelCar(sender, e);
                TextChangedBusinessCode(sender, e);
                ValueChangedPurchaseDate(sender, e);
                TextChangedKmTraveled(sender, e);
                SelectedValueChangedVehicle(sender, e);
                SelectedValueChangedCarCompany(sender, e);
                SelectedValueChangedCarClassification(sender, e);
            }
        }
        private void ClickReset(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion

        #region OTHERS
        private Car CreatePassengerCar()
        {
            PassengerCar passengerCar = new PassengerCar(textBox1.Text, textBox2.Text, (ECarCompany)comboBox2.SelectedItem, (ECarSeats)comboBox6.SelectedItem,
                (ECarClassification)comboBox3.SelectedItem, dateTimePicker2.Value, havecarinsurance);
            return passengerCar;
        }
        private Car CreateTouristCar()
        {
            TouristCar touristCar = new TouristCar(textBox1.Text, textBox2.Text, (ECarCompany)comboBox2.SelectedItem, (ECarSeats)comboBox6.SelectedItem,
                (ECarClassification)comboBox3.SelectedItem, dateTimePicker2.Value, havecarinsurance);
            return touristCar;
        }
        private Car CreateSelfDrivingCar()
        {
            SelfDrivingCar selfDrivingCar = new SelfDrivingCar(textBox1.Text, textBox2.Text, (ECarCompany)comboBox2.SelectedItem, (ECarSeats)comboBox6.SelectedItem,
                (ECarClassification)comboBox3.SelectedItem, dateTimePicker2.Value, havecarinsurance, (ECollateral)comboBox4.SelectedItem);
            return selfDrivingCar;
        }
        private Car CreateTransitCar()
        {
            TransitCar transitCar = new TransitCar(textBox1.Text, textBox2.Text, (ECarCompany)comboBox2.SelectedItem, (ECarSeats)comboBox6.SelectedItem,
                (ECarClassification)comboBox3.SelectedItem, dateTimePicker2.Value, havecarinsurance, (ECarLoad)comboBox5.SelectedItem);
            return transitCar;
        }
        private void AddKilometersTraveled(ref Car car)
        {
            car.AddKilometersTraveled(Convert.ToDouble(textBox3.Text));
        }
        private void AddAmenities(ref Car car)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    car.AddCarAmenities((ECarAmenities)checkedListBox1.CheckedItems[i]);
                }
            }
        }
        #endregion

        //
        // LABEL CAR
        //
        private void TextChangedLabelCar(object sender, EventArgs e)
        {
            string input = Convert.ToString(textBox1.Text);
            if (!CheckLabelCar(input))
            {
                label10.ForeColor = Color.LightCoral;
                label10.Text = "Enter your label car";
            }
            else
            {
                label10.Text = "";
            }
        }
        private void MouseClickLabelCar(object sender, MouseEventArgs e)
        {
            TextChangedLabelCar(sender, e);
        }
        //
        // BUSINESS CODE
        //
        private void TextChangedBusinessCode(object sender, EventArgs e)
        {
            string input = Convert.ToString(textBox2.Text);
            if (!CheckBusinessCode(input))
            {
                label11.ForeColor = Color.LightCoral;
                label11.Text = "Enter your business code";
            }
            else
            {
                label11.Text = "";
            }
        }
        private void MouseClickBusinessCode(object sender, MouseEventArgs e)
        {
            TextChangedBusinessCode(sender, e);
        }
        //
        // PYRCHASE DATE
        //
        private void ValueChangedPurchaseDate(object sender, EventArgs e)
        {
            if (!CheckPurchaseDate(dateTimePicker2.Value))
            {
                label16.ForeColor = Color.LightCoral;
                label16.Text = "Purchase date not available";
            }
            else
            {
                label16.Text = "";
            }
        }
        private void MouseClickPurchaseDate(object sender, MouseEventArgs e)
        {
            ValueChangedPurchaseDate(sender, e);
        }
        //
        // KM TRAVELED
        //
        private void TextChangedKmTraveled(object sender, EventArgs e)
        {
            string input = Convert.ToString(textBox3.Text);
            if (!CheckKmTraveled(input))
            {
                label19.ForeColor = Color.LightCoral;
                label19.Text = "Number not available";
            }
            else
            {
                label19.Text = "";
            }
        }
        private void MouseClickKmTraveled(object sender, MouseEventArgs e)
        {
            TextChangedKmTraveled(sender, e);
        }
        //
        // VEHICLE
        //
        private void SelectedValueChangedVehicle(object sender, EventArgs e)
        {
            if (!CheckVehicle())
            {
                label12.ForeColor = Color.LightCoral;
                label12.Text = "Choose your vehicle";
                return;
            }
            label12.Text = "";
            if (CheckVehicle())
            {
                comboBox3.DataSource = null;
                comboBox4.DataSource = null;
                comboBox5.DataSource = null;
                comboBox6.DataSource = null;

                label12.Text = "";
                EVehicles eVehicles = (EVehicles)comboBox1.SelectedItem;
                List<ECarClassification> list = new List<ECarClassification>();
                List<ECarSeats> seats = new List<ECarSeats>();
                List<ECollateral> collaterals = new List<ECollateral>();
                List<ECarLoad> loads = new List<ECarLoad>();
                if (eVehicles == EVehicles.PassengerCar)
                {
                    list.AddRange(new List<ECarClassification> { ECarClassification.CarSeats, ECarClassification.SleeperCar, ECarClassification.Limousine });
                    seats.AddRange(new List<ECarSeats> { ECarSeats.S29seats, ECarSeats.S36seats, ECarSeats.S45seats });
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                }
                if (eVehicles == EVehicles.TouristCar)
                {
                    list.AddRange(new List<ECarClassification> { ECarClassification.CarSeats });
                    seats.AddRange(new List<ECarSeats> { ECarSeats.S4seats, ECarSeats.S7seats, ECarSeats.S16seats });
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                }
                if (eVehicles == EVehicles.SelfDrivingCar)
                {
                    list.AddRange(new List<ECarClassification> { ECarClassification.CarSeats });
                    seats.AddRange(new List<ECarSeats> { ECarSeats.S4seats, ECarSeats.S7seats, ECarSeats.S16seats, ECarSeats.S24seats });
                    collaterals.AddRange(new List<ECollateral> { ECollateral.Movables, ECollateral.RealEstate, ECollateral.CurrentSalary, ECollateral.FutureAssets, ECollateral.Share, ECollateral.Bonds });
                    comboBox4.Enabled = true;
                    comboBox5.Enabled = false;
                }
                if (eVehicles == EVehicles.TransitCar)
                {
                    list.AddRange(new List<ECarClassification> { ECarClassification.RegularCar, ECarClassification.FreezingCar });
                    seats.AddRange(new List<ECarSeats> { ECarSeats.S2seats });
                    loads.AddRange(new List<ECarLoad> { ECarLoad.W1dot25ton, ECarLoad.W1dot50ton, ECarLoad.W1dot90ton, ECarLoad.W2dot50ton, ECarLoad.W3dot50ton, ECarLoad.W5dot00ton, ECarLoad.W8dot00ton, ECarLoad.W10dot00ton });
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = true;
                }
                comboBox3.DataSource = list;
                comboBox3.DisplayMember = "Name";

                comboBox4.DataSource = collaterals;
                comboBox4.DisplayMember = "Name";

                comboBox5.DataSource = loads;
                comboBox5.DisplayMember = "Name";

                comboBox6.DataSource = seats;
                comboBox6.DisplayMember = "Name";
            }
            else
            {
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
            }
        }
        private void MouseClickVehicle(object sender, MouseEventArgs e)
        {
            if (!CheckVehicle())
            {
                label12.ForeColor = Color.LightCoral;
                label12.Text = "Choose your vehicle";
            }
            else
            {
                SelectedValueChangedVehicle(sender, e);
            }
        }
        //
        // CAR COMPANY
        //
        private void SelectedValueChangedCarCompany(object sender, EventArgs e)
        {
            if (!CheckCarCompany())
            {
                label6.ForeColor = Color.LightCoral;
                label6.Text = "Choose your car company";
            }
            else
            {
                label6.Text = "";
            }
        }
        private void MouseClickCarCompany(object sender, MouseEventArgs e)
        {
            SelectedValueChangedCarCompany(sender, e);
        }
        //
        // CLASSIFICATION
        //
        private void SelectedValueChangedCarClassification(object sender, EventArgs e)
        {
            if (!CheckCarClassification())
            {
                label14.ForeColor = Color.LightCoral;
                label14.Text = "Choose your car classification";
            }
            else
            {
                label14.Text = "";
            }
        }
        private void MouseClickCarClassification(object sender, MouseEventArgs e)
        {
            SelectedValueChangedCarClassification(sender, e);
        }
        //
        // HAS INSURANCE
        //
        private void ClickCheckBoxInsurance(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            havecarinsurance = checkBox.Checked;
        }
    }
}
