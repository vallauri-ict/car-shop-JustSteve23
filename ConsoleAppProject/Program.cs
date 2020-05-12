using System;
using venditaVeicoliDLLProject;
using DocumentFormat.OpenXml.CustomProperties;
using System.IO;


namespace ConsoleAppProject
{
    class Program
    {
        static string connectionStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName}\\DB\\Veicoli.accdb";
        static void Main(string[] args)
        {
        Console.Title = "Car shop";
        Console.WriteLine("**** salone vendita veicoli ****".ToUpper());
        Console.WriteLine("Per visualizzare il menù comandi utilizzare il comandi -> ?");
        string[] DBFieldArray= {"type","marca","modello","cilindrata","potenzaKw", "dataImmatricolazione", "kmPercorsi","colore","isUsato","isKm0","info","prezzo" };
        string scelta;
            
            do
            {
                Console.Write("\n->");
                scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "?": menu(); break;
                    case "Ginfo": Ginfo(); break;
                    case "CT": Console.WriteLine(DB.createTableVehicles(connectionStr));
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "DeleteTab":
                        Console.WriteLine(DB.dropTable(connectionStr));
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "VT": DB.visualizeTableConsole(connectionStr); break;
                    case "EXIT": Console.ForegroundColor = ConsoleColor.Green; Console.Write("\nGOODBYE"); 
                        System.Threading.Thread.Sleep(1000);
                        System.Environment.Exit(0);  break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n!!comando errato!!".ToUpper());
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (scelta!="EXIT");
        }

        #region VisualMenu - info shell
        private static void Ginfo()
        {
            Console.WriteLine("\nshell versione 1.0\nla selezione dei comandi è case-sensitive");
        }

        private static void menu()
        {
            Console.WriteLine("\n ? -> VISUALIZZA INFORMAZIONI SUI COMANDI");
            Console.WriteLine(" Ginfo -> VISUALIZZA ALCUNE INFORMAZIONI SULLA SHELL");
            Console.WriteLine(" CT -> CREA LA TABELLA");
            Console.WriteLine(" DeleteTab -> ELIMINA LA TABELLA");
            Console.WriteLine(" VT -> VISUALIZZA I CAMPI DELLA TABELLA AUTOMOBILI");
            Console.WriteLine(" EXIT -> CHIUDE IL PROGRAMMA");
        }
        #endregion
    }
}
