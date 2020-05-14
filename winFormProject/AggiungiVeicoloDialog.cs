using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using venditaVeicoliDLLProject;

namespace winFormProject
{
    public partial class AggiungiVeicoloDialog : Form
    {
        static string connectionStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\DB\\Veicoli.accdb";
        BindingList<veicolo> listVeicolo;
        public AggiungiVeicoloDialog(BindingList<veicolo> listVeicolo)
        {
            InitializeComponent();
            this.listVeicolo = listVeicolo;
        }

        string[] marcaAuto = { "Alfa Romeo","Audi","BMW","Citroen","Dacia","Ferrari","Fiat","Ford","Honda","Hunady",
            "Infinity","Jaguar","Jeep","Kia","Lamborghini","Lancia","Land Rover","Lexus","Maserati","Mazda",
            "Mercedes","Mini-Cooper","Mitsubishi","Nissan","Opel","Peugeot","Porsche","Renault","Seat",
            "Skoda","Smart","Subaru","Suzuki","Tesla","Toyota","Volkswagen","Volvo"
        };

        string[] marcaMoto ={
            "Aprilia","BMW","Ducati","Gilera","Harley Davidson","Honda","Husqvarna","Kawasaki","KTM","Moto Guzzi",
            "MV Agusta","Ohvale","Suzuki","Triumph","Yamaha","Vertigo","KSR","Zaeta"
        };

        public string[] color = {"Aquamarina","Avorio", "Azzurro", "Bianco","Blu","Giallo","Grigio Antracite","Rosa","Nero","Ocra","Rosso","Verde"};
        private void AggiungiVeicoloDialog_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            cmbTipoVeicolo.SelectedIndex = 0;
            lblMarcaSella.Hide();
            tbMarcaSella.Hide();
            cmbMarca.DataSource = marcaAuto;
            cmbColor.DataSource = color;
            nudMP.Maximum = int.MaxValue;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Ins();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoVeicolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoVeicolo.SelectedIndex==1)
            {
                lblNAirBag.Hide();
                nudNumeroAirBag.Hide();
                lblMarcaSella.Show();
                tbMarcaSella.Show();
                cmbMarca.DataSource = marcaMoto;
            }
            else
            {
                lblMarcaSella.Hide();
                tbMarcaSella.Hide();
                lblNAirBag.Show();
                nudNumeroAirBag.Show();
                cmbMarca.DataSource = marcaAuto;
            }
        }

        private void cbUsato_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUsato.Checked)
            {
                cbKmZero.Enabled = false;
                nudMP.Enabled = true;
            }
            else
            {
                cbKmZero.Enabled = true;
                nudMP.Enabled = true;
            }
        }

        private void cbKmZero_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKmZero.Checked)
            {
                cbUsato.Enabled = false;
                nudMP.Enabled = false;
            }
            else
            {
                cbUsato.Enabled = true;
                nudMP.Enabled = true;
            }
        }

        private void Ins()
        {
            MessageBox.Show(DB.addVehicle(connectionStr, cmbTipoVeicolo.SelectedItem.ToString(), cmbMarca.SelectedItem.ToString(), txtModello.Text, int.Parse(txtCilindrata.Text), double.Parse(txtPotenza.Text), Convert.ToDateTime(dtpImm.Value), Convert.ToInt32(nudMP.Value), cmbColor.SelectedItem.ToString(), cbUsato.Checked ? "SI" : "NO", cbKmZero.Checked ? "SI" : "NO", cmbTipoVeicolo.SelectedItem.ToString() == "auto".ToLower() ? "numero airbag " + Convert.ToInt32(nudNumeroAirBag.Value) : "marca sella " + tbMarcaSella.Text, int.Parse(txtPrezzo.Text)));
            tbMarcaSella.Clear();
            txtCilindrata.Clear();
            txtModello.Clear();
            txtPotenza.Clear();
            txtPrezzo.Clear();
            dtpImm.Value = DateTime.Today;
            cbKmZero.Checked = false;
            cbUsato.Checked = false;
            nudMP.Value = nudMP.Minimum;
            nudNumeroAirBag.Value = nudNumeroAirBag.Minimum;
            cmbColor.SelectedIndex = 0;
            cmbMarca.SelectedIndex = 0;
            cmbTipoVeicolo.SelectedIndex = 0;
            //if (cmbTipoVeicolo.SelectedIndex == 0)
            //    listVeicolo.Add(new auto(cmbMarca.SelectedItem.ToString(),txtModello.Text,int.Parse(txtCilindrata.Text) ,int.Parse(txtPotenza.Text),dtpImm.Value,Convert.ToInt32(nudMP.Value), cmbColor.SelectedItem.ToString(), cbUsato.Checked,cbKmZero.Checked,Convert.ToInt64(txtPrezzo.Text) ,Convert.ToString(nudNumeroAirBag.Value)));
            //else
            //    listVeicolo.Add(new moto(cmbMarca.SelectedItem.ToString(), txtModello.Text, int.Parse(txtCilindrata.Text), int.Parse(txtPotenza.Text), dtpImm.Value, Convert.ToInt32(nudMP.Value), cmbColor.SelectedItem.ToString(), cbUsato.Checked, cbKmZero.Checked,Convert.ToUInt64(txtPrezzo.Text) ,tbMarcaSella.Text));

            //MessageBox.Show($"Aggiungi\n {listVeicolo.Last()}");
            //this.Close();
        }

        private void AggiungiVeicoloDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Ins();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
