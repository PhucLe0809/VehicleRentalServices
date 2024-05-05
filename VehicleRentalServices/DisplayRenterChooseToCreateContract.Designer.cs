namespace VehicleRentalServices
{
    partial class DisplayRenterChooseToCreateContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayRenterChooseToCreateContract));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label7 = new Label();
            label11 = new Label();
            label12 = new Label();
            button2 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            comboBox1 = new ComboBox();
            contextMSRenter = new ContextMenuStrip(components);
            renterDetailsToolStripMenuItem = new ToolStripMenuItem();
            label16 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            contextMSDriver = new ContextMenuStrip(components);
            driverDetailsToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            label10 = new Label();
            comboBox3 = new ComboBox();
            contextMSCar = new ContextMenuStrip(components);
            carDetailsToolStripMenuItem = new ToolStripMenuItem();
            label13 = new Label();
            label18 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            textBox1 = new TextBox();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            comboBox4 = new ComboBox();
            contextMSAssistant = new ContextMenuStrip(components);
            assistantDetailsToolStripMenuItem = new ToolStripMenuItem();
            label31 = new Label();
            label30 = new Label();
            label8 = new Label();
            button3 = new Button();
            contextMSRenter.SuspendLayout();
            contextMSDriver.SuspendLayout();
            contextMSCar.SuspendLayout();
            contextMSAssistant.SuspendLayout();
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
            label1.Size = new Size(293, 39);
            label1.TabIndex = 1;
            label1.Text = "Create Contract";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(320, 35);
            label2.Name = "label2";
            label2.Size = new Size(229, 21);
            label2.TabIndex = 2;
            label2.Text = "Please fill in the information below";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 356);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 5;
            label4.Text = "Kilometers";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Location = new Point(599, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 27);
            textBox2.TabIndex = 7;
            textBox2.MouseClick += MouseClickPrepayments;
            textBox2.TextChanged += TextChangedPrepayments;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 245);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 7;
            label5.Text = "Start date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Location = new Point(154, 241);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += ValueChangedStartDate;
            dateTimePicker1.MouseDown += MouseClickStartDate;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(466, 351);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 8;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickRegister;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(466, 393);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(154, 382);
            label11.Name = "label11";
            label11.Size = new Size(0, 17);
            label11.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(154, 271);
            label12.Name = "label12";
            label12.Size = new Size(0, 17);
            label12.TabIndex = 17;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(635, 351);
            button2.Name = "button2";
            button2.Size = new Size(127, 29);
            button2.TabIndex = 9;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClickReset;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "Welcome to VRS, let's start your first experiences";
            notifyIcon1.BalloonTipTitle = "Registered successfully";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.Info;
            label14.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.DodgerBlue;
            label14.Location = new Point(581, 34);
            label14.Name = "label14";
            label14.Size = new Size(85, 21);
            label14.TabIndex = 20;
            label14.Text = "Business";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(567, 26);
            label15.Name = "label15";
            label15.Size = new Size(19, 28);
            label15.TabIndex = 21;
            label15.Text = "|";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label17.Location = new Point(156, 161);
            label17.Name = "label17";
            label17.Size = new Size(0, 17);
            label17.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.ContextMenuStrip = contextMSRenter;
            comboBox1.DisplayMember = "Name";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(154, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += SelectedValueChangedRenter;
            comboBox1.SelectedValueChanged += SelectedValueChangedRenter;
            comboBox1.MouseClick += MouseClickRenter;
            // 
            // contextMSRenter
            // 
            contextMSRenter.ImageScalingSize = new Size(20, 20);
            contextMSRenter.Items.AddRange(new ToolStripItem[] { renterDetailsToolStripMenuItem });
            contextMSRenter.Name = "contextMSRenter";
            contextMSRenter.Size = new Size(170, 28);
            contextMSRenter.Click += CMSRenterClick;
            // 
            // renterDetailsToolStripMenuItem
            // 
            renterDetailsToolStripMenuItem.Name = "renterDetailsToolStripMenuItem";
            renterDetailsToolStripMenuItem.Size = new Size(169, 24);
            renterDetailsToolStripMenuItem.Text = "Renter details";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(21, 134);
            label16.Name = "label16";
            label16.Size = new Size(60, 23);
            label16.TabIndex = 27;
            label16.Text = "Driver";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(156, 216);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 32;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.ContextMenuStrip = contextMSDriver;
            comboBox2.DisplayMember = "Name";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(154, 130);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += SelectedValueChangedDriver;
            comboBox2.SelectedValueChanged += SelectedValueChangedDriver;
            comboBox2.MouseClick += MouseClickDriver;
            // 
            // contextMSDriver
            // 
            contextMSDriver.ImageScalingSize = new Size(20, 20);
            contextMSDriver.Items.AddRange(new ToolStripItem[] { driverDetailsToolStripMenuItem });
            contextMSDriver.Name = "contextMSDriver";
            contextMSDriver.Size = new Size(167, 28);
            contextMSDriver.Click += CMSDriverClick;
            // 
            // driverDetailsToolStripMenuItem
            // 
            driverDetailsToolStripMenuItem.Name = "driverDetailsToolStripMenuItem";
            driverDetailsToolStripMenuItem.Size = new Size(166, 24);
            driverDetailsToolStripMenuItem.Text = "Driver details";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(21, 189);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 30;
            label6.Text = "Label car";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(156, 104);
            label10.Name = "label10";
            label10.Size = new Size(0, 17);
            label10.TabIndex = 35;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.ContextMenuStrip = contextMSCar;
            comboBox3.DisplayMember = "Name";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(154, 185);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 28);
            comboBox3.TabIndex = 3;
            comboBox3.SelectedIndexChanged += SelectedValueChangedLabelCar;
            comboBox3.SelectedValueChanged += SelectedValueChangedLabelCar;
            comboBox3.MouseClick += MouseClickLabelCar;
            // 
            // contextMSCar
            // 
            contextMSCar.ImageScalingSize = new Size(20, 20);
            contextMSCar.Items.AddRange(new ToolStripItem[] { carDetailsToolStripMenuItem });
            contextMSCar.Name = "contextMSCar";
            contextMSCar.Size = new Size(149, 28);
            contextMSCar.Click += CMSCarClick;
            // 
            // carDetailsToolStripMenuItem
            // 
            carDetailsToolStripMenuItem.Name = "carDetailsToolStripMenuItem";
            carDetailsToolStripMenuItem.Size = new Size(148, 24);
            carDetailsToolStripMenuItem.Text = "Car details";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(21, 77);
            label13.Name = "label13";
            label13.Size = new Size(63, 23);
            label13.TabIndex = 33;
            label13.Text = "Renter";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label18.Location = new Point(154, 326);
            label18.Name = "label18";
            label18.Size = new Size(0, 17);
            label18.TabIndex = 38;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top;
            dateTimePicker2.Location = new Point(154, 296);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 5;
            dateTimePicker2.ValueChanged += ValueChangedEndDate;
            dateTimePicker2.MouseDown += MouseClickEndDate;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(21, 300);
            label19.Name = "label19";
            label19.Size = new Size(81, 23);
            label19.TabIndex = 36;
            label19.Text = "End date";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(466, 301);
            label20.Name = "label20";
            label20.Size = new Size(175, 23);
            label20.TabIndex = 39;
            label20.Text = "Pre-SettlementValue";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.Orange;
            label21.Location = new Point(659, 301);
            label21.Name = "label21";
            label21.Size = new Size(0, 23);
            label21.TabIndex = 40;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(466, 133);
            label22.Name = "label22";
            label22.Size = new Size(127, 23);
            label22.TabIndex = 41;
            label22.Text = "% Prepayment";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Green;
            label23.Location = new Point(614, 133);
            label23.Name = "label23";
            label23.Size = new Size(0, 23);
            label23.TabIndex = 42;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top;
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(466, 189);
            label24.Name = "label24";
            label24.Size = new Size(107, 23);
            label24.TabIndex = 43;
            label24.Text = "Prepayment";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label25.Location = new Point(599, 216);
            label25.Name = "label25";
            label25.Size = new Size(0, 17);
            label25.TabIndex = 46;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(154, 352);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 6;
            textBox1.MouseClick += MouseClickKilometers;
            textBox1.TextChanged += TextChangedKilometers;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label26.ForeColor = Color.Green;
            label26.Location = new Point(486, 159);
            label26.Name = "label26";
            label26.Size = new Size(183, 17);
            label26.TabIndex = 47;
            label26.Text = "This is required upfront rate";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label27.ForeColor = Color.Green;
            label27.Location = new Point(486, 271);
            label27.Name = "label27";
            label27.Size = new Size(270, 17);
            label27.TabIndex = 50;
            label27.Text = "This is a discount rate for loyal customers";
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top;
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.Green;
            label28.Location = new Point(614, 245);
            label28.Name = "label28";
            label28.Size = new Size(0, 23);
            label28.TabIndex = 49;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top;
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(466, 245);
            label29.Name = "label29";
            label29.Size = new Size(100, 23);
            label29.TabIndex = 48;
            label29.Text = "% Discount";
            // 
            // comboBox4
            // 
            comboBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox4.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox4.ContextMenuStrip = contextMSAssistant;
            comboBox4.DisplayMember = "Name";
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(599, 72);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(163, 28);
            comboBox4.TabIndex = 51;
            comboBox4.SelectedIndexChanged += SelectedValueChangedAssistant;
            comboBox4.SelectedValueChanged += SelectedValueChangedAssistant;
            comboBox4.MouseClick += MouseClickAssistant;
            // 
            // contextMSAssistant
            // 
            contextMSAssistant.ImageScalingSize = new Size(20, 20);
            contextMSAssistant.Items.AddRange(new ToolStripItem[] { assistantDetailsToolStripMenuItem });
            contextMSAssistant.Name = "contextMSAssistant";
            contextMSAssistant.Size = new Size(185, 28);
            contextMSAssistant.Click += CMSAssistantClick;
            // 
            // assistantDetailsToolStripMenuItem
            // 
            assistantDetailsToolStripMenuItem.Name = "assistantDetailsToolStripMenuItem";
            assistantDetailsToolStripMenuItem.Size = new Size(184, 24);
            assistantDetailsToolStripMenuItem.Text = "Assistant details";
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Top;
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label31.Location = new Point(467, 77);
            label31.Name = "label31";
            label31.Size = new Size(81, 23);
            label31.TabIndex = 52;
            label31.Text = "Assistant";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label30.Location = new Point(600, 104);
            label30.Name = "label30";
            label30.Size = new Size(0, 17);
            label30.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(674, 385);
            label8.Name = "label8";
            label8.Size = new Size(114, 28);
            label8.TabIndex = 54;
            label8.Text = "IDContract";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.LimeGreen;
            button3.Location = new Point(21, 402);
            button3.Name = "button3";
            button3.Size = new Size(133, 36);
            button3.TabIndex = 55;
            button3.Text = "Rental Policy";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ClickRentalPolicy;
            // 
            // DisplayRenterChooseToCreateContract
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label30);
            Controls.Add(comboBox4);
            Controls.Add(label31);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(label29);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(textBox1);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(dateTimePicker2);
            Controls.Add(label19);
            Controls.Add(label10);
            Controls.Add(comboBox3);
            Controls.Add(label13);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(label17);
            Controls.Add(comboBox1);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(button2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayRenterChooseToCreateContract";
            Text = "Renter Create Contract";
            contextMSRenter.ResumeLayout(false);
            contextMSDriver.ResumeLayout(false);
            contextMSCar.ResumeLayout(false);
            contextMSAssistant.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label7;
        private Label label11;
        private Label label12;
        private Button button2;
        private NotifyIcon notifyIcon1;
        private Label label14;
        private Label label15;
        private Label label17;
        private ComboBox comboBox1;
        private Label label16;
        private Label label3;
        private ComboBox comboBox2;
        private Label label6;
        private Label label10;
        private ComboBox comboBox3;
        private Label label13;
        private Label label18;
        private DateTimePicker dateTimePicker2;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private TextBox textBox1;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private ComboBox comboBox4;
        private Label label31;
        private Label label30;
        private Label label8;
        private Button button3;
        private ContextMenuStrip contextMSDriver;
        private ToolStripMenuItem driverDetailsToolStripMenuItem;
        private ContextMenuStrip contextMSAssistant;
        private ToolStripMenuItem assistantDetailsToolStripMenuItem;
        private ContextMenuStrip contextMSRenter;
        private ToolStripMenuItem renterDetailsToolStripMenuItem;
        private ContextMenuStrip contextMSCar;
        private ToolStripMenuItem carDetailsToolStripMenuItem;
    }
}