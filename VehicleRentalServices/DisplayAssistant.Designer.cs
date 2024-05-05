namespace VehicleRentalServices
{
    partial class DisplayAssistant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAssistant));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(49, 21);
            label1.Name = "label1";
            label1.Size = new Size(179, 39);
            label1.TabIndex = 1;
            label1.Text = "Assistant";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(49, 62);
            label2.Name = "label2";
            label2.Size = new Size(297, 21);
            label2.TabIndex = 5;
            label2.Text = "Customer satisfaction reflects your capabilities";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.giftAssistant;
            pictureBox1.Location = new Point(480, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(49, 201);
            button2.Name = "button2";
            button2.Size = new Size(162, 76);
            button2.TabIndex = 1;
            button2.Text = "Contract History";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ClickContractHistory;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(49, 298);
            button3.Name = "button3";
            button3.Size = new Size(162, 76);
            button3.TabIndex = 2;
            button3.Text = "Feedback History";
            button3.UseVisualStyleBackColor = false;
            button3.Click += ClickFeedbackHistory;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.BackColor = SystemColors.Control;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(49, 105);
            button4.Name = "button4";
            button4.Size = new Size(162, 76);
            button4.TabIndex = 0;
            button4.Text = "Salary";
            button4.UseVisualStyleBackColor = false;
            button4.Click += ClickSalary;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(673, 33);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 7;
            label3.Text = "Register";
            label3.Click += ClickRegister;
            // 
            // DisplayAssistant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayAssistant";
            Text = "Display Assistant";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
    }
}