﻿using System;
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
        double scontoCorrente = 0;
        string stringaFiltro;


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

            stringaFiltro = " AND IdEdiLibro ='";
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

            //stringaFiltro = " AND IdAutoreLibro ='";
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

            stringaFiltro = " AND CodRepLibro ='";
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

            stringaFiltro = " AND IdOffLibro ='";
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
                tabellaLibri = l.lista('A');
            else
                tabellaLibri = l.lista(' ');

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
            if (cmbFiltro.SelectedIndex == -1)
                stringaFiltro = string.Empty;
            else
                stringaFiltro += cmbFiltro.SelectedValue.ToString() + "'";


            clsLibro l = new clsLibro("CatalogoLibri.mdf");
            tabellaLibri = l.filtra(stringaFiltro);

            selezionaLibro = false;
            

            cmbLibri.DataSource = tabellaLibri;
            cmbLibri.ValueMember = "IdLibro";
            cmbLibri.DisplayMember = "TitoloLibro";
            cmbLibri.SelectedIndex = -1;

            dgvLibri.DataSource = tabellaLibri;
            dgvLibri.ClearSelection();

            selezionaLibro = true;
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
            lblPrezzo.Text ="00.00";
            lblPrezzoScontato.Text = "00.00";
        }
    }
}