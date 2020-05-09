using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using venditaVeicoliDLLProject;
using static venditaVeicoliDLLProject.Utilities;
using System.IO;

namespace winFormProject
{
    public partial class frmDettagli : Form
    {
        int id;
        int[] iDs = new int[10000];
        SerializableBindingList<veicolo> l;
        public frmDettagli(int id,int[] iDs,SerializableBindingList<veicolo> lstVeicoli)
        {
            InitializeComponent();
            this.id = id;
            this.l = lstVeicoli;
            this.iDs = iDs;
        }

        string[] imgs = new string[10000];
        private void frmDettagli_Load(object sender, EventArgs e)
        {
            tbID.Text = id.ToString();

            int i = 0;
            foreach (var item in l)
            {
                if (iDs[i] == id)
                {
                    if (item is auto)
                        tbType.Text = "auto";
                    else
                        tbType.Text = "moto";
                    tbMarca.Text =item.Marca;
                    tbModello.Text =item.Modello;
                    tbcilindrata.Text = item.Cilindrata.ToString();
                    tbPotenza.Text=item.PotenzaKw.ToString();
                    tbDimm.Text = item.Immatricolazione.ToShortDateString();
                    tbKMP.Text = item.KmPercorsi.ToString();
                    tbColor.Text = item.Colore;
                    tbUsato.Text =item.IsUsato==true ? "SI" : "NO";
                    tbKm0.Text = item.IsKmZero == true ? "SI" : "NO";
                    tbInfo.Text = (item is auto) ? (item as auto).NumairBag : (item as moto).MarcaSella;
                    tbPrezzo.Text =item.Prezzo+"$";


                    break;
                }
                else
                    i++;

            }
        }
    }
}
