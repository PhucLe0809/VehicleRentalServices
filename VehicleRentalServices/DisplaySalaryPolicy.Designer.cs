namespace VehicleRentalServices
{
    partial class DisplaySalaryPolicy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplaySalaryPolicy));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            emploToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(127, 21);
            label1.Name = "label1";
            label1.Size = new Size(243, 39);
            label1.TabIndex = 0;
            label1.Text = "Salary Policy";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(379, 35);
            label2.Name = "label2";
            label2.Size = new Size(229, 21);
            label2.TabIndex = 1;
            label2.Text = "Please fill in the information below";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imageSalaryDriver;
            pictureBox1.Location = new Point(12, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(953, 401);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.IndianRed;
            button2.Location = new Point(135, 72);
            button2.Name = "button2";
            button2.Size = new Size(171, 35);
            button2.TabIndex = 4;
            button2.Text = "Driver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClickDriver;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.RoyalBlue;
            button3.Location = new Point(312, 72);
            button3.Name = "button3";
            button3.Size = new Size(171, 35);
            button3.TabIndex = 5;
            button3.Text = "Assistant";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ClickAssistant;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.ContextMenuStrip = contextMenuStrip1;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(222, 529);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += SelectedIndexChangedLabelCar;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(401, 534);
            label4.Name = "label4";
            label4.Size = new Size(159, 23);
            label4.TabIndex = 9;
            label4.Text = "is holding position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(745, 534);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 11;
            label3.Text = "at the company";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Tomato;
            textBox1.Location = new Point(566, 527);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(173, 30);
            textBox1.TabIndex = 12;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(128, 534);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 13;
            label5.Text = "Employee";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { emploToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            contextMenuStrip1.Click += ClickContextMS;
            // 
            // emploToolStripMenuItem
            // 
            emploToolStripMenuItem.Name = "emploToolStripMenuItem";
            emploToolStripMenuItem.Size = new Size(210, 24);
            emploToolStripMenuItem.Text = "Employee details";
            // 
            // DisplaySalaryPolicy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1006, 612);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplaySalaryPolicy";
            Text = "Salary Policy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem emploToolStripMenuItem;
    }
}