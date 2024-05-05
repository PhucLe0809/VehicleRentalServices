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
    public partial class DisplayContractDetails : Form
    {
        private Contract contract = new Contract();
        public DisplayContractDetails(Contract contract)
        {
            this.contract = contract;

            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
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

            label38.ForeColor = Color.IndianRed;
            label38.Text = "N/A";
            label4.ForeColor = Color.IndianRed;
            label4.Text = "N/A";
            label3.ForeColor = Color.IndianRed;
            label3.Text = "N/A";
            button1.ForeColor = Color.IndianRed;
            button1.Text = "N/A";
            button2.ForeColor = Color.IndianRed;
            button2.Text = "N/A";
            button3.ForeColor = Color.IndianRed;
            button3.Text = "N/A";

            TimeSpan timeSpan = DateTime.Now.Date - contract.EndDate.Date;
            if (contract.HasTakenEffect == true && contract.Paid == false && timeSpan.Days > 0)
            {
                button1.ForeColor = Color.IndianRed;
                button1.Text = "Expired";
            }
            else
            {
                if (contract.Paid == true)
                {
                    label38.ForeColor = SystemColors.ControlText;
                    label38.Text = contract.PaymentDate.ToString("dd/MM/yyyy");
                    foreach (var item in contract.GetEDamages)
                    {
                        richTextBox1.Text = richTextBox1.Text + " damage: " + item.ToString() + "\n";
                    }
                    LoadDamageCost();
                    LoadLateCost();
                    LoadPrepayment();
                    LoadTotalCosts();
                    button1.ForeColor = Color.LimeGreen;
                    button1.Text = "Paid";
                    button3.ForeColor = Color.RoyalBlue;
                    button3.Text = contract.GetEPayments.ToString();
                }
                else
                {
                    button1.ForeColor = Color.Gold;
                    button1.Text = "Effected";
                }
            }
        }
        private void LoadDamageCost()
        {
            label4.ForeColor = Color.LightCoral;
            label4.Text = (contract.GetEDamages.Count * 1000000).ToString();
        }
        private void LoadLateCost()
        {
            TimeSpan timeSpan = contract.PaymentDate.Date - contract.EndDate.Date;
            label3.ForeColor = Color.LightCoral;
            label3.Text = Math.Max(timeSpan.Days * Convert.ToInt64(2000000), 0).ToString();
        }
        private void LoadPrepayment()
        {
            label23.ForeColor = Color.LimeGreen;
            label23.Text = contract.PrePayment.ToString();
        }
        private void LoadTotalCosts()
        {
            if (contract.Paid == true)
            {
                TimeSpan timeSpan = contract.PaymentDate.Date - contract.EndDate.Date;
                double value = contract.PreSettlementValue + (timeSpan.Days * Convert.ToInt64(2000000)) + (contract.GetEDamages.Count * Convert.ToInt64(1000000));
                button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
                button2.ForeColor = Color.IndianRed;
                button2.Text = value.ToString() + "VND";
            }
        }
    }
}
