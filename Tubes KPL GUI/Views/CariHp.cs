using Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class CariHp : Form
    {
        public CariHp()
        {
            InitializeComponent();
            namaBarangDisplay.ReadOnly = true;
            kodeBarangDisplay.ReadOnly = true;
            stokBarangDisplay.ReadOnly = true;
            hargaBarangDisplay.ReadOnly = true;
        }

        private void cariBTN_Click(object sender, EventArgs e)
        {
            List<Hp> list = ReadJSON();
            string namabarang = namaBarangInput.Text;
            Hp found = cariBarang(list, namabarang);
            if (found != null)
            {
                namaBarangDisplay.Text = found.NamaBarang;
                kodeBarangDisplay.Text = found.KodeBarang.ToString();
                stokBarangDisplay.Text = found.KodeBarang.ToString();
                hargaBarangDisplay.Text = found.HargaBarang.ToString();

            }
            else
            {
                MessageBox.Show("Barang Tidak Ditemukan");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public List<Hp> ReadJSON()
        {
            string filePathDataBarang = "C:\\Users\\fauzan\\Documents\\FILE SEM 4\\KPL\\tubes amisa\\Tubes KPL GUI\\Main\\Data\\dataHp.json";
            List<Hp> DataBarang = new List<Hp>();
            try
            {
                string configJsonData = File.ReadAllText(filePathDataBarang);
                DataBarang = JsonSerializer.Deserialize<List<Hp>>(configJsonData);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return DataBarang;


        }
        private Hp cariBarang(List<Hp> DataBarang, String namaBarang)
        {
            for (int i = 0; i < DataBarang.Count; i++)
            {
                if (DataBarang[i].NamaBarang.Equals(namaBarang))
                {
                    return DataBarang[i];
                }
            }
            return null;

        }

        private void namaBarangInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
