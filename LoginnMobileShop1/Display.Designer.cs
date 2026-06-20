namespace LoginnMobileShop1
{
    partial class Display
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Picture1;
            pictureBox1.Location = new Point(115, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(887, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 49);
            label2.TabIndex = 39;
            label2.Text = "x";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(193, 79);
            label1.Name = "label1";
            label1.Size = new Size(578, 47);
            label1.TabIndex = 40;
            label1.Text = "Mobile Management System";
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.PowderBlue;
            button3.Location = new Point(376, 176);
            button3.Name = "button3";
            button3.Size = new Size(170, 50);
            button3.TabIndex = 41;
            button3.Text = "Mobile";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.PowderBlue;
            button2.Location = new Point(376, 254);
            button2.Name = "button2";
            button2.Size = new Size(170, 50);
            button2.TabIndex = 42;
            button2.Text = "Accessories";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Display
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(930, 390);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Display";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
    }
}