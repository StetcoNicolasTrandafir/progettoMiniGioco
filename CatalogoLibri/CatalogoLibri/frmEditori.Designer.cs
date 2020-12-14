
namespace CatalogoLibri
{
    partial class frmEditori
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.grpElenco = new System.Windows.Forms.GroupBox();
            this.cmbEditori = new System.Windows.Forms.ComboBox();
            this.ckbVisualizzaAnnullati = new System.Windows.Forms.CheckBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.dgvEditori = new System.Windows.Forms.DataGridView();
            this.grpModifica.SuspendLayout();
            this.grpElenco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditori)).BeginInit();
            this.SuspendLayout();
            // 
            // grpModifica
            // 
            this.grpModifica.Controls.Add(this.lblCodice);
            this.grpModifica.Controls.Add(this.label2);
            this.grpModifica.Controls.Add(this.ckbValidita);
            this.grpModifica.Controls.Add(this.label4);
            this.grpModifica.Controls.Add(this.txtNome);
            this.grpModifica.Controls.Add(this.btnAnnulla);
            this.grpModifica.Controls.Add(this.btnConferma);
            this.grpModifica.Location = new System.Drawing.Point(545, 1);
            this.grpModifica.Name = "grpModifica";
            this.grpModifica.Size = new System.Drawing.Size(402, 445);
            this.grpModifica.TabIndex = 3;
            this.grpModifica.TabStop = false;
            this.grpModifica.Text = "Modifica";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.ForeColor = System.Drawing.Color.Red;
            this.lblCodice.Location = new System.Drawing.Point(246, 118);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(0, 17);
            this.lblCodice.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Codice:";
            // 
            // ckbValidita
            // 
            this.ckbValidita.AutoSize = true;
            this.ckbValidita.Location = new System.Drawing.Point(173, 260);
            this.ckbValidita.Name = "ckbValidita";
            this.ckbValidita.Size = new System.Drawing.Size(69, 21);
            this.ckbValidita.TabIndex = 40;
            this.ckbValidita.Text = "Valido";
            this.ckbValidita.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 180);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(289, 22);
            this.txtNome.TabIndex = 38;
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
            this.btnConferma.Text = "Inserisci editore";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // grpElenco
            // 
            this.grpElenco.Controls.Add(this.cmbEditori);
            this.grpElenco.Controls.Add(this.ckbVisualizzaAnnullati);
            this.grpElenco.Controls.Add(this.btnInserisci);
            this.grpElenco.Controls.Add(this.dgvEditori);
            this.grpElenco.Location = new System.Drawing.Point(5, 1);
            this.grpElenco.Name = "grpElenco";
            this.grpElenco.Size = new System.Drawing.Size(534, 445);
            this.grpElenco.TabIndex = 2;
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
            this.btnInserisci.Text = "Inserisci editore";
            this.btnInserisci.UseVisualStyleBackColor = false;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // dgvEditori
            // 
            this.dgvEditori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditori.Location = new System.Drawing.Point(6, 21);
            this.dgvEditori.Name = "dgvEditori";
            this.dgvEditori.RowHeadersWidth = 51;
            this.dgvEditori.RowTemplate.Height = 24;
            this.dgvEditori.Size = new System.Drawing.Size(514, 341);
            this.dgvEditori.TabIndex = 0;
            // 
            // frmEditori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 458);
            this.Controls.Add(this.grpModifica);
            this.Controls.Add(this.grpElenco);
            this.Name = "frmEditori";
            this.Text = "frmEditori";
            this.Load += new System.EventHandler(this.frmEditori_Load);
            this.grpModifica.ResumeLayout(false);
            this.grpModifica.PerformLayout();
            this.grpElenco.ResumeLayout(false);
            this.grpElenco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModifica;
        private System.Windows.Forms.CheckBox ckbValidita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.GroupBox grpElenco;
        private System.Windows.Forms.ComboBox cmbEditori;
        private System.Windows.Forms.CheckBox ckbVisualizzaAnnullati;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.DataGridView dgvEditori;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label label2;
    }
}