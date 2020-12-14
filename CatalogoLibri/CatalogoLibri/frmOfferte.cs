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
    public partial class frmOfferte : Form
    {
        DataTable tabellaOfferte;
        bool selezionaOfferta = true;

        public frmOfferte()
        {
            InitializeComponent();
        }

        private void frmOfferte_Load(object sender, EventArgs e)
        {
            selezionaOfferta = false;
            elencoOfferte(ckbVisualizzaAnnullati.Checked);
            selezionaOfferta = true;
        }

        private void elencoOfferte(bool visualizzaAnnullati)
        {
            clsOfferte o = new clsOfferte("CatalogoLibri.mdf");

            if (visualizzaAnnullati)
                tabellaOfferte = o.lista('A');
            else
                tabellaOfferte = o.lista(' ');

            o.dispose();

            cmbEditori.DataSource = tabellaOfferte;
            cmbEditori.ValueMember = "IdOfferta";
            cmbEditori.DisplayMember = "DesOfferta";
            cmbEditori.SelectedIndex = -1;

            dgvOfferte.DataSource = tabellaOfferte;
            dgvOfferte.ClearSelection();

            annulla();
        }

        private void annulla()
        {
            grpElenco.Enabled = true;
            grpModifica.Enabled = false;
            txtDescrizione.Text = string.Empty;
            ckbValidita.Checked = false;
            nmbSconto.Value = 0;
            lblCodice.Text = string.Empty;
            btnConferma.Text = "Conferma";
        }

        private void ckbVisualizzaAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            frmOfferte_Load(this, e );
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            grpElenco.Enabled = false;
            grpModifica.Enabled = true;
            btnConferma.Text = "Inserisci offerta";
            clsOfferte o = new clsOfferte("CatalogoLibri.mdf");
            lblCodice.Text = o.getNuovoCodice().ToString();
            o.dispose();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (controlloCampiInput())
            {
                clsOfferte o = letturaCampiInput();
                //MessageBox.Show(r.codReparto);

                if (btnConferma.Text == "Conferma")
                    o.modifica();
                else
                    o.aggiungi();

                elencoOfferte(ckbVisualizzaAnnullati.Checked);
                o.dispose();
            }
        }


        private bool controlloCampiInput()
        {
            if (txtDescrizione.Text == string.Empty)
            {
                MessageBox.Show("Inserisci un nome valido!");
                txtDescrizione.Focus();
                return false;
            }
            else
                return true;
        }

        private clsOfferte letturaCampiInput()
        {
            clsOfferte o = new clsOfferte("CatalogoLibri.mdf");

            o.codOfferta = Convert.ToInt32(lblCodice.Text);
            o.descrizione = txtDescrizione.Text;
            o.sconto = Convert.ToInt32(nmbSconto.Value);
            if (ckbValidita.Checked)
                o.validita = 'A';
            else
                o.validita = ' ';

            return o;
        }

        private void cmbEditori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selezionaOfferta && cmbEditori.SelectedIndex != -1)
            {
                grpElenco.Enabled = false;
                grpModifica.Enabled = true;

                lblCodice.Text = cmbEditori.SelectedValue.ToString();

                clsOfferte o = new clsOfferte("CatalogoLibri.mdf");
                o.codOfferta = Convert.ToInt32(cmbEditori.SelectedValue);
                o.getDati();
                nmbSconto.Value = o.sconto;
                txtDescrizione.Text = o.descrizione;
                if (o.validita == 'A')
                    ckbValidita.Checked = true;
                o.dispose();

            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            annulla();
        }
    }
}
