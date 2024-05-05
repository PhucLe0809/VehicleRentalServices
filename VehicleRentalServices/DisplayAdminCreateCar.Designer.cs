namespace VehicleRentalServices
{
    partial class DisplayAdminCreateCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAdminCreateCar));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label7 = new Label();
            button2 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label13 = new Label();
            comboBox3 = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label17 = new Label();
            checkedListBox1 = new CheckedListBox();
            label18 = new Label();
            label19 = new Label();
            textBox3 = new TextBox();
            label20 = new Label();
            checkBox1 = new CheckBox();
            label21 = new Label();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            label22 = new Label();
            comboBox6 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(200, 39);
            label1.TabIndex = 1;
            label1.Text = "Create Car";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(227, 35);
            label2.Name = "label2";
            label2.Size = new Size(229, 21);
            label2.TabIndex = 2;
            label2.Text = "Please fill in the information below";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(466, 351);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 11;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickRegister;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.LimeGreen;
            label7.Location = new Point(466, 393);
            label7.Name = "label7";
            label7.Size = new Size(0, 23);
            label7.TabIndex = 12;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(635, 351);
            button2.Name = "button2";
            button2.Size = new Size(127, 29);
            button2.TabIndex = 19;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClickReset;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 77);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 3;
            label3.Text = "Label car";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(159, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 4;
            textBox1.MouseClick += MouseClickLabelCar;
            textBox1.TextChanged += TextChangedLabelCar;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 132);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 5;
            label4.Text = "Business code";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Location = new Point(159, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 6;
            textBox2.MouseClick += MouseClickBusinessCode;
            textBox2.TextChanged += TextChangedBusinessCode;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 190);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 7;
            label5.Text = "Vehicles";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(159, 103);
            label10.Name = "label10";
            label10.Size = new Size(0, 17);
            label10.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(159, 158);
            label11.Name = "label11";
            label11.Size = new Size(0, 17);
            label11.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(159, 216);
            label12.Name = "label12";
            label12.Size = new Size(0, 17);
            label12.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.DisplayMember = "Name";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { EVehicles.PassengerCar, EVehicles.TouristCar, EVehicles.SelfDrivingCar, EVehicles.TransitCar });
            comboBox1.Location = new Point(159, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 24;
            comboBox1.SelectedIndexChanged += SelectedValueChangedVehicle;
            comboBox1.SelectedValueChanged += SelectedValueChangedVehicle;
            comboBox1.MouseClick += MouseClickVehicle;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.DisplayMember = "Name";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { ECarCompany.VinFast, ECarCompany.Mazda, ECarCompany.Toyota, ECarCompany.MercedesBenz, ECarCompany.Lexus, ECarCompany.Ford, ECarCompany.Hyundai, ECarCompany.Porsche, ECarCompany.Honda, ECarCompany.Bentley, ECarCompany.BMW, ECarCompany.Audi, ECarCompany.Bugatti, ECarCompany.Ferrari, ECarCompany.Lamborghini });
            comboBox2.Location = new Point(159, 242);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 27;
            comboBox2.SelectedIndexChanged += SelectedValueChangedCarCompany;
            comboBox2.SelectedValueChanged += SelectedValueChangedCarCompany;
            comboBox2.MouseClick += MouseClickCarCompany;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(159, 274);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 26;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(26, 248);
            label13.Name = "label13";
            label13.Size = new Size(115, 23);
            label13.TabIndex = 25;
            label13.Text = "Car company";
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.DisplayMember = "Name";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(159, 298);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 28);
            comboBox3.TabIndex = 30;
            comboBox3.SelectedIndexChanged += SelectedValueChangedCarClassification;
            comboBox3.SelectedValueChanged += SelectedValueChangedCarClassification;
            comboBox3.MouseClick += MouseClickCarClassification;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(159, 330);
            label14.Name = "label14";
            label14.Size = new Size(0, 17);
            label14.TabIndex = 29;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(26, 304);
            label15.Name = "label15";
            label15.Size = new Size(115, 23);
            label15.TabIndex = 28;
            label15.Text = "Classification";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label16.Location = new Point(161, 384);
            label16.Name = "label16";
            label16.Size = new Size(0, 17);
            label16.TabIndex = 33;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top;
            dateTimePicker2.Location = new Point(159, 354);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 32;
            dateTimePicker2.MouseClick += MouseClickPurchaseDate;
            dateTimePicker2.ValueChanged += ValueChangedPurchaseDate;
            dateTimePicker2.MouseDown += MouseClickPurchaseDate;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(26, 358);
            label17.Name = "label17";
            label17.Size = new Size(121, 23);
            label17.TabIndex = 31;
            label17.Text = "Purchase date";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(466, 81);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.ScrollAlwaysVisible = true;
            checkedListBox1.Size = new Size(296, 136);
            checkedListBox1.TabIndex = 34;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(466, 53);
            label18.Name = "label18";
            label18.Size = new Size(178, 23);
            label18.TabIndex = 35;
            label18.Text = "Choose car amenities";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label19.Location = new Point(592, 256);
            label19.Name = "label19";
            label19.Size = new Size(0, 17);
            label19.TabIndex = 38;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.Location = new Point(592, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 27);
            textBox3.TabIndex = 37;
            textBox3.MouseClick += MouseClickKmTraveled;
            textBox3.TextChanged += TextChangedKmTraveled;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(466, 230);
            label20.Name = "label20";
            label20.Size = new Size(107, 23);
            label20.TabIndex = 36;
            label20.Text = "km traveled";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(26, 406);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(178, 27);
            checkBox1.TabIndex = 39;
            checkBox1.Text = "have car insurance";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += ClickCheckBoxInsurance;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(466, 281);
            label21.Name = "label21";
            label21.Size = new Size(87, 23);
            label21.TabIndex = 40;
            label21.Text = "Collateral";
            // 
            // comboBox4
            // 
            comboBox4.Enabled = false;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(592, 276);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(170, 28);
            comboBox4.TabIndex = 41;
            // 
            // comboBox5
            // 
            comboBox5.Enabled = false;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(592, 310);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(170, 28);
            comboBox5.TabIndex = 42;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(466, 315);
            label22.Name = "label22";
            label22.Size = new Size(69, 23);
            label22.TabIndex = 43;
            label22.Text = "Weight";
            // 
            // comboBox6
            // 
            comboBox6.DisplayMember = "Name";
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(258, 405);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(151, 28);
            comboBox6.TabIndex = 44;
            // 
            // DisplayAdminCreateCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox6);
            Controls.Add(label22);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(label21);
            Controls.Add(checkBox1);
            Controls.Add(label19);
            Controls.Add(textBox3);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(checkedListBox1);
            Controls.Add(label16);
            Controls.Add(dateTimePicker2);
            Controls.Add(label17);
            Controls.Add(comboBox3);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(label13);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayAdminCreateCar";
            Text = "Admin Create Car";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label7;
        private Button button2;
        private NotifyIcon notifyIcon1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        private Label label13;
        private ComboBox comboBox3;
        private Label label14;
        private Label label15;
        private Label label16;
        private DateTimePicker dateTimePicker2;
        private Label label17;
        private CheckedListBox checkedListBox1;
        private Label label18;
        private Label label19;
        private TextBox textBox3;
        private Label label20;
        private CheckBox checkBox1;
        private Label label21;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label22;
        private ComboBox comboBox6;
    }
}