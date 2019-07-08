using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace KlienciWeb.Models
{
    public class KlienciDB
    {
        protected SqlConnection klienciConnection;

        public KlienciDB()
        {
            string cnnString = ConfigurationManager
                .ConnectionStrings["KlienciDB"].ConnectionString;
            klienciConnection = new SqlConnection(cnnString);
        }

        public void DodajKlienta(Klient nowyKlient)
        {
            string insertKlient =
                "INSERT Klienci VALUES (@Nazwa, @NIP, @DataModyfikacji);";
            SqlCommand cmdInsertKlient 
                = new SqlCommand(insertKlient, klienciConnection);
            cmdInsertKlient.Parameters.Add(
                "@Nazwa", SqlDbType.NVarChar, 50).Value = nowyKlient.Nazwa;
            cmdInsertKlient.Parameters.Add(
                "@NIP", SqlDbType.Char, 13).Value = nowyKlient.NIP;
            cmdInsertKlient.Parameters.Add(
                "@DataModyfikacji", SqlDbType.DateTime).Value = nowyKlient.DataModyfikacji;
            klienciConnection.Open();
            cmdInsertKlient.ExecuteNonQuery();
            klienciConnection.Close();
        }

        public void ModyfikujKlienta(Klient zmodyfikowanyKlient)
        {
            string updateKlient =
                "Update Klienci SET Nazwa=@Nazwa, " +
                "NIP=@NIP, DataModyfikacji=@DataModyfikacji " +
                "WHERE IdKlienta=@IdKlienta";
            SqlCommand cmdUpdateKlient
                = new SqlCommand(updateKlient, klienciConnection);
            cmdUpdateKlient.Parameters.Add(
                "@Nazwa", SqlDbType.NVarChar, 50).Value = zmodyfikowanyKlient.Nazwa;
            cmdUpdateKlient.Parameters.Add(
                "@NIP", SqlDbType.Char, 13).Value = zmodyfikowanyKlient.NIP;
            cmdUpdateKlient.Parameters.Add(
                "@DataModyfikacji", SqlDbType.DateTime).Value = zmodyfikowanyKlient.DataModyfikacji;
            cmdUpdateKlient.Parameters.Add(
                "@IdKlienta", SqlDbType.Int).Value = zmodyfikowanyKlient.IdKlienta;
            klienciConnection.Open();
            cmdUpdateKlient.ExecuteNonQuery();
            klienciConnection.Close();

        }
    }
}