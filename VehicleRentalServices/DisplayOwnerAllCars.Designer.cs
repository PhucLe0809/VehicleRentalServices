namespace VehicleRentalServices
{
    partial class DisplayOwnerAllCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayOwnerAllCars));
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label15 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            carDetailsToolStripMenuItem = new ToolStripMenuItem();
            largeImageList = new ImageList(components);
            smallImageList = new ImageList(components);
            button1 = new Button();
            button5 = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            listView1 = new ListView();
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
            label1.Size = new Size(155, 39);
            label1.TabIndex = 0;
            label1.Text = "All Cars";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(196, 35);
            label2.Name = "label2";
            label2.Size = new Size(229, 21);
            label2.TabIndex = 1;
            label2.Text = "Please fill in the information below";
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
            comboBox2.SelectedIndexChanged += SelectedValueChangedVehicles;
            comboBox2.SelectedValueChanged += SelectedValueChangedVehicles;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 69);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 38;
            label5.Text = "Vehicles";
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { carDetailsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(149, 28);
            contextMenuStrip1.Click += ClickContextMS;
            // 
            // carDetailsToolStripMenuItem
            // 
            carDetailsToolStripMenuItem.Name = "carDetailsToolStripMenuItem";
            carDetailsToolStripMenuItem.Size = new Size(148, 24);
            carDetailsToolStripMenuItem.Text = "Car details";
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
            smallImageList.Images.SetKeyName(0, "imageCar.ico");
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonShadow;
            button1.Location = new Point(471, 27);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Total";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickTotal;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.LimeGreen;
            button5.Location = new Point(571, 27);
            button5.Name = "button5";
            button5.Size = new Size(194, 29);
            button5.TabIndex = 48;
            button5.Text = "sort by km Traveled";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ClickSortByKm;
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
            columnHeader9.Text = "Vehicles type";
            columnHeader9.Width = 120;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.LargeImageList = largeImageList;
            listView1.Location = new Point(28, 95);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(737, 329);
            listView1.SmallImageList = smallImageList;
            listView1.TabIndex = 44;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // DisplayOwnerAllCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(comboBox3);
            Controls.Add(label15);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayOwnerAllCars";
            Text = "Owner All Cars";
            Click += ClickForm;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox3;
        private Label label15;
        private Button button1;
        private ImageList largeImageList;
        private ImageList smallImageList;
        private Button button5;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem carDetailsToolStripMenuItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ListView listView1;
    }
}