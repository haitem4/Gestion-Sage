namespace WinFormsApp1
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
            Fermer_btn = new Button();
            Connect_btn = new Button();
            Verifier_btn = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Password_txt = new TextBox();
            User_txt = new TextBox();
            Database_txt = new TextBox();
            Server_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // Fermer_btn
            // 
            Fermer_btn.BackColor = SystemColors.MenuBar;
            Fermer_btn.ForeColor = SystemColors.ControlText;
            Fermer_btn.Location = new Point(361, 399);
            Fermer_btn.Name = "Fermer_btn";
            Fermer_btn.Size = new Size(128, 29);
            Fermer_btn.TabIndex = 25;
            Fermer_btn.Text = "FERMER";
            Fermer_btn.UseVisualStyleBackColor = false;
            Fermer_btn.Click += Fermer_btn_Click;
            // 
            // Connect_btn
            // 
            Connect_btn.Location = new Point(536, 356);
            Connect_btn.Name = "Connect_btn";
            Connect_btn.Size = new Size(128, 29);
            Connect_btn.TabIndex = 24;
            Connect_btn.Text = "CONNECTER";
            Connect_btn.UseVisualStyleBackColor = true;
            Connect_btn.Click += Connect_btn_Click;
            // 
            // Verifier_btn
            // 
            Verifier_btn.Location = new Point(205, 356);
            Verifier_btn.Name = "Verifier_btn";
            Verifier_btn.Size = new Size(128, 29);
            Verifier_btn.TabIndex = 23;
            Verifier_btn.Text = "VÉRIFIER";
            Verifier_btn.UseVisualStyleBackColor = true;
            Verifier_btn.Click += Verifier_btn_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(455, 153);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(192, 24);
            radioButton2.TabIndex = 22;
            radioButton2.TabStop = true;
            radioButton2.Text = "Authentication Windows";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(218, 153);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(202, 24);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Authentication SQL Server";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Password_txt
            // 
            Password_txt.Location = new Point(315, 290);
            Password_txt.Name = "Password_txt";
            Password_txt.Size = new Size(268, 27);
            Password_txt.TabIndex = 20;
            Password_txt.TextChanged += Password_txt_Enter;
            // 
            // User_txt
            // 
            User_txt.Location = new Point(315, 200);
            User_txt.Name = "User_txt";
            User_txt.Size = new Size(268, 27);
            User_txt.TabIndex = 19;
            User_txt.TextChanged += User_txt_Enter;
            // 
            // Database_txt
            // 
            Database_txt.Location = new Point(315, 104);
            Database_txt.Name = "Database_txt";
            Database_txt.Size = new Size(268, 27);
            Database_txt.TabIndex = 18;
            // 
            // Server_txt
            // 
            Server_txt.Location = new Point(315, 23);
            Server_txt.Name = "Server_txt";
            Server_txt.Size = new Size(268, 27);
            Server_txt.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(136, 293);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 16;
            label4.Text = "PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(157, 203);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 15;
            label3.Text = "USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(141, 107);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 14;
            label2.Text = "DATABASE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 26);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 13;
            label1.Text = "SERVER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 401);
            label5.Name = "label5";
            label5.Size = new Size(213, 23);
            label5.TabIndex = 26;
            label5.Text = "Copyright © ERNET 2024";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(600, 292);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 24);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "AFFICHER";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(Fermer_btn);
            Controls.Add(Connect_btn);
            Controls.Add(Verifier_btn);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(Password_txt);
            Controls.Add(User_txt);
            Controls.Add(Database_txt);
            Controls.Add(Server_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Fermer_btn;
        private Button Connect_btn;
        private Button Verifier_btn;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox Password_txt;
        private TextBox User_txt;
        private TextBox Database_txt;
        private TextBox Server_txt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private CheckBox checkBox1;
    }
}