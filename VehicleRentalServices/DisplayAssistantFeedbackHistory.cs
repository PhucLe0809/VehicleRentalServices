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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VehicleRentalServices
{
    public partial class DisplayAssistantFeedbackHistory : Form
    {
        private Person reciver = new Person();
        private bool isPicture1Visible = true;
        private bool isPicture2Visible = true;
        private bool isPicture3Visible = true;
        private bool isPicture4Visible = true;
        private bool isPicture5Visible = true;
        public DisplayAssistantFeedbackHistory()
        {
            InitializeComponent();
            LoadForm();
            LoadListView(Database.feedbacks);
        }
        private void LoadListView(List<Feedback> input)
        {
            listView1.Items.Clear();
            foreach (var feedback in input)
            {
                if (feedback.Reciver == this.reciver)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = feedback.ID;
                    item.ImageIndex = 0;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = feedback.Sender.FullName });
                    string surnom = "";
                    if (feedback.Reciver is Person)
                    {
                        Person person = (Person)feedback.Reciver;
                        surnom = person.FullName;
                    }
                    else
                    {
                        Car car = (Car)feedback.Reciver;
                        surnom = car.LicensePlates;
                    }
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = surnom });
                    string position = "";
                    if (feedback.Reciver is Owner) position = "Owner";
                    if (feedback.Reciver is Driver) position = "Driver";
                    if (feedback.Reciver is Assistant) position = "Assistant";
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = position });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = feedback.GetECategory.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = feedback.GetERate.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = feedback.SendDate.ToString("dd/MM/yyyy") });

                    listView1.Items.Add(item);
                }
            }
        }
        private void LoadForm()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = Database.assistants;
            comboBox1.DisplayMember = "FullName";

            SelectedValueChangedAssistant(this, EventArgs.Empty);
        }
        private bool CheckAssistant()
        {
            if (comboBox1.SelectedIndex != -1) return true;
            else return false;
        }
        private bool CheckListFeedback()
        {
            return listView1.SelectedItems.Count > 0;
        }
        private bool CheckToSearch()
        {
            TimeSpan timeSpan = dateTimePicker2.Value.Date - dateTimePicker1.Value.Date;
            return timeSpan.Days >= 0;
        }
        private void ResetData()
        {
            isPicture1Visible = true;
            isPicture2Visible = true;
            isPicture3Visible = true;
            isPicture4Visible = true;
            isPicture5Visible = true;
            ClickPictureBox1(); ClickPictureBox2(); ClickPictureBox3(); ClickPictureBox4(); ClickPictureBox5();

            richTextBox1.Text = "";
        }
        private void SelectedValueChangedAssistant(object sender, EventArgs e)
        {
            if (CheckAssistant())
            {
                this.reciver = (Assistant)comboBox1.SelectedItem;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                LoadListView(Database.feedbacks);
            }
            ResetData();
        }
        private void SelectedIndexChangedListFeedback(object sender, EventArgs e)
        {
            if (CheckListFeedback())
            {
                ListViewItem item = listView1.SelectedItems[0];
                var result = Database.feedbacks.Where(feedback => feedback.ID == item.Text).ToList();
                Feedback feedback = result[0];
                richTextBox1.Text = "     " + feedback.Content;

                int rate = (int)feedback.GetERate;
                isPicture1Visible = true;
                isPicture2Visible = true;
                isPicture3Visible = true;
                isPicture4Visible = true;
                isPicture5Visible = true;
                if (rate == 1)
                {
                    isPicture1Visible = false;
                }
                if (rate == 2)
                {
                    isPicture1Visible = isPicture2Visible = false;
                }
                if (rate == 3)
                {
                    isPicture1Visible = isPicture2Visible = isPicture3Visible = false;
                }
                if (rate == 4)
                {
                    isPicture1Visible = isPicture2Visible = isPicture3Visible = isPicture4Visible = false;
                }
                if (rate == 5)
                {
                    isPicture1Visible = isPicture2Visible = isPicture3Visible = isPicture4Visible = isPicture5Visible = false;
                }
                ClickPictureBox1(); ClickPictureBox2(); ClickPictureBox3(); ClickPictureBox4(); ClickPictureBox5();
            }
        }

        private void ClickPictureBox1()
        {
            if (isPicture1Visible)
            {
                pictureBox1.Image = Properties.Resources.imageStar;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.imageStarLight;
            }
        }
        private void ClickPictureBox2()
        {
            if (isPicture2Visible)
            {
                pictureBox2.Image = Properties.Resources.imageStar;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.imageStarLight;
            }
        }
        private void ClickPictureBox3()
        {
            if (isPicture3Visible)
            {
                pictureBox3.Image = Properties.Resources.imageStar;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.imageStarLight;
            }
        }
        private void ClickPictureBox4()
        {
            if (isPicture4Visible)
            {
                pictureBox4.Image = Properties.Resources.imageStar;
            }
            else
            {
                pictureBox4.Image = Properties.Resources.imageStarLight;
            }
        }
        private void ClickPictureBox5()
        {
            if (isPicture5Visible)
            {
                pictureBox5.Image = Properties.Resources.imageStar;
            }
            else
            {
                pictureBox5.Image = Properties.Resources.imageStarLight;
            }
        }
        private void ValueChanged(object sender, EventArgs e)
        {
            if (CheckToSearch())
            {
                var list = new List<Feedback>();
                foreach (var feedback in Database.feedbacks)
                {
                    TimeSpan timeSpan1 = feedback.SendDate.Date - dateTimePicker1.Value.Date;
                    TimeSpan timeSpan2 = dateTimePicker2.Value.Date - feedback.SendDate.Date;
                    if (timeSpan1.Days >= 0 && timeSpan2.Days >= 0)
                    {
                        list.Add(feedback);
                    }
                }
                LoadListView(list);
            }
            else
            {
                ResetData();
            }
        }
        private void ClickForm(object sender, EventArgs e)
        {
            ValueChanged(sender, e);
        }
        private void CMSDetailsClick(object sender, EventArgs e)
        {
            DisplayAssistantDetails displayAssistantDetails = new DisplayAssistantDetails((Assistant)comboBox1.SelectedItem);
            displayAssistantDetails.Show();
        }
    }
}
