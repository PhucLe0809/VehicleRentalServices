using System.Windows.Forms;

namespace VehicleRentalServices
{
    partial class DisplayOwnerAllEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayOwnerAllEmployees));
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            largeImageList = new ImageList(components);
            smallImageList = new ImageList(components);
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
            button1 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            employeeDetailsToolStripMenuItem = new ToolStripMenuItem();
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
            label1.Size = new Size(262, 39);
            label1.TabIndex = 0;
            label1.Text = "All Employees";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(292, 35);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "in Business";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Gold;
            button2.Location = new Point(676, 28);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Assistant";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClickButtonAssistant;
            // 
            // largeImageList
            // 
            largeImageList.ColorDepth = ColorDepth.Depth16Bit;
            largeImageList.ImageStream = (ImageListStreamer)resources.GetObject("largeImageList.ImageStream");
            largeImageList.TransparentColor = Color.Transparent;
            largeImageList.Images.SetKeyName(0, "imageHuman.ico");
            // 
            // smallImageList
            // 
            smallImageList.ColorDepth = ColorDepth.Depth16Bit;
            smallImageList.ImageStream = (ImageListStreamer)resources.GetObject("smallImageList.ImageStream");
            smallImageList.TransparentColor = Color.Transparent;
            smallImageList.Images.SetKeyName(0, "imageHuman.ico");
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.LargeImageList = largeImageList;
            listView1.Location = new Point(33, 63);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(737, 340);
            listView1.SmallImageList = smallImageList;
            listView1.TabIndex = 47;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ID";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Birthday";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "PhoneNum";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Joint date";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Avg rate";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "nContracts";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "TotalVContracts";
            columnHeader8.Width = 140;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Position";
            columnHeader9.Width = 80;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(576, 28);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Driver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickButtonDriver;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonShadow;
            button5.Location = new Point(476, 28);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 0;
            button5.Text = "Total";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ClickButtonTotal;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.LimeGreen;
            button3.Location = new Point(269, 409);
            button3.Name = "button3";
            button3.Size = new Size(163, 29);
            button3.TabIndex = 48;
            button3.Text = "sort by Name";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ClickSortByName;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.RoyalBlue;
            button4.Location = new Point(438, 409);
            button4.Name = "button4";
            button4.Size = new Size(163, 29);
            button4.TabIndex = 49;
            button4.Text = "sort by VContracts";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ClickSortByContractValue;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Tomato;
            button6.Location = new Point(607, 409);
            button6.Name = "button6";
            button6.Size = new Size(163, 29);
            button6.TabIndex = 50;
            button6.Text = "sort by AvgRate";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ClickSortByAvgRate;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { employeeDetailsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            contextMenuStrip1.Click += ClickContextMS;
            // 
            // employeeDetailsToolStripMenuItem
            // 
            employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            employeeDetailsToolStripMenuItem.Size = new Size(210, 24);
            employeeDetailsToolStripMenuItem.Text = "Employee details";
            // 
            // DisplayOwnerAllEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayOwnerAllEmployees";
            Text = "Owner All Employee";
            Click += ClickForm;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button2;
        private ImageList largeImageList;
        private ImageList smallImageList;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button button1;
        private Button button5;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Button button3;
        private Button button4;
        private Button button6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem employeeDetailsToolStripMenuItem;
    }
}