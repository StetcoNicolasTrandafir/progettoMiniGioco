
namespace CatalogoLibri
{
    partial class frmReparti
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
            this.grpElenco = new System.Windows.Forms.GroupBox();
            this.grpModifica = new System.Windows.Forms.GroupBox();
            this.dgvReparti = new System.Windows.Forms.DataGridView();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.cmbReparti = new System.Windows.Forms.ComboBox();
            this.ckbVisualizzaAnnullati = new System.Windows.Forms.CheckBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.ckbValidita = new System.Windows.Forms.CheckBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.grpElenco.SuspendLayout();
            this.grpModifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparti)).BeginInit();
            this.SuspendLayout();
            // 
            // grpElenco
            // 
            this.grpElenco.Controls.Add(this.cmbReparti);
            this.grpElenco.Controls.Add(this.ckbVisualizzaAnnullati);
            this.grpElenco.Controls.Add(this.btnInserisci);
            this.grpElenco.Controls.Add(this.dgvReparti);
            this.grpElenco.Location = new System.Drawing.Point(0, 0);
            this.grpElenco.Name = "grpElenco";
            this.grpElenco.Size = new System.Drawing.Size(534, 445);
            this.grpElenco.TabIndex = 0;
            this.grpElenco.TabStop = false;
            this.grpElenco.Text = "Elenco reparti";
            // 
            // grpModifica
            // 
            this.grpModifica.Controls.Add(this.txtCodice);
            this.grpModifica.Controls.Add(this.ckbValidita);
            this.grpModifica.Controls.Add(this.label4);
            this.grpModifica.Controls.Add(this.txtDescrizione);
            this.grpModifica.Controls.Add(this.label1);
            this.grpModifica.Controls.Add(this.btnAnnulla);
            this.grpModifica.Controls.Add(this.btnConferma);
            this.grpModifica.Location = new System.Drawing.Point(540, 0);
            this.grpModifica.Name = "grpModifica";
            this.grpModifica.Size = new System.Drawing.Size(402, 445);
            this.grpModifica.TabIndex = 1;
            this.grpModifica.TabStop = false;
            this.grpModifica.Text = "Modifica";
            // 
            // dgvReparti
            // 
            this.dgvReparti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReparti.Location = new System.Drawing.Point(6, 21);
            this.dgvReparti.Name = "dgvReparti";
            this.dgvReparti.RowHeadersWidth = 51;
            this.dgvReparti.RowTemplate.Height = 24;
            this.dgvReparti.Size = new System.Drawing.Size(514, 341);
            this.dgvReparti.TabIndex = 0;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnnulla.Location = new System.Drawing.Point(223, 369);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(175, 60);
            this.btnAnnulla.TabIndex = 35;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConferma.Location = new System.Drawing.Point(6, 369);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(175, 60);
            this.btnConferma.TabIndex = 34;
            this.btnConferma.Text = "Inserisci reparto";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Codice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Descrizione:";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(114, 107);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(254, 175);
            this.txtDescrizione.TabIndex = 38;
            // 
            // cmbReparti
            // 
            this.cmbReparti.FormattingEnabled = true;
            this.cmbReparti.Location = new System.Drawing.Point(15, 387);
            this.cmbReparti.Name = "cmbReparti";
            this.cmbReparti.Size = new System.Drawing.Size(121, 24);
            this.cmbReparti.TabIndex = 27;
            this.cmbReparti.Visible = false;
            this.cmbReparti.SelectedIndexChanged += new System.EventHandler(this.cmbReparti_SelectedIndexChanged);
            // 
            // ckbVisualizzaAnnullati
            // 
            this.ckbVisualizzaAnnullati.AutoSize = true;
            this.ckbVisualizzaAnnullati.Location = new System.Drawing.Point(285, 390);
            this.ckbVisualizzaAnnullati.Name = "ckbVisualizzaAnnullati";
            this.ckbVisualizzaAnnullati.Size = new System.Drawing.Size(202, 21);
            this.ckbVisualizzaAnnullati.TabIndex = 26;
            this.ckbVisualizzaAnnullati.Text = "Visualizza reparti non validi";
            this.ckbVisualizzaAnnullati.UseVisualStyleBackColor = true;
            this.ckbVisualizzaAnnullati.CheckedChanged += new System.EventHandler(this.ckbVisualizzaAnnullati_CheckedChanged);
            // 
            // btnInserisci
            // 
            this.btnInserisci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInserisci.Location = new System.Drawing.Point(81, 369);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(175, 60);
            this.btnInserisci.TabIndex = 25;
            this.btnInserisci.Text = "Inserisci reparto";
            this.btnInserisci.UseVisualStyleBackColor = false;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // ckbValidita
            // 
            this.ckbValidita.AutoSize = true;
            this.ckbValidita.Location = new System.Drawing.Point(183, 299);
            this.ckbValidita.Name = "ckbValidita";
            this.ckbValidita.Size = new System.Drawing.Size(69, 21);
            this.ckbValidita.TabIndex = 40;
            this.ckbValidita.Text = "Valido";
            this.ckbValidita.UseVisualStyleBackColor = true;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(196, 55);
            this.txtCodice.MaxLength = 3;
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(82, 22);
            this.txtCodice.TabIndex = 41;
            // 
            // frmReparti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.grpModifica);
            this.Controls.Add(this.grpElenco);
            this.Name = "frmReparti";
            this.Text = "Reparti";
            this.Load += new System.EventHandler(this.frmReparti_Load);
            this.grpElenco.ResumeLayout(false);
            this.grpElenco.PerformLayout();
            this.grpModifica.ResumeLayout(false);
            this.grpModifica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpElenco;
        private System.Windows.Forms.DataGridView dgvReparti;
        private System.Windows.Forms.GroupBox grpModifica;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.ComboBox cmbReparti;
        private System.Windows.Forms.CheckBox ckbVisualizzaAnnullati;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.CheckBox ckbValidita;
        private System.Windows.Forms.TextBox txtCodice;
    }
}