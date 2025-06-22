namespace ATM
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(208, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 60);
            label1.TabIndex = 0;
            label1.Text = "Transfer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(38, 90);
            label2.Name = "label2";
            label2.Size = new Size(213, 32);
            label2.TabIndex = 1;
            label2.Text = "Account Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(64, 175);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 2;
            label3.Text = "Receiver Name";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(239, 237);
            button1.Name = "button1";
            button1.Size = new Size(227, 40);
            button1.TabIndex = 3;
            button1.Text = "Transfer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(257, 178);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "please wait . . . ";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(194, 31);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(463, 90);
            button2.Name = "button2";
            button2.Size = new Size(156, 40);
            button2.TabIndex = 6;
            button2.Text = "Get Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(257, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 31);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(96, 130);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 7;
            label4.Text = "Amount";
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(463, 305);
            button3.Name = "button3";
            button3.Size = new Size(99, 42);
            button3.TabIndex = 12;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(630, 353);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Transfer";
            Text = "Transfer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Label label4;
        private Button button3;
    }
}