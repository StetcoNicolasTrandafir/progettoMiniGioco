using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace CatalogoLibri
{
    class adoNetSQL
    {
        private static string cnString;
        private SqlConnection cn;
        private SqlDataReader reader;

        public SqlCommand cmd;
        public SqlDataAdapter adp;

        /// <summary>
        /// Metodo statico per impostare la connessione
        /// </summary>
        /// <param name="dbName">DataBase rispetto al quale impostare la connessione</param>
        public static void impostaConnessione(string dbName)
        {
            string abs = dbName;
            cnString = @"Server=(localdb)\MSSQLLocalDB;attachdbfilename= " + abs + @";Integrated Security=True";                  // 2012
        }


        /// <summary>
        /// Costruttore
        /// </summary>
        public adoNetSQL()
        {
            init();
        }

        /// <summary>
        /// Costruttore
        /// </summary>
        /// <param name="dbName">DataBase rispetto al quale impostare la connessione</param>
        public adoNetSQL(string dbName)
        {
            impostaConnessione(dbName);
            init();
        }

        /// <summary>
        /// Imposta la connessione al dataBase
        /// </summary>
        private void init()
        {
            if (cnString != string.Empty)
            {
                cn = new SqlConnection();
                cn.ConnectionString = cnString;
                cmd = new SqlCommand();
                cmd.Connection = cn;
                adp = new SqlDataAdapter(cmd);
                adp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            }
            else
                throw new Exception("ATTENZIONE: Connection String non inizializzata !");
        }

        /// <summary>
        /// Apre la connessione al database se non è già aperta
        /// </summary>
        public void apriConnessione()
        {
            if (cn != null && cn.ConnectionString != "" && cn.State == ConnectionState.Closed)
                cn.Open();
        }

        /// <summary>
        /// Chiude la connessione al database se non è già chiusa
        /// </summary>
        public void chiudiConnessione()
        {
            if (cn != null && cn.ConnectionString != "" && cn.State == ConnectionState.Open)
                cn.Close();
        }

        /// <summary>
        /// Esegue la query passata per parametro
        /// </summary>
        /// <param name="sql">Testo della query SQL</param>
        /// <param name="tipo">Text/Stored Procedure</param>
        /// <returns>Restituisce l'oggetto DataTable altrimenti va in eccezione</returns>
        public DataTable eseguiQuery(string sql, CommandType tipo)
        {
            DataTable daTable = new DataTable();
            cmd.CommandText = sql;
            cmd.CommandType = tipo;
            if (daTable.IsInitialized) daTable.Clear();
            adp.Fill(daTable);
            this.cmd.Parameters.Clear();
            return daTable;
        }

        /// <summary>
        /// Esegue la query passata per parametro
        /// </summary>
        /// <param name="sql">Testo della query SQL</param>
        /// <param name="tipo">Text/Stored Procedure</param>
        public int eseguiNonQuery(string sql, CommandType tipo)
        {
            int ris = -1;
            cmd.CommandText = sql;
            cmd.CommandType = tipo;
            apriConnessione();
            ris = cmd.ExecuteNonQuery();
            chiudiConnessione();
            this.cmd.Parameters.Clear();
            return ris;
        }

        /// <summary>
        /// Esegue la query scalare senza istanziare nessun dataTable
        /// </summary>
        /// <param name="sql">Testo della query SQL</param>
        /// <param name="tipo">Text/Stored Procedure</param>
        /// <returns>Restituisce String.empty in caso di Errore, altrimenti il risultato della query scalare</returns>
        public string eseguiScalar(string sql, CommandType tipo)
        {
            Object obj;
            string ris = string.Empty;
            cmd.CommandText = sql;
            cmd.CommandType = tipo;
            apriConnessione();
            obj = cmd.ExecuteScalar();
            if (obj != null)
                ris = obj.ToString();
            chiudiConnessione();
            this.cmd.Parameters.Clear();
            return ris;
        }

        /// <summary>
        /// Istanzia un oggetto dataReaderConnection
        /// </summary>
        /// <param name="sql">Testo della query SQL</param>
        /// <param name="tipo">Text/Stored Procedure</param>
        /// <returns>Restituisce l'oggetto istanziato</returns>
        public SqlDataReader creaLettore(string sql, CommandType tipo)
        {
            cmd.CommandText = sql;
            cmd.CommandType = tipo;
            apriConnessione();
            reader = cmd.ExecuteReader();
            return reader;
        }

        /// <summary>
        /// Deistanzia l'oggetto istanziato con creaLettore
        /// </summary>
        public void chiudiLettore()
        {
            chiudiConnessione();
            reader.Dispose();
        }

        /// <summary>
        /// Deistanzia tutti gli oggetti
        /// </summary>
        public void Dispose()
        {
            if (adp != null) adp.Dispose();
            if (cmd != null) cmd.Dispose();
            if (cn != null) cn.Dispose();
        }
    }
}
