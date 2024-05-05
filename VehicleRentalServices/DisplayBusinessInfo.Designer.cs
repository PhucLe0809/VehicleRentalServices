namespace VehicleRentalServices
{
    partial class DisplayBusinessInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayBusinessInfo));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label31 = new Label();
            label30 = new Label();
            label14 = new Label();
            label13 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
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
            label1.Size = new Size(245, 39);
            label1.TabIndex = 0;
            label1.Text = "Business Info";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(275, 35);
            label2.Name = "label2";
            label2.Size = new Size(316, 21);
            label2.TabIndex = 1;
            label2.Text = "You can see information about the business below";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(368, 83);
            button1.Name = "button1";
            button1.Size = new Size(162, 76);
            button1.TabIndex = 0;
            button1.Text = "Rental Policy";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ClickRentalPolicy;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(368, 177);
            button2.Name = "button2";
            button2.Size = new Size(162, 76);
            button2.TabIndex = 1;
            button2.Text = "Salary Policy";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ClickSalaryPolicy;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label31.ForeColor = Color.LimeGreen;
            label31.Location = new Point(242, 63);
            label31.Name = "label31";
            label31.Size = new Size(121, 20);
            label31.TabIndex = 130;
            label31.Text = "Informationss";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label30.ForeColor = Color.Tomato;
            label30.Location = new Point(242, 40);
            label30.Name = "label30";
            label30.Size = new Size(121, 20);
            label30.TabIndex = 129;
            label30.Text = "Informationss";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(364, 333);
            label14.Name = "label14";
            label14.Size = new Size(198, 23);
            label14.TabIndex = 119;
            label14.Text = "Monthly salary expense";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(364, 310);
            label13.Name = "label13";
            label13.Size = new Size(145, 23);
            label13.TabIndex = 118;
            label13.Text = "Monthly revenue";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label31);
            groupBox1.Controls.Add(label30);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(340, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 106);
            groupBox1.TabIndex = 138;
            groupBox1.TabStop = false;
            groupBox1.Text = "Business Infomations";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.giftBusinessInfo;
            pictureBox1.Location = new Point(31, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 139;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(47, 399);
            label3.Name = "label3";
            label3.Size = new Size(387, 19);
            label3.TabIndex = 140;
            label3.Text = "Total monthly salary expense is calculated up to date ";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.LightCoral;
            button3.Location = new Point(582, 130);
            button3.Name = "button3";
            button3.Size = new Size(162, 29);
            button3.TabIndex = 4;
            button3.Text = "Contracts";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ClickContracts;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.LightCoral;
            button4.Location = new Point(582, 177);
            button4.Name = "button4";
            button4.Size = new Size(162, 29);
            button4.TabIndex = 5;
            button4.Text = "Cars";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ClickCars;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.LightCoral;
            button6.Location = new Point(582, 83);
            button6.Name = "button6";
            button6.Size = new Size(162, 29);
            button6.TabIndex = 3;
            button6.Text = "Renters";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ClickRenters;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.LightCoral;
            button5.Location = new Point(582, 224);
            button5.Name = "button5";
            button5.Size = new Size(162, 29);
            button5.TabIndex = 6;
            button5.Text = "Employees";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ClickEmployees;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(651, 33);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 141;
            label4.Text = "Feedbacks";
            label4.Click += ClickFeedbacks;
            // 
            // DisplayBusinessInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayBusinessInfo";
            Text = "Business Info";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label31;
        private Label label30;
        private Label label14;
        private Label label13;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private Label label4;
    }
}