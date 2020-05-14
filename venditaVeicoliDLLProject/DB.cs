using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using static venditaVeicoliDLLProject.Utilities;

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
                        command.CommandText = "INSERT INTO veicoli(type,marca,modello,cilindrata,potenzaKw,dataimmatricolazione,kmPercorsi,colore,isUsato,isKm0,info,prezzo) VALUES('auto','Ferrari','F8 Triturbo',4000,459,#10/01/2020#,0,'Blu','NO','NO','numero airbag 12',388999);";
                        command.ExecuteNonQuery();
                        command.CommandText = "INSERT INTO veicoli(type,marca,modello,cilindrata,potenzaKw,dataimmatricolazione,kmPercorsi,colore,isUsato,isKm0,info,prezzo) VALUES('moto','BMW','S100RR',1000,150,#10/08/2019#,0,'Bianco','NO','NO','Marca sella BMWStock',29999);";
                        command.ExecuteNonQuery();

                        Console.ForegroundColor = ConsoleColor.Green;
                        return "\nTabella auto creata!";
                    }
                    catch (OleDbException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        return "\n!!ERROR!!" + ex.Message;
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
                                $"Km0: {reader.GetString(10)}\n" +
                                $"Informazioni: {reader.GetString(11)}\n" +
                                $"Prezzo: {reader.GetInt32(12)}$\n" +
                                "\n-------------------------\n");
                    }
                    else
                        Console.WriteLine("\nTabella vuota");
                    reader.Close();
                }
                System.Threading.Thread.Sleep(2000);
            }
        }

        public static string updateVehicle(string connectionStr, string id, string uField, string toUpdate, int nf)
        {
            if (connectionStr != null)
            {
                OleDbConnection connection = new OleDbConnection(connectionStr);
                using (connection)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    int ausI = 0;
                    string ausS = null;
                    DateTime ausDT = Convert.ToDateTime("01/01/1900");
                    double ausD = 0;
                    int fl = 0;

                    string SQLquery = null;

                    switch (nf)
                    {
                        case 0:
                            if (toUpdate == "auto" || toUpdate == "moto")
                            {
                                ausS = toUpdate; fl = 2;
                                SQLquery = $"UPDATE veicoli SET type=@aus WHERE id={id};";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                return "!!ERROR VALORI VALIDI-> auto/moto!!\n";
                            }
                            break;
                        case 1: ausS = toUpdate; fl = 2; SQLquery = $"UPDATE veicoli SET marca=@aus WHERE id={id};"; break;
                        case 2: ausS = toUpdate; fl = 2; SQLquery = $"UPDATE veicoli SET modello=@aus WHERE id={id};"; break;
                        case 3:
                            try { ausI = int.Parse(toUpdate); fl = 1; SQLquery = $"UPDATE veicoli SET cilindrata=@aus WHERE id={id};"; }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                return "!!ERROR!!\n" + ex.Message;
                            }
                            break;
                        case 4:
                            try { ausD = double.Parse(toUpdate); fl = 4; SQLquery = $"UPDATE veicoli SET potenzaKw=@aus WHERE id={id};"; }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                return "!!ERROR!!\n" + ex.Message;
                            }
                            break;
                        case 5:
                            try { ausDT = Convert.ToDateTime(toUpdate); fl = 3; SQLquery = $"UPDATE veicoli SET dataImmatricolazione=@aus WHERE id={id};"; }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                return "!!ERROR!!\n" + ex.Message;
                            }
                            break;
                        case 6: ausI = int.Parse(toUpdate); fl = 1; SQLquery = $"UPDATE veicoli SET kmPercorsi=@aus WHERE id={id};"; break;
                        case 7: ausS = toUpdate; fl = 2; SQLquery = $"UPDATE veicoli SET colore=@aus WHERE id={id};"; break;
                        case 8:
                            if (toUpdate == "SI" || toUpdate == "NO")
                            {
                                ausS = toUpdate; fl = 2;
                                SQLquery = $"UPDATE veicoli SET isUsato=@aus WHERE id={id};";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                return "!!ERROR VALORI VALIDI-> SI/NO!!\n";
                            }
                            break;
                        case 9:
                            if (toUpdate == "SI" || toUpdate == "NO")
                            {
                                ausS = toUpdate; fl = 2;
                                SQLquery = $"UPDATE veicoli SET isKm0=@aus WHERE id={id};";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                return "!!ERROR VALORI VALIDI-> SI/NO!!\n";
                            }
                            break;
                        case 10: ausS = toUpdate; fl = 2; SQLquery = $"UPDATE veicoli SET info=@aus WHERE id={id};"; break;
                        case 11:
                            try { ausI = int.Parse(toUpdate); fl = 1; SQLquery = $"UPDATE veicoli SET prezzo=@aus WHERE id={id};"; }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                return "!!ERROR!!\n" + ex.Message;
                            }
                            break;
                    }

                    if (fl == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        return "\n!!ERROR!!";
                    }
                    else if (fl == 1)
                    {
                        command.Parameters.Add("@aus", OleDbType.Integer).Value = ausI;
                        //SQLquery = $"UPDATE veicoli SET {uField}={ausI} WHERE id={id};";
                    }
                    else if (fl == 2)
                    {
                        command.Parameters.Add("@aus", OleDbType.VarChar, 255).Value = ausS;
                        //SQLquery = $"UPDATE veicoli SET {uField}='{ausS}' WHERE id={id};";
                    }
                    else if (fl == 3)
                    {
                        command.Parameters.Add("@aus", OleDbType.Date).Value = ausDT;
                        //SQLquery = $"UPDATE veicoli SET {uField}=#{ausDT}# WHERE id={id};";
                    }
                    else
                    {
                        command.Parameters.Add("@aus", OleDbType.Double).Value = ausD;
                        //SQLquery = $"UPDATE veicoli SET {uField}={ausD} WHERE id={id};";
                    }

                    if (SQLquery != null)
                    {
                        try
                        {
                            if (IDexitence(connectionStr, int.Parse(id)))
                            {
                                command.CommandText = SQLquery;
                                command.Prepare();
                                command.ExecuteNonQuery();

                                Console.ForegroundColor = ConsoleColor.Green;
                                return "Campo Modificato Correttamente";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                return "\n!!il record non esiste nella tabella!!".ToUpper();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            return "\n!!ERROR!! " + ex.Message;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        return "\n!!ERROR!!";
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "\n!!ERROR!!";
            }
        }

        public static bool IDexitence(string connectionStr, int id)
        {
            bool flag = false;
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
                        while (reader.Read())
                        {
                            int aus = reader.GetInt32(0);
                            if (aus == id)
                            {
                                flag = true;
                                return flag;
                            }
                        }
                    }
                    reader.Close();
                }
            }
            return flag;
        }

        public static string addVehicle(string connectionStr, string type, string marca, string modello, int cilindrata, double kw, DateTime dImm, int kmPercorsi, string colore, string usato, string km0, string info, int prezzo)
        {
            if (connectionStr != null)
            {
                try
                {
                    OleDbConnection connection = new OleDbConnection(connectionStr);
                    using (connection)
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;

                        //string SQLquery = $"INSERT INTO veicoli(type,marca,modello,cilindrata,potenzaKw,dataimmatricolazione,kmPercorsi,colore,isUsato,isKm0,info,prezzo) VALUES('{type}','{marca}','{modello}',{cilindrata},{kw},#{dImm.ToShortDateString()}#,{kmPercorsi},'{colore}','{usato}','{km0}','{info}',{prezzo});";
                        string SQLquery = $"INSERT INTO veicoli(type,marca,modello,cilindrata,potenzaKw,dataimmatricolazione,kmPercorsi,colore,isUsato,isKm0,info,prezzo) VALUES(@type,@marca,@modello,@cilindrata,@potenzaKw,@dataimmatricolazione,@kmPercorsi,@colore,@isUsato,@isKm0,@info,@prezzo);";
                        command.CommandText = SQLquery;

                        command.Parameters.Add(new OleDbParameter("@type", OleDbType.VarChar, 10)).Value = type;
                        command.Parameters.Add(new OleDbParameter("@marca", OleDbType.VarChar, 255)).Value = marca;
                        command.Parameters.Add(new OleDbParameter("@modello", OleDbType.VarChar, 255)).Value = modello;
                        command.Parameters.Add(new OleDbParameter("@cilindrata", OleDbType.Integer)).Value = cilindrata;
                        command.Parameters.Add(new OleDbParameter("@potenzaKw", OleDbType.Double)).Value = kw;
                        command.Parameters.Add(new OleDbParameter("@dataimmatricolazione", OleDbType.Date)).Value = dImm;
                        command.Parameters.Add(new OleDbParameter("@kmPercorsi", OleDbType.Integer)).Value = kmPercorsi;
                        command.Parameters.Add(new OleDbParameter("@colore", OleDbType.VarChar, 25)).Value = colore;
                        command.Parameters.Add(new OleDbParameter("@isKm0", OleDbType.VarChar, 3)).Value = km0;
                        command.Parameters.Add(new OleDbParameter("@isUsato", OleDbType.VarChar, 3)).Value = usato;
                        command.Parameters.Add(new OleDbParameter("@info", OleDbType.VarChar, 255)).Value = info;
                        command.Parameters.Add(new OleDbParameter("@prezzo", OleDbType.Integer)).Value = prezzo;

                        command.Prepare();
                        command.ExecuteNonQuery();

                        Console.ForegroundColor = ConsoleColor.Green;
                        return "\nVeicolo inserito correttamente!!";
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "\n!!ERROR!! "+ex.Message;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "\n!!ERROR!!";
            }
        }

        public static string deleteVehicle(string connectionStr, int id)
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

                            string SQLquery = $"DELETE FROM veicoli WHERE id={id};";
                            command.CommandText = SQLquery;

                        if (IDexitence(connectionStr, id))
                        {
                            command.Prepare();
                            command.ExecuteNonQuery();
                            Console.ForegroundColor = ConsoleColor.Green;
                            return "\nRECORD ELIMINATO";
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            return "\n!!il record non esiste nella tabella!!".ToUpper();
                        }
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
        public static string datapass(string connectionStr, SerializableBindingList<veicolo> listveicolo,int[] iDs)
        {
            try
            {
                if (connectionStr != null)
                {
                    OleDbConnection connection = new OleDbConnection(connectionStr);
                    using (connection)
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand("SELECT * FROM veicoli", connection);
                        OleDbDataReader reader = command.ExecuteReader();

                        listveicolo.Clear();
                        Array.Clear(iDs, 0, iDs.Length);
                        if (reader.HasRows)
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                if (reader.GetString(1) == "auto")
                                {
                                    iDs[i] = reader.GetInt32(0);
                                    listveicolo.Add(new auto(reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetDouble(5), reader.GetDateTime(6), reader.GetInt32(7), reader.GetString(8), reader.GetString(9) == "SI" ? true : false, reader.GetString(10) == "SI" ? true : false, reader.GetInt32(12), reader.GetString(11)));
                                }
                                else
                                {
                                    iDs[i] = reader.GetInt32(0);
                                    listveicolo.Add(new moto(reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetDouble(5), reader.GetDateTime(6), reader.GetInt32(7), reader.GetString(8), reader.GetString(9) == "SI" ? true : false, reader.GetString(10) == "SI" ? true : false, reader.GetInt32(12), reader.GetString(11)));
                                }
                                i++;
                                //    Marca: {reader.GetString(2)};
                                //    Modello: {reader.GetString(3)};
                                //    Cilindrata: {reader.GetInt32(4)};
                                //    Potenza(KW): {reader.GetDouble(5)};
                                //    Data Immatricolazione: {reader.GetDateTime(6).ToShortDateString()};
                                //    Chilometri percorsi: {reader.GetInt32(7)};
                                //    Colore: {reader.GetString(8)};
                                //    Usato: {reader.GetString(9)};
                                //    Km0: {reader.GetString(10)};
                                //    Informazioni: {reader.GetString(11)};
                                //    Prezzo: {reader.GetInt32(12)};
                            }
                        }
                        reader.Close();
                    }
                }
                return "DONE";
            }
            catch (Exception ex)
            {
                return "\n!!ERROR!! "+ex.Message;
            }
        }

        public static string dropTable(string connectionStr)
        {
            if (connectionStr!= null)
            {
                OleDbConnection connection = new OleDbConnection(connectionStr);
                using (connection)
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;

                        string SQLquery = $"DROP TABLE veicoli;";
                        command.CommandText = SQLquery;

                        command.Prepare();
                        command.ExecuteNonQuery();

                        Console.ForegroundColor = ConsoleColor.Green;
                        return "\nTABELLA ELIMINATA";
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        return "\n!!ERROR!!" +ex.Message;
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
