using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentalServices
{
    public partial class DisplayAssistant : Form
    {
        public DisplayAssistant()
        {
            InitializeComponent();
        }
        private void ClickRegister(object sender, EventArgs e)
        {
            DisplayAssistantRegister displayAssistantRegister = new DisplayAssistantRegister();
            displayAssistantRegister.Show();
            this.Close();
        }
        private void ClickContractHistory(object sender, EventArgs e)
        {
            DisplayAssistantContractHistory displayAssistantContractHistory = new DisplayAssistantContractHistory();
            displayAssistantContractHistory.Show();
            this.Close();
        }
        private void ClickFeedbackHistory(object sender, EventArgs e)
        {
            DisplayAssistantFeedbackHistory displayAssistantFeedbackHistory = new DisplayAssistantFeedbackHistory();
            displayAssistantFeedbackHistory.Show();
            this.Close();
        }
        private void ClickSalary(object sender, EventArgs e)
        {
            DisplayAssistantSalary displayAssistantSalary = new DisplayAssistantSalary();
            displayAssistantSalary.Show();
            this.Close();
        }
    }
}
