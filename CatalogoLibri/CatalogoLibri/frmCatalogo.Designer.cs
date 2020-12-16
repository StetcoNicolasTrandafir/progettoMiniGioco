
namespace CatalogoLibri
{
    partial class frmCatalogo
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
            this.lblFiltro = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.rdbReparto = new System.Windows.Forms.RadioButton();
            this.rdbOfferta = new System.Windows.Forms.RadioButton();
            this.rdbEditore = new System.Windows.Forms.RadioButton();
            this.rdbAutore = new System.Windows.Forms.RadioButton();
            this.cmbLibri = new System.Windows.Forms.ComboBox();
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            this.cmbReparto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbOfferta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPrezzoScontato = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpModifica = new System.Windows.Forms.GroupBox();
            this.ckbValidita = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.cmbEditori = new System.Windows.Forms.ComboBox();
            this.ptbImmagine = new System.Windows.Forms.PictureBox();
            this.dtpDataPubblicazione = new System.Windows.Forms.DateTimePicker();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpElenco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            this.grpModifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImmagine)).BeginInit();
            this.SuspendLayout();
            // 
            // grpElenco
            // 
            this.grpElenco.Controls.Add(this.lblFiltro);
            this.grpElenco.Controls.Add(this.label13);
            this.grpElenco.Controls.Add(this.cmbFiltro);
            this.grpElenco.Controls.Add(this.rdbReparto);
            this.grpElenco.Controls.Add(this.rdbOfferta);
            this.grpElenco.Controls.Add(this.rdbEditore);
            this.grpElenco.Controls.Add(this.rdbAutore);
            this.grpElenco.Controls.Add(this.cmbLibri);
            this.grpElenco.Controls.Add(this.dgvLibri);
            this.grpElenco.Location = new System.Drawing.Point(-1, 12);
            this.grpElenco.Name = "grpElenco";
            this.grpElenco.Size = new System.Drawing.Size(790, 638);
            this.grpElenco.TabIndex = 28;
            this.grpElenco.TabStop = false;
            this.grpElenco.Text = "Elenco";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(446, 586);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(0, 17);
            this.lblFiltro.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Filtra per:";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(586, 579);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(182, 24);
            this.cmbFiltro.TabIndex = 29;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // rdbReparto
            // 
            this.rdbReparto.AutoSize = true;
            this.rdbReparto.Location = new System.Drawing.Point(294, 582);
            this.rdbReparto.Name = "rdbReparto";
            this.rdbReparto.Size = new System.Drawing.Size(80, 21);
            this.rdbReparto.TabIndex = 28;
            this.rdbReparto.TabStop = true;
            this.rdbReparto.Text = "Reparto";
            this.rdbReparto.UseVisualStyleBackColor = true;
            this.rdbReparto.CheckedChanged += new System.EventHandler(this.rdbReparto_CheckedChanged);
            // 
            // rdbOfferta
            // 
            this.rdbOfferta.AutoSize = true;
            this.rdbOfferta.Location = new System.Drawing.Point(112, 582);
            this.rdbOfferta.Name = "rdbOfferta";
            this.rdbOfferta.Size = new System.Drawing.Size(73, 21);
            this.rdbOfferta.TabIndex = 27;
            this.rdbOfferta.TabStop = true;
            this.rdbOfferta.Text = "Offerta";
            this.rdbOfferta.UseVisualStyleBackColor = true;
            this.rdbOfferta.CheckedChanged += new System.EventHandler(this.rdbOfferta_CheckedChanged);
            // 
            // rdbEditore
            // 
            this.rdbEditore.AutoSize = true;
            this.rdbEditore.Location = new System.Drawing.Point(204, 582);
            this.rdbEditore.Name = "rdbEditore";
            this.rdbEditore.Size = new System.Drawing.Size(74, 21);
            this.rdbEditore.TabIndex = 26;
            this.rdbEditore.TabStop = true;
            this.rdbEditore.Text = "Editore";
            this.rdbEditore.UseVisualStyleBackColor = true;
            this.rdbEditore.CheckedChanged += new System.EventHandler(this.rdbEditore_CheckedChanged);
            // 
            // rdbAutore
            // 
            this.rdbAutore.AutoSize = true;
            this.rdbAutore.Location = new System.Drawing.Point(18, 582);
            this.rdbAutore.Name = "rdbAutore";
            this.rdbAutore.Size = new System.Drawing.Size(71, 21);
            this.rdbAutore.TabIndex = 25;
            this.rdbAutore.TabStop = true;
            this.rdbAutore.Text = "Autore";
            this.rdbAutore.UseVisualStyleBackColor = true;
            this.rdbAutore.CheckedChanged += new System.EventHandler(this.rdbAutore_CheckedChanged);
            // 
            // cmbLibri
            // 
            this.cmbLibri.FormattingEnabled = true;
            this.cmbLibri.Location = new System.Drawing.Point(6, 608);
            this.cmbLibri.Name = "cmbLibri";
            this.cmbLibri.Size = new System.Drawing.Size(121, 24);
            this.cmbLibri.TabIndex = 24;
            this.cmbLibri.Visible = false;
            this.cmbLibri.SelectedIndexChanged += new System.EventHandler(this.cmbLibri_SelectedIndexChanged);
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
            // cmbReparto
            // 
            this.cmbReparto.Enabled = false;
            this.cmbReparto.FormattingEnabled = true;
            this.cmbReparto.Location = new System.Drawing.Point(155, 90);
            this.cmbReparto.Name = "cmbReparto";
            this.cmbReparto.Size = new System.Drawing.Size(263, 24);
            this.cmbReparto.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Reparto:";
            // 
            // cmbOfferta
            // 
            this.cmbOfferta.Enabled = false;
            this.cmbOfferta.FormattingEnabled = true;
            this.cmbOfferta.Location = new System.Drawing.Point(155, 151);
            this.cmbOfferta.Name = "cmbOfferta";
            this.cmbOfferta.Size = new System.Drawing.Size(263, 24);
            this.cmbOfferta.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Offerta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "€";
            // 
            // lblPrezzoScontato
            // 
            this.lblPrezzoScontato.AutoSize = true;
            this.lblPrezzoScontato.Location = new System.Drawing.Point(389, 188);
            this.lblPrezzoScontato.Name = "lblPrezzoScontato";
            this.lblPrezzoScontato.Size = new System.Drawing.Size(44, 17);
            this.lblPrezzoScontato.TabIndex = 43;
            this.lblPrezzoScontato.Text = "00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Prezzo scontato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Prezzo pieno:";
            // 
            // grpModifica
            // 
            this.grpModifica.Controls.Add(this.ckbValidita);
            this.grpModifica.Controls.Add(this.label12);
            this.grpModifica.Controls.Add(this.listBox1);
            this.grpModifica.Controls.Add(this.lblPrezzo);
            this.grpModifica.Controls.Add(this.cmbReparto);
            this.grpModifica.Controls.Add(this.label10);
            this.grpModifica.Controls.Add(this.cmbOfferta);
            this.grpModifica.Controls.Add(this.label8);
            this.grpModifica.Controls.Add(this.label9);
            this.grpModifica.Controls.Add(this.lblPrezzoScontato);
            this.grpModifica.Controls.Add(this.label7);
            this.grpModifica.Controls.Add(this.label6);
            this.grpModifica.Controls.Add(this.label4);
            this.grpModifica.Controls.Add(this.cmbEditori);
            this.grpModifica.Controls.Add(this.ptbImmagine);
            this.grpModifica.Controls.Add(this.dtpDataPubblicazione);
            this.grpModifica.Controls.Add(this.txtTitolo);
            this.grpModifica.Controls.Add(this.label5);
            this.grpModifica.Controls.Add(this.label3);
            this.grpModifica.Controls.Add(this.label2);
            this.grpModifica.Controls.Add(this.lblCodice);
            this.grpModifica.Controls.Add(this.label1);
            this.grpModifica.Location = new System.Drawing.Point(795, 12);
            this.grpModifica.Name = "grpModifica";
            this.grpModifica.Size = new System.Drawing.Size(473, 638);
            this.grpModifica.TabIndex = 29;
            this.grpModifica.TabStop = false;
            this.grpModifica.Text = "Modifica";
            // 
            // ckbValidita
            // 
            this.ckbValidita.AutoSize = true;
            this.ckbValidita.Location = new System.Drawing.Point(54, 443);
            this.ckbValidita.Name = "ckbValidita";
            this.ckbValidita.Size = new System.Drawing.Size(98, 21);
            this.ckbValidita.TabIndex = 32;
            this.ckbValidita.Text = "checkBox1";
            this.ckbValidita.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(93, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "Autori:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(156, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 100);
            this.listBox1.TabIndex = 50;
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(174, 188);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(44, 17);
            this.lblPrezzo.TabIndex = 49;
            this.lblPrezzo.Text = "00.00";
            // 
            // cmbEditori
            // 
            this.cmbEditori.Enabled = false;
            this.cmbEditori.FormattingEnabled = true;
            this.cmbEditori.Location = new System.Drawing.Point(155, 121);
            this.cmbEditori.Name = "cmbEditori";
            this.cmbEditori.Size = new System.Drawing.Size(263, 24);
            this.cmbEditori.TabIndex = 38;
            // 
            // ptbImmagine
            // 
            this.ptbImmagine.Location = new System.Drawing.Point(225, 393);
            this.ptbImmagine.Name = "ptbImmagine";
            this.ptbImmagine.Size = new System.Drawing.Size(158, 210);
            this.ptbImmagine.TabIndex = 31;
            this.ptbImmagine.TabStop = false;
            // 
            // dtpDataPubblicazione
            // 
            this.dtpDataPubblicazione.Enabled = false;
            this.dtpDataPubblicazione.Location = new System.Drawing.Point(155, 343);
            this.dtpDataPubblicazione.Name = "dtpDataPubblicazione";
            this.dtpDataPubblicazione.Size = new System.Drawing.Size(263, 22);
            this.dtpDataPubblicazione.TabIndex = 30;
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(156, 62);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.ReadOnly = true;
            this.txtTitolo.Size = new System.Drawing.Size(262, 22);
            this.txtTitolo.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data pubblicazione:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Editore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Titolo:";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.ForeColor = System.Drawing.Color.Red;
            this.lblCodice.Location = new System.Drawing.Point(280, 18);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(0, 17);
            this.lblCodice.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codice:";
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 657);
            this.Controls.Add(this.grpElenco);
            this.Controls.Add(this.grpModifica);
            this.Name = "frmCatalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            this.grpElenco.ResumeLayout(false);
            this.grpElenco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            this.grpModifica.ResumeLayout(false);
            this.grpModifica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImmagine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpElenco;
        private System.Windows.Forms.RadioButton rdbReparto;
        private System.Windows.Forms.RadioButton rdbOfferta;
        private System.Windows.Forms.RadioButton rdbEditore;
        private System.Windows.Forms.RadioButton rdbAutore;
        private System.Windows.Forms.ComboBox cmbLibri;
        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.ComboBox cmbReparto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbOfferta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPrezzoScontato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpModifica;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.ComboBox cmbEditori;
        private System.Windows.Forms.PictureBox ptbImmagine;
        private System.Windows.Forms.DateTimePicker dtpDataPubblicazione;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.CheckBox ckbValidita;
    }
}