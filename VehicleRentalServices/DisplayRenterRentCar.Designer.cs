namespace VehicleRentalServices
{
    partial class DisplayRenterRentCar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayRenterRentCar));
            label1 = new Label();
            label2 = new Label();
            label13 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label15 = new Label();
            label3 = new Label();
            label4 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            largeImageList = new ImageList(components);
            smallImageList = new ImageList(components);
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            errorProviderStartDate = new ErrorProvider(components);
            errorProviderEndDate = new ErrorProvider(components);
            errorProviderVehicles = new ErrorProvider(components);
            errorProviderClassification = new ErrorProvider(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            carDetailsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)errorProviderStartDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEndDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderVehicles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderClassification).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(170, 39);
            label1.TabIndex = 0;
            label1.Text = "Rent Car";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(200, 35);
            label2.Name = "label2";
            label2.Size = new Size(229, 21);
            label2.TabIndex = 1;
            label2.Text = "Please fill in the information below";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(446, 33);
            label13.Name = "label13";
            label13.Size = new Size(63, 23);
            label13.TabIndex = 34;
            label13.Text = "Renter";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DisplayMember = "Name";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(515, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Location = new Point(105, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 36;
            dateTimePicker1.ValueChanged += ValueChangedStartDate;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top;
            dateTimePicker2.Location = new Point(515, 98);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 37;
            dateTimePicker2.ValueChanged += ValueChangedEndDate;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.BackColor = SystemColors.Window;
            comboBox2.DisplayMember = "Name";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { EVehicles.PassengerCar, EVehicles.TouristCar, EVehicles.SelfDrivingCar, EVehicles.TransitCar });
            comboBox2.Location = new Point(105, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(223, 28);
            comboBox2.TabIndex = 39;
            comboBox2.SelectedIndexChanged += SelectedValueChangedVehicle;
            comboBox2.SelectedValueChanged += SelectedValueChangedVehicle;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 69);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 38;
            label5.Text = "Vehicle";
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.DisplayMember = "Name";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(515, 64);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 28);
            comboBox3.TabIndex = 41;
            comboBox3.SelectedIndexChanged += SelectedValueChangedClassification;
            comboBox3.SelectedValueChanged += SelectedValueChangedClassification;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(396, 70);
            label15.Name = "label15";
            label15.Size = new Size(115, 23);
            label15.TabIndex = 40;
            label15.Text = "Classification";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 102);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 42;
            label3.Text = "Start";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(435, 101);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 43;
            label4.Text = "The End";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.LargeImageList = largeImageList;
            listView1.Location = new Point(28, 144);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(737, 228);
            listView1.SmallImageList = smallImageList;
            listView1.TabIndex = 44;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += SelectedValueChangedListCar;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Label";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "BusiCode";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Company";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Seats";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Classification";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Purchase date";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "kmTraveled";
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "hasInsurance";
            columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Vehicle type";
            columnHeader9.Width = 120;
            // 
            // largeImageList
            // 
            largeImageList.ColorDepth = ColorDepth.Depth8Bit;
            largeImageList.ImageStream = (ImageListStreamer)resources.GetObject("largeImageList.ImageStream");
            largeImageList.TransparentColor = Color.Transparent;
            largeImageList.Images.SetKeyName(0, "imageCar.ico");
            // 
            // smallImageList
            // 
            smallImageList.ColorDepth = ColorDepth.Depth8Bit;
            smallImageList.ImageStream = (ImageListStreamer)resources.GetObject("smallImageList.ImageStream");
            smallImageList.TransparentColor = Color.Transparent;
            smallImageList.Images.SetKeyName(0, "imageCar.png");
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(489, 378);
            button1.Name = "button1";
            button1.Size = new Size(276, 47);
            button1.TabIndex = 45;
            button1.Text = "Choose and Create Contract";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickChooseToCreateContract;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 402);
            label6.Name = "label6";
            label6.Size = new Size(81, 23);
            label6.TabIndex = 46;
            label6.Text = "Car Load";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(115, 402);
            label7.Name = "label7";
            label7.Size = new Size(0, 23);
            label7.TabIndex = 47;
            // 
            // errorProviderStartDate
            // 
            errorProviderStartDate.ContainerControl = this;
            // 
            // errorProviderEndDate
            // 
            errorProviderEndDate.ContainerControl = this;
            // 
            // errorProviderVehicles
            // 
            errorProviderVehicles.ContainerControl = this;
            // 
            // errorProviderClassification
            // 
            errorProviderClassification.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { carDetailsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            contextMenuStrip1.Click += ClickContextMS;
            // 
            // carDetailsToolStripMenuItem
            // 
            carDetailsToolStripMenuItem.Name = "carDetailsToolStripMenuItem";
            carDetailsToolStripMenuItem.Size = new Size(210, 24);
            carDetailsToolStripMenuItem.Text = "Car details";
            // 
            // DisplayRenterRentCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(label15);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayRenterRentCar";
            Text = "Renter Rent Car";
            Load += LoadForm;
            Click += ClickForm;
            ((System.ComponentModel.ISupportInitialize)errorProviderStartDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEndDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderVehicles).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderClassification).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label13;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox3;
        private Label label15;
        private Label label3;
        private Label label4;
        private ListView listView1;
        private Button button1;
        private ImageList largeImageList;
        private ImageList smallImageList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label6;
        private Label label7;
        private ErrorProvider errorProviderStartDate;
        private ErrorProvider errorProviderEndDate;
        private ErrorProvider errorProviderVehicles;
        private ErrorProvider errorProviderClassification;
        private ColumnHeader columnHeader9;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem carDetailsToolStripMenuItem;
    }
}