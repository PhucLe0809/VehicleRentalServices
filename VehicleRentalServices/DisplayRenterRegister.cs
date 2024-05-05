using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentalServices
{
    public partial class DisplayRenterRegister : Form
    {
        public DisplayRenterRegister()
        {
            InitializeComponent();
        }

        #region CHECK
        private bool CheckToRegister()
        {
            return CheckFullName(textBox1.Text) && CheckCitizenCode(textBox2.Text) && CheckBirthday(dateTimePicker1.Value) && CheckPhoneNumber(textBox3.Text)
                && CheckJointdate(dateTimePicker2.Value);
        }
        private bool CheckFullName(string input)
        {
            return !string.IsNullOrEmpty(input) && input.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }
        private bool CheckCitizenCode(string input)
        {
            return !string.IsNullOrEmpty(input);
        }
        private bool CheckBirthday(DateTime input)
        {
            TimeSpan timeSpan = DateTime.Now.Date - input.Date;
            return (timeSpan.Days > 18 * 365) && !(dateTimePicker1.Value.Year == DateTime.Now.Year && dateTimePicker1.Value.Month == DateTime.Now.Month && dateTimePicker1.Value.Day == DateTime.Now.Day);
        }
        private bool CheckPhoneNumber(string input)
        {
            return !string.IsNullOrEmpty(input) && input.All(char.IsDigit);
        }
        private bool CheckJointdate(DateTime input)
        {
            TimeSpan timeSpan = input.Date.Date - dateTimePicker1.Value.Date;
            return timeSpan.Days > 18 * 365;
        }
        #endregion

        #region CLICK
        private void ClickRegister(object sender, EventArgs e)
        {
            if (CheckToRegister())
            {
                label7.Text = "You have successfully registered";
                label8.Text = "Hello";
                label9.Text = textBox1.Text;
                notifyIcon1.ShowBalloonTip(2000, "Registered successfully", "Welcome " + textBox1.Text + " to VRS, let's start your first experiences", ToolTipIcon.None);

                Assistant assistant = new Assistant(textBox1.Text, textBox2.Text, dateTimePicker1.Value, textBox3.Text, dateTimePicker2.Value);
                Database.assistants.Add(assistant);

                Button button = new Button();
                button.Text = textBox1.Text;
                button.AutoSize = true;

                ClickReset(sender, e);
            }
            else
            {
                MessageBox.Show("You have not entered enough information or the information is not available", "Warning",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                TextChangedFullName(sender, e);
                TextChangedCitizenCode(sender, e);
                TextChangedBirthday(sender, e);
                TextChangedPhoneNumber(sender, e);
                TextChangedJointdate(sender, e);
            }
        }
        private void ClickReset(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Refresh();
            dateTimePicker2.Refresh();
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label16.Text = "";
        }
        #endregion

        //
        // FULL NAME
        //
        private void TextChangedFullName(object sender, EventArgs e)
        {
            string input = Convert.ToString(textBox1.Text);
            if (!CheckFullName(input))
            {
                label10.ForeColor = Color.LightCoral;
                label10.Text = "The name includes only alphabetic characters";
            }
            else
            {
                label10.Text = "";
            }
        }
        private void MouseClickFullName(object sender, MouseEventArgs e)
        {
            TextChangedFullName(sender, e);
        }
        //
        // CITIZEN CODE
        //
        private void TextChangedCitizenCode(object sender, EventArgs e)
        {
            string input = Convert.ToString(textBox2.Text);
            if (!CheckCitizenCode(input))
            {
                label11.ForeColor = Color.LightCoral;
                label11.Text = "Enter your citizen code";
            }
            else
            {
                label11.Text = "";
            }
        }
        private void MouseClickCitizenCode(object sender, MouseEventArgs e)
        {
            TextChangedCitizenCode(sender, e);
        }
        //
        // BIRTHDAY
        //
        private void TextChangedBirthday(object sender, EventArgs e)
        {
            if (!CheckBirthday(dateTimePicker1.Value))
            {
                label12.ForeColor = Color.LightCoral;
                label12.Text = "You must be 18 years old";
            }
            else
            {
                label12.Text = "";
            }
        }
        private void MouseClickBirthday(object sender, MouseEventArgs e)
        {
            TextChangedBirthday(sender, e);
        }
        //
        // PHONE NUMBER
        //
        private void TextChangedPhoneNumber(object sender, EventArgs e)
        {
            string input = Convert.ToString(textBox3.Text);
            if (!CheckPhoneNumber(input))
            {
                label13.ForeColor = Color.LightCoral;
                label13.Text = "The phone number must includes numbers";
            }
            else
            {
                label13.Text = "";
            }
        }
        private void MouseClickPhoneNumber(object sender, MouseEventArgs e)
        {
            TextChangedPhoneNumber(sender, e);
        }
        //
        // JOINT DATE
        //
        private void TextChangedJointdate(object sender, EventArgs e)
        {
            if (!CheckJointdate(dateTimePicker2.Value))
            {
                label16.ForeColor = Color.LightCoral;
                label16.Text = "You must be 18 years old to participate";
            }
            else
            {
                label16.Text = "";
            }
        }
        private void MouseClickJointdate(object sender, MouseEventArgs e)
        {
            TextChangedJointdate(sender, e);
        }
    }
}
