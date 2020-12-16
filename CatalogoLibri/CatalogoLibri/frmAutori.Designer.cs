
namespace CatalogoLibri
{
    partial class frmAutori
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
            this.cmbAutori = new System.Windows.Forms.ComboBox();
            this.ckbVisualizzaAnnullati = new System.Windows.Forms.CheckBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.dgvAutori = new System.Windows.Forms.DataGridView();
            this.grpModifica = new System.Windows.Forms.GroupBox();
            this.btnImmagine = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.ptbImmagine = new System.Windows.Forms.PictureBox();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ckbValidita = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.lblCodice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpElenco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).BeginInit();
            this.grpModifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImmagine)).BeginInit();
            this.SuspendLayout();
            // 
            // grpElenco
            // 
            this.grpElenco.Controls.Add(this.cmbAutori);
            this.grpElenco.Controls.Add(this.ckbVisualizzaAnnullati);
            this.grpElenco.Controls.Add(this.btnInserisci);
            this.grpElenco.Controls.Add(this.dgvAutori);
            this.grpElenco.Location = new System.Drawing.Point(12, 12);
            this.grpElenco.Name = "grpElenco";
            this.grpElenco.Size = new System.Drawing.Size(790, 638);
            this.grpElenco.TabIndex = 21;
            this.grpElenco.TabStop = false;
            this.grpElenco.Text = "Elenco autori";
            // 
            // cmbAutori
            // 
            this.cmbAutori.FormattingEnabled = true;
            this.cmbAutori.Location = new System.Drawing.Point(209, 561);
            this.cmbAutori.Name = "cmbAutori";
            this.cmbAutori.Size = new System.Drawing.Size(121, 24);
            this.cmbAutori.TabIndex = 24;
            this.cmbAutori.SelectedIndexChanged += new System.EventHandler(this.cmbAutori_SelectedIndexChanged);
            // 
            // ckbVisualizzaAnnullati
            // 
            this.ckbVisualizzaAnnullati.AutoSize = true;
            this.ckbVisualizzaAnnullati.Location = new System.Drawing.Point(562, 564);
            this.ckbVisualizzaAnnullati.Name = "ckbVisualizzaAnnullati";
            this.ckbVisualizzaAnnullati.Size = new System.Drawing.Size(197, 21);
            this.ckbVisualizzaAnnullati.TabIndex = 23;
            this.ckbVisualizzaAnnullati.Text = "Visualizza autori non validi";
            this.ckbVisualizzaAnnullati.UseVisualStyleBackColor = true;
            this.ckbVisualizzaAnnullati.CheckedChanged += new System.EventHandler(this.ckbVisualizzaAnnullati_CheckedChanged);
            // 
            // btnInserisci
            // 
            this.btnInserisci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInserisci.Location = new System.Drawing.Point(362, 543);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(175, 60);
            this.btnInserisci.TabIndex = 22;
            this.btnInserisci.Text = "Inserisci autore";
            this.btnInserisci.UseVisualStyleBackColor = false;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click_1);
            // 
            // dgvAutori
            // 
            this.dgvAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutori.Location = new System.Drawing.Point(6, 35);
            this.dgvAutori.Name = "dgvAutori";
            this.dgvAutori.RowHeadersWidth = 51;
            this.dgvAutori.RowTemplate.Height = 24;
            this.dgvAutori.Size = new System.Drawing.Size(773, 502);
            this.dgvAutori.TabIndex = 21;
            // 
            // grpModifica
            // 
            this.grpModifica.Controls.Add(this.btnImmagine);
            this.grpModifica.Controls.Add(this.btnAnnulla);
            this.grpModifica.Controls.Add(this.btnConferma);
            this.grpModifica.Controls.Add(this.ptbImmagine);
            this.grpModifica.Controls.Add(this.dtpDataNascita);
            this.grpModifica.Controls.Add(this.txtCognome);
            this.grpModifica.Controls.Add(this.txtNome);
            this.grpModifica.Controls.Add(this.ckbValidita);
            this.grpModifica.Controls.Add(this.label5);
            this.grpModifica.Controls.Add(this.label4);
            this.grpModifica.Controls.Add(this.label3);
            this.grpModifica.Controls.Add(this.label2);
            this.grpModifica.Controls.Add(this.txtDescrizione);
            this.grpModifica.Controls.Add(this.lblCodice);
            this.grpModifica.Controls.Add(this.label1);
            this.grpModifica.Location = new System.Drawing.Point(808, 12);
            this.grpModifica.Name = "grpModifica";
            this.grpModifica.Size = new System.Drawing.Size(473, 638);
            this.grpModifica.TabIndex = 25;
            this.grpModifica.TabStop = false;
            this.grpModifica.Text = "Modifica";
            // 
            // btnImmagine
            // 
            this.btnImmagine.Location = new System.Drawing.Point(42, 376);
            this.btnImmagine.Name = "btnImmagine";
            this.btnImmagine.Size = new System.Drawing.Size(105, 50);
            this.btnImmagine.TabIndex = 34;
            this.btnImmagine.Text = "Scegli immagine";
            this.btnImmagine.UseVisualStyleBackColor = true;
            this.btnImmagine.Click += new System.EventHandler(this.btnImmagine_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnnulla.Location = new System.Drawing.Point(259, 550);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(175, 60);
            this.btnAnnulla.TabIndex = 33;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click_1);
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConferma.Location = new System.Drawing.Point(42, 550);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(175, 60);
            this.btnConferma.TabIndex = 32;
            this.btnConferma.Text = "Inserisci autore";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // ptbImmagine
            // 
            this.ptbImmagine.Location = new System.Drawing.Point(174, 367);
            this.ptbImmagine.Name = "ptbImmagine";
            this.ptbImmagine.Size = new System.Drawing.Size(197, 161);
            this.ptbImmagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImmagine.TabIndex = 31;
            this.ptbImmagine.TabStop = false;
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Location = new System.Drawing.Point(142, 339);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(254, 22);
            this.dtpDataNascita.TabIndex = 30;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(134, 97);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(262, 22);
            this.txtCognome.TabIndex = 29;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(134, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 22);
            this.txtNome.TabIndex = 28;
            // 
            // ckbValidita
            // 
            this.ckbValidita.AutoSize = true;
            this.ckbValidita.Location = new System.Drawing.Point(42, 443);
            this.ckbValidita.Name = "ckbValidita";
            this.ckbValidita.Size = new System.Drawing.Size(69, 21);
            this.ckbValidita.TabIndex = 27;
            this.ckbValidita.Text = "Valido";
            this.ckbValidita.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data nascita:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descrizione:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cognome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome:";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(134, 133);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(254, 175);
            this.txtDescrizione.TabIndex = 21;
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.ForeColor = System.Drawing.Color.Red;
            this.lblCodice.Location = new System.Drawing.Point(258, 18);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(0, 17);
            this.lblCodice.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codice:";
            // 
            // frmAutori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 662);
            this.Controls.Add(this.grpModifica);
            this.Controls.Add(this.grpElenco);
            this.Name = "frmAutori";
            this.Text = "frmAutori";
            this.Load += new System.EventHandler(this.frmAutori_Load);
            this.grpElenco.ResumeLayout(false);
            this.grpElenco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).EndInit();
            this.grpModifica.ResumeLayout(false);
            this.grpModifica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImmagine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpElenco;
        private System.Windows.Forms.ComboBox cmbAutori;
        private System.Windows.Forms.CheckBox ckbVisualizzaAnnullati;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.DataGridView dgvAutori;
        private System.Windows.Forms.GroupBox grpModifica;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.PictureBox ptbImmagine;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox ckbValidita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImmagine;
    }
}