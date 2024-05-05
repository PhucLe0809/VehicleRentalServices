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
    public partial class DisplayAdmin : Form
    {
        public DisplayAdmin()
        {
            InitializeComponent();
        }
        private void ClickCreateCar(object sender, EventArgs e)
        {
            DisplayAdminCreateCar displayAdminCreateCar = new DisplayAdminCreateCar();
            displayAdminCreateCar.Show();
            this.Close();
        }
        private void ClickCreateContract(object sender, EventArgs e)
        {
            DisplayAdminCreateContract displayAdminCreateContract = new DisplayAdminCreateContract();
            displayAdminCreateContract.Show();
            this.Close();
        }

        private void CickContractPayments(object sender, EventArgs e)
        {
            DisplayAdminContractPayments displayAdminContractPayments = new DisplayAdminContractPayments();
            displayAdminContractPayments.Show();
            this.Close();
        }
    }
}
