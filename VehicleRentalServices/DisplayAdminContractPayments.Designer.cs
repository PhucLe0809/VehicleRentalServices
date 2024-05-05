namespace VehicleRentalServices
{
    partial class DisplayAdminContractPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAdminContractPayments));
            label1 = new Label();
            label2 = new Label();
            largeImageList = new ImageList(components);
            smallImageList = new ImageList(components);
            button1 = new Button();
            label18 = new Label();
            checkedListBox1 = new CheckedListBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label23 = new Label();
            label22 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            notifyIcon1 = new NotifyIcon(components);
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
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contractDetailsToolStripMenuItem = new ToolStripMenuItem();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(349, 39);
            label1.TabIndex = 0;
            label1.Text = "Contract Payments";
            label1.Click += ClickReset;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(379, 35);
            label2.Name = "label2";
            label2.Size = new Size(370, 21);
            label2.TabIndex = 1;
            label2.Text = "Select your contract and fill in your payment information";
            // 
            // largeImageList
            // 
            largeImageList.ColorDepth = ColorDepth.Depth8Bit;
            largeImageList.ImageStream = (ImageListStreamer)resources.GetObject("largeImageList.ImageStream");
            largeImageList.TransparentColor = Color.Transparent;
            largeImageList.Images.SetKeyName(0, "imageContract.ico");
            // 
            // smallImageList
            // 
            smallImageList.ColorDepth = ColorDepth.Depth8Bit;
            smallImageList.ImageStream = (ImageListStreamer)resources.GetObject("smallImageList.ImageStream");
            smallImageList.TransparentColor = Color.Transparent;
            smallImageList.Images.SetKeyName(0, "imageContract.ico");
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LimeGreen;
            button1.Location = new Point(698, 386);
            button1.Name = "button1";
            button1.Size = new Size(92, 29);
            button1.TabIndex = 3;
            button1.Text = "Choose";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickChoose;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(819, 72);
            label18.Name = "label18";
            label18.Size = new Size(166, 23);
            label18.TabIndex = 38;
            label18.Text = "Choose car damage";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(819, 98);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.ScrollAlwaysVisible = true;
            checkedListBox1.Size = new Size(233, 136);
            checkedListBox1.TabIndex = 37;
            checkedListBox1.MouseMove += ValueChangedCarDamage;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Location = new Point(156, 389);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 39;
            dateTimePicker1.ValueChanged += ValueChangedPaymentDate;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 393);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 40;
            label5.Text = "Payment date";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Green;
            label23.Location = new Point(945, 291);
            label23.Name = "label23";
            label23.Size = new Size(0, 23);
            label23.TabIndex = 49;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(820, 291);
            label22.Name = "label22";
            label22.Size = new Size(107, 23);
            label22.TabIndex = 48;
            label22.Text = "Prepayment";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(945, 242);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 54;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(820, 242);
            label6.Name = "label6";
            label6.Size = new Size(114, 23);
            label6.TabIndex = 53;
            label6.Text = "Damage cost";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(945, 267);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 56;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(820, 267);
            label7.Name = "label7";
            label7.Size = new Size(81, 23);
            label7.TabIndex = 55;
            label7.Text = "Late cost";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonShadow;
            button2.Location = new Point(819, 319);
            button2.Name = "button2";
            button2.Size = new Size(233, 56);
            button2.TabIndex = 57;
            button2.Text = "After-SettlementValue";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClickToContractPayment;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DodgerBlue;
            button3.Location = new Point(925, 387);
            button3.Name = "button3";
            button3.Size = new Size(127, 29);
            button3.TabIndex = 58;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ClickReset;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(820, 387);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(88, 28);
            comboBox1.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.LightCoral;
            label8.Location = new Point(156, 420);
            label8.Name = "label8";
            label8.Size = new Size(0, 17);
            label8.TabIndex = 60;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipTitle = "Payment success";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.LargeImageList = largeImageList;
            listView1.Location = new Point(24, 72);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(766, 303);
            listView1.SmallImageList = smallImageList;
            listView1.TabIndex = 61;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Start date";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "End date";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Renter";
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Pre-SettlementValue";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Prepayment";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Status";
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Vehicle Type";
            columnHeader8.Width = 140;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Label Car";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Driver";
            columnHeader10.Width = 160;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Assistant";
            columnHeader11.Width = 160;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Classification";
            columnHeader12.Width = 100;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { contractDetailsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(183, 28);
            contextMenuStrip1.Click += ClickContextMS;
            // 
            // contractDetailsToolStripMenuItem
            // 
            contractDetailsToolStripMenuItem.Name = "contractDetailsToolStripMenuItem";
            contractDetailsToolStripMenuItem.Size = new Size(182, 24);
            contractDetailsToolStripMenuItem.Text = "Contract details";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.LimeGreen;
            button4.Location = new Point(958, 27);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 62;
            button4.Text = "Paid";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ClickButtonPaid;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.IndianRed;
            button5.Location = new Point(858, 27);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 63;
            button5.Text = "Expired";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ClickButtonExpired;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Gold;
            button6.Location = new Point(758, 27);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 64;
            button6.Text = "Effected";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ClickButtonEffected;
            // 
            // DisplayAdminContractPayments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1082, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listView1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label18);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayAdminContractPayments";
            Text = "Admin Contract Payments";
            Click += ClickForm;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ImageList largeImageList;
        private ImageList smallImageList;
        private Button button1;
        private Label label18;
        private CheckedListBox checkedListBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label23;
        private Label label22;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label7;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private Label label8;
        private NotifyIcon notifyIcon1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem contractDetailsToolStripMenuItem;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}