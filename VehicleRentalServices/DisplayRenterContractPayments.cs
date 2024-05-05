using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VehicleRentalServices
{
    public partial class DisplayRenterContractPayments : Form
    {
        private Renter renter = new Renter();
        public DisplayRenterContractPayments()
        {
            InitializeComponent();
            LoadForm();
            LoadListView(Database.contracts);
        }
        private void LoadListView(List<Contract> input)
        {
            listView1.Items.Clear();
            foreach (var contract in input)
            {
                if (contract.GetRenter == this.renter)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = contract.ID;
                    item.ImageIndex = 0;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = contract.StartDate.ToString("dd/MM/yyyy") });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = contract.EndDate.ToString("dd/MM/yyyy") });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = contract.GetRenter.FullName });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = contract.PreSettlementValue.ToString() + "đ" });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = contract.PrePayment.ToString() + "đ" });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = contract.Paid ? "Paid" : "Effected" });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = contract.GetCar.GetEVehicles.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = contract.GetCar.LicensePlates.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = contract.GetDriver.FullName });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = contract.GetAssistant.FullName });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = contract.GetCar.GetECarClassification.ToString() });

                    listView1.Items.Add(item);
                }
            }
        }
        private void LoadForm()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = Database.renter;
            comboBox1.DisplayMember = "FullName";

            SelectedValueChangedRenter(this, EventArgs.Empty);
        }
        private void ClickChooseToPayments(object sender, EventArgs e)
        {
            if (CheckListContract())
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                var result = Database.contracts.Where(contract => contract.ID == selectedItem.Text).ToList();
                Contract contract = result[0];
                if (contract.HasTakenEffect == true && contract.Paid == true)
                {
                    MessageBox.Show("You have paid for contract " + contract.ID, "Warning",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    return;
                }
                TimeSpan timeSpan = DateTime.Now.Date - contract.EndDate.Date;
                if (!(timeSpan.Days >= 0))
                {
                    MessageBox.Show("Contract " + contract.ID + " is not yet due for payment", "Warning",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    return;
                }
                if (contract != null)
                {
                    DisplayRenterChooseToPayments display = new DisplayRenterChooseToPayments(contract);
                    display.ShowDialog();

                    ClickButtonTotal(sender, e);
                }
            }
            else
            {
                MessageBox.Show("You have not entered enough information or the information is not available", "Warning",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
        private void ClickChooseToFeedback(object sender, EventArgs e)
        {
            if (CheckListContract())
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                var result = Database.contracts.Where(contract => contract.ID == selectedItem.Text).ToList();
                Contract contract = result[0];
                if (contract.Paid == true)
                {
                    DisplayRenterChooseToFeedback display = new DisplayRenterChooseToFeedback(contract);
                    display.ShowDialog();

                    ClickButtonTotal(sender, e);
                }
                else
                {
                    MessageBox.Show("You have not paid this contract yet", "Warning",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("You have not entered enough information or the information is not available", "Warning",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
        private List<Contract> GetContractEffected()
        {
            var list = new List<Contract>();
            foreach (var contract in Database.contracts)
            {
                if (contract.HasTakenEffect == true && contract.Paid == false)
                {
                    list.Add(contract);
                }
            }
            return list;
        }
        private List<Contract> GetContractExpired()
        {
            var list = new List<Contract>();
            foreach (var contract in Database.contracts)
            {
                TimeSpan timeSpan = DateTime.Now.Date - contract.EndDate.Date;
                if (contract.HasTakenEffect == true && contract.Paid == false && timeSpan.Days > 0)
                {
                    list.Add(contract);
                }
            }
            return list;
        }
        private List<Contract> GetContractPaid()
        {
            var list = new List<Contract>();
            foreach (var contract in Database.contracts)
            {
                if (contract.HasTakenEffect == true && contract.Paid == true)
                {
                    list.Add(contract);
                }
            }
            return list;
        }
        private bool CheckRenter()
        {
            if (comboBox1.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckListContract()
        {
            return listView1.SelectedItems.Count > 0;
        }
        private void SelectedValueChangedRenter(object sender, EventArgs e)
        {
            if (CheckRenter())
            {
                this.renter = (Renter)comboBox1.SelectedItem;
                LoadListView(Database.contracts);
            }
        }
        private void ClickButtonTotal(object sender, EventArgs e)
        {
            LoadListView(Database.contracts);
        }
        private void ClickButtonEffected(object sender, EventArgs e)
        {
            LoadListView(GetContractEffected());
        }
        private void ClickButtonExpired(object sender, EventArgs e)
        {
            LoadListView(GetContractExpired());
        }
        private void ClickButtonPaid(object sender, EventArgs e)
        {
            LoadListView(GetContractPaid());
        }
        private void ClickContextMS(object sender, EventArgs e)
        {
            if (CheckListContract())
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                var result = Database.contracts.Where(item => item.ID == selectedItem.Text).ToList();
                DisplayContractDetails displayContractDetails = new DisplayContractDetails(result[0]);
                displayContractDetails.Show();
            }
        }
    }
}
