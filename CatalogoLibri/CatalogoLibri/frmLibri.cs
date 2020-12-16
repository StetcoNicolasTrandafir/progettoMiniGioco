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
    public partial class frmLibri : Form
    {

        bool selezionaLibro = true, selezionaCombo = false;
        DataTable tabellaLibri;
        double scontoCorrente = 0;
        DataTable tabellaAutori = new DataTable();


        public frmLibri()
        {
            InitializeComponent();
        }


        private void frmLibri_Load(object sender, EventArgs e)
        {
            selezionaLibro = false;
            elencoLibri(ckbVisualizzaAnnullati.Checked);
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


            clsAutori a = new clsAutori("CatalogoLibri.mdf");
            tabellaAutori=a.lista(val);
            for (int i = 0; i < tabellaAutori.Rows.Count; i++)
                cklAutori.Items.Add(tabellaAutori.Rows[i].ItemArray[0].ToString()+"\t"+ tabellaAutori.Rows[i].ItemArray[1]+"\t"+tabellaAutori.Rows[i].ItemArray[2]);
            a.dispose();
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

        private void btnAnnulla_Click(object sender, EventArgs e)
        {   
            annulla();
        }

        private void annulla()
        {
            grpElenco.Enabled = true;
            grpModifica.Enabled = false;
            txtTitolo.Text = string.Empty;
            dtpDataPubblicazione.Value = DateTime.Now;
            ckbValidita.Checked = false;
            ptbImmagine.ImageLocation = string.Empty;
            lblCodice.Text = string.Empty;
            cmbEditori.SelectedIndex = -1;
            cmbOfferta.SelectedIndex = -1;
            cmbReparto.SelectedIndex = -1;
            nmbPrezzo.Value = 0;
            lblPrezzoScontato.Text = "00.00";
            btnConferma.Text = "Conferma";
            cklAutori.Items.Clear();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            grpElenco.Enabled = false;
            grpModifica.Enabled = true;
            btnConferma.Text = "Inserisci libro";

            selezionaCombo = false;
            caricamentoComboBox(' ');
            selezionaCombo = true;

            clsLibro l = new clsLibro("CatalogoLibri.mdf");
            lblCodice.Text = l.getNuovoCodice().ToString();
            l.dispose(); 
        }


        private void nmbPrezzo_ValueChanged_1(object sender, EventArgs e)
        {
            double prezzoScontato;
            int prezzo = Convert.ToInt32(nmbPrezzo.Value);
            double kSconto = 1- (1 - (scontoCorrente / 100));

            prezzoScontato = prezzo - (prezzo*kSconto);
            lblPrezzoScontato.Text = prezzoScontato.ToString();
        }

        private void cmbLibri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selezionaLibro && cmbLibri.SelectedIndex != -1)
            {
                selezionaCombo = false;
                caricamentoComboBox('A'); //da ripensare
                selezionaCombo = true;

                grpElenco.Enabled = false;
                grpModifica.Enabled = true;
                lblCodice.Text = cmbLibri.SelectedValue.ToString();


                clsLibro l = new clsLibro("CatalogoLibri.mdf");
                l.codLibro = Convert.ToInt32(cmbLibri.SelectedValue);
                l.getDati();

                clsAutori a = new clsAutori("CatalogoLibri.mdf");
                DataTable autoriSelezionati = a.hannoScritto(l.codLibro);
                bool presente;
                int codAut;
                int codAutSelezionato;
                for (int i=0; i< tabellaAutori.Rows.Count; i++)
                {
                    presente = false;
                    
                    codAut = Convert.ToInt32(tabellaAutori.Rows[i].ItemArray[0]);
                    for (int j = 0; j < autoriSelezionati.Rows.Count; j++)
                    {
                        codAutSelezionato = Convert.ToInt32(autoriSelezionati.Rows[j].ItemArray[0]);
                        if (codAutSelezionato == codAut)
                            presente = true;
                    }
                        
                    if (presente)
                        cklAutori.SetItemChecked(i, true);
                }

                //DataTable tabSelezionati = a.hannoScritto(l.codLibro);
                a.dispose();

                txtTitolo.Text = l.titolo;
                cmbReparto.SelectedValue = l.codReparto;
                cmbEditori.SelectedValue = l.codEditore;
                cmbOfferta.SelectedValue = l.codOfferta; 
                nmbPrezzo.Value = l.prezzo;
                ptbImmagine.ImageLocation= @"IMG\"+l.immagine;
                //MessageBox.Show(ptbImmagine.ImageLocation.ToString());
                if (l.validita == 'A')
                    ckbValidita.Checked = true;
                l.dispose();
               
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (controlloCampiInput())
            {
                clsLibro l = letturaCampiInput();
                //MessageBox.Show(l.dataPubblicazione.ToString());
                int[] v = new int[cklAutori.CheckedItems.Count];

                for (int i = 0; i < cklAutori.CheckedItems.Count; i++)
                {
                    v[i] = Convert.ToInt32((cklAutori.CheckedItems[i].ToString()).Split('\t')[0]);
                    //MessageBox.Show(v[i].ToString());
                }

                if (btnConferma.Text == "Conferma")
                {
                    l.modifica(v);
                    if(l.validita=='A')
                    {
                        clsScrive s = new clsScrive("CatalogoLibri.mdf");
                        
                        s.elimina(l.codLibro);
                        s.dispose();
                    }    
                }
                    
                else
                    l.aggiungi(v);

                elencoLibri(ckbVisualizzaAnnullati.Checked);
                l.dispose();
            }
        }

        private clsLibro letturaCampiInput()
        {
            clsLibro l= new clsLibro("CatalogoLibri.mdf");

            l.codLibro = Convert.ToInt32(lblCodice.Text);
            l.codEditore = Convert.ToInt32(cmbEditori.SelectedValue);
            l.codOfferta = Convert.ToInt32(cmbOfferta.SelectedValue);
            l.codReparto = cmbReparto.SelectedValue.ToString();
            l.immagine= (ptbImmagine.ImageLocation).Split('\\')[1];
            l.prezzo = Convert.ToInt32(nmbPrezzo.Value);
            l.titolo = txtTitolo.Text;
            l.dataPubblicazione = dtpDataPubblicazione.Value;

            if (ckbValidita.Checked)
                l.validita = 'A';
            else
                l.validita = ' ';

            return l;
        }

        private bool controlloCampiInput()
        {
            if (txtTitolo.Text == string.Empty)
            {
                MessageBox.Show("Inserisci un titolo!");
                txtTitolo.Focus();
                return false;
            }else if (cmbReparto.SelectedIndex == -1)
            {
                MessageBox.Show("Scegli un reparto!");
                cmbReparto.Focus();
                return false;
            }else if (cmbEditori.SelectedIndex == -1)
            {
                MessageBox.Show("Scegli un editore!");
                cmbEditori.Focus();
                return false;
            }else if (nmbPrezzo.Value==0)
            {
                MessageBox.Show("Scegli un prezzo valido!");
                nmbPrezzo.Focus();
                return false;
            }
            else if (cklAutori.CheckedItems.Count==0)
            {
                MessageBox.Show("Inserisci l'/gli autore/i!");
                return false;
            }
            else if (cmbOfferta.SelectedIndex == -1)
            {
                MessageBox.Show("Scegli un' offerta!");
                cmbOfferta.Focus();
                return false;
            }else if (dtpDataPubblicazione.Value > DateTime.Now)
            {
                MessageBox.Show("Inserisci una data valida!");
                dtpDataPubblicazione.Focus();
                return false;
            }else if (ptbImmagine.ImageLocation == string.Empty)
            {
                MessageBox.Show("Seleziona un'immagine!");
                scegliImmagine();
                return false;
            }

            return true;
        }

        private void btnImmagine_Click(object sender, EventArgs e)
        {
            scegliImmagine();
        }

        private void scegliImmagine()
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

        private void ptbImmagine_MouseHover(object sender, EventArgs e)
        {
            ptbImmagine.Width = ptbImmagine.Width * 3;
            ptbImmagine.Height = ptbImmagine.Height * 3;
        }

        private void cmbOfferta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbOfferta.SelectedIndex != -1&& selezionaCombo)
            {
                clsOfferte o = new clsOfferte("CatalogoLibri.mdf");

                o.codOfferta = Convert.ToInt32(cmbOfferta.SelectedValue);
                o.getDati();
                scontoCorrente = o.sconto;
                nmbPrezzo_ValueChanged_1(this, e);
                o.dispose();
            }
        }
    }
}
