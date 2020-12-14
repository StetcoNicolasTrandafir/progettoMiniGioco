
namespace CatalogoLibri
{
    partial class frmOfferte
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
            this.grpModifica = new System.Windows.Forms.GroupBox();
            this.lblCodice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbValidita = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.grpElenco = new System.Windows.Forms.GroupBox();
            this.cmbEditori = new System.Windows.Forms.ComboBox();
            this.ckbVisualizzaAnnullati = new System.Windows.Forms.CheckBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.dgvOfferte = new System.Windows.Forms.DataGridView();
            this.nmbSconto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpModifica.SuspendLayout();
            this.grpElenco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSconto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpModifica
            // 
            this.grpModifica.Controls.Add(this.label3);
            this.grpModifica.Controls.Add(this.label1);
            this.grpModifica.Controls.Add(this.nmbSconto);
            this.grpModifica.Controls.Add(this.lblCodice);
            this.grpModifica.Controls.Add(this.label2);
            this.grpModifica.Controls.Add(this.ckbValidita);
            this.grpModifica.Controls.Add(this.label4);
            this.grpModifica.Controls.Add(this.txtDescrizione);
            this.grpModifica.Controls.Add(this.btnAnnulla);
            this.grpModifica.Controls.Add(this.btnConferma);
            this.grpModifica.Location = new System.Drawing.Point(540, 3);
            this.grpModifica.Name = "grpModifica";
            this.grpModifica.Size = new System.Drawing.Size(402, 445);
            this.grpModifica.TabIndex = 5;
            this.grpModifica.TabStop = false;
            this.grpModifica.Text = "Modifica";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.ForeColor = System.Drawing.Color.Red;
            this.lblCodice.Location = new System.Drawing.Point(253, 60);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(0, 17);
            this.lblCodice.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Codice:";
            // 
            // ckbValidita
            // 
            this.ckbValidita.AutoSize = true;
            this.ckbValidita.Location = new System.Drawing.Point(170, 320);
            this.ckbValidita.Name = "ckbValidita";
            this.ckbValidita.Size = new System.Drawing.Size(69, 21);
            this.ckbValidita.TabIndex = 40;
            this.ckbValidita.Text = "Valido";
            this.ckbValidita.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Descrizione:";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(96, 89);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(291, 158);
            this.txtDescrizione.TabIndex = 38;
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
            this.btnConferma.Text = "Inserisci offerta";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // grpElenco
            // 
            this.grpElenco.Controls.Add(this.cmbEditori);
            this.grpElenco.Controls.Add(this.ckbVisualizzaAnnullati);
            this.grpElenco.Controls.Add(this.btnInserisci);
            this.grpElenco.Controls.Add(this.dgvOfferte);
            this.grpElenco.Location = new System.Drawing.Point(0, 3);
            this.grpElenco.Name = "grpElenco";
            this.grpElenco.Size = new System.Drawing.Size(534, 445);
            this.grpElenco.TabIndex = 4;
            this.grpElenco.TabStop = false;
            this.grpElenco.Text = "Elenco reparti";
            // 
            // cmbEditori
            // 
            this.cmbEditori.FormattingEnabled = true;
            this.cmbEditori.Location = new System.Drawing.Point(15, 387);
            this.cmbEditori.Name = "cmbEditori";
            this.cmbEditori.Size = new System.Drawing.Size(121, 24);
            this.cmbEditori.TabIndex = 27;
            this.cmbEditori.Visible = false;
            this.cmbEditori.SelectedIndexChanged += new System.EventHandler(this.cmbEditori_SelectedIndexChanged);
            // 
            // ckbVisualizzaAnnullati
            // 
            this.ckbVisualizzaAnnullati.AutoSize = true;
            this.ckbVisualizzaAnnullati.Location = new System.Drawing.Point(285, 390);
            this.ckbVisualizzaAnnullati.Name = "ckbVisualizzaAnnullati";
            this.ckbVisualizzaAnnullati.Size = new System.Drawing.Size(207, 21);
            this.ckbVisualizzaAnnullati.TabIndex = 26;
            this.ckbVisualizzaAnnullati.Text = "Visualizza offerte non valide";
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
            this.btnInserisci.Text = "Inserisci offerta";
            this.btnInserisci.UseVisualStyleBackColor = false;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // dgvOfferte
            // 
            this.dgvOfferte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfferte.Location = new System.Drawing.Point(6, 21);
            this.dgvOfferte.Name = "dgvOfferte";
            this.dgvOfferte.RowHeadersWidth = 51;
            this.dgvOfferte.RowTemplate.Height = 24;
            this.dgvOfferte.Size = new System.Drawing.Size(514, 341);
            this.dgvOfferte.TabIndex = 0;
            // 
            // nmbSconto
            // 
            this.nmbSconto.Location = new System.Drawing.Point(179, 265);
            this.nmbSconto.Name = "nmbSconto";
            this.nmbSconto.Size = new System.Drawing.Size(120, 22);
            this.nmbSconto.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sconto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "%";
            // 
            // frmOfferte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 457);
            this.Controls.Add(this.grpModifica);
            this.Controls.Add(this.grpElenco);
            this.Name = "frmOfferte";
            this.Text = "Offerte";
            this.Load += new System.EventHandler(this.frmOfferte_Load);
            this.grpModifica.ResumeLayout(false);
            this.grpModifica.PerformLayout();
            this.grpElenco.ResumeLayout(false);
            this.grpElenco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSconto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModifica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmbSconto;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbValidita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.GroupBox grpElenco;
        private System.Windows.Forms.ComboBox cmbEditori;
        private System.Windows.Forms.CheckBox ckbVisualizzaAnnullati;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.DataGridView dgvOfferte;
    }
}