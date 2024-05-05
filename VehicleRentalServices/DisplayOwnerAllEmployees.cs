using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VehicleRentalServices
{
    public partial class DisplayOwnerAllEmployees : Form
    {
        private List<Employee> employees = new List<Employee>();
        public DisplayOwnerAllEmployees()
        {
            InitializeComponent();

            this.employees.AddRange(Database.drivers);
            this.employees.AddRange(Database.assistants);
            LoadListView(employees);
        }
        private void LoadListView(List<Employee> input)
        {
            listView1.Items.Clear();
            foreach (var employee in input)
            {
                ListViewItem item = new ListViewItem();
                item.Text = employee.FullName;
                string position = "";
                item.ImageIndex = 0;
                if (employee is Driver)
                {
                    position = "Driver";
                }
                else
                {
                    position = "Assistant";
                }
                employee.CalculateAverageFeedbackRating();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = employee.ID });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = employee.DateOfBirth.ToString("dd/MM/yyyy") });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = employee.PhoneNumber });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = employee.JointDate.ToString("dd/MM/yyyy") });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = employee.AverageRating.ToString("N2") });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = employee.ContractHistory.Count.ToString() });
                double value = 0;
                foreach (var contract in employee.ContractHistory)
                {
                    value += contract.AfterSettlementValue;
                }
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = value.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = position });

                listView1.Items.Add(item);
            }
        }
        private void ClickButtonTotal(object sender, EventArgs e)
        {
            this.employees.Clear();
            this.employees.AddRange(Database.drivers);
            this.employees.AddRange(Database.assistants);
            LoadListView(employees);
        }
        private void ClickButtonDriver(object sender, EventArgs e)
        {
            this.employees.Clear();
            this.employees.AddRange(Database.drivers);
            LoadListView(this.employees);
        }
        private void ClickButtonAssistant(object sender, EventArgs e)
        {
            this.employees.Clear();
            this.employees.AddRange(Database.assistants);
            LoadListView(this.employees);
        }
        private void ClickForm(object sender, EventArgs e)
        {
            ClickButtonTotal(sender, e);
        }
        private void ClickSortByName(object sender, EventArgs e)
        {
            this.employees.Sort((person1, person2) => string.Compare(person1.FullName, person2.FullName));
            LoadListView(employees);
        }
        private void ClickSortByContractValue(object sender, EventArgs e)
        {
            this.employees.Sort((person1, person2) => person2.TotalContractValue.CompareTo(person1.TotalContractValue));
            LoadListView(employees);
        }
        private void ClickSortByAvgRate(object sender, EventArgs e)
        {
            this.employees.Sort((person1, person2) => person2.AverageRating.CompareTo(person1.AverageRating));
            LoadListView(employees);
        }
        private void ClickContextMS(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                var result = this.employees.Where(item => item.ID == selectedItem.SubItems[1].Text).ToList();
                if (Database.drivers.Where(item => item.ID == selectedItem.SubItems[1].Text).ToList().Count > 0)
                {
                    DisplayDriverDetails displayDriverDetails = new DisplayDriverDetails(result[0]);
                    displayDriverDetails.Show();
                }
                else 
                { 
                    DisplayAssistantDetails displayAssistantDetails = new DisplayAssistantDetails(result[0]);
                    displayAssistantDetails.Show();
                }
            }
        }
    }
}
