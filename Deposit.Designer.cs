namespace ATM
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            button1 = new Button();
            With = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(253, 246);
            button1.Name = "button1";
            button1.Size = new Size(99, 42);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // With
            // 
            With.AutoSize = true;
            With.BackColor = Color.Transparent;
            With.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            With.ForeColor = Color.DodgerBlue;
            With.Location = new Point(253, 173);
            With.Name = "With";
            With.Size = new Size(139, 42);
            With.TabIndex = 9;
            With.Text = "Deposit";
            With.UseVisualStyleBackColor = false;
            With.Click += With_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 108);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Amount";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(125, 105);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 7;
            label2.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(234, 20);
            label1.Name = "label1";
            label1.Size = new Size(192, 60);
            label1.TabIndex = 6;
            label1.Text = "Deposit\r\n";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(605, 334);
            Controls.Add(button1);
            Controls.Add(With);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Deposit";
            Text = "Deposit";
            Load += Deposit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button With;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}