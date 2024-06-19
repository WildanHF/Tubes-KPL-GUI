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
using View;
using static System.Windows.Forms.DataFormats;

namespace Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage _homepage = new Homepage();
            HomepageUser _homepageUser = new HomepageUser();
            string _username = textBox1.Text;
            string _password = textBox2.Text;

            if (_username == null && _password == null)
            {
                MessageBox.Show("Username atau Password tidak boleh kosong!");
            }
            else
            {
                List<Akun> _dataAkun = ReadJSON();
                Akun _akunTerdaftar = ValidateUser(_dataAkun, _username, _password);
                if (_akunTerdaftar != null)
                {
                    if (_akunTerdaftar.Role.Equals("Admin"))
                    {
                        _homepage.Show();
                    }
                    else if (_akunTerdaftar.Role.Equals("User"))
                    {
                        _homepageUser.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Akun anda tidak terdaftar ");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register _register = new Register();
            _register.Show();
            this.Hide();
        }

        public List<Akun> ReadJSON()
        {
            string filePathDataAkun = "C:\\Users\\fauzan\\Documents\\FILE SEM 4\\KPL\\tubes amisa\\Tubes KPL GUI\\Main\\Data\\dataAkun.json";
            List<Akun> dataAkun = new List<Akun>();
            try
            {
                string configJsonData = File.ReadAllText(filePathDataAkun);
                dataAkun = JsonSerializer.Deserialize<List<Akun>>(configJsonData);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return dataAkun;

        }
        private void WriteJSON(List<Akun> newDataBarang)
        {
            string filePathDataAkun = "C:\\Users\\fauzan\\Documents\\FILE SEM 4\\KPL\\tubes amisa\\Tubes KPL GUI\\Main\\Data\\dataAkun.json";
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(newDataBarang, options);
            File.WriteAllText(filePathDataAkun, jsonString);
        }

        private Akun ValidateUser(List<Akun> newDataAkun, string username, string password)
        {
            for (int i = 0; i < newDataAkun.Count; i++)
            {
                if (newDataAkun[i].Password.Equals(password) && newDataAkun[i].Username.Equals(username))
                {
                    return newDataAkun[i];
                }
            }
            return null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
