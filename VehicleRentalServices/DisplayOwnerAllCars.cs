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
    public partial class DisplayOwnerAllCars : Form
    {
        private List<Car> cars = new List<Car>();
        public DisplayOwnerAllCars()
        {
            InitializeComponent();

            this.cars = Database.cars;
            LoadListView(this.cars);
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

        private void GetListCar()
        {
            if (CheckVehicle() && CheckCarClassification())
            {
                this.cars = Database.cars.Where(car => car.GetEVehicles == (EVehicles)comboBox2.SelectedItem && car.GetECarClassification == (ECarClassification)comboBox3.SelectedItem).ToList();
            }
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
        private bool CheckListCar()
        {
            return listView1.SelectedItems.Count > 0;
        }
        private void SelectedValueChangedVehicles(object sender, EventArgs e)
        {
            if (CheckVehicle())
            {
                LoadCarClassification();
                GetListCar();
                LoadListView(this.cars);
            }
        }
        private void SelectedValueChangedClassification(object sender, EventArgs e)
        {
            if (CheckCarClassification())
            {
                GetListCar();
                LoadListView(this.cars);
            }
        }
        private void ClickForm(object sender, EventArgs e)
        {
            this.cars = Database.cars;
            LoadListView(this.cars);
        }
        private void ClickTotal(object sender, EventArgs e)
        {
            this.cars = Database.cars;
            LoadListView(this.cars);
        }
        private void ClickSortByKm(object sender, EventArgs e)
        {
            this.cars.Sort((car1, car2) => car2.KmTraveled.CompareTo(car1.KmTraveled));
            LoadListView(this.cars);
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
