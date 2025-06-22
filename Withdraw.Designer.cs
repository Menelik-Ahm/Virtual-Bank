namespace ATM
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            With = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(218, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 60);
            label1.TabIndex = 0;
            label1.Text = "Withdraw";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(110, 105);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 108);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Amount";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // With
            // 
            With.AutoSize = true;
            With.BackColor = Color.Transparent;
            With.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            With.ForeColor = Color.DodgerBlue;
            With.Location = new Point(238, 173);
            With.Name = "With";
            With.Size = new Size(139, 42);
            With.TabIndex = 3;
            With.Text = "Withdraw";
            With.UseVisualStyleBackColor = false;
            With.Click += With_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(238, 257);
            button1.Name = "button1";
            button1.Size = new Size(99, 42);
            button1.TabIndex = 5;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Withdraw
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(588, 334);
            Controls.Add(button1);
            Controls.Add(With);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Withdraw";
            Text = "Withdraw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button With;
        private Button button1;
    }
}