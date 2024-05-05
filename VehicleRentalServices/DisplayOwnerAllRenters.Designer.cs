using System.Windows.Forms;

namespace VehicleRentalServices
{
    partial class DisplayOwnerAllRenters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayOwnerAllRenters));
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
            button1 = new Button();
            button5 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            renterDetailsToolStripMenuItem = new ToolStripMenuItem();
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
            label1.Size = new Size(213, 39);
            label1.TabIndex = 0;
            label1.Text = "All Renters";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(243, 32);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "in Business";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.RoyalBlue;
            button2.Location = new Point(615, 28);
            button2.Name = "button2";
            button2.Size = new Size(163, 29);
            button2.TabIndex = 2;
            button2.Text = "sort by Spending";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClickSortBySpending;
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
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.LargeImageList = largeImageList;
            listView1.Location = new Point(24, 63);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(754, 357);
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
            columnHeader6.Text = "nContracts";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Total spending";
            columnHeader7.Width = 140;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LimeGreen;
            button1.Location = new Point(447, 28);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 1;
            button1.Text = "sort by Name";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickSortByName;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonShadow;
            button5.Location = new Point(347, 28);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 0;
            button5.Text = "Total";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ClickButtonTotal;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { renterDetailsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            contextMenuStrip1.Click += ClickContextMS;
            // 
            // renterDetailsToolStripMenuItem
            // 
            renterDetailsToolStripMenuItem.Name = "renterDetailsToolStripMenuItem";
            renterDetailsToolStripMenuItem.Size = new Size(210, 24);
            renterDetailsToolStripMenuItem.Text = "Renter details";
            // 
            // DisplayOwnerAllRenters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
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
            Name = "DisplayOwnerAllRenters";
            Text = "Owner All Renter";
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
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem renterDetailsToolStripMenuItem;
    }
}