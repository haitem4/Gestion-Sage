namespace WinFormsApp1
{
    partial class DecomptabilisationFactureVente
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
            dataGridView1 = new DataGridView();
            Executer_btn = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(730, 257);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Executer_btn
            // 
            Executer_btn.Location = new Point(551, 84);
            Executer_btn.Name = "Executer_btn";
            Executer_btn.Size = new Size(120, 29);
            Executer_btn.TabIndex = 7;
            Executer_btn.Text = "Executer";
            Executer_btn.UseVisualStyleBackColor = true;
            Executer_btn.Click += Executer_btn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(551, 49);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 6;
            button1.Text = "Actualiser ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(128, 67);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 4;
            label1.Text = "Facture N°";
            // 
            // DecomptabilisationFactureVente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Executer_btn);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "DecomptabilisationFactureVente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dècomptabilisation Facture Vente";
            FormClosed += DècomptabilisationFactureVente_FormClosed;
            Load += DècomptabilisationFactureVente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button Executer_btn;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}