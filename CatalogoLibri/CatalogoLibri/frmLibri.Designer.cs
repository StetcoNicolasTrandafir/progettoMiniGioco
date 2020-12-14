
namespace CatalogoLibri
{
    partial class frmLibri
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
            this.btnImmagine = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.ptbImmagine = new System.Windows.Forms.PictureBox();
            this.dtpDataPubblicazione = new System.Windows.Forms.DateTimePicker();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.ckbValidita = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLibri = new System.Windows.Forms.ComboBox();
            this.ckbVisualizzaAnnullati = new System.Windows.Forms.CheckBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            this.grpModifica = new System.Windows.Forms.GroupBox();
            this.cmbOfferta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPrezzoScontato = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmbPrezzo = new System.Windows.Forms.NumericUpDown();
            this.cmbEditori = new System.Windows.Forms.ComboBox();
            this.grpElenco = new System.Windows.Forms.GroupBox();
            this.cmbReparto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImmagine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            this.grpModifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPrezzo)).BeginInit();
            this.grpElenco.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
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
            this.ptbImmagine.TabIndex = 31;
            this.ptbImmagine.TabStop = false;
            // 
            // dtpDataPubblicazione
            // 
            this.dtpDataPubblicazione.Location = new System.Drawing.Point(191, 339);
            this.dtpDataPubblicazione.Name = "dtpDataPubblicazione";
            this.dtpDataPubblicazione.Size = new System.Drawing.Size(254, 22);
            this.dtpDataPubblicazione.TabIndex = 30;
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(134, 62);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(262, 22);
            this.txtTitolo.TabIndex = 28;
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
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data pubblicazione:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Editore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Titolo:";
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
            // cmbLibri
            // 
            this.cmbLibri.FormattingEnabled = true;
            this.cmbLibri.Location = new System.Drawing.Point(209, 561);
            this.cmbLibri.Name = "cmbLibri";
            this.cmbLibri.Size = new System.Drawing.Size(121, 24);
            this.cmbLibri.TabIndex = 24;
            this.cmbLibri.SelectedIndexChanged += new System.EventHandler(this.cmbLibri_SelectedIndexChanged);
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
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // dgvLibri
            // 
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibri.Location = new System.Drawing.Point(6, 35);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.RowHeadersWidth = 51;
            this.dgvLibri.RowTemplate.Height = 24;
            this.dgvLibri.Size = new System.Drawing.Size(773, 502);
            this.dgvLibri.TabIndex = 21;
            // 
            // grpModifica
            // 
            this.grpModifica.Controls.Add(this.cmbReparto);
            this.grpModifica.Controls.Add(this.label10);
            this.grpModifica.Controls.Add(this.cmbOfferta);
            this.grpModifica.Controls.Add(this.label8);
            this.grpModifica.Controls.Add(this.label9);
            this.grpModifica.Controls.Add(this.lblPrezzoScontato);
            this.grpModifica.Controls.Add(this.label7);
            this.grpModifica.Controls.Add(this.label6);
            this.grpModifica.Controls.Add(this.label4);
            this.grpModifica.Controls.Add(this.nmbPrezzo);
            this.grpModifica.Controls.Add(this.cmbEditori);
            this.grpModifica.Controls.Add(this.btnImmagine);
            this.grpModifica.Controls.Add(this.btnAnnulla);
            this.grpModifica.Controls.Add(this.btnConferma);
            this.grpModifica.Controls.Add(this.ptbImmagine);
            this.grpModifica.Controls.Add(this.dtpDataPubblicazione);
            this.grpModifica.Controls.Add(this.txtTitolo);
            this.grpModifica.Controls.Add(this.ckbValidita);
            this.grpModifica.Controls.Add(this.label5);
            this.grpModifica.Controls.Add(this.label3);
            this.grpModifica.Controls.Add(this.label2);
            this.grpModifica.Controls.Add(this.lblCodice);
            this.grpModifica.Controls.Add(this.label1);
            this.grpModifica.Location = new System.Drawing.Point(799, 2);
            this.grpModifica.Name = "grpModifica";
            this.grpModifica.Size = new System.Drawing.Size(473, 638);
            this.grpModifica.TabIndex = 27;
            this.grpModifica.TabStop = false;
            this.grpModifica.Text = "Modifica";
            // 
            // cmbOfferta
            // 
            this.cmbOfferta.FormattingEnabled = true;
            this.cmbOfferta.Location = new System.Drawing.Point(133, 151);
            this.cmbOfferta.Name = "cmbOfferta";
            this.cmbOfferta.Size = new System.Drawing.Size(263, 24);
            this.cmbOfferta.TabIndex = 46;
            this.cmbOfferta.SelectedIndexChanged += new System.EventHandler(this.cmbOfferta_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Offerta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "€";
            // 
            // lblPrezzoScontato
            // 
            this.lblPrezzoScontato.AutoSize = true;
            this.lblPrezzoScontato.Location = new System.Drawing.Point(367, 188);
            this.lblPrezzoScontato.Name = "lblPrezzoScontato";
            this.lblPrezzoScontato.Size = new System.Drawing.Size(44, 17);
            this.lblPrezzoScontato.TabIndex = 43;
            this.lblPrezzoScontato.Text = "00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Prezzo scontato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Prezzo pieno:";
            // 
            // nmbPrezzo
            // 
            this.nmbPrezzo.Location = new System.Drawing.Point(127, 186);
            this.nmbPrezzo.Name = "nmbPrezzo";
            this.nmbPrezzo.Size = new System.Drawing.Size(92, 22);
            this.nmbPrezzo.TabIndex = 39;
            this.nmbPrezzo.ValueChanged += new System.EventHandler(this.nmbPrezzo_ValueChanged_1);
            // 
            // cmbEditori
            // 
            this.cmbEditori.FormattingEnabled = true;
            this.cmbEditori.Location = new System.Drawing.Point(133, 121);
            this.cmbEditori.Name = "cmbEditori";
            this.cmbEditori.Size = new System.Drawing.Size(263, 24);
            this.cmbEditori.TabIndex = 38;
            // 
            // grpElenco
            // 
            this.grpElenco.Controls.Add(this.cmbLibri);
            this.grpElenco.Controls.Add(this.ckbVisualizzaAnnullati);
            this.grpElenco.Controls.Add(this.btnInserisci);
            this.grpElenco.Controls.Add(this.dgvLibri);
            this.grpElenco.Location = new System.Drawing.Point(3, 2);
            this.grpElenco.Name = "grpElenco";
            this.grpElenco.Size = new System.Drawing.Size(790, 638);
            this.grpElenco.TabIndex = 26;
            this.grpElenco.TabStop = false;
            this.grpElenco.Text = "Elenco autori";
            // 
            // cmbReparto
            // 
            this.cmbReparto.FormattingEnabled = true;
            this.cmbReparto.Location = new System.Drawing.Point(133, 90);
            this.cmbReparto.Name = "cmbReparto";
            this.cmbReparto.Size = new System.Drawing.Size(263, 24);
            this.cmbReparto.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Reparto:";
            // 
            // frmLibri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 645);
            this.Controls.Add(this.grpModifica);
            this.Controls.Add(this.grpElenco);
            this.Name = "frmLibri";
            this.Text = "frmLibri";
            this.Load += new System.EventHandler(this.frmLibri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImmagine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            this.grpModifica.ResumeLayout(false);
            this.grpModifica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPrezzo)).EndInit();
            this.grpElenco.ResumeLayout(false);
            this.grpElenco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImmagine;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.PictureBox ptbImmagine;
        private System.Windows.Forms.DateTimePicker dtpDataPubblicazione;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.CheckBox ckbValidita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLibri;
        private System.Windows.Forms.CheckBox ckbVisualizzaAnnullati;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.GroupBox grpModifica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmbPrezzo;
        private System.Windows.Forms.ComboBox cmbEditori;
        private System.Windows.Forms.GroupBox grpElenco;
        private System.Windows.Forms.ComboBox cmbOfferta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPrezzoScontato;
        private System.Windows.Forms.ComboBox cmbReparto;
        private System.Windows.Forms.Label label10;
    }
}