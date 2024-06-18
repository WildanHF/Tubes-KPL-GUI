using Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; 
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class HomepageUser : Form
    {
        public string fileDataPathHp = "C:\\Users\\fauzan\\Documents\\FILE SEM 4\\KPL\\tubes amisa\\Tubes KPL GUI\\Main\\Data\\datahp.json";
        private DataGridView dataGridView1; 

        public HomepageUser()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            List<Hp> daftarHp = ReadJsonFile(fileDataPathHp);
            foreach (Hp hp in daftarHp)
            {
                dataGridView1.Rows.Add(hp.KodeBarang, hp.NamaBarang, hp.JumlahBarang, hp.HargaBarang); // Change add to Add
            }
        }

        private List<Hp> ReadJsonFile(string filePath)
        {
            List<Hp> daftarHp = new List<Hp>();

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

                daftarHp = JsonSerializer.Deserialize<List<Hp>>(json);
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

            return daftarHp;
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

                Hp barang = new Hp(namaBarang, kodeBarang, jumlahBarang, hargaBarang);
                // Do something with the Hp object
            }
        }

        private void HomepageUser_Load(object sender, EventArgs e) // Move this method inside the class
        {
            // Handle form load event
        }
    }
}
