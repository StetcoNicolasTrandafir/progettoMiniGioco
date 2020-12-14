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
    public partial class frmReparti : Form
    {


        DataTable tabellaReparti;
        bool selezionaReparto = true;
        public frmReparti()
        {
            InitializeComponent();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            annulla();
        }

        private void annulla()
        {
            grpElenco.Enabled = true;
            grpModifica.Enabled = false;
            txtDescrizione.Text = string.Empty;
            ckbValidita.Checked = false;
            txtCodice.Text = string.Empty;
            btnConferma.Text = "Conferma";
            txtCodice.ReadOnly = false;
        }

        private void elencoReparti(bool visualizzaAnnullati)
        {
            clsReparto r = new clsReparto("CatalogoLibri.mdf");

            if (visualizzaAnnullati)
                tabellaReparti = r.lista('A');
            else
                tabellaReparti = r.lista(' ');

            r.dispose();

            cmbReparti.DataSource = tabellaReparti;
            cmbReparti.ValueMember = "CodReparto";
            cmbReparti.DisplayMember = "DesReparto";
            cmbReparti.SelectedIndex = -1;

            dgvReparti.DataSource = tabellaReparti;
            dgvReparti.ClearSelection();

            annulla();
        }

        private void frmReparti_Load(object sender, EventArgs e)
        {
            selezionaReparto = false;
            elencoReparti(ckbVisualizzaAnnullati.Checked);
            selezionaReparto = true;
        }

        private void ckbVisualizzaAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            frmReparti_Load(this, e);
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            grpElenco.Enabled = false;
            grpModifica.Enabled = true;
            btnConferma.Text = "Inserisci Reparto";
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (controlloCampiInput())
            {
                clsReparto r = letturaCampiInput();
                //MessageBox.Show(r.codReparto);

                if (btnConferma.Text == "Conferma")
                    r.modifica();
                else
                    r.aggiungi();

                elencoReparti(ckbVisualizzaAnnullati.Checked);
                r.dispose();
            }
        }

        private bool controlloCampiInput()
        {
            if(txtCodice.Text.Length<2)
            {
                MessageBox.Show("Inserisci un codice valido!");
                txtCodice.Focus();
                return false;
            }else if(txtDescrizione.Text==string.Empty)
            {
                MessageBox.Show("Inserisci una descrizione valida!");
                txtDescrizione.Focus();
                return false;
            }else
                return true;
        }

        private clsReparto letturaCampiInput()
        {
            clsReparto r = new clsReparto("CatalogoLibri.mdf");
           
            r.codReparto=txtCodice.Text.ToUpper();
            r.descrizione = txtDescrizione.Text;
            if (ckbValidita.Checked)
                r.validita = 'A';
            else
                r.validita = ' ';

            return r;
        }

        private void cmbReparti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selezionaReparto && cmbReparti.SelectedIndex != -1)
            {
                grpElenco.Enabled = false;
                grpModifica.Enabled = true;
                txtCodice.ReadOnly = true ;
                txtCodice.Text = cmbReparti.SelectedValue.ToString();

                clsReparto r = new clsReparto("CatalogoLibri.mdf");
                r.codReparto =cmbReparti.SelectedValue.ToString();
                r.getDati();
                txtDescrizione.Text = r.descrizione;
                if (r.validita == 'A')
                    ckbValidita.Checked = true;
                r.dispose();

            }
        }
    }
}
