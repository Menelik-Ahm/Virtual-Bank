namespace ATM
{
    partial class PIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PIN));
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(244, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 31);
            textBox3.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 31);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(211, 197);
            button1.Name = "button1";
            button1.Size = new Size(227, 40);
            button1.TabIndex = 12;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(129, 94);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 10;
            label2.Text = "Old PIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(394, 60);
            label1.TabIndex = 9;
            label1.Text = "Change Your PIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(129, 134);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 16;
            label4.Text = "New PIN";
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(211, 258);
            button3.Name = "button3";
            button3.Size = new Size(161, 42);
            button3.TabIndex = 17;
            button3.Text = "Never Mind";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // PIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(551, 332);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PIN";
            Text = "PIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button button3;
    }
}