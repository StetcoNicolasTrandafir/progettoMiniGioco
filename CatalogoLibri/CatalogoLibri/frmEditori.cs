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
    public partial class frmEditori : Form
    {

        DataTable tabellaEditori;
        bool selezionaEditore = true;
        
        public frmEditori()
        {
            InitializeComponent();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            annulla();
        }

        private void elencoEditori(bool visualizzaAnnullati)
        {
            clsEditori e = new clsEditori("CatalogoLibri.mdf");

            if (visualizzaAnnullati)
                tabellaEditori = e.lista('A');
            else
                tabellaEditori = e.lista(' ');

            e.dispose();

            cmbEditori.DataSource = tabellaEditori;
            cmbEditori.ValueMember = "IdEditore";
            cmbEditori.DisplayMember = "NomeEditore";
            cmbEditori.SelectedIndex = -1;

            dgvEditori.DataSource = tabellaEditori;
            dgvEditori.ClearSelection();

            annulla();
        }

        private void annulla()
        {
            grpElenco.Enabled = true;
            grpModifica.Enabled = false;
            txtNome.Text = string.Empty;
            ckbValidita.Checked = false;
            lblCodice.Text = string.Empty;
            btnConferma.Text = "Conferma";
        }

        private void frmEditori_Load(object sender, EventArgs e)
        {
            selezionaEditore = false;
            elencoEditori(ckbVisualizzaAnnullati.Checked);
            selezionaEditore = true;
        }

        private void ckbVisualizzaAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            frmEditori_Load(this, e);
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            grpElenco.Enabled = false;
            grpModifica.Enabled = true;
            btnConferma.Text = "Inserisci Editore";
            clsEditori ed = new clsEditori("CatalogoLibri.mdf");
            lblCodice.Text = ed.getNuovoCodice().ToString();
            ed.dispose();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (controlloCampiInput())
            {
                clsEditori ed = letturaCampiInput();
                //MessageBox.Show(r.codReparto);

                if (btnConferma.Text == "Conferma")
                    ed.modifica();
                else
                    ed.aggiungi();

                elencoEditori(ckbVisualizzaAnnullati.Checked);
                ed.dispose();
            }
        }

        private bool controlloCampiInput()
        {
            if (txtNome.Text==string.Empty)
            {
                MessageBox.Show("Inserisci un nome valido!");
                txtNome.Focus();
                return false;
            }
            else 
                return true;
        }


        private clsEditori letturaCampiInput()
        {
            clsEditori e = new clsEditori("CatalogoLibri.mdf");

            e.codEditore = Convert.ToInt32(lblCodice.Text);
            e.nome = txtNome.Text;
            if (ckbValidita.Checked)
                e.validita = 'A';
            else
                e.validita = ' ';

            return e;
        }

        private void cmbEditori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selezionaEditore && cmbEditori.SelectedIndex != -1)
            {
                grpElenco.Enabled = false;
                grpModifica.Enabled = true;
                
                lblCodice.Text = cmbEditori.SelectedValue.ToString();

                clsEditori ed = new clsEditori("CatalogoLibri.mdf");
                ed.codEditore = Convert.ToInt32(cmbEditori.SelectedValue);
                ed.getDati();
                txtNome.Text = ed.nome;
                if (ed.validita == 'A')
                    ckbValidita.Checked = true;
                ed.dispose();

            }
        }
    }
}
