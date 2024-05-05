﻿using System.Windows.Forms;

namespace VehicleRentalServices
{
    partial class DisplayOwnerAllContracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayOwnerAllContracts));
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contractToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
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
            label1.Size = new Size(248, 39);
            label1.TabIndex = 0;
            label1.Text = "All Contracts";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(33, 60);
            label2.Name = "label2";
            label2.Size = new Size(285, 21);
            label2.TabIndex = 1;
            label2.Text = "Please fill in your criteria in the fields below";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Gold;
            button2.Location = new Point(476, 60);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Effected";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClickButtonEffected;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.IndianRed;
            button3.Location = new Point(576, 60);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Expired";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ClickButtonExpired;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.LimeGreen;
            button4.Location = new Point(676, 60);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Paid";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ClickButtonPaid;
            // 
            // largeImageList
            // 
            largeImageList.ColorDepth = ColorDepth.Depth16Bit;
            largeImageList.ImageStream = (ImageListStreamer)resources.GetObject("largeImageList.ImageStream");
            largeImageList.TransparentColor = Color.Transparent;
            largeImageList.Images.SetKeyName(0, "imageContract.ico");
            // 
            // smallImageList
            // 
            smallImageList.ColorDepth = ColorDepth.Depth16Bit;
            smallImageList.ImageStream = (ImageListStreamer)resources.GetObject("smallImageList.ImageStream");
            smallImageList.TransparentColor = Color.Transparent;
            smallImageList.Images.SetKeyName(0, "imageContract.ico");
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.LargeImageList = largeImageList;
            listView1.Location = new Point(33, 95);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(737, 324);
            listView1.SmallImageList = smallImageList;
            listView1.TabIndex = 47;
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
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { contractToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(183, 28);
            contextMenuStrip1.Click += ClickContextMS;
            // 
            // contractToolStripMenuItem
            // 
            contractToolStripMenuItem.Name = "contractToolStripMenuItem";
            contractToolStripMenuItem.Size = new Size(182, 24);
            contractToolStripMenuItem.Text = "Contract details";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonShadow;
            button1.Location = new Point(376, 60);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Total";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickButtonTotal;
            // 
            // DisplayOwnerAllContracts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayOwnerAllContracts";
            Text = "Owner All Contract";
            Click += ClickForm;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
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
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem contractToolStripMenuItem;
    }
}