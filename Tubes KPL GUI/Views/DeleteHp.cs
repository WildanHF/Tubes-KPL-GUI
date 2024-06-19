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
    public partial class DeleteHp : Form
    {
        public DeleteHp()
        {
            InitializeComponent();
        }

        private void DeleteHp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Hp> list = ReadJSON();
            string namabarang = inputNamaBarang.Text;
            if (string.IsNullOrEmpty(namabarang))
            {
                MessageBox.Show("Masukkan Nama Barang");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (namabarang.Equals(list[i].NamaBarang))
                    {
                        list.Remove(list[i]);
                        WriteJSON(list);
                        MessageBox.Show("Barang terhapus!");
                        inputNamaBarang.Clear();
                    }
                }
            }
        }
        public List<Hp> ReadJSON()
        {
            string filePathDataHandPhone = "D:\\Tubes GUI KPL\\V3\\Tubes KPL GUI\\Main\\Data\\dataHp.json";
            List<Hp> DataHandPhone = new List<Hp>();
            try
            {
                string configJsonData = File.ReadAllText(filePathDataHandPhone);
                DataHandPhone = JsonSerializer.Deserialize<List<Hp>>(configJsonData);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return DataHandPhone;

        }
        private void WriteJSON(List<Hp> newDataHandPhone)
        {
            string filePathDataHandPhone = "D:\\Tubes GUI KPL\\V3\\Tubes KPL GUI\\Main\\Data\\dataHp.json";
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(newDataHandPhone, options);
            File.WriteAllText(filePathDataHandPhone, jsonString);
        }
        private Hp validateBarang(string namaBarang)
        {
            List<Hp> DataHandPhone = ReadJSON();
            for (int i = 0; i < DataHandPhone.Count; i++)
            {
                if (DataHandPhone[i].NamaBarang.Equals(namaBarang))
                {
                    return DataHandPhone[i];
                }
            }
            return null;

        }

        private void inputNamaHandPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputNamaBarang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
