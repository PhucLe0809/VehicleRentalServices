namespace VehicleRentalServices
{
    partial class DisplayAssistantSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAssistantSalary));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            CMSDetails = new ContextMenuStrip(components);
            detailsToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label38 = new Label();
            label37 = new Label();
            label36 = new Label();
            label35 = new Label();
            label34 = new Label();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label20 = new Label();
            label19 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            CMSDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.Size = new Size(299, 39);
            label1.TabIndex = 0;
            label1.Text = "Assistant Salary";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(329, 35);
            label2.Name = "label2";
            label2.Size = new Size(401, 21);
            label2.TabIndex = 1;
            label2.Text = "Salary is calculated according to the company's current policy";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightCoral;
            button1.Location = new Point(44, 357);
            button1.Name = "button1";
            button1.Size = new Size(183, 38);
            button1.TabIndex = 0;
            button1.Text = "Salary Policy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickSalaryPolicy;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 75);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 3;
            label3.Text = "Assistant";
            // 
            // comboBox1
            // 
            comboBox1.ContextMenuStrip = CMSDetails;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(114, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // CMSDetails
            // 
            CMSDetails.ImageScalingSize = new Size(20, 20);
            CMSDetails.Items.AddRange(new ToolStripItem[] { detailsToolStripMenuItem });
            CMSDetails.Name = "CMSDetails";
            CMSDetails.Size = new Size(125, 28);
            CMSDetails.Click += CMSDetailsClick;
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(124, 24);
            detailsToolStripMenuItem.Text = "Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(300, 75);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 5;
            label4.Text = "Published";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(394, 70);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 28);
            comboBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.RoyalBlue;
            button2.Location = new Point(603, 63);
            button2.Name = "button2";
            button2.Size = new Size(166, 38);
            button2.TabIndex = 7;
            button2.Text = "Expected salary";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imageSalary;
            pictureBox1.Location = new Point(44, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label38.ForeColor = SystemColors.ControlText;
            label38.Location = new Point(486, 393);
            label38.Name = "label38";
            label38.Size = new Size(120, 23);
            label38.TabIndex = 137;
            label38.Text = "Informationss";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label37.ForeColor = SystemColors.ControlText;
            label37.Location = new Point(486, 370);
            label37.Name = "label37";
            label37.Size = new Size(120, 23);
            label37.TabIndex = 136;
            label37.Text = "Informationss";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label36.ForeColor = SystemColors.ControlText;
            label36.Location = new Point(486, 342);
            label36.Name = "label36";
            label36.Size = new Size(120, 23);
            label36.TabIndex = 135;
            label36.Text = "Informationss";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label35.ForeColor = SystemColors.ControlText;
            label35.Location = new Point(486, 296);
            label35.Name = "label35";
            label35.Size = new Size(120, 23);
            label35.TabIndex = 134;
            label35.Text = "Informationss";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label34.ForeColor = SystemColors.ControlText;
            label34.Location = new Point(486, 272);
            label34.Name = "label34";
            label34.Size = new Size(120, 23);
            label34.TabIndex = 133;
            label34.Text = "Informationss";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label33.ForeColor = SystemColors.ControlText;
            label33.Location = new Point(486, 233);
            label33.Name = "label33";
            label33.Size = new Size(120, 23);
            label33.TabIndex = 132;
            label33.Text = "Informationss";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label32.ForeColor = SystemColors.ControlText;
            label32.Location = new Point(486, 210);
            label32.Name = "label32";
            label32.Size = new Size(120, 23);
            label32.TabIndex = 131;
            label32.Text = "Informationss";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = SystemColors.ControlText;
            label31.Location = new Point(486, 172);
            label31.Name = "label31";
            label31.Size = new Size(120, 23);
            label31.TabIndex = 130;
            label31.Text = "Informationss";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label30.ForeColor = Color.Tomato;
            label30.Location = new Point(486, 149);
            label30.Name = "label30";
            label30.Size = new Size(130, 20);
            label30.TabIndex = 129;
            label30.Text = "Informationss";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = SystemColors.Highlight;
            label27.Location = new Point(300, 322);
            label27.Name = "label27";
            label27.Size = new Size(423, 20);
            label27.TabIndex = 128;
            label27.Text = "---------------------------------------------------------------------";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = SystemColors.ButtonShadow;
            label26.Location = new Point(300, 370);
            label26.Name = "label26";
            label26.Size = new Size(132, 23);
            label26.TabIndex = 127;
            label26.Text = "Years of service";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = SystemColors.ButtonShadow;
            label25.Location = new Point(300, 342);
            label25.Name = "label25";
            label25.Size = new Size(102, 23);
            label25.TabIndex = 126;
            label25.Text = "Basic salary";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ButtonShadow;
            label24.Location = new Point(300, 295);
            label24.Name = "label24";
            label24.Size = new Size(79, 23);
            label24.TabIndex = 125;
            label24.Text = "Avg rate";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ButtonShadow;
            label20.Location = new Point(300, 272);
            label20.Name = "label20";
            label20.Size = new Size(159, 23);
            label20.TabIndex = 124;
            label20.Text = "% Feedback bonus";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.Highlight;
            label19.Location = new Point(300, 256);
            label19.Name = "label19";
            label19.Size = new Size(423, 20);
            label19.TabIndex = 123;
            label19.Text = "---------------------------------------------------------------------";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonShadow;
            label17.Location = new Point(300, 233);
            label17.Name = "label17";
            label17.Size = new Size(108, 23);
            label17.TabIndex = 122;
            label17.Text = "Total CValue";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonShadow;
            label16.Location = new Point(300, 210);
            label16.Name = "label16";
            label16.Size = new Size(152, 23);
            label16.TabIndex = 121;
            label16.Text = "% Contract bonus";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.Highlight;
            label15.Location = new Point(300, 190);
            label15.Name = "label15";
            label15.Size = new Size(423, 20);
            label15.TabIndex = 120;
            label15.Text = "---------------------------------------------------------------------";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonShadow;
            label14.Location = new Point(300, 167);
            label14.Name = "label14";
            label14.Size = new Size(91, 23);
            label14.TabIndex = 119;
            label14.Text = "Joint date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonShadow;
            label13.Location = new Point(300, 144);
            label13.Name = "label13";
            label13.Size = new Size(88, 23);
            label13.TabIndex = 118;
            label13.Text = "Full name";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(300, 393);
            label5.Name = "label5";
            label5.Size = new Size(135, 23);
            label5.TabIndex = 117;
            label5.Text = "Expected salary";
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(272, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 319);
            groupBox1.TabIndex = 138;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expected Salary";
            // 
            // DisplayAssistantSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label38);
            Controls.Add(label37);
            Controls.Add(label36);
            Controls.Add(label35);
            Controls.Add(label34);
            Controls.Add(label33);
            Controls.Add(label32);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayAssistantSalary";
            Text = "Assistant Salary";
            CMSDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label20;
        private Label label19;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label5;
        private GroupBox groupBox1;
        private ContextMenuStrip CMSDetails;
        private ToolStripMenuItem detailsToolStripMenuItem;
    }
}