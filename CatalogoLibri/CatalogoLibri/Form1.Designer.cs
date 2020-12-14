namespace CatalogoLibri
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anagraficheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repartiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offerteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Location = new System.Drawing.Point(26, 61);
            this.btnCatalogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(191, 98);
            this.btnCatalogo.TabIndex = 1;
            this.btnCatalogo.Text = "CATALOGO";
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anagraficheToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(272, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anagraficheToolStripMenuItem
            // 
            this.anagraficheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libriToolStripMenuItem,
            this.autoriToolStripMenuItem,
            this.repartiToolStripMenuItem,
            this.editoriToolStripMenuItem,
            this.offerteToolStripMenuItem});
            this.anagraficheToolStripMenuItem.Name = "anagraficheToolStripMenuItem";
            this.anagraficheToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.anagraficheToolStripMenuItem.Text = "Anagrafiche";
            // 
            // libriToolStripMenuItem
            // 
            this.libriToolStripMenuItem.Name = "libriToolStripMenuItem";
            this.libriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.libriToolStripMenuItem.Text = "Libri";
            this.libriToolStripMenuItem.Click += new System.EventHandler(this.libriToolStripMenuItem_Click);
            // 
            // autoriToolStripMenuItem
            // 
            this.autoriToolStripMenuItem.Name = "autoriToolStripMenuItem";
            this.autoriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.autoriToolStripMenuItem.Text = "Autori";
            this.autoriToolStripMenuItem.Click += new System.EventHandler(this.autoriToolStripMenuItem_Click);
            // 
            // repartiToolStripMenuItem
            // 
            this.repartiToolStripMenuItem.Name = "repartiToolStripMenuItem";
            this.repartiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.repartiToolStripMenuItem.Text = "Reparti";
            this.repartiToolStripMenuItem.Click += new System.EventHandler(this.repartiToolStripMenuItem_Click);
            // 
            // editoriToolStripMenuItem
            // 
            this.editoriToolStripMenuItem.Name = "editoriToolStripMenuItem";
            this.editoriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editoriToolStripMenuItem.Text = "Editori";
            this.editoriToolStripMenuItem.Click += new System.EventHandler(this.editoriToolStripMenuItem_Click);
            // 
            // offerteToolStripMenuItem
            // 
            this.offerteToolStripMenuItem.Name = "offerteToolStripMenuItem";
            this.offerteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.offerteToolStripMenuItem.Text = "Offerte";
            this.offerteToolStripMenuItem.Click += new System.EventHandler(this.offerteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 250);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anagraficheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repartiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offerteToolStripMenuItem;
    }
}

