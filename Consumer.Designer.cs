namespace WaterConsumptionInformationSystem
{
    partial class Consumer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consumer));
            pictureBox1 = new PictureBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(404, 158);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221, 23);
            textBox6.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 140);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 8;
            label2.Text = "Consumer's Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 219);
            label1.Name = "label1";
            label1.Size = new Size(246, 24);
            label1.TabIndex = 9;
            label1.Text = "Lopchan's Water Suppliers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 54);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 10;
            label3.Text = "Consumers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 54);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "Consumers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(558, 54);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 12;
            label5.Text = "Consumers";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(477, 54);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 13;
            label6.Text = "Consumers";
            label6.Click += this.label6_Click;
            // 
            // Consumer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(pictureBox1);
            Name = "Consumer";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox6;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}