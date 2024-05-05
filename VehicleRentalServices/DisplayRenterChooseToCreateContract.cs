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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VehicleRentalServices
{
    public partial class DisplayRenterChooseToCreateContract : Form
    {
        private Contract contract = new Contract();
        private Renter renter;
        private DateTime startDate;
        private DateTime endDate;
        private Car car;
        public DisplayRenterChooseToCreateContract(Renter renter, DateTime startDate, DateTime endDate, Car car)
        {
            this.renter = renter;
            this.startDate = startDate;
            this.endDate = endDate;
            this.car = car;

            InitializeComponent();
            LoadForm();
        }

        #region LOAD
        private void LoadForm()
        {
            if (Database.businessName == "") label14.Text = "Business";
            else label14.Text = Database.businessName + "'s Business";

            dateTimePicker1.Value = this.startDate;
            dateTimePicker2.Value = this.endDate;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

            comboBox1.DataSource = null;
            comboBox1.DataSource = new List<Renter> { this.renter };
            comboBox1.DisplayMember = "FullName";

            comboBox2.DataSource = null;
            comboBox2.DataSource = GetListDriver();
            comboBox2.DisplayMember = "FullName";

            comboBox3.DataSource = null;
            comboBox3.DataSource = GetListCar();
            comboBox3.DisplayMember = "LicensePlates";

            comboBox4.DataSource = null;
            comboBox4.DataSource = GetListAssistant();
            comboBox4.DisplayMember = "FullName";
        }
        #endregion

        #region CHECK
        private bool CheckToRegister()
        {
            return (CheckDriver() || CheckAssistant())
                && CheckRenter() && CheckLabelCar() && CheckStartDate() && CheckEndDate() && CheckKilometers() && CheckPrepayment();
        }
        private bool CheckToUpdateContract()
        {
            return (CheckDriver() || CheckAssistant())
                && CheckRenter() && CheckLabelCar() && CheckStartDate() && CheckEndDate() && CheckKilometers();
        }
        private bool CheckRenter()
        {
            if (comboBox1.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckDriver()
        {
            if (comboBox2.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckLabelCar()
        {
            if (comboBox3.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckStartDate()
        {
            TimeSpan timeSpan = dateTimePicker1.Value.Date - DateTime.Now.Date;
            return timeSpan.Days >= 0;
        }
        private bool CheckEndDate()
        {
            TimeSpan timeSpan = dateTimePicker2.Value.Date - dateTimePicker1.Value.Date;
            return timeSpan.Days >= 0 && timeSpan.Days < 3;
        }
        private bool CheckKilometers()
        {
            return !string.IsNullOrEmpty(textBox1.Text) && textBox1.Text.All(char.IsDigit) && textBox1.Text.Length < 5;
        }
        private bool CheckAssistant()
        {
            if (comboBox4.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckPrepayment()
        {
            return !string.IsNullOrEmpty(textBox2.Text) && textBox2.Text.All(char.IsDigit)
                && Convert.ToDouble(textBox2.Text) >= contract.PercentagePrepayment * contract.PreSettlementValue
                && Convert.ToDouble(textBox2.Text) <= contract.PreSettlementValue;
        }
        #endregion

        #region CLICK
        private void ClickRegister(object sender, EventArgs e)
        {
            if (CheckToRegister())
            {
                contract.AddPrepayment(Convert.ToDouble(textBox2.Text));
                Database.contracts.Add(contract);

                label7.Text = "You have successfully created";
                notifyIcon1.ShowBalloonTip(2000, "Created " + contract.ID + " successfully", "Welcome to VRS, let's start your first experiences", ToolTipIcon.None);

                ClickReset(sender, e);

                label8.ForeColor = Color.IndianRed;
                label8.Text = contract.ID;
            }
            else
            {
                MessageBox.Show("You have not entered enough information or the information is not available", "Warning",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                SelectedValueChangedRenter(sender, e);
                SelectedValueChangedDriver(sender, e);
                SelectedValueChangedAssistant(sender, e);
                SelectedValueChangedLabelCar(sender, e);
                TextChangedKilometers(sender, e);
                TextChangedPrepayments(sender, e);
            }
        }
        private void ClickReset(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Refresh();
            comboBox2.Refresh();
            comboBox3.Refresh();
            dateTimePicker1.Refresh();
            dateTimePicker2.Refresh();
            label8.Text = "IDContract";
            label8.ForeColor = SystemColors.ButtonShadow;
            label10.Text = "";
            label17.Text = "";
            label30.Text = "";
            label3.Text = "";
            label12.Text = "";
            label18.Text = "";
            label11.Text = "";
            label25.Text = "";

            LoadForm();
            UpdateContract();
        }
        #endregion

        #region OTHERS
        private void UpdateContract()
        {
            if (CheckToUpdateContract())
            {
                if (CheckDriver() && CheckAssistant())
                {
                    contract = new Contract(Database.owner, (Renter)comboBox1.SelectedItem, (Driver)comboBox2.SelectedItem,
                        (Assistant)comboBox4.SelectedItem, (Car)comboBox3.SelectedItem, dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(textBox1.Text));
                }
                if (!CheckDriver() && CheckAssistant())
                {
                    contract = new Contract(Database.owner, (Renter)comboBox1.SelectedItem, new Driver(),
                        (Assistant)comboBox4.SelectedItem, (Car)comboBox3.SelectedItem, dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(textBox1.Text));
                }
                if (CheckDriver() && !CheckAssistant())
                {
                    contract = new Contract(Database.owner, (Renter)comboBox1.SelectedItem, (Driver)comboBox2.SelectedItem,
                        new Assistant(), (Car)comboBox3.SelectedItem, dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(textBox1.Text));
                }

                label23.Text = (contract.PercentagePrepayment * 100).ToString() + "%";
                label28.Text = (contract.PercentageDiscounted * 100).ToString() + "%";
                label21.Text = contract.PreSettlementValue.ToString();
            }
            else
            {
                label23.Text = "";
                label28.Text = "";
                label21.Text = "$$$";
            }
        }
        private List<Car> GetListCar()
        {
            if (CheckRenter() && CheckStartDate() && CheckEndDate())
            {
                var resultCars = new List<Car>();
                foreach (var car in Database.cars)
                {
                    bool check = true;
                    foreach (var contract in Database.contracts)
                    {
                        TimeSpan timeSpan1 = contract.StartDate.Date - dateTimePicker2.Value.Date;
                        TimeSpan timeSpan2 = dateTimePicker1.Value.Date - contract.EndDate.Date;
                        bool option1 = contract.GetCar != car;
                        bool option2 = contract.GetCar == car && contract.Paid == true;
                        bool option3 = contract.GetCar == car && contract.Paid == false && (timeSpan1.Days > 0 || timeSpan2.Days > 0);
                        check = check && (option1 || option2 || option3);
                    }
                    if (check)
                    {
                        resultCars.Add(car);
                    }
                }
                return resultCars;
            }
            return new List<Car>();
        }
        private List<Driver> GetListDriver()
        {
            if (CheckStartDate() && CheckEndDate())
            {
                var resultDrivers = new List<Driver>();
                foreach (var driver in Database.drivers)
                {
                    bool check = true;
                    foreach (var contract in Database.contracts)
                    {
                        TimeSpan timeSpan1 = contract.StartDate.Date - dateTimePicker2.Value.Date;
                        TimeSpan timeSpan2 = dateTimePicker1.Value.Date - contract.EndDate.Date;
                        bool option1 = contract.GetDriver != driver;
                        bool option2 = contract.GetDriver == driver && contract.Paid == true;
                        bool option3 = contract.GetDriver == driver && contract.Paid == false && (timeSpan1.Days > 0 || timeSpan2.Days > 0);
                        check = check && (option1 || option2 || option3);
                    }
                    if (check)
                    {
                        resultDrivers.Add(driver);
                    }
                }
                return resultDrivers;
            }
            return new List<Driver>();
        }
        private List<Assistant> GetListAssistant()
        {
            if (CheckStartDate() && CheckEndDate())
            {
                var resultAssistants = new List<Assistant>();
                foreach (var assistant in Database.assistants)
                {
                    bool check = true;
                    foreach (var contract in Database.contracts)
                    {
                        TimeSpan timeSpan1 = contract.StartDate.Date - dateTimePicker2.Value.Date;
                        TimeSpan timeSpan2 = dateTimePicker1.Value.Date - contract.EndDate.Date;
                        bool option1 = contract.GetAssistant != assistant;
                        bool option2 = contract.GetAssistant == assistant && contract.Paid == true;
                        bool option3 = contract.GetAssistant == assistant && contract.Paid == false && (timeSpan1.Days > 0 || timeSpan2.Days > 0);
                        check = check && (option1 || option2 || option3);
                    }
                    if (check)
                    {
                        resultAssistants.Add(assistant);
                    }
                }
                return resultAssistants;
            }
            return new List<Assistant>();
        }
        private void CMSDriverClick(object sender, EventArgs e)
        {
            if (CheckDriver())
            {
                DisplayDriverDetails displayDriverDetails = new DisplayDriverDetails((Driver)comboBox2.SelectedItem);
                displayDriverDetails.Show();
            }
        }
        private void CMSAssistantClick(object sender, EventArgs e)
        {
            if (CheckAssistant())
            {
                DisplayAssistantDetails displayAssistantDetails = new DisplayAssistantDetails((Assistant)comboBox4.SelectedItem);
                displayAssistantDetails.Show();
            }
        }
        private void CMSRenterClick(object sender, EventArgs e)
        {
            if (CheckRenter())
            {
                DisplayRenterDetails displayRenterDetails = new DisplayRenterDetails((Renter)comboBox1.SelectedItem);
                displayRenterDetails.Show();
            }
        }
        private void CMSCarClick(object sender, EventArgs e)
        {
            if (CheckLabelCar())
            {
                DisplayCarDetails displayCarDetails = new DisplayCarDetails((Car)comboBox3.SelectedItem);
                displayCarDetails.Show();
            }
        }
        #endregion

        //
        // RENTER
        //
        private void SelectedValueChangedRenter(object sender, EventArgs e)
        {
            if (!CheckRenter())
            {
                label10.ForeColor = Color.LightCoral;
                label10.Text = "Please select renter";
            }
            else
            {
                label10.Text = "";
            }
            UpdateContract();
        }
        private void MouseClickRenter(object sender, MouseEventArgs e)
        {
            SelectedValueChangedRenter(sender, e);
        }
        //
        // DRIVER
        //
        private void SelectedValueChangedDriver(object sender, EventArgs e)
        {
            if (!CheckDriver())
            {
                label17.ForeColor = Color.LightCoral;
                label17.Text = "Please select driver";
            }
            else
            {
                label17.Text = "";
            }
            UpdateContract();
        }
        private void MouseClickDriver(object sender, MouseEventArgs e)
        {
            SelectedValueChangedDriver(sender, e);
        }
        //
        // ASSISTANT
        //
        private void SelectedValueChangedAssistant(object sender, EventArgs e)
        {
            if (!CheckAssistant())
            {
                label30.ForeColor = Color.LightCoral;
                label30.Text = "Please select assistant";
            }
            else
            {
                label30.Text = "";
            }
            UpdateContract();
        }
        private void MouseClickAssistant(object sender, MouseEventArgs e)
        {
            SelectedValueChangedAssistant(sender, e);
        }
        //
        // LABEL CAR
        //
        private void SelectedValueChangedLabelCar(object sender, EventArgs e)
        {
            if (!CheckLabelCar())
            {
                label3.ForeColor = Color.LightCoral;
                label3.Text = "Please select label car";
            }
            else
            {
                label3.Text = "";
            }
            UpdateContract();
        }
        private void MouseClickLabelCar(object sender, MouseEventArgs e)
        {
            SelectedValueChangedLabelCar(sender, e);
        }
        //
        // START DATE
        //
        private void ValueChangedStartDate(object sender, EventArgs e)
        {
            if (!CheckStartDate())
            {
                label12.ForeColor = Color.LightCoral;
                label12.Text = "Start date not available";
            }
            else
            {
                label12.Text = "";
                LoadForm();
            }
            UpdateContract();
        }
        private void MouseClickStartDate(object sender, MouseEventArgs e)
        {
            ValueChangedStartDate(sender, e);
        }
        // 
        // END DATE
        //
        private void ValueChangedEndDate(object sender, EventArgs e)
        {
            if (!CheckEndDate())
            {
                label18.ForeColor = Color.LightCoral;
                label18.Text = "No more than 3 days from the start date";
            }
            else
            {
                label18.Text = "";
                LoadForm();
            }
            UpdateContract();
        }
        private void MouseClickEndDate(object sender, MouseEventArgs e)
        {
            ValueChangedEndDate(sender, e);
        }
        //
        // KILOMETERS
        //
        private void TextChangedKilometers(object sender, EventArgs e)
        {
            if (!CheckKilometers())
            {
                label11.ForeColor = Color.LightCoral;
                label11.Text = "Kilometers not available";
            }
            else
            {
                label11.Text = "";
            }
            UpdateContract();
        }
        private void MouseClickKilometers(object sender, MouseEventArgs e)
        {
            TextChangedKilometers(sender, e);
        }
        //
        // PREPAYMENTS
        //
        private void TextChangedPrepayments(object sender, EventArgs e)
        {
            if (!CheckPrepayment())
            {
                label25.ForeColor = Color.LightCoral;
                label25.Text = "Prepaid amount not available";
            }
            else
            {
                label25.Text = "";
            }
            UpdateContract();
        }
        private void MouseClickPrepayments(object sender, MouseEventArgs e)
        {
            TextChangedPrepayments(sender, e);
        }
        //
        // THIS FORM
        //
        private void ClickRentalPolicy(object sender, EventArgs e)
        {
            var list = new List<Car>();
            if (CheckLabelCar()) list.Add((Car)comboBox3.SelectedItem);
            else list.AddRange(Database.cars);
            DisplayRentalPolicy displayRenterRentalPolicy = new DisplayRentalPolicy(list);
            displayRenterRentalPolicy.Show();
        }
    }
}
