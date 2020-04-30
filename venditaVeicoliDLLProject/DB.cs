using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace venditaVeicoliDLLProject
{
    public class DB
    {
        public static void createTableCars(string connectionStr)
        {
            if (connectionStr != null)
            {
                OleDbConnection connection = new OleDbConnection(connectionStr);
                using (connection)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    try
                    {
                        command.CommandText = @"CREATE TABLE veicoli(
                                            id int identity(1,1) PRIMARY KEY,type VARCHAR(10),
                                            marca VARCHAR(255),modello VARCHAR(255),cilindrata INT,
                                            potenzaKw FLOAT,dataImmatricolazione DATE,kmPercorsi INT,
                                            colore VARCHAR(25),isUsato BIT,isKm0 BIT,prezzo INT);";
                        command.ExecuteNonQuery();
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine("\n\n" + ex.Message);
                        System.Threading.Thread.Sleep(2000);
                        return;
                    }

                    command.CommandText = "INSERT INTO veicoli(id,type,marca,modello,cilindrata,potenzaKw,dataimmatricolazione,kmPercorsi,colore,isUsato,isKm0,prezzo) VALUES(1,'auto','Ferrari','488Pista',4000,589.24,10/08/2019,0,'red',0,0,400000);";
                    command.ExecuteNonQuery();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\nTabella auto creata!");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(2000);
                }
            }
        }

        private static void ListCars(string connectionStr)
        {
            if (connectionStr != null)
            {
                OleDbConnection connection = new OleDbConnection(connectionStr);
                using (connection)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM cars", connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Console.WriteLine("\n");
                        while (reader.Read())
                            Console.WriteLine($"ID{reader.GetInt32(0)}\n");
                    }
                    else
                        Console.WriteLine("\n\nRiga non trovata");
                    reader.Close();
                }
                Console.WriteLine("\nVeicolo aggiunto");
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
