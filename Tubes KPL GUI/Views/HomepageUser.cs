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
using Main.Model;

namespace View
{
    public partial class HomepageUser : Form
    {
        public string fileDataPathBarang = "D:\\Tubes GUI KPL\\V3\\Tubes KPL GUI\\Main\\Data\\dataHp.json";

        public HomepageUser()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            List<Hp> daftarHp = ReadJsonFile(fileDataPathBarang);

            foreach (var hp in daftarHp)
            {
                dataGridView1.Rows.Add(hp.NamaBarang, hp.KodeBarang, hp.JumlahBarang, hp.HargaBarang);
            }
        }

        private List<Hp> ReadJsonFile(string filePath)
        {
            List<Hp> daftarhp = new List<Hp>();

            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
                }

                string json;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    json = reader.ReadToEnd();
                }

                daftarhp = JsonSerializer.Deserialize<List<Hp>>(json);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"File not found: {ex.Message}");
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Error parsing JSON file: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading JSON file: {ex.Message}");
            }

            return daftarhp;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string namaBarang = row.Cells[1].Value.ToString();
                int kodeBarang = Convert.ToInt32(row.Cells[0].Value);
                int jumlahBarang = Convert.ToInt32(row.Cells[2].Value);
                int hargaBarang = Convert.ToInt32(row.Cells[3].Value);

                Hp hp = new Hp(namaBarang, kodeBarang, jumlahBarang, hargaBarang);


            }
        }


    }
}
