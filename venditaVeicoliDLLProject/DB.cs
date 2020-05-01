using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace venditaVeicoliDLLProject
{
    public class DB
    {
        public static string createTableVehicles(string connectionStr)
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
                                            id INT identity(1,1) PRIMARY KEY,type VARCHAR(10),
                                            marca VARCHAR(255),modello VARCHAR(255),cilindrata INT,
                                            potenzaKw FLOAT,dataImmatricolazione DATE,kmPercorsi INT,
                                            colore VARCHAR(25),isUsato VARCHAR(2),isKm0 VARCHAR(2),info VARCHAR(255),prezzo INT);";
                        command.ExecuteNonQuery();
                        command.CommandText = "INSERT INTO veicoli(type,marca,modello,cilindrata,potenzaKw,dataimmatricolazione,kmPercorsi,colore,isUsato,isKm0,info,prezzo) VALUES('auto','Ferrari','488Pista',4000,589.24,#10/08/2019#,0,'Rosso','NO','NO','numero airbag 8',400000);";
                        command.ExecuteNonQuery();

                        Console.ForegroundColor = ConsoleColor.Green;
                        return "\nTabella auto creata!";
                    }
                    catch (OleDbException ex)
                    {
                        return "\n" + ex.Message;
                    }
                }
            }
            return "";
        }

        public static void visualizeTableConsole(string connectionStr)
        {
            if (connectionStr != null)
            {
                OleDbConnection connection = new OleDbConnection(connectionStr);
                using (connection)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM veicoli", connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("---------VEICOLI---------\n");
                        while (reader.Read())
                            Console.WriteLine($"ID: {reader.GetInt32(0)}\n" +
                                $"Type: {reader.GetString(1)}\n" +
                                $"Marca: {reader.GetString(2)}\n" +
                                $"Modello: {reader.GetString(3)}\n" +
                                $"Cilindrata: {reader.GetInt32(4)}\n" +
                                $"Potenza(KW): {reader.GetDouble(5)}\n" +
                                $"Data Immatricolazione: {reader.GetDateTime(6).ToShortDateString()}\n" +
                                $"Chilometri percorsi: {reader.GetInt32(7)}Km\n" +
                                $"Colore: {reader.GetString(8)}\n" +
                                $"Usato: {reader.GetString(9)}\n" +
                                $"Km0: {reader.GetString(10)}\n"+
                                $"Informazioni: {reader.GetString(11)}\n" +
                                $"Prezzo: {reader.GetInt32(12)}$\n"+
                                "\n-------------------------\n");
                    }
                    else
                        Console.WriteLine("\nTabella vuota");
                    reader.Close();
                }
                System.Threading.Thread.Sleep(2000);
            }
        }

        public static string addVehicle(string connectionStr, string type, string marca, string modello, int cilindrata, double kw, DateTime dImm, int kmPercorsi, string colore, string usato, string km0, string info, int prezzo)
        {
            if (connectionStr != null)
            {
                OleDbConnection connection = new OleDbConnection(connectionStr);
                using (connection)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    string SQLquery = "INSERT INTO veicoli(type,marca,modello,cilindrata,potenzaKw,dataimmatricolazione,kmPercorsi,colore,isUsato,isKm0,info,prezzo) VALUES(@type,@marca,@modello,@cilindrata,@potenzaKw,@dataimmatricolazione,@kmPercorsi,@colore,@isUsato,@isKm0,@info,@prezzo)";
                    command.CommandText = SQLquery;

                    command.Parameters.Add(new OleDbParameter("@type", OleDbType.VarChar, 10)).Value = type;
                    command.Parameters.Add("@marca", OleDbType.VarChar, 255).Value = marca;
                    command.Parameters.Add("@modello", OleDbType.VarChar, 255).Value = modello;
                    command.Parameters.Add("@cilindrata", OleDbType.Integer).Value = cilindrata;
                    command.Parameters.Add("@potenzaKw", OleDbType.Double).Value = kw;
                    command.Parameters.Add("@dataimmatricolazione", OleDbType.Date).Value = dImm.ToShortDateString();
                    command.Parameters.Add("@kmPercorsi", OleDbType.Integer).Value = kmPercorsi;
                    command.Parameters.Add("@colore", OleDbType.VarChar, 25).Value = colore;
                    command.Parameters.Add("@isKm0", OleDbType.VarChar, 2).Value = km0;
                    command.Parameters.Add("@isUsato", OleDbType.VarChar, 2).Value = usato;
                    command.Parameters.Add("@info", OleDbType.VarChar, 255).Value = info;
                    command.Parameters.Add("@prezzo", OleDbType.Integer).Value = prezzo;

                    command.Prepare();
                    command.ExecuteNonQuery();

                    Console.ForegroundColor = ConsoleColor.Green;
                    return "\nVeicolo inserito correttamente!!";
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "\n!!ERROR!!";
            }
        }

        public static string deleteVehicle(string connectionStr,int id)
        {
            if (connectionStr != null)
            {
                OleDbConnection connection = new OleDbConnection(connectionStr);
                using (connection)
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;

                        string SQLquery = "DELETE FROM veicoli WHERE id=@id;";
                        command.CommandText = SQLquery;
                        var parameter = new OleDbParameter("@id", OleDbType.Integer);
                        parameter.Value = id;
                        command.Parameters.Add(parameter);
                        command.Prepare();
                        command.ExecuteNonQuery();
                        Console.ForegroundColor = ConsoleColor.Green;
                        return "";
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        return "\n"+ex.Message;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "\n!!ERROR!!";
            }
        }
    }
}
