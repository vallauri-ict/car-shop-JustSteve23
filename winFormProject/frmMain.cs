using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using venditaVeicoliDLLProject;
using static venditaVeicoliDLLProject.Utilities;
using Microsoft.VisualBasic;
using System.Data.OleDb;

namespace winFormProject
{
    public partial class frmMain : Form
    {
        //correggere
        public static string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Stefano grosso\\Desktop\\vendiataVeicoliSolution\\DB\\Veicoli.accdb";

        SerializableBindingList<veicolo> listVeicolo;
        public frmMain()
        {
            listVeicolo = new SerializableBindingList<veicolo>();
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            CaricaDatiDiTesto();
        }

        private void CaricaDatiDiTesto()
        {
            //moto m = new moto();
            //m = new moto("Ducati", "Panigale V4R", 1000, 75, DateTime.Now, 0, "blu", false, false, 10000, "StandarCO");
            //listVeicolo.Add(m);
            //auto a = new auto("Alfa Romeo", "Stelvio", 2000, 150, DateTime.Now, 0, "rosso", false, false, 35000, 8);
            //listVeicolo.Add(a);
            //a = new auto("Ferrari", "SF90Stradale", 5000, 800, DateTime.Now, 0, "rosso", false, false, 500000, 12);
            //listVeicolo.Add(a);
            //a = new auto("Bentley", "Continental GT", 3500, 600, DateTime.Now, 0, "nero", false, false, 200000, 14);
            //listVeicolo.Add(a);
            //m = new moto("Yamaha", "R1", 1000, 75, DateTime.Now, 0, "blu", false, false, 8500, "StandardCO");
            //listVeicolo.Add(m);
            //a = new auto("BMW", "M2 Competizione", 3000, 450, DateTime.Now, 0, "bianco", false, false, 66000, 10);
            //listVeicolo.Add(a);
            //lbVeicoli.DataSource = listVeicolo;
        }

        private void toolStripBtnAddVeicolo_Click_1(object sender, EventArgs e)
        {
            AggiungiVeicoloDialog frmDialog = new AggiungiVeicoloDialog(listVeicolo);
            frmDialog.ShowDialog();
        }

        private void apriToolStripButton_Click(object sender, EventArgs e)
        {
            //string[] data;
            //StreamReader sr = new StreamReader("veicolo.csv");
            //listVeicolo.Clear();
            //while (!sr.EndOfStream)
            //{
            //    data = sr.ReadLine().Split('|');
            //    if (data[0] == "AUTO")
            //    {
            //        listVeicolo.Add(new auto(data));
            //    }
            //    else
            //    {
            //        listVeicolo.Add(new moto(data));
            //    }
            //}

            //sr.Close();
        }

        private void salvaToolStripButton_Click(object sender, EventArgs e)
        {
            Utilities.SerializeToCsv(listVeicolo, "./veicolo.csv");
            Utilities.SerializeToXml(listVeicolo, "./veicolo.xml");
            Utilities.SerializeToJson(listVeicolo, "./veicolo.json");
            //string toWrite = null;
            //StreamWriter sw = new StreamWriter("veicoli.dat");

            //foreach (var item in listVeicolo)
            //{
            //    toWrite = null;
            //    if (item is auto)
            //    {   
            //        toWrite = $"AUTO|{item.Marca}|{item.Modello}|{item.Cilindrata}|{item.PotenzaKw}|{item.Immatricolazione.ToShortDateString()}|{item.KmPercorsi}|{item.Colore}|{item.IsUsato}|{item.IsKmZero}|{(item as auto).NumairBag}";
            //    }
            //    else
            //    {
            //        toWrite = $"MOTO|{item.Marca}|{item.Modello}|{item.Cilindrata}|{item.PotenzaKw}|{item.Immatricolazione.ToShortDateString()}|{item.KmPercorsi}|{item.Colore}|{item.IsUsato}|{item.IsKmZero}|{(item as moto).MarcaSella}";
            //    }
            //    sw.WriteLine(toWrite);
            //}
            //sw.Close();
        }

        private void tlsBtnCaricaOnline_Click(object sender, EventArgs e)
        {
            string homePath = @".\www.\index.html";
            Utilities.createHTML(listVeicolo, homePath);
            System.Diagnostics.Process.Start(homePath);
        }

        private void tsbWordParse_Click(object sender, EventArgs e)
        {
            try
            {
                Utilities.WordDocumentCreation(listVeicolo);
                SystemSounds.Beep.Play();
                System.Diagnostics.Process.Start("veicoli.docx");
            }
            catch (Exception)
            {
                MessageBox.Show("Errore creazione foglio di word");
            }
        }

        private void tsbEliminaVeicolo_Click(object sender, EventArgs e)
        {
            DB.deleteVehicle(connectionString, int.Parse(Interaction.InputBox("INSERIRE IDENTIFICATORE DEL VEICOLO DA ELIMINARE")));
        }
    }
}
