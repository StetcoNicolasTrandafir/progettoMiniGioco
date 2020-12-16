using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CatalogoLibri
{
    class clsLibro
    {
        private int _codLibro;
        private int _prezzo;
        private string _titolo;
        private string _codReparto;
        private int _codOfferta;
        private int _codEditore;
        private int[] _vAutori;
        private DateTime _dataPubblicazione;
        private string _imgLibro;
        private char _valLibro;

        private string sql;
        private adoNetSQL sqlLibri;
        private DataTable tabellaLibri = new DataTable();

        public int codLibro
        {
            get { return _codLibro; }
            set { _codLibro = value; }
        }

        public int [] vAutori
        {
            get { return _vAutori; }
            set { _vAutori = value; }
        }

        public int codEditore
        {
            get { return _codEditore; }
            set { _codEditore = value; }
        }

        public int prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        public string codReparto
        {
            get { return _codReparto; }
            set { _codReparto = value; }
        }

        public int codOfferta
        {
            get { return _codOfferta; }
            set { _codOfferta = value; }
        }

        public string titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }

        public string immagine
        {
            get { return _imgLibro; }
            set { _imgLibro = value; }
        }


        public DateTime dataPubblicazione
        {
            get { return _dataPubblicazione; }
            set { _dataPubblicazione = value; }
        }

        public char validita
        {
            get { return _valLibro; }
            set { _valLibro = value; }
        }

        public void dispose()
        {
            sqlLibri.Dispose();
        }

        /***************/
        /* Costruttore */
        /***************/
        public clsLibro(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlLibri = new adoNetSQL(pathDB);
        }

        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlLibri.Dispose();
        }

        public int getNuovoCodice()
        {
            string risultato = string.Empty;


            sql = "SELECT MAX(IdLibro) AS MAXCODICE " +
                "FROM Libri";

            try
            {
                risultato = sqlLibri.eseguiScalar(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE!! [getNuovoCodice]" + e.Message);
            }

            return Convert.ToInt32(risultato) + 1; ;
        }

        private void clearDati()
        {
            _codReparto = string.Empty;
            _titolo = string.Empty;
            _imgLibro = string.Empty;
            _codOfferta = -1;
            _prezzo = -1;
            _codEditore = -1;
            _dataPubblicazione = DateTime.MinValue;
            _valLibro = ' ';
        }

        public DataTable lista(char validita)
        {
            string strValidita = "('')";

            tabellaLibri.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Libri " +
                "WHERE ValLibro IN " + strValidita;
            try
            {
                tabellaLibri = sqlLibri.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [lista]" + e.Message);
            }


            return tabellaLibri;
        }

        public DataTable tabella(char validita)
        {
            string strValidita = "('')";

            tabellaLibri.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT Libri.IdLibro, Libri.TitoloLibro, Libri.DataLibro, Reparti.DesReparto, Libri.PrezzoLibro, Offerte.DesOfferta, Editori.NomeEditore " +
                "FROM Libri " +
                "INNER JOIN Reparti ON (CodRepLibro = CodReparto) " +
                "INNER JOIN Editori ON (IdEdiLibro = IdEditore) " +
                "INNER JOIN Offerte ON (IdOffLibro = IdOfferta AND ValLibro IN " + strValidita + ")";
            try
            {
                tabellaLibri = sqlLibri.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [lista]" + e.Message);
            }


            return tabellaLibri;
        }


        public DataTable hasWritten(char validita, int codAutore)
        {
            string strValidita = "('')";

            tabellaLibri.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";


            sql = "SELECT Libri.IdLibro, Libri.TitoloLibro, Libri.DataLibro, Reparti.DesReparto, Libri.PrezzoLibro, Offerte.DesOfferta, Editori.NomeEditore " +
                "FROM Libri " +
                "INNER JOIN Reparti ON (CodRepLibro = CodReparto) " +
                "INNER JOIN Editori ON (IdEdiLibro = IdEditore) " +
                "INNER JOIN Scrive ON (IdAutScrive = "+codAutore+" and IdLibro= IdLibScrive) " +
                "INNER JOIN Offerte ON (IdOffLibro = IdOfferta )";
            try
            {
                tabellaLibri = sqlLibri.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [lista]" + e.Message);
            }


            return tabellaLibri;
        }

        public DataTable filtra(string filtro)
        {
            string strValidita = "('')";

            sql = "SELECT Libri.IdLibro, Libri.TitoloLibro, Libri.DataLibro, Reparti.DesReparto, Libri.PrezzoLibro, Offerte.DesOfferta, Editori.NomeEditore " +
                "FROM Libri " +
                "INNER JOIN Reparti ON (CodRepLibro = CodReparto) " +
                "INNER JOIN Editori ON (IdEdiLibro = IdEditore) " +
                "INNER JOIN Offerte ON (IdOffLibro = IdOfferta AND ValLibro IN " + strValidita + filtro+")";
            try
            {
                tabellaLibri = sqlLibri.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [filtra]" + e.Message);
            }


            return tabellaLibri;
        }

        //string cognome, string nome, char validita
        public bool aggiungi()
        {
            bool esito = false;

            if (verifica())
            {
                // int codice = getNuovoCodice();

                sql = "INSERT INTO Libri " +
                        "( TitoloLibro, ImgLibro, DataLibro, IdOffLibro, CodRepLibro, IdEdiLibro, PrezzoLibro, ValLibro) " +
                        "VALUES(" + "'" + _titolo + "'," +
                                    "'" + _imgLibro + "'," +
                                    "'" + _dataPubblicazione.ToString("MM/dd/yyyy") + "'," +
                                    "'" + _codOfferta + "'," +
                                    "'" + _codReparto + "'," +
                                    "'" + _codEditore + "'," +
                                    "" + _prezzo + "," +
                                    "'" + _valLibro + "')";

                try
                {
                    sqlLibri.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Libro inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione!! [aggiungi]" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Libro già presente.");
            }

            return esito;
        }

        private bool verifica()
        {
            bool esito = false;

            string risultato = String.Empty;


            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Libri " +
                "WHERE UPPER(TitoloLibro) = '" + _titolo.ToUpper() + "' AND DataLibro='" + _dataPubblicazione.ToString("MM/dd/yyyy")+"'"; 

            try
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlLibri.eseguiScalar(sql, CommandType.Text);

                //se risultato vale 0, non ci altre aziende con quel nome
                if (Convert.ToInt32(risultato) == 0)
                {
                    esito = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE!! [verifica]" + e.Message);
            }

            //se la funziona restituisce falso, esiste già un inquinante con quel nome
            return esito;
        }
        //int codice, string nome, string cognome, char validita
        public bool modifica()
        {
            bool esito = false;

            sql = "UPDATE Libri " +
                  "SET " +
                  "TitoloLibro = '" + _titolo + "', " +
                  "CodRepLibro = '" + _codReparto + "', " +
                  "IdOffLibro = '" + _codOfferta + "', " +
                  "ImgLibro = '" + _imgLibro + "', " +
                  "PrezzoLibro = '" + _prezzo + "', " +
                  "IdEdiLibro = '" + _codEditore+ "', " +
                  "DataLibro = '" + _dataPubblicazione.ToString("MM/dd/yyyy") + "', " +
                  "ValLibro = '" + _valLibro + "' " +
                  "WHERE IdLibro = '" + _codLibro + "' ";
            try
            {
                sqlLibri.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Libro modificato con successo.");

                clsScrive s = new clsScrive("CatalogoLibri.mdf");

                s.dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [modifica]" + e.Message);
            }

            return esito;
        }
        //int codice, char validita
        public bool cancella()
        {
            bool esito = false;

            sql = "UPDATE Libri " +
                  "SET " +
                  "ValLibro = '" + _valLibro + "' " +
                  "WHERE ValLibro = '" + _codLibro + "' ";
            try
            {
                sqlLibri.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                if (_valLibro == 'A')
                    MessageBox.Show("Libro cancellato con successo.");
                else
                    MessageBox.Show("Libro ripristinato con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [cancella]" + e.Message);
            }

            return esito;
        }

        /***************************/
        /* Recupera singola Entità */
        /***************************/
        public void getDati()
        {
            int I;

            clearDati();
            tabellaLibri.Clear();

            sql = "SELECT " +
                  " TitoloLibro, ImgLibro, DataLibro, CodRepLibro, IdOffLibro, ValLibro, PrezzoLibro, IdEdiLibro " +
                  "FROM Libri " +
                  "WHERE IdLibro = '" + _codLibro + "' ";
            try
            {
                tabellaLibri = sqlLibri.eseguiQuery(sql, CommandType.Text);
                _titolo = tabellaLibri.Rows[0].ItemArray[0].ToString();
                _imgLibro = tabellaLibri.Rows[0].ItemArray[1].ToString();
                _dataPubblicazione = Convert.ToDateTime(tabellaLibri.Rows[0].ItemArray[2].ToString());
                _codReparto = tabellaLibri.Rows[0].ItemArray[3].ToString();
                _codOfferta = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[4]);
                _valLibro = Convert.ToChar(tabellaLibri.Rows[0].ItemArray[5]);
                _prezzo = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[6]);
                _codEditore = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[7]);

            }
            catch (Exception e)
            {
                _codLibro = -1;
                MessageBox.Show("Attenzione!! [getDati]" + e.Message);
            }
        }
    }
}
