using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CatalogoLibri
{
    class clsAutori
    {
        private int _codAutore;
        private string _cognome;
        private string _nome;
        private string _descrizione;
        private DateTime _dataNascita;
        private string _imgAutore;
        private char _valAutore;

        private string sql;
        private adoNetSQL sqlAutori;
        private DataTable tabellaAutori = new DataTable();


        public int codAutore
        {
            get { return _codAutore; }
            set { _codAutore = value; }
        }

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public string cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public string immagine
        {
            get { return _imgAutore; }
            set { _imgAutore = value; }
        }


        public DateTime dataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }



        public char validita
        {
            get { return _valAutore; }
            set { _valAutore = value; }
        }

        public void dispose()
        {
            sqlAutori.Dispose();
        }

        /***************/
        /* Costruttore */
        /***************/
        public clsAutori(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlAutori = new adoNetSQL(pathDB);
        }

        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlAutori.Dispose();
        }

        public int getNuovoCodice()
        {
            int nuovoCodice = -1;
            string risultato = string.Empty;


            sql = "SELECT MAX(IdAutore) AS MAXCODICE " +
                "FROM Autori";

            try
            {
                risultato = sqlAutori.eseguiScalar(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE!! [getNuovoCodice]" + e.Message);
            }

            return Convert.ToInt32(risultato) + 1; ;
        }

        private void clearDati()
        {
            _nome = string.Empty;
            _cognome = string.Empty;
            _imgAutore = string.Empty;
            _descrizione = string.Empty;
            _dataNascita = DateTime.MinValue;
            _valAutore = ' ';
        }

        public DataTable hannoScritto(int codLibro)
        {
            string strValidita = "('')";

            tabellaAutori.Clear();


            sql = "SELECT Autori.IdAutore, Autori.CognAutore, Autori.NomeAutore " +
                "FROM Autori " +
                "INNER JOIN Scrive ON (IdLibScrive= "+codLibro+" AND IdAutore=IdAutScrive and ValScrive IN " + strValidita + ")";

            try
            {
                tabellaAutori = sqlAutori.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [hannoScritto]" + e.Message);
            }


            return tabellaAutori;
        }

        public DataTable lista(char validita)
        {
            string strValidita = "('')";

            tabellaAutori.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Autori " +
                "WHERE ValAutore IN " + strValidita;
            try
            {
                tabellaAutori = sqlAutori.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [lista]" + e.Message);
            }


            return tabellaAutori;
        }


        //string cognome, string nome, char validita
        public bool aggiungi()
        {
            bool esito = false;

            if (verifica())
            {
                // int codice = getNuovoCodice();

                sql = "INSERT INTO Autori " +
                        "( CognAutore, FotoAutore, DatNasAutore, DesAutore, NomeAutore, ValAutore) " +
                        "VALUES(" + "'" + _cognome + "'," +
                                    "'" + _imgAutore + "'," +
                                    "'" + _dataNascita.ToString("MM/dd/yyyy") + "'," +
                                    "'"+_descrizione+"',"+
                                    "'"+_nome+"',"+
                                    "'" + _valAutore + "')";

                try
                {
                    sqlAutori.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Autore inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione!! [aggiungi]" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Autore già presente.");
            }

            return esito;
        }

        private bool verifica()
        {
            bool esito = false;

            string risultato = String.Empty;

            /* seleziona dalla tabella inquinanti tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Autori " +
                "WHERE UPPER(NomeAutore) = '" + _cognome.ToUpper() + "' AND UPPER(CognAutore)='"+_nome.ToUpper()+"'";

            try 
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlAutori.eseguiScalar(sql, CommandType.Text);

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

            sql = "UPDATE Autori " +
                  "SET " +
                  "CognAutore = '" + _cognome + "', " +
                  "NomeAutore = '" + _nome + "', " +
                  "DesAutore = '" + _descrizione + "', " +
                  "FotoAutore = '" + _imgAutore + "', " +
                  "DatNasAutore = '" + _dataNascita.ToString("MM/dd/yyyy") + "', " +
                  "ValAutore = '" + _valAutore + "' " +
                  "WHERE IdAutore = '" + _codAutore + "' ";
            try
            {
                sqlAutori.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Autore modificato con successo.");
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

            sql = "UPDATE Autore " +
                  "SET " +
                  "ValAutore = '" + _valAutore + "' " +
                  "WHERE IdAutore = '" + _codAutore + "' ";
            try
            {
                sqlAutori.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                if (_valAutore == 'A')
                    MessageBox.Show("Autore cancellato con successo.");
                else
                    MessageBox.Show("Autore ripristinato con successo.");
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
            tabellaAutori.Clear();

            sql = "SELECT " +
                  " CognAutore, FotoAutore, DatNasAutore, NomeAutore, DesAutore, ValAutore " +
                  "FROM Autori " +
                  "WHERE IdAutore = '" + _codAutore + "' ";
            try
            {
                tabellaAutori = sqlAutori.eseguiQuery(sql, CommandType.Text);
                _cognome = tabellaAutori.Rows[0].ItemArray[0].ToString();
                _imgAutore = tabellaAutori.Rows[0].ItemArray[1].ToString();
                _dataNascita = Convert.ToDateTime(tabellaAutori.Rows[0].ItemArray[2].ToString());
                _nome = tabellaAutori.Rows[0].ItemArray[3].ToString();
                _descrizione= tabellaAutori.Rows[0].ItemArray[4].ToString();
                _valAutore = Convert.ToChar(tabellaAutori.Rows[0].ItemArray[5]);
            }
            catch (Exception e)
            {
                _codAutore = -1;
                MessageBox.Show("Attenzione!! [getDati]" + e.Message);
            }
        }


    }
}
