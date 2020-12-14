using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace CatalogoLibri
{
    class clsReparto
    {

        private string _codReparto;
        private string _descrizione;
        private char _validita;

        private string sql;
        private adoNetSQL sqlReparti;
        private DataTable tabellaReparti = new DataTable();


        public string codReparto
        {
            get { return _codReparto; }
            set { _codReparto = value; }
        }

        public string descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }


        public char validita
        {
            get { return _validita; }
            set { _validita = value; }
        }

        public void dispose()
        {
            sqlReparti.Dispose();
        }

        /***************/
        /* Costruttore */
        /***************/
        public clsReparto(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlReparti = new adoNetSQL(pathDB);
        }

        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlReparti.Dispose();
        }

 

        private void clearDati()
        {
            _descrizione = string.Empty;
            _validita = ' ';
        }

        public DataTable lista(char validita)
        {
            string strValidita = "('')";

            tabellaReparti.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Reparti " +
                "WHERE ValReparto IN " + strValidita;
            try
            {
                tabellaReparti = sqlReparti.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [lista]" + e.Message);
            }


            return tabellaReparti;
        }
        //string cognome, string nome, char validita
        public bool aggiungi()
        {
            bool esito = false;

            if (verifica())
            {
                // int codice = getNuovoCodice();

                sql = "INSERT INTO Reparti " +
                        "( CodReparto, DesReparto, ValReparto) " +
                        "VALUES(" + "'" + _codReparto + "'," + 
                                    "'" + _descrizione + "'," +  
                                    "'" + _validita + "')";

                try
                {
                    sqlReparti.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Reparto inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione!! [aggiungi]" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Reparto già presente.");
            }

            return esito;
        }

        private bool verifica()
        {
            bool esito = false;

            string risultato = String.Empty;

            /* seleziona dalla tabella inquinanti tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Reparti " +
                "WHERE UPPER(CodReparto) = '" + _codReparto + "'";

            try
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlReparti.eseguiScalar(sql, CommandType.Text);

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

            sql = "UPDATE Reparti " +
                  "SET " +
                  "ValReparto = '" + _validita + "', " +
                  "DesReparto = '" + _descrizione + "' " +
                  "WHERE CodReparto= '" + _codReparto + "' ";
            try
            {
                sqlReparti.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Reparto modificato con successo.");
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
            tabellaReparti.Clear();

            sql = "SELECT " +
                  "DesReparto, ValReparto " +
                  "FROM Reparti " +
                  "WHERE CodReparto = '" + _codReparto + "' ";
            try
            {
                tabellaReparti = sqlReparti.eseguiQuery(sql, CommandType.Text);
                _descrizione = tabellaReparti.Rows[0].ItemArray[0].ToString();
                _validita = Convert.ToChar(tabellaReparti.Rows[0].ItemArray[1]);
            }
            catch (Exception e)
            {
                _codReparto = string.Empty;
                MessageBox.Show("Attenzione!! [getDati]" + e.Message);
            }
        }


    }
}
