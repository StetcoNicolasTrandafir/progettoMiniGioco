using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoLibri
{
    public partial class frmAutori : Form
    {


        DataTable tabellaAutori;
        bool selezionaAutore = true;

        public frmAutori()
        {
            InitializeComponent();
        }

        private void frmAutori_Load(object sender, EventArgs e)
        {
            selezionaAutore = false;
            elencoAutori(ckbVisualizzaAnnullati.Checked);
            selezionaAutore = true;
        }

        private void annulla()
        {
            grpElenco.Enabled = true;
            grpModifica.Enabled = false;
            txtCognome.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDescrizione.Text = string.Empty;
            dtpDataNascita.Value = DateTime.Now;
            ckbValidita.Checked = false;
            ptbImmagine.ImageLocation = string.Empty;
            lblCodice.Text = string.Empty;
            btnConferma.Text = "Conferma";
        }

        private void elencoAutori(bool visualizzaAnnullati)
        {
            clsAutori a = new clsAutori("CatalogoLibri.mdf");

            if(visualizzaAnnullati)
                tabellaAutori = a.lista('A');
            else
                tabellaAutori = a.lista(' ');

            a.dispose();

            cmbAutori.DataSource = tabellaAutori; 
            cmbAutori.ValueMember = "IdAutore";
            cmbAutori.DisplayMember = "CognAutore";
            cmbAutori.SelectedIndex = -1;

            dgvAutori.DataSource = tabellaAutori;
            dgvAutori.ClearSelection();

            annulla();
        }


     
        private void btnInserisci_Click_1(object sender, EventArgs e)
        {
            grpElenco.Enabled = false;
            grpModifica.Enabled = true;
            btnConferma.Text = "Inserisci autore";

            clsAutori a = new clsAutori("CatalogoLibri.mdf");
            lblCodice.Text=a.getNuovoCodice().ToString();
            a.dispose();
        }
         
        private void btnAnnulla_Click_1(object sender, EventArgs e)
        {
            annulla();
        }

        private void cmbAutori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selezionaAutore&& cmbAutori.SelectedIndex!=-1)
            {
                grpElenco.Enabled = false;
                grpModifica.Enabled = true;
                lblCodice.Text = cmbAutori.SelectedValue.ToString();

                clsAutori a = new clsAutori("CatalogoLibri.mdf");
                a.codAutore = Convert.ToInt32(cmbAutori.SelectedValue);
                a.getDati();
                txtCognome.Text = a.cognome;
                txtNome.Text = a.nome;
                txtDescrizione.Text = a.descrizione;
                dtpDataNascita.Value = a.dataNascita;
                //(ptbImmagine.ImageLocation).Split('\\')[1] = a.immagine;
                if (a.validita == 'A')
                    ckbValidita.Checked = true;
                a.dispose();

            }
        }



        private clsAutori letturaCampiInput()
        {
            clsAutori a = new clsAutori("CatalogoLibri.mdf");
            

            a.codAutore = Convert.ToInt32(lblCodice.Text);
            a.cognome = txtCognome.Text;
            a.nome = txtNome.Text;
            a.descrizione = txtDescrizione.Text;
            a.dataNascita = dtpDataNascita.Value;
            a.immagine = (ptbImmagine.ImageLocation).Split('\\')[1];
            if (ckbValidita.Checked)
                a.validita = 'A';
            else
                a.validita = ' ';
            return a;
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (controlloCampiInput())
            {
                clsAutori a = letturaCampiInput();

                if (btnConferma.Text == "Conferma")
                    a.modifica();
                else
                    a.aggiungi();

                elencoAutori(ckbVisualizzaAnnullati.Checked);
                a.dispose();
            }

        }


        private bool controlloCampiInput()
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Inserisci un nome!");
                txtNome.Focus();
                return false;
            }else if (txtCognome.Text == string.Empty)
            {
                MessageBox.Show("Inserisci un cognome!");
                txtCognome.Focus();
                return false;
            }else if (txtDescrizione.Text == string.Empty)
            {
                MessageBox.Show("Inserisci una descrizione!");
                txtDescrizione.Focus();
                return false;
            }else if (dtpDataNascita.Value>= DateTime.Now)
            {
                MessageBox.Show("Inserisci una data di nascita valida!");
                dtpDataNascita.Focus();
                return false;
            } else if (ptbImmagine.ImageLocation == string.Empty)
            {
                MessageBox.Show("Inserisci un' immagine!");
                //txtNome.Focus();
                return false;
            }else
                return true;
        }

        private void ckbVisualizzaAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            selezionaAutore = false;
            elencoAutori(ckbVisualizzaAnnullati.Checked);
            selezionaAutore = true;
        }

        private void btnImmagine_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\IMG";
            
            openFile.Filter = "Tutti i file (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            openFile.ShowDialog();
            //MessageBox.Show(openFile.FileName);

            //vado a prendere sottocartella e nome del file splittando il percorso globale e prendendone gli ultimi due elementi
            string[] path = openFile.FileName.Split('\\');
            string nomeFile = path[path.Length - 1];
            //MessageBox.Show(nomeFile);
            ptbImmagine.ImageLocation = @"IMG\" + nomeFile;
        }
    }
}
