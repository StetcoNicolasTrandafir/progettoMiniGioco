using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CatalogoLibri
{
    class clsEditori
    {

        private int _codEditore;
        private string _nome;
        private char _validita;

        private string sql;
        private adoNetSQL sqlEditori;
        private DataTable tabellaEditori = new DataTable();


        public int codEditore
        {
            get { return _codEditore; }
            set { _codEditore = value; }
        }

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }


        public char validita
        {
            get { return _validita; }
            set { _validita = value; }
        }

        public void dispose()
        {
            sqlEditori.Dispose();
        }

        /***************/
        /* Costruttore */
        /***************/
        public clsEditori(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlEditori = new adoNetSQL(pathDB);
        }

        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlEditori.Dispose();
        }



        private void clearDati()
        {
            _nome = string.Empty;
            _validita = ' ';
        }

        public int getNuovoCodice()
        {
            int nuovoCodice = -1;
            string risultato = string.Empty;


            sql = "SELECT MAX(IdEditore) AS MAXCODICE " +
                "FROM Editori";

            try
            {
                risultato = sqlEditori.eseguiScalar(sql, CommandType.Text);
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

            tabellaEditori.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Editori " +
                "WHERE ValEditore IN " + strValidita;
            try
            {
                tabellaEditori = sqlEditori.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [lista]" + e.Message);
            }


            return tabellaEditori;
        }
        //string cognome, string nome, char validita
        public bool aggiungi()
        {
            bool esito = false;

            if (verifica())
            {
                // int codice = getNuovoCodice();

                sql = "INSERT INTO Editori " +
                        "( NomeEditore, ValEditore) " +
                        "VALUES(" + "'" + _nome + "'," +
                                    "'" + _validita + "')";

                try
                {
                    sqlEditori.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Editore inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione!! [aggiungi]" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Editore già presente.");
            }

            return esito;
        }

        private bool verifica()
        {
            bool esito = false;

            string risultato = String.Empty;

            /* seleziona dalla tabella inquinanti tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Editori " +
                "WHERE UPPER(NomeEditore) = '" + _nome.ToUpper() + "'";

            try
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlEditori.eseguiScalar(sql, CommandType.Text);

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

            sql = "UPDATE Editori " +
                  "SET " +
                  "ValEditore = '" + _validita + "', " +
                  "NomeEditore = '" + _nome + "' " +
                  "WHERE IdEditore= '" + _codEditore + "' ";
            try
            {
                sqlEditori.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Editore modificato con successo.");
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
            tabellaEditori.Clear();

            sql = "SELECT " +
                  "NomeEditore, ValEditore " +
                  "FROM Editori " +
                  "WHERE IdEditore = '" + _codEditore + "' ";
            try
            {
                tabellaEditori = sqlEditori.eseguiQuery(sql, CommandType.Text);
                _nome = tabellaEditori.Rows[0].ItemArray[0].ToString();
                _validita = Convert.ToChar(tabellaEditori.Rows[0].ItemArray[1]);
            }
            catch (Exception e)
            {
                _codEditore = -1;
                MessageBox.Show("Attenzione!! [getDati]" + e.Message);
            }
        }
    }
}
