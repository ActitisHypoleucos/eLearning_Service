using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace eLearningService.Models
{
    public class CLS_DB
    {
        // Definizione delle variabuili della Classe
        private const string StringaDiConnessione = @"Data Source=AULA2-PC10\SQLEXPRESS;Initial Catalog=eLearning;User ID=sa;Password=Pa$$w0rd1!";

    #region  SELECT(query)

        public DataTable MySelect(string SqlString)
        {

            /*           
            * ***************************************************************************************
            * *** Metodo per avviare una query sul DB.
            * ***************************************************************************************
            */
            
            // Definisco l'oggetto per eseguire la connessione al DB
            SqlConnection conn = new SqlConnection();
             // Associo all'oggetto connessione la stringa del db di riferimento a cui connettersi
            conn.ConnectionString = StringaDiConnessione;

            // Definisco l'oggetto con cui eseguire il comando
            SqlCommand cmd = new SqlCommand();
            //Oggetto che mi ritorna la tabella dove ho fatto la select
            SqlDataReader reader;
            
            //Istanzio la tabella
            DataTable RecordLetti = new DataTable();

            // Definire il tipo di comando che lancio
            cmd.CommandType = CommandType.Text;
            // Assegno all'oggetto CMD.Commandtext La stringa del comando da eseguire
            cmd.CommandText = SqlString;
            //Imposto l'oggetto 'conn' come Connection del comando
            cmd.Connection = conn;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                RecordLetti.Load(reader);


                
            }
            catch //(Exception)
            {
                //ErroreMySelect = "Attenzione !! Errore durante l'esecuzione della query nel Db";
                throw new Exception();
            }
            finally
            {
                // Comunque forzo la chiusura della connessione per non lasc iare memoria impegnata
                conn.Close();
            }
            return RecordLetti;
        }
        
    #endregion

    #region SELECT(query,ultimoid)

        /*
        * ***************************************************************************************
        * *** Adolfo 16/05/2018
        * ***************************************************************************************
        * *** Metodo per avviare una query sul DB per estrarre l'ultimo id inserito
        * ***************************************************************************************
        */

        public int EseguiComandoSql(string SqlStringaComando, bool id_SiNo)
        {
            /*
            /*
             * ***************************************************************************************
             * *** Adolfo 16/05/2018
             * ***************************************************************************************
             *  Funzione che permette di lanciare un comando in Sql Server
             */

            // Definisco l'oggetto per eseguire la connessione al DB
            SqlConnection conn = new SqlConnection();
            // Associo all'oggetto connessione la stringa del db di riferimento a cui connettersi
            conn.ConnectionString = StringaDiConnessione;

            // Definisco l'oggetto con cui eseguire il comando
            SqlCommand cmd = new SqlCommand();

            // Definire il tipo di comando che lancio
            cmd.CommandType = CommandType.Text;
            // Assegno all'oggetto CMD.Commandtext La stringa del comando da eseguire
            cmd.CommandText = SqlStringaComando;
            //Imposto l'oggetto 'conn' come Connection del comando
            cmd.Connection = conn;

            int Id_Ultimo = 0;
            try
            {
                conn.Open();
                if (id_SiNo)
                {
                    // Eseguo il comando che mi è stato passato
                    //cmd.ExecuteNonQuery();
                    Id_Ultimo = (int)cmd.ExecuteScalar();
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    Id_Ultimo = 0;
                }
            }
            catch (Exception)
            {
                //Gestisco l'eccezione tramite throw
                //throw new Exception("Errore nell'istruzione SQL");
            }
            finally
            {
                // Chiudo la connessione
                conn.Close();
            }
            return Id_Ultimo;
        }

    #endregion

    #region STORED PROCEDURE(query,List<string>Parametri)

        public void EseguiStoredProcedure(string StringaComandoSQL, List<string> ParametroStoredProcedure,
            List<string> ValoreParametro)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = StringaDiConnessione;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.CommandText = StringaComandoSQL;
            try
            {
                for (int i = 0; i != ParametroStoredProcedure.Count; i++)
                    cmd.Parameters.AddWithValue(ParametroStoredProcedure[i], ValoreParametro[i]);
            }
            catch (Exception err)
            {
                throw new Exception("ATTENZIONE!!\n" + err.Message);
            }
            finally
            {
                ParametroStoredProcedure.Clear();
                ValoreParametro.Clear();
            }
            cmd.Connection = conn;
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            try
            {
                conn.Open();
                Reader = cmd.ExecuteReader();
                cmd.ExecuteNonQuery();
                Table.Load(Reader);
            }
            catch (Exception err)
            {
                throw new Exception("l'errore :   " + err.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    #endregion

    #region SELECT STORE PROCEDURE
        
        public DataTable EseguiStoredProcedureLettura(string StringaComandoSQL)

        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = StringaDiConnessione;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.CommandText = StringaComandoSQL;
            cmd.Connection = conn;
            SqlDataReader Reader;
            DataTable Table = new DataTable();

            try
            {
                conn.Open();

                Reader = cmd.ExecuteReader();

                Table.Load(Reader);

            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                conn.Close();
            }
            return Table;
        }
        
    #endregion

#region FILES - DB

    #region FILE TO BINARY

        public bool databaseFilePut(string varFilePath, string nome)
        {
            bool esito = false;

            //dichiara un array di byte
            byte[] file;

            //istanzia il "convertitore"
            using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    //legge il file, e lo converte
                    file = reader.ReadBytes((int)stream.Length);
                }

                //invia il file al DB
                using (SqlConnection connection = new SqlConnection(StringaDiConnessione))
                {
                    using (var sqlWrite = new SqlCommand("INSERT INTO Materiali_Didattici (Materiale, Tipo) Values(@File,@Tipo)", connection))
                    {
                        connection.Open();
                        sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
                        sqlWrite.Parameters.Add("@Tipo", SqlDbType.VarChar, nome.Length).Value = nome;
                        esito = sqlWrite.ExecuteNonQuery() > 0;
                        connection.Close();
                        return esito;
                    }
                }

            }
        }

    #endregion

    #region BINARY TO FILE
    
        public bool databaseFileRead(string Nome, string varPathToNewLocation)
        {
            
            bool esito = false;

            using (SqlConnection connection = new SqlConnection(StringaDiConnessione))
            using (var sqlQuery = new SqlCommand(@"SELECT Materiale FROM [Materiali_Didattici WHERE [Id_Materiale_PK] = @ID", connection))
            {
                connection.Open();
                sqlQuery.Parameters.AddWithValue("@ID", Nome);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                {
                    if (sqlQueryResult != null)
                    {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        try
                        {
                            //new FileStream()
                            using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                            {
                                fs.Write(blob, 0, blob.Length);
                            }

                            esito = true;
                        }
                        catch (Exception)
                        {
                            esito = false;
                        }

                    }
                }

                connection.Close();
            }
            return esito;
        }
    #endregion

    #region BINARY TO WEB

        public byte[] getFileDB(int Id)
        {

            bool esito = false;
            byte[] file = null;

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = StringaDiConnessione;
                using (var sqlQuery = new SqlCommand(@"SELECT [Materiale] FROM Materiali_Didattici WHERE [Id_Materiale_PK] = @Id", connection)) //Adonet
                {
                    connection.Open();
                    sqlQuery.Parameters.AddWithValue("@Id", Id);
                    using (var sqlQueryResult = sqlQuery.ExecuteReader())
                    {
                        if (sqlQueryResult != null)
                        {
                            try
                            {
                                sqlQueryResult.Read();
                                var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                                sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                                file = blob;
                                esito = true;
                            }
                            catch (Exception)
                            {
                                esito = false;
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                        if (esito==true)
                            return file;
                        else
                            return null;
                    }
                }
            }
        }

        #endregion

#endregion
 
    
    
    }
}