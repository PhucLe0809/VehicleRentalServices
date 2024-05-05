namespace VehicleRentalServices
{
    partial class DisplayDriverRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayDriverRegister));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            button2 = new Button();
            label14 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label16 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
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
            label1.Size = new Size(131, 39);
            label1.TabIndex = 1;
            label1.Text = "Driver";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(158, 35);
            label2.Name = "label2";
            label2.Size = new Size(229, 21);
            label2.TabIndex = 2;
            label2.Text = "Please fill in the information below";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 77);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 3;
            label3.Text = "Full name";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(154, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 4;
            textBox1.MouseClick += MouseClickFullName;
            textBox1.TextChanged += TextChangedFullName;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 132);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 5;
            label4.Text = "Citizen code";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Location = new Point(154, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 6;
            textBox2.MouseClick += MouseClickCitizenCode;
            textBox2.TextChanged += TextChangedCitizenCode;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 190);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 7;
            label5.Text = "Birthday";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Location = new Point(154, 186);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += TextChangedBirthday;
            dateTimePicker1.MouseDown += MouseClickBirthday;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(21, 245);
            label6.Name = "label6";
            label6.Size = new Size(127, 23);
            label6.TabIndex = 9;
            label6.Text = "Phone number";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.Location = new Point(154, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 10;
            textBox3.MouseClick += MouseClickPhoneNumber;
            textBox3.TextChanged += TextChangedPhoneNumber;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(466, 312);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 11;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickRegister;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(154, 103);
            label10.Name = "label10";
            label10.Size = new Size(0, 17);
            label10.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(154, 158);
            label11.Name = "label11";
            label11.Size = new Size(0, 17);
            label11.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(154, 216);
            label12.Name = "label12";
            label12.Size = new Size(0, 17);
            label12.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(154, 271);
            label13.Name = "label13";
            label13.Size = new Size(0, 17);
            label13.TabIndex = 18;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(635, 312);
            button2.Name = "button2";
            button2.Size = new Size(127, 29);
            button2.TabIndex = 19;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClickReset;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(21, 301);
            label14.Name = "label14";
            label14.Size = new Size(91, 23);
            label14.TabIndex = 21;
            label14.Text = "Joint date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top;
            dateTimePicker2.Location = new Point(154, 297);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 22;
            dateTimePicker2.ValueChanged += TextChangedJointdate;
            dateTimePicker2.MouseDown += MouseClickJointdate;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label16.Location = new Point(156, 327);
            label16.Name = "label16";
            label16.Size = new Size(0, 17);
            label16.TabIndex = 25;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imageDriverRegister;
            pictureBox1.Location = new Point(466, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 276);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonShadow;
            groupBox1.Location = new Point(466, 347);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 85);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(64, 52);
            label9.Name = "label9";
            label9.Size = new Size(0, 23);
            label9.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(14, 29);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 52);
            label8.Name = "label8";
            label8.Size = new Size(0, 23);
            label8.TabIndex = 13;
            // 
            // DisplayDriverRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label16);
            Controls.Add(dateTimePicker2);
            Controls.Add(label14);
            Controls.Add(button2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayDriverRegister";
            Text = "Driver Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox textBox3;
        private Button button1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button2;
        private Label label14;
        private DateTimePicker dateTimePicker2;
        private Label label16;
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label9;
        private Label label7;
        private Label label8;
    }
}