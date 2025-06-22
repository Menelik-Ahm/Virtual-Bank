using System.Numerics;

namespace ATM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(367, 224);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '4';
            textBox2.PlaceholderText = "Enter PIN";
            textBox2.Size = new Size(224, 39);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(367, 160);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Card Number";
            textBox1.Size = new Size(224, 39);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.LinkColor = Color.FromArgb(192, 0, 192);
            linkLabel1.Location = new Point(367, 358);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 32);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(275, 225);
            label2.Name = "label2";
            label2.Size = new Size(68, 38);
            label2.TabIndex = 1;
            label2.Text = "PIN";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(367, 287);
            button2.Name = "button2";
            button2.Size = new Size(118, 48);
            button2.TabIndex = 17;
            button2.Text = "Log in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(158, 158);
            label1.Name = "label1";
            label1.Size = new Size(203, 38);
            label1.TabIndex = 0;
            label1.Text = "Card Number\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(312, 71);
            label3.Name = "label3";
            label3.Size = new Size(227, 60);
            label3.TabIndex = 4;
            label3.Text = "Welcome";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(754, 424);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button button2;
        private Label label1;
        private Label label3;
    }
}