using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CatalogoLibri
{
    class clsOfferte
    {
        private int _codOfferta;
        private string _descrizione;
        private int _sconto;
        private char _validita;

        private string sql;
        private adoNetSQL sqlOfferta;
        private DataTable tabellaOfferte = new DataTable();


        public int codOfferta
        {
            get { return _codOfferta; }
            set { _codOfferta = value; }
        }

        public string descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public int sconto
        {
            get { return _sconto; }
            set { _sconto = value; }
        }

        public char validita
        {
            get { return _validita; }
            set { _validita = value; }
        }

        public void dispose()
        {
            sqlOfferta.Dispose();
        }

        /***************/
        /* Costruttore */
        /***************/
        public clsOfferte(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlOfferta = new adoNetSQL(pathDB);
        }

        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlOfferta.Dispose();
        }



        private void clearDati()
        {
            _descrizione = string.Empty;
            _validita = ' ';
        }

        public int getNuovoCodice()
        {
            string risultato = string.Empty;

            sql = "SELECT MAX(IdOfferta) AS MAXCODICE " +
                "FROM Offerte";

            try
            {
                risultato = sqlOfferta.eseguiScalar(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE!! [getNuovoCodice]" + e.Message);
            }

            return Convert.ToInt32(risultato) + 1; ;
        }

        public DataTable lista(char validita)
        {
            string strValidita = "('')";

            tabellaOfferte.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Offerte " +
                "WHERE ValOfferta IN " + strValidita;
            try
            {
                tabellaOfferte = sqlOfferta.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [lista]" + e.Message);
            }


            return tabellaOfferte;
        }
        //string cognome, string nome, char validita
        public bool aggiungi()
        {
            bool esito = false;

            if (verifica())
            {
                // int codice = getNuovoCodice();

                sql = "INSERT INTO Offerte " +
                        "( DesOfferta, ScontoOfferta, ValOfferta) " +
                        "VALUES(" + "'" + _descrizione + "'," +
                                    "'" + _sconto  + "',"+
                                    "'" + _validita + "')";

                try
                {
                    sqlOfferta.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Offerta inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione!! [aggiungi]" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Offerta già presente.");
            }

            return esito;
        }

        private bool verifica()
        {
            bool esito = false;

            string risultato = String.Empty;

            /* seleziona dalla tabella inquinanti tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Offerte " +
                "WHERE UPPER(DesOfferta) = '" + _descrizione.ToUpper() + "'";

            try
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlOfferta.eseguiScalar(sql, CommandType.Text);

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

            sql = "UPDATE Offerte " +
                  "SET " +
                  "ValOfferta = '" + _validita + "', " +
                  "ScontoOfferta = '" + _sconto + "', " +
                  "DesOfferta = '" + _descrizione + "' " +
                  "WHERE IdOfferta= '" + _codOfferta + "' ";
            try
            {
                sqlOfferta.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Offerta modificato con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [modifica]" + e.Message);
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
            tabellaOfferte.Clear();

            sql = "SELECT " +
                  "DesOfferta, ValOfferta, ScontoOfferta " +
                  "FROM Offerte " +
                  "WHERE IdOfferta = '" + _codOfferta + "' ";
            try
            {
                tabellaOfferte = sqlOfferta.eseguiQuery(sql, CommandType.Text);
                _descrizione = tabellaOfferte.Rows[0].ItemArray[0].ToString();
                _validita = Convert.ToChar(tabellaOfferte.Rows[0].ItemArray[1]);
                _sconto = Convert.ToChar(tabellaOfferte.Rows[0].ItemArray[2]);
            }
            catch (Exception e)
            {
                _codOfferta = -1;
                MessageBox.Show("Attenzione!! [getDati]" + e.Message);
            }
        }
    }
}
