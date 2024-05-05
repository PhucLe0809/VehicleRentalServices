using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentalServices
{
    public partial class DisplayRenterChooseToPayments : Form
    {
        private Contract contract = new Contract();
        public DisplayRenterChooseToPayments(Contract contract)
        {
            this.contract = contract;

            InitializeComponent();
            LoadForm();
            LoadChecklistCarDamage();
            LoadRemainingCosts();
        }
        private void LoadForm()
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Enabled = false;

            label10.Text = this.contract.ID;
            label28.Text = this.contract.GetRenter.FullName;
            label29.Text = this.contract.StartDate.ToString("dd/MM/yyyy");
            label30.Text = this.contract.EndDate.ToString("dd/MM/yyyy");
            label31.Text = this.contract.Kilometers.ToString();
            label32.Text = this.contract.GetDriver.FullName;
            label33.Text = this.contract.GetAssistant.FullName;
            label34.Text = (this.contract.PercentagePrepayment * 100).ToString() + "%";
            label35.Text = this.contract.PrePayment.ToString() + "VND";
            label36.Text = (this.contract.PercentageDiscounted * 100).ToString() + "%";
            label37.Text = this.contract.PreSettlementValue.ToString() + "VND";

            label4.Text = "0";
            LoadLateCost();
            LoadPrepayment();

            if (!CheckPaymentDate())
            {
                label38.Text = "Cannot pay before due date";
            }
        }
        private void LoadChecklistCarDamage()
        {
            foreach (var enumValue in Enum.GetValues(typeof(EDamage)))
            {
                checkedListBox1.Items.Add(enumValue);
            }
        }
        private void LoadLateCost()
        {
            TimeSpan timeSpan = dateTimePicker1.Value.Date - contract.EndDate.Date;
            label3.Text = Math.Max(timeSpan.Days * Convert.ToInt64(2000000), 0).ToString();
        }
        private void LoadPrepayment()
        {
            label23.Text = contract.PrePayment.ToString();
        }
        private void LoadRemainingCosts()
        {
            if (CheckPaymentDate())
            {
                TimeSpan timeSpan = dateTimePicker1.Value.Date - contract.EndDate.Date;
                double value = contract.PreSettlementValue + (timeSpan.Days * Convert.ToInt64(2000000)) + (checkedListBox1.CheckedItems.Count * Convert.ToInt64(1000000)) - contract.PrePayment;
                button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
                button2.ForeColor = Color.IndianRed;
                button2.Text = value.ToString() + "VND";
            }
        }
        private bool CheckPayments()
        {
            if (comboBox1.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckPaymentDate()
        {
            TimeSpan timeSpan = dateTimePicker1.Value.Date - this.contract.EndDate.Date;
            return timeSpan.Days >= 0;
        }
        private bool CheckToPayment()
        {
            return CheckPayments() && CheckPaymentDate();
        }
        private void ClickToContractPayment(object sender, EventArgs e)
        {
            if (CheckToPayment())
            {
                DialogResult choose = MessageBox.Show("Confirm contract payment " + contract.ID, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choose == DialogResult.Yes)
                {
                    TimeSpan timeSpan = dateTimePicker1.Value.Date - contract.EndDate.Date;
                    double money = contract.PreSettlementValue + (timeSpan.Days * Convert.ToInt64(2000000)) + (checkedListBox1.CheckedItems.Count * Convert.ToInt64(1000000)) - contract.PrePayment;
                    contract.ContractPayments(dateTimePicker1.Value, (EPayments)comboBox1.SelectedItem, money);
                    notifyIcon1.ShowBalloonTip(2000, contract.ID + " contract payment successfully", "Welcome to VRS, let's start your first experiences", ToolTipIcon.None);

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You have not entered enough information or the information is not available", "Warning",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        //
        // CAR DAMAGE
        //
        private void ValueChangedCarDamage(object sender, MouseEventArgs e)
        {
            label4.Text = (checkedListBox1.CheckedItems.Count * Convert.ToInt64(1000000)).ToString();
            LoadRemainingCosts();
        }
    }
}
