namespace ATM
{
    partial class ATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM));
            Title = new Label();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button8 = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.MintCream;
            Title.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Teal;
            Title.Image = (Image)resources.GetObject("Title.Image");
            Title.Location = new Point(186, 9);
            Title.Name = "Title";
            Title.Size = new Size(0, 60);
            Title.TabIndex = 0;
            Title.Click += Title_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(98, 44);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(264, 44);
            label2.Name = "label2";
            label2.Size = new Size(295, 60);
            label2.TabIndex = 2;
            label2.Text = "Virtual Bank";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 10;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(170, 166);
            button2.Name = "button2";
            button2.Size = new Size(168, 42);
            button2.TabIndex = 4;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 10;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button3.ForeColor = Color.DodgerBlue;
            button3.Location = new Point(170, 258);
            button3.Name = "button3";
            button3.Size = new Size(168, 42);
            button3.TabIndex = 5;
            button3.Text = "Deposit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.White;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 10;
            button4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button4.ForeColor = Color.DodgerBlue;
            button4.Location = new Point(170, 353);
            button4.Name = "button4";
            button4.Size = new Size(168, 42);
            button4.TabIndex = 6;
            button4.Text = "Transfer";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.White;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.BorderSize = 10;
            button5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button5.ForeColor = Color.DodgerBlue;
            button5.Location = new Point(440, 166);
            button5.Name = "button5";
            button5.Size = new Size(173, 42);
            button5.TabIndex = 7;
            button5.Text = "Transactions";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.BackColor = Color.White;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.BorderSize = 10;
            button6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button6.ForeColor = Color.DodgerBlue;
            button6.Location = new Point(440, 258);
            button6.Name = "button6";
            button6.Size = new Size(173, 42);
            button6.TabIndex = 8;
            button6.Text = "Balance";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.BackColor = Color.White;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 10;
            button7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button7.ForeColor = Color.DodgerBlue;
            button7.Location = new Point(440, 353);
            button7.Name = "button7";
            button7.Size = new Size(173, 42);
            button7.TabIndex = 9;
            button7.Text = "Change Pin";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(335, 110);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(301, 418);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(77, 25);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log Out";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.BackColor = Color.Transparent;
            button8.Location = new Point(440, 418);
            button8.Name = "button8";
            button8.Size = new Size(97, 35);
            button8.TabIndex = 13;
            button8.Text = "Exit";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // ATM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(753, 461);
            Controls.Add(button8);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ATM";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "ATM";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button button8;
    }
}
