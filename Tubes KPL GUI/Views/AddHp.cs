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
    public partial class AddHp : Form
    {
        public AddHp()
        {
            InitializeComponent();
        }

        private void AddHp_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namabarang = inputNamaBarang.Text;
            int kodebarang = int.Parse(inputKodeBarang.Text);
            int jumlahbarang = int.Parse(inputJumlahBarang.Text);
            int hargabarang = int.Parse(inputHargaBarang.Text);

            List<Hp> dataBarang = ReadJSON();
            Boolean statusKodeBarang = validateBarang(kodebarang);
            if (statusKodeBarang)
            {
                MessageBox.Show("kode barang sudah ada");
            }
            else
            {
                Hp newBarang = new Hp(namabarang, kodebarang, jumlahbarang, hargabarang);
                dataBarang.Add(newBarang);
                WriteJSON(dataBarang);
                MessageBox.Show("Barang baru berhasil di tambahkan");
            }
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

        private void WriteJSON(List<Hp> newDataBarang)
        {
            string filePathDataBarang = "C:\\Users\\fauzan\\Documents\\FILE SEM 4\\KPL\\tubes amisa\\Tubes KPL GUI\\Main\\Data\\dataHp.json";
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(newDataBarang, options);
            File.WriteAllText(filePathDataBarang, jsonString);
        }

        private Boolean validateBarang(int kodeBarang)
        {
            List<Hp> dataBarang = ReadJSON();
            for (int i = 0; i < dataBarang.Count; i++)
            {
                if (dataBarang[i].KodeBarang.Equals(kodeBarang))
                {
                    return true;
                }
            }
            return false;
        }

        private void inputNamaBarang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
