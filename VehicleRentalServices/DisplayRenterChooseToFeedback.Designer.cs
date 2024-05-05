namespace VehicleRentalServices
{
    partial class DisplayRenterChooseToFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayRenterChooseToFeedback));
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            CMSRecipient = new ContextMenuStrip(components);
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            label17 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            label9 = new Label();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            CMSRecipient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            label1.Size = new Size(180, 39);
            label1.TabIndex = 0;
            label1.Text = "Feedback";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(210, 35);
            label2.Name = "label2";
            label2.Size = new Size(229, 21);
            label2.TabIndex = 1;
            label2.Text = "Please fill in the information below";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += ForFrom;
            comboBox1.SelectedValueChanged += ForFrom;
            comboBox1.MouseClick += MouseClickForFrom;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 78);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 3;
            label3.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(268, 78);
            label4.Name = "label4";
            label4.Size = new Size(28, 23);
            label4.TabIndex = 4;
            label4.Text = "To";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(488, 78);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 6;
            label5.Text = "Category";
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { ECategory.ServiceAttitude, ECategory.VehicleQuality, ECategory.CommitmentInContract });
            comboBox3.Location = new Point(578, 73);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(187, 28);
            comboBox3.TabIndex = 7;
            comboBox3.SelectedIndexChanged += ForCategory;
            comboBox3.SelectedValueChanged += ForCategory;
            comboBox3.MouseClick += MouseClickForCategory;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.ContextMenuStrip = CMSRecipient;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(302, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 28);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += ForTo;
            comboBox2.SelectedValueChanged += ForTo;
            comboBox2.MouseClick += MouseClickForTo;
            // 
            // CMSRecipient
            // 
            CMSRecipient.ImageScalingSize = new Size(20, 20);
            CMSRecipient.Items.AddRange(new ToolStripItem[] { detailsToolStripMenuItem });
            CMSRecipient.Name = "CMSRecipient";
            CMSRecipient.Size = new Size(125, 28);
            CMSRecipient.Click += CMSRecipientClick;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.ForeColor = SystemColors.Highlight;
            richTextBox1.Location = new Point(24, 133);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(741, 190);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imageStar;
            pictureBox1.Location = new Point(33, 342);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ClickPictureBox1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.imageStar;
            pictureBox2.Location = new Point(91, 342);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += ClickPictureBox2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.imageStar;
            pictureBox3.Location = new Point(147, 342);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += ClickPictureBox3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.imageStar;
            pictureBox4.Location = new Point(203, 342);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += ClickPictureBox4;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.imageStar;
            pictureBox5.Location = new Point(259, 342);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            pictureBox5.Click += ClickPictureBox5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(619, 353);
            button1.Name = "button1";
            button1.Size = new Size(146, 50);
            button1.TabIndex = 15;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickSend;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label17.ForeColor = Color.IndianRed;
            label17.Location = new Point(83, 104);
            label17.Name = "label17";
            label17.Size = new Size(0, 17);
            label17.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(308, 102);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(404, 406);
            label7.Name = "label7";
            label7.Size = new Size(361, 25);
            label7.TabIndex = 29;
            label7.Text = "~ We are committed to protecting your information";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(579, 105);
            label8.Name = "label8";
            label8.Size = new Size(0, 17);
            label8.TabIndex = 30;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(44, 395);
            label9.Name = "label9";
            label9.Size = new Size(0, 17);
            label9.TabIndex = 31;
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(124, 24);
            detailsToolStripMenuItem.Text = "Details";
            // 
            // DisplayRenterChooseToFeedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label17);
            Controls.Add(button1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayRenterChooseToFeedback";
            Text = "Renter Send Feedback";
            CMSRecipient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button1;
        private Label label17;
        private Label label6;
        private Label label7;
        private Label label8;
        private NotifyIcon notifyIcon1;
        private Label label9;
        private ContextMenuStrip CMSRecipient;
        private ToolStripMenuItem detailsToolStripMenuItem;
    }
}