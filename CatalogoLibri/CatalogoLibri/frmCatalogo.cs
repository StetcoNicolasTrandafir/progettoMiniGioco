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
    public partial class frmCatalogo : Form
    {

        bool selezionaLibro = true, selezionaCombo = false;
        DataTable tabellaLibri;

        string stringaFiltro;
        string campoFiltro = string.Empty;


        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void rdbEditore_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltro.Text = "Seleziona editore";

            clsEditori ed = new clsEditori("CatalogoLibri.mdf");
            DataTable tabellaEditori = ed.lista(' ');
            selezionaLibro = false;
            cmbFiltro.DataSource = tabellaEditori;
            cmbFiltro.DisplayMember = "NomeEditore";
            cmbFiltro.ValueMember = "IdEditore";
            cmbFiltro.SelectedIndex = -1;
            selezionaLibro = true;
            ed.dispose();

            campoFiltro = " AND IdEdiLibro ='";
        }

        private void rdbAutore_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltro.Text = "Seleziona autore";

            clsAutori a = new clsAutori("CatalogoLibri.mdf");
            DataTable tabellaAutori = a.lista(' ');
            selezionaLibro = false;
            cmbFiltro.DataSource = tabellaAutori;
            cmbFiltro.DisplayMember = "CognAutore";
            cmbFiltro.ValueMember = "IdAutore";
            cmbFiltro.SelectedIndex = -1;
            selezionaLibro = true;
            a.dispose();

            //campoFiltro = " AND IdAutoreLibro ='";
        }

        private void rdbReparto_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltro.Text = "Seleziona reparto";

            clsReparto r = new clsReparto("CatalogoLibri.mdf");
            DataTable tabellaReparti = r.lista(' ');
            selezionaLibro = false;
            cmbFiltro.DataSource = tabellaReparti;
            cmbFiltro.DisplayMember = "DesReparto";
            cmbFiltro.ValueMember = "CodReparto";
            cmbFiltro.SelectedIndex = -1;
            selezionaLibro = true;
            r.dispose();

            campoFiltro = " AND CodRepLibro ='";
        }

        private void rdbOfferta_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltro.Text = "Seleziona offerta";

            clsOfferte o = new clsOfferte("CatalogoLibri.mdf");
            DataTable tabellaOfferte = o.lista(' ');
            selezionaLibro = false;
            cmbFiltro.DataSource = tabellaOfferte;
            cmbFiltro.DisplayMember = "DesOfferta";
            cmbFiltro.ValueMember = "IdOfferta";
            cmbFiltro.SelectedIndex = -1;
            selezionaLibro = true;
            o.dispose();

            campoFiltro = " AND IdOffLibro ='";
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {


            caricamentoComboBox('A');
            

            selezionaLibro = false;
            elencoLibri(false);
            selezionaLibro = true;
        }

        private void caricamentoComboBox(char val)
        {
            clsOfferte o = new clsOfferte("CatalogoLibri.mdf");
            DataTable tabellaOfferte = o.lista(val);
            cmbOfferta.DataSource = tabellaOfferte;
            cmbOfferta.DisplayMember = "DesOfferta";
            cmbOfferta.ValueMember = "IdOfferta";
            cmbOfferta.SelectedIndex = -1;
            o.dispose();

            clsEditori e = new clsEditori("CatalogoLibri.mdf");
            DataTable tabellaEditori = e.lista(val);
            cmbEditori.DataSource = tabellaEditori;
            cmbEditori.DisplayMember = "NomeEditore";
            cmbEditori.ValueMember = "IdEditore";
            cmbEditori.SelectedIndex = -1;
            e.dispose();

            clsReparto r = new clsReparto("CatalogoLibri.mdf");
            DataTable tabellaReparti = r.lista(val);
            cmbReparto.DataSource = tabellaReparti;
            cmbReparto.DisplayMember = "DesReparto";
            cmbReparto.ValueMember = "CodReparto";
            cmbReparto.SelectedIndex = -1;
            r.dispose();
        }

        private void elencoLibri(bool visualizzaAnnullati)
        {
            clsLibro l = new clsLibro("CatalogoLibri.mdf");

            if (visualizzaAnnullati)
                tabellaLibri = l.tabella('A');
            else
                tabellaLibri = l.tabella(' ');

            l.dispose();

            cmbLibri.DataSource = tabellaLibri;
            cmbLibri.ValueMember = "IdLibro";
            cmbLibri.DisplayMember = "TitoloLibro";
            cmbLibri.SelectedIndex = -1;

            dgvLibri.DataSource = tabellaLibri;
            dgvLibri.ClearSelection();

            annulla();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selezionaLibro)
            {
                if (cmbFiltro.SelectedIndex == -1)
                    stringaFiltro = string.Empty;
                else
                {
                    clsLibro l = new clsLibro("CatalogoLibri.mdf");
                    if (!rdbAutore.Checked)
                    {
                        stringaFiltro = campoFiltro + cmbFiltro.SelectedValue.ToString() + "'";
                        
                        tabellaLibri = l.filtra(stringaFiltro);
                    }
                    else
                        tabellaLibri = l.filtraPerAutore(' ',Convert.ToInt32(cmbFiltro.SelectedValue));
                    l.dispose();
                }
                

                selezionaLibro = false;


                cmbLibri.DataSource = tabellaLibri;
                cmbLibri.ValueMember = "IdLibro";
                cmbLibri.DisplayMember = "TitoloLibro";
                cmbLibri.SelectedIndex = -1;

                dgvLibri.DataSource = tabellaLibri;
                dgvLibri.ClearSelection();

                selezionaLibro = true;
            }
        }

        private void cmbLibri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selezionaLibro && cmbLibri.SelectedIndex != -1)
            {
                //selezionaCombo = false;
                //caricamentoComboBox('A'); //da ripensare
                //selezionaCombo = true;

                lblCodice.Text = cmbLibri.SelectedValue.ToString();


                clsLibro l = new clsLibro("CatalogoLibri.mdf");
                l.codLibro = Convert.ToInt32(cmbLibri.SelectedValue);
                l.getDati();
                txtTitolo.Text = l.titolo;
                cmbReparto.SelectedValue = l.codReparto;
                cmbEditori.SelectedValue = l.codEditore;
                cmbOfferta.SelectedValue = l.codOfferta;
                dtpDataPubblicazione.Value = l.dataPubblicazione;
                clsAutori a = new clsAutori("CatalogoLibri.mdf");
                dgvAutori.DataSource= a.hannoScritto(l.codLibro);
                a.dispose();
                lblPrezzo.Text= l.prezzo.ToString();
                ptbImmagine.ImageLocation = @"IMG\" + l.immagine;

                l.dispose();

            }
        }

        private void lblPrezzo_TextChanged(object sender, EventArgs e)
        {
            if (lblPrezzo.Text!="00.00")
            {
                double prezzoScontato;
                int prezzo = Convert.ToInt32(lblPrezzo.Text);
                clsOfferte o = new clsOfferte("CatalogoLibri.mdf");

                o.codOfferta = Convert.ToInt32(cmbOfferta.SelectedValue);
                o.getDati();
                //MessageBox.Show(o.sconto.ToString()); 
                double kSconto = 1-(1 - (Convert.ToDouble(o.sconto) / 100));
                //MessageBox.Show(kSconto.ToString());
                o.dispose();
                prezzoScontato = prezzo - (prezzo * kSconto);
                lblPrezzoScontato.Text = prezzoScontato.ToString();
            }
        }

        private void annulla()
        {

            txtTitolo.Text = string.Empty;
            dtpDataPubblicazione.Value = DateTime.Now;
            ptbImmagine.ImageLocation = string.Empty;
            lblCodice.Text = string.Empty;
            cmbEditori.SelectedIndex = -1;
            cmbOfferta.SelectedIndex = -1;
            cmbReparto.SelectedIndex = -1;
            dgvAutori.DataSource = null;
            lblPrezzo.Text ="00.00";
            lblPrezzoScontato.Text = "00.00";
        }
    }
}
