namespace VehicleRentalServices
{
    partial class DisplayAboutVRS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAboutVRS));
            labelTutorialHeading = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTutorialHeading
            // 
            labelTutorialHeading.Anchor = AnchorStyles.Top;
            labelTutorialHeading.AutoSize = true;
            labelTutorialHeading.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelTutorialHeading.ForeColor = Color.Tomato;
            labelTutorialHeading.Location = new Point(19, 17);
            labelTutorialHeading.Name = "labelTutorialHeading";
            labelTutorialHeading.Size = new Size(209, 39);
            labelTutorialHeading.TabIndex = 0;
            labelTutorialHeading.Text = "About VRS";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(234, 31);
            label1.Name = "label1";
            label1.Size = new Size(323, 21);
            label1.TabIndex = 1;
            label1.Text = "was developed by Le Hong Phuc and Le Nhut Anh";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.IndianRed;
            groupBox1.Location = new Point(326, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 327);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introduction";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(274, 281);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 4;
            label2.Text = "~ by Le Hong Phuc";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.Location = new Point(22, 29);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(404, 275);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.imageAboutVRS;
            pictureBox1.Image = Properties.Resources.imageAboutVRS;
            pictureBox1.Location = new Point(12, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 327);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // DisplayAboutVRS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(labelTutorialHeading);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayAboutVRS";
            Text = "About VRS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTutorialHeading;
        private Label label1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}