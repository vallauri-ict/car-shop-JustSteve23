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
                    case "AV":
                        string aus;
                        do
                        {
                            dataCheck();
                            do
                            {
                                Console.Write("\nVuoi aggiungere un altro veicolo (S/N)-> ");
                                aus = Console.ReadLine().ToUpper();
                                if (aus!="S" && aus!="N")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n!!COMANDO ERRATO!!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            } while (aus!="S" && aus!="N");
                        } while(aus!="N");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "DV":
                        Console.Write("\ninserici id->"); int id = int.Parse(Console.ReadLine());
                        Console.WriteLine(DB.deleteVehicle(connectionStr,id));
                        Console.ForegroundColor = ConsoleColor.White;
                        string cs=null;
                        do
                        {
                            Console.Write("Vuoi visualizzare la tabella veicoli? (S/N)-> ");
                            cs =Console.ReadLine().ToUpper();
                            if (cs=="S")
                                DB.visualizeTableConsole(connectionStr);
                            else if(cs!="N" && cs !="S")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n!!COMANDO ERRATO!!\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        } while (cs!="N" && cs!="S");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "UV":
                        Console.WriteLine();
                        for (int i = 0; i <DBFieldArray.Length; i++)
                        {
                            Console.WriteLine(i+"-> "+DBFieldArray[i]);
                        }
                        Console.WriteLine();
                        Console.Write("Numero Relativo al Campo da Aggiornare-> "); int uField;
                        while (!int.TryParse(Console.ReadLine(), out uField))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("!!INSERIMENTO ERRATO!!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Numero Relativo al Campo da Aggiornare-> ");
                        }
                        Console.Write("ID Campo da Aggiornare-> "); string ide = Console.ReadLine();
                        Console.Write($"inseriere valore da aggiornare(Campo: {DBFieldArray[uField]})-> "); string toUpdate = Console.ReadLine(); 
                        Console.WriteLine();
                        Console.WriteLine(DB.updateVehicle(connectionStr, ide,DBFieldArray[uField],toUpdate,uField));
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

        private static void dataCheck()
        {
            Console.WriteLine("------INSERIMENTO VEICOLO------\n");
            bool isPresente = false;
            Console.Write("Tipo veicolo(auto/moto)-> "); string type=null;
            do
            {
                type = Console.ReadLine().ToLower();
                if (type=="auto" || type=="moto")
                {
                    isPresente = true;
                }
                else
                    isPresente = false;
             
                if (!isPresente)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!ERROR TIPO ERRATO!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Tipo veicolo(auto/moto)-> ");
                }
            } while (!isPresente);

            Console.Write("Marca veicolo-> "); string marca= Console.ReadLine();

            Console.Write($"Modello veicolo di {marca}-> "); string modello = Console.ReadLine();

            Console.Write("Cilindrata veicolo-> "); int cilindrata;
            while(!int.TryParse(Console.ReadLine(),out cilindrata))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!INSERIMENTO ERRATO!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Cilindrata veicolo-> ");
            }

            Console.Write("Potenza(Kw) veicolo-> "); double kw;
            while (!double.TryParse(Console.ReadLine(), out kw))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!INSERIMENTO ERRATO!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Potenza(Kw) veicolo-> ");
            }

            Console.Write("Data immatricolazione-> "); DateTime dImm;
            while(!DateTime.TryParse(Console.ReadLine(),out dImm))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!INSERIMENTO ERRATO!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Data immatricolazione-> ");
            }

            Console.Write("Chilometri persorsi-> "); int KmPercorsi;
            while (!int.TryParse(Console.ReadLine(), out KmPercorsi))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!INSERIMENTO ERRATO!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Chilometri persorsi-> ");
            }

            string[] color = { "Aquamarina", "Avorio", "Azzurro", "Bianco", "Blu", "Giallo", "Grigio Antracite", "Rosa", "Nero", "Ocra", "Rosso", "Verde" };
            Console.WriteLine("\nColori Disponibili");
            for (int i = 0; i < color.Length; i++)
                Console.WriteLine($"-{color[i]}");
            Console.WriteLine();
            Console.Write("Colore-> "); string colore=null; 
            do {
                colore = Console.ReadLine();
                for (int i = 0; i < color.Length; i++)
                {
                    if (color[i] == colore)
                    {
                        isPresente = true;
                        break;
                    }
                    else
                        isPresente = false;
                }
                if (!isPresente)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!ERROR COLORE NON TROVATO!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Colore-> ");
                }
            } while (!isPresente);

            Console.Write("Usato(SI/NO)-> "); string Usato=null;
            do
            {
                Usato = Console.ReadLine().ToUpper();
                if (Usato == "SI" || Usato == "NO")
                {
                    isPresente = true;
                }
                else
                    isPresente = false;

                if (!isPresente)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!ERROR RISPOSTE VALIDE: SI/NO!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Usato(SI/NO)-> ");
                }
            } while (!isPresente);

            Console.Write("Km0(SI/NO)-> "); string Km0 = null;
            do
            {
                Km0 = Console.ReadLine().ToUpper();
                if (Km0 == "SI" || Km0 == "NO")
                {
                    isPresente = true;
                }
                else
                    isPresente = false;

                if (!isPresente)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!ERROR RISPOSTE VALIDE: SI/NO!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Km0(SI/NO)-> ");
                }
            } while (!isPresente);

            Console.Write("Ulteriori informazioni-> "); string Info = Console.ReadLine();

            Console.Write("Prezzo veicolo-> "); int prezzo;
            while (!int.TryParse(Console.ReadLine(), out prezzo))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!INSERIMENTO ERRATO!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Prezzo veicolo-> ");
            }

            Console.WriteLine(DB.addVehicle(connectionStr, type,marca,modello,cilindrata,kw,dImm,KmPercorsi,colore,Usato,Km0,Info,prezzo));
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(2000);
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
            Console.WriteLine(" AV -> AGGIUNGE UN VEICOLO ALLA TABELLA AUTOMOBLI");
            Console.WriteLine(" DV -> ELIMINA UN VEICOLO ALLA TABELLA AUTOMOBLI DATO IN IGRESSO L'IDENTIFICATORE");
            Console.WriteLine(" UV -> AGGIORNA UN CAMPO DI UNA RIGA");
            Console.WriteLine(" VT -> VISUALIZZA I CAMPI DELLA TABELLA AUTOMOBILI");
            Console.WriteLine(" EXIT -> CHIUDE IL PROGRAMMA");
        }
        #endregion
    }
}
