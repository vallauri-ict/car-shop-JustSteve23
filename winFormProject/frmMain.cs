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
using DocumentFormat.OpenXml.CustomProperties;

namespace winFormProject
{ 
    public partial class frmMain : Form
    {
    static string connectionStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\DB\\Veicoli.accdb";
    SerializableBindingList<veicolo> listVeicolo;
        public frmMain()
        { 
            listVeicolo = new SerializableBindingList<veicolo>();
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            dgv.ClearSelection();
            CaricaDatiDiTesto();
        }
        int[] iDs = new int[10000];
        private void CaricaDatiDiTesto()
        {
            dgv.Rows.Clear();
            DB.datapass(connectionStr, listVeicolo, iDs);
            int rowN = 0;
            foreach (var item in listVeicolo)
            {
                dgv.Rows.Add();
                dgv.Rows[rowN].Cells[0].Value = iDs[rowN];
                if (item is auto)
                    dgv.Rows[rowN].Cells[1].Value = "auto";
                else
                    dgv.Rows[rowN].Cells[1].Value = "moto";
                dgv.Rows[rowN].Cells[2].Value = item.Marca;
                dgv.Rows[rowN].Cells[3].Value = item.Modello;
                dgv.Rows[rowN].Cells[4].Value = item.Cilindrata;
                dgv.Rows[rowN].Cells[5].Value = item.PotenzaKw;
                dgv.Rows[rowN].Cells[6].Value = item.Immatricolazione;
                dgv.Rows[rowN].Cells[7].Value = item.KmPercorsi;
                dgv.Rows[rowN].Cells[8].Value = item.Colore;
                dgv.Rows[rowN].Cells[9].Value = item.IsUsato == true ? "SI" : "NO";
                dgv.Rows[rowN].Cells[10].Value = item.IsKmZero == true ? "SI" : "NO";
                dgv.Rows[rowN].Cells[11].Value = item is auto ? (item as auto).NumairBag : (item as moto).MarcaSella;
                dgv.Rows[rowN].Cells[12].Value = item.Prezzo + "$";

                rowN++;
            }
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

        //private void apriToolStripButton_Click(object sender, EventArgs e)
        //{
        //    //string[] data;
        //    //StreamReader sr = new StreamReader("veicolo.csv");
        //    //listVeicolo.Clear();
        //    //while (!sr.EndOfStream)
        //    //{
        //    //    data = sr.ReadLine().Split('|');
        //    //    if (data[0] == "AUTO")
        //    //    {
        //    //        listVeicolo.Add(new auto(data));
        //    //    }
        //    //    else
        //    //    {
        //    //        listVeicolo.Add(new moto(data));
        //    //    }
        //    //}

        //    //sr.Close();
        //}

        private void salvaToolStripButton_Click(object sender, EventArgs e)
        {
            Utilities.SerializeToCsv(listVeicolo, "./veicolo.csv");
            Utilities.SerializeToXml(listVeicolo, "./veicolo.xml");
            Utilities.SerializeToJson(listVeicolo, "./veicolo.json");
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
            try
            {
                MessageBox.Show(DB.deleteVehicle(connectionStr, int.Parse(Interaction.InputBox("INSERIRE IDENTIFICATORE DEL VEICOLO DA ELIMINARE"))));
                CaricaDatiDiTesto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!ERROR!! "+ex.Message);
            }
        }
    }
}
