using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace CatalogoLibri
{
    class clsScrive
    {
        private int _codScrive;
        private int _codLibro;
        private int _codAutore;
        private char _validita;

        private string sql;
        private adoNetSQL sqlScrive;
        private DataTable tabellaScrive = new DataTable();


        public int codScrive
        {
            get { return _codScrive; }
            set { _codScrive = value; }
        }

        public int codLibro
        {
            get { return _codLibro; }
            set { _codLibro = value; }
        }

        public int codAutore
        {
            get { return _codAutore; }
            set { _codAutore = value; }
        }

        public char validita
        {
            get { return _validita; }
            set { _validita = value; }
        }

        public void dispose()
        {
            sqlScrive.Dispose();
        }

        /***************/
        /* Costruttore */
        /***************/
        public clsScrive(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlScrive = new adoNetSQL(pathDB);
        }

        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlScrive.Dispose();
        }



        private void clearDati()
        {
            _codLibro = -1;
            _codAutore = -1;
            _validita = ' ';
        }

        public int getNuovoCodice()
        {
            string risultato = string.Empty;

            sql = "SELECT MAX(IdScrive) AS MAXCODICE " +
                "FROM Scrive";

            try
            {
                risultato = sqlScrive.eseguiScalar(sql, CommandType.Text);
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

            tabellaScrive.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Scrive " +
                "WHERE  IN " + strValidita;
            try
            {
                tabellaScrive = sqlScrive.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [lista]" + e.Message);
            }


            return tabellaScrive;
        }
        //string cognome, string nome, char validita


        public DataTable hasWritten(int codAutore)
        {
            string strValidita = "('')";

            tabellaScrive.Clear();

            sql = "SELECT * " +
                "FROM Scrive " +
                "WHERE ValScrive IN " + strValidita+" AND IdAutScrive="+codAutore;
            try
            {
                tabellaScrive = sqlScrive.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [lista]" + e.Message);
            }


            return tabellaScrive;
        }

        public bool aggiungi()
        {
            bool esito = false;

            
                // int codice = getNuovoCodice();

                sql = "INSERT INTO Scrive " +
                        "( IdLibScrive, IdAutScrive, ValScrive) " +
                        "VALUES(" + "'" + _codLibro + "'," +
                                    "'" + _codAutore + "'," +
                                    "' ')";

                try
                {
                    sqlScrive.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    //MessageBox.Show("Offerta inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione!! [scrive.aggiungi]" + e.Message);
                }


            return esito;
        }


        public bool elimina(int codiceLibro)
        {
            bool esito = false;

            sql = "UPDATE Scrive " +
                  "SET " +
                  "ValScrive = 'A' " +
                  "WHERE IdLibScrive= '" + codiceLibro + "' ";
            try
            {
                sqlScrive.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                //MessageBox.Show("Scrittura eliminata");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [cancella]" + e.Message);
            }

            return esito;
        }

        public void eliminaRecord(int codiceLibro)
        {

            sql = "DELETE FROM " +
                  "Scrive " +
                  "WHERE IdLibScrive= '" + codiceLibro + "' ";
            try
            {
                sqlScrive.eseguiNonQuery(sql, CommandType.Text);
                //MessageBox.Show("Scrittura eliminata");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione!! [eliminaRecord]" + e.Message);
            }
        }


        //int codice, string nome, string cognome, char validita
        public bool modifica()
        {
            bool esito = false;

            sql = "UPDATE Offerte " +
                  "SET " +
                  "ValOfferta = '" + _validita + "', " +
                  "ScontoOfferta = '" + _codAutore + "', " +
                  "DesOfferta = '" + _codLibro + "' " +
                  "WHERE IdOfferta= '" + _codScrive + "' ";
            try
            {
                sqlScrive.eseguiNonQuery(sql, CommandType.Text);
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
            tabellaScrive.Clear();

            sql = "SELECT " +
                  "IdLibScrive, ValScrive, IdAutScrive " +
                  "FROM Scrive " +
                  "WHERE IdScrive = '" + _codScrive + "' ";
            try
            {
                tabellaScrive = sqlScrive.eseguiQuery(sql, CommandType.Text);
                _codLibro = Convert.ToInt32(tabellaScrive.Rows[0].ItemArray[0]);
                _validita = Convert.ToChar(tabellaScrive.Rows[0].ItemArray[1]);
                _codAutore = Convert.ToInt32(tabellaScrive.Rows[0].ItemArray[2]);
            }
            catch (Exception e)
            {
                _codScrive = -1;
                MessageBox.Show("Attenzione!! [getDati]" + e.Message);
            }
        }
    }
}
