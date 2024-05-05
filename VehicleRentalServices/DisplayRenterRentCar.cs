using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VehicleRentalServices
{
    public partial class DisplayRenterRentCar : Form
    {
        public DisplayRenterRentCar()
        {
            InitializeComponent();
            LoadRenter();
            LoadListView(Database.cars);
        }
        private void LoadForm(object sender, EventArgs e)
        {
            SelectedValueChangedVehicle(sender, e);
            SelectedValueChangedClassification(sender, e);
            LoadListView(GetListCar());
        }
        private void LoadRenter()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = Database.renter;
            comboBox1.DisplayMember = "FullName";
        }
        private void LoadCarClassification()
        {
            if (CheckVehicle())
            {
                EVehicles eVehicles = (EVehicles)comboBox2.SelectedItem;
                List<ECarClassification> list = new List<ECarClassification>();
                if (eVehicles == EVehicles.PassengerCar)
                {
                    list.AddRange(new List<ECarClassification> { ECarClassification.CarSeats, ECarClassification.SleeperCar, ECarClassification.Limousine });
                }
                if (eVehicles == EVehicles.TouristCar)
                {
                    list.AddRange(new List<ECarClassification> { ECarClassification.CarSeats });
                }
                if (eVehicles == EVehicles.SelfDrivingCar)
                {
                    list.AddRange(new List<ECarClassification> { ECarClassification.CarSeats });
                }
                if (eVehicles == EVehicles.TransitCar)
                {
                    list.AddRange(new List<ECarClassification> { ECarClassification.RegularCar, ECarClassification.FreezingCar });
                }

                comboBox3.DataSource = null;
                comboBox3.DataSource = list;
                comboBox3.DisplayMember = "Name";
            }
            else
            {
                comboBox3.DataSource = null;
            }
        }
        private void LoadListView(List<Car> input)
        {
            listView1.Items.Clear();
            foreach (var car in input)
            {
                ListViewItem item = new ListViewItem();
                item.Text = car.LicensePlates;
                item.ImageIndex = 0;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = car.BusinessCode });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = car.GetECarCompany.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = car.GetECarSeats.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = car.GetECarClassification.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = car.PurchaseDate.ToString("dd/MM/yyyy") });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = car.KmTraveled.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (car.CarInsurance) ? "Yes" : "No" });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = car.GetEVehicles.ToString() });

                listView1.Items.Add(item);
            }
        }
        private List<Car> GetListCar()
        {
            var list = new List<Car>();
            if (CheckRenter() && CheckVehicle() && CheckCarClassification() && CheckStartDate() && CheckEndDate())
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
                list = resultCars.Where(car => car.GetEVehicles == (EVehicles)comboBox2.SelectedItem && car.GetECarClassification == (ECarClassification)comboBox3.SelectedItem).ToList();
            }
            return list;
        }
        private bool CheckRenter()
        {
            if (comboBox1.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckVehicle()
        {
            if (comboBox2.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckCarClassification()
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
        private bool CheckListCar()
        {
            return listView1.SelectedItems.Count > 0;
        }
        private bool CheckToChoose()
        {
            return CheckRenter() && CheckVehicle() && CheckCarClassification() && CheckStartDate() && CheckEndDate() && CheckListCar();
        }
        private void ClickForm(object sender, EventArgs e)
        {
            ValueChangedEndDate(sender, e);
            LoadListView(GetListCar());
        }
        private void ClickChooseToCreateContract(object sender, EventArgs e)
        {
            if (CheckToChoose())
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                var result = Database.cars.Where(car => car.LicensePlates == selectedItem.Text).ToList();
                Car car = result[0];
                if (car != null)
                {
                    DisplayRenterChooseToCreateContract diplay = new DisplayRenterChooseToCreateContract((Renter)comboBox1.SelectedItem,
                        dateTimePicker1.Value, dateTimePicker2.Value, car);
                    diplay.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You have not entered enough information or the information is not available", "Warning",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("You have not entered enough information or the information is not available", "Warning",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
        private void SelectedValueChangedVehicle(object sender, EventArgs e)
        {
            if (!CheckVehicle())
            {
                comboBox2.Focus();
                errorProviderVehicles.SetError(comboBox2, "Choose your vehicle");
            }
            else
            {
                label7.Text = "";
                errorProviderVehicles.SetError(comboBox2, null);
                LoadCarClassification();
                LoadListView(GetListCar());
            }
        }
        private void SelectedValueChangedClassification(object sender, EventArgs e)
        {
            if (!CheckCarClassification())
            {
                comboBox3.Focus();
                errorProviderClassification.SetError(comboBox3, "Choose your car classification");
            }
            else
            {
                label7.Text = "";
                errorProviderClassification.SetError(comboBox3, null);
                LoadListView(GetListCar());
            }
        }
        private void ValueChangedStartDate(object sender, EventArgs e)
        {
            if (!CheckStartDate())
            {
                dateTimePicker1.Focus();
                errorProviderStartDate.SetError(dateTimePicker1, "Start date not available");
            }
            else
            {
                label7.Text = "";
                errorProviderStartDate.SetError(dateTimePicker1, null);
                LoadListView(GetListCar());
            }
        }
        private void ValueChangedEndDate(object sender, EventArgs e)
        {
            if (!CheckEndDate())
            {
                dateTimePicker2.Focus();
                errorProviderEndDate.SetError(dateTimePicker2, "No more than 3 days from the start date");
            }
            else
            {
                label7.Text = "";
                errorProviderEndDate.SetError(dateTimePicker2, null);
                LoadListView(GetListCar());
            }
        }
        private void SelectedValueChangedListCar(object sender, EventArgs e)
        {
            if (CheckListCar())
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                var result = Database.cars.Where(car => car.LicensePlates == selectedItem.Text).ToList();
                Car car = result[0];
                if (car != null && car is TransitCar)
                {
                    label7.Text = car.GetECarLoad().ToString();
                }
                else
                {
                    label7.Text = "";
                }
            }
        }
        private void ClickContextMS(object sender, EventArgs e)
        {
            if (CheckListCar())
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                var result = Database.cars.Where(item => item.LicensePlates == selectedItem.Text).ToList();
                DisplayCarDetails displayCarDetails = new DisplayCarDetails(result[0]);
                displayCarDetails.Show();
            }
        }
    }
}
