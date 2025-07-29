namespace WinFormsApp1
{
    partial class Menu
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
            gestionEcritureToolStripMenuItem = new ToolStripMenuItem();
            declotureEcritureToolStripMenuItem = new ToolStripMenuItem();
            gestionFacturationToolStripMenuItem = new ToolStripMenuItem();
            venteToolStripMenuItem = new ToolStripMenuItem();
            décomptabilisationToolStripMenuItem = new ToolStripMenuItem();
            décomptabilisationToolStripMenuItem1 = new ToolStripMenuItem();
            gestionReglementToolStripMenuItem = new ToolStripMenuItem();
            dévalidationToolStripMenuItem1 = new ToolStripMenuItem();
            décomptabilisationToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            devalidationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gestionEcritureToolStripMenuItem
            // 
            gestionEcritureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { declotureEcritureToolStripMenuItem });
            gestionEcritureToolStripMenuItem.Name = "gestionEcritureToolStripMenuItem";
            gestionEcritureToolStripMenuItem.Size = new Size(127, 24);
            gestionEcritureToolStripMenuItem.Text = "Gestion Ecriture";
            gestionEcritureToolStripMenuItem.Click += gestionEcritureToolStripMenuItem_Click;
            // 
            // declotureEcritureToolStripMenuItem
            // 
            declotureEcritureToolStripMenuItem.Name = "declotureEcritureToolStripMenuItem";
            declotureEcritureToolStripMenuItem.Size = new Size(211, 26);
            declotureEcritureToolStripMenuItem.Text = "Décloture Ecriture";
            declotureEcritureToolStripMenuItem.Click += declotureEcritureToolStripMenuItem_Click;
            // 
            // gestionFacturationToolStripMenuItem
            // 
            gestionFacturationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { venteToolStripMenuItem });
            gestionFacturationToolStripMenuItem.Name = "gestionFacturationToolStripMenuItem";
            gestionFacturationToolStripMenuItem.Size = new Size(150, 24);
            gestionFacturationToolStripMenuItem.Text = "Gestion Facturation";
            // 
            // venteToolStripMenuItem
            // 
            venteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { devalidationToolStripMenuItem, décomptabilisationToolStripMenuItem, décomptabilisationToolStripMenuItem1 });
            venteToolStripMenuItem.Name = "venteToolStripMenuItem";
            venteToolStripMenuItem.Size = new Size(224, 26);
            venteToolStripMenuItem.Text = "Vente";
            // 
            // décomptabilisationToolStripMenuItem
            // 
            décomptabilisationToolStripMenuItem.Name = "décomptabilisationToolStripMenuItem";
            décomptabilisationToolStripMenuItem.Size = new Size(322, 26);
            décomptabilisationToolStripMenuItem.Text = "Décomptabilisation";
            décomptabilisationToolStripMenuItem.Click += décomptabilisationToolStripMenuItem_Click;
            // 
            // décomptabilisationToolStripMenuItem1
            // 
            décomptabilisationToolStripMenuItem1.Name = "décomptabilisationToolStripMenuItem1";
            décomptabilisationToolStripMenuItem1.Size = new Size(322, 26);
            décomptabilisationToolStripMenuItem1.Text = "Décomptabilisation / Dévalidation";
            décomptabilisationToolStripMenuItem1.Click += décomptabilisationToolStripMenuItem1_Click;
            // 
            // gestionReglementToolStripMenuItem
            // 
            gestionReglementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dévalidationToolStripMenuItem1, décomptabilisationToolStripMenuItem2 });
            gestionReglementToolStripMenuItem.Name = "gestionReglementToolStripMenuItem";
            gestionReglementToolStripMenuItem.Size = new Size(153, 24);
            gestionReglementToolStripMenuItem.Text = "Gestion Reglement ";
            // 
            // dévalidationToolStripMenuItem1
            // 
            dévalidationToolStripMenuItem1.Name = "dévalidationToolStripMenuItem1";
            dévalidationToolStripMenuItem1.Size = new Size(224, 26);
            dévalidationToolStripMenuItem1.Text = "Dévalidation";
            dévalidationToolStripMenuItem1.Click += dévalidationToolStripMenuItem1_Click;
            // 
            // décomptabilisationToolStripMenuItem2
            // 
            décomptabilisationToolStripMenuItem2.Name = "décomptabilisationToolStripMenuItem2";
            décomptabilisationToolStripMenuItem2.Size = new Size(224, 26);
            décomptabilisationToolStripMenuItem2.Text = "Décomptabilisation";
            décomptabilisationToolStripMenuItem2.Click += décomptabilisationToolStripMenuItem2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionEcritureToolStripMenuItem, gestionFacturationToolStripMenuItem, gestionReglementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(813, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // devalidationToolStripMenuItem
            // 
            devalidationToolStripMenuItem.Name = "devalidationToolStripMenuItem";
            devalidationToolStripMenuItem.Size = new Size(322, 26);
            devalidationToolStripMenuItem.Text = "Dévalidation";
            devalidationToolStripMenuItem.Click += devalidationToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 443);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Page de recherche";
            FormClosed += Menu_FormClosed;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem gestionEcritureToolStripMenuItem;
        private ToolStripMenuItem declotureEcritureToolStripMenuItem;
        private ToolStripMenuItem gestionFacturationToolStripMenuItem;
        private ToolStripMenuItem venteToolStripMenuItem;
        private ToolStripMenuItem décomptabilisationToolStripMenuItem;
        private ToolStripMenuItem décomptabilisationToolStripMenuItem1;
        private ToolStripMenuItem gestionReglementToolStripMenuItem;
        private ToolStripMenuItem dévalidationToolStripMenuItem1;
        private ToolStripMenuItem décomptabilisationToolStripMenuItem2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem devalidationToolStripMenuItem;
    }
}