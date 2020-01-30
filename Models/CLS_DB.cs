using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace eLearningService.Models
{
    public class CLS_DB
    {
        /*
  * ***************************************************************************************
  * *** Definizione della classe che utilizzo per effettuare tutti gli accessi al database.
  * ***************************************************************************************
  */
        // Definizione delle variabuili della Classe
        private const string StringaDiConnessione = @"Data Source=AULA2-PC10\SQLEXPRESS;Initial Catalog=eLearning;User ID=sa;Password=Pa$$w0rd1!";

        public DataTable MySelect(string SqlString)
        {

            /*           
            * ***************************************************************************************
            * *** Metodo per avviare una query sul DB.
            * ***************************************************************************************
            */
            
            // Definisco l'oggetto per eseguire la connessione al DB
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = StringaDiConnessione;

            // Definisco l'oggetto con cui eseguire il comando
            SqlCommand cmd = new SqlCommand();

            SqlDataReader reader;     //Oggetto che mi ritorna la tabella dove ho fatto la select
            DataTable RecordLetti = new DataTable();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = SqlString;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                RecordLetti.Load(reader);


                // Data is accessible through the DataReader object here.
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
    }
}