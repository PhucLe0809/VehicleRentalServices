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
    public partial class DisplayAboutVRS : Form
    {
        public DisplayAboutVRS()
        {
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            richTextBox1.Text = richTextBox1.Text + "     ";
            richTextBox1.Text = richTextBox1.Text + "VRS is a management system for car rentals, designed to automate and optimize the processes involved in managing and tracking vehicles within the car rental business model." + "\n";
            richTextBox1.Text = richTextBox1.Text + "     ";
            richTextBox1.Text = richTextBox1.Text + "VRS provides features such as vehicle search, deposit management and contract tracking, helping businesses manage and provide effective car rental services to their customers." + "\n";
        }
    }
}
