using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VehicleRentalServices
{
    public partial class DisplayOwnerAllContracts : Form
    {
        public DisplayOwnerAllContracts()
        {
            InitializeComponent();
            LoadListView(Database.contracts);
        }
        private void LoadListView(List<Contract> input)
        {
            listView1.Items.Clear();
            foreach (var contract in input)
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
                TimeSpan timeSpan1 = DateTime.Now.Date - contract.EndDate.Date;
                if (contract.HasTakenEffect == true && contract.Paid == false && timeSpan1.Days > 0)
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
        private bool CheckListContract()
        {
            return listView1.SelectedItems.Count > 0;
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
        private void ButtonClickDetail(object sender, EventArgs e)
        {
            if (!CheckListContract()) return;
            ListViewItem selectedItem = listView1.SelectedItems[0];
            var result = Database.contracts.Where(contract => contract.ID == selectedItem.Text).ToList();
            DisplayContractDetails displayOwnerContractDetails = new DisplayContractDetails(result[0]);
            displayOwnerContractDetails.ShowDialog();
        }
        private void ClickForm(object sender, EventArgs e)
        {
            ClickButtonTotal(sender, e);
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
