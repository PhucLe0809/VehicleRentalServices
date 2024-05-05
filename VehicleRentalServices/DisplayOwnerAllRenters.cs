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
    public partial class DisplayOwnerAllRenters : Form
    {
        public DisplayOwnerAllRenters()
        {
            InitializeComponent();

            LoadListView(Database.renter);
        }
        private void LoadListView(List<Renter> input)
        {
            listView1.Items.Clear();
            foreach (var renter in input)
            {
                ListViewItem item = new ListViewItem();
                item.Text = renter.FullName;
                item.ImageIndex = 0;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = renter.ID });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = renter.DateOfBirth.ToString("dd/MM/yyyy") });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = renter.PhoneNumber });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = renter.JointDate.ToString("dd/MM/yyyy") });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = renter.ContractHistory.Count.ToString() });
                double value = 0;
                foreach (var contract in renter.ContractHistory)
                {
                    value += contract.AfterSettlementValue;
                }
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = value.ToString() });

                listView1.Items.Add(item);
            }
        }
        private void ClickButtonTotal(object sender, EventArgs e)
        {
            LoadListView(Database.renter);
        }
        private void ClickForm(object sender, EventArgs e)
        {
            LoadListView(Database.renter);
        }
        private void ClickSortByName(object sender, EventArgs e)
        {
            Database.renter.Sort((person1, person2) => string.Compare(person1.FullName, person2.FullName));
            LoadListView(Database.renter);
        }
        private void ClickSortBySpending(object sender, EventArgs e)
        {
            Database.renter.Sort((person1, person2) => person2.TotalContractValue.CompareTo(person1.TotalContractValue));
            LoadListView(Database.renter);
        }
        private void ClickContextMS(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                var result = Database.renter.Where(item => item.ID == selectedItem.SubItems[1].Text).ToList();
                DisplayRenterDetails displayRenterDetails = new DisplayRenterDetails(result[0]);
                displayRenterDetails.Show();
            }
        }
    }
}
