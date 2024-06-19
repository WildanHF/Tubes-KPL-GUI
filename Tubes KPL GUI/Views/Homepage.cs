using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddHp addHp = new AddHp();
            addHp.Visible = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            CariHp cariHp = new CariHp();
            cariHp.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteHp deleteHp = new DeleteHp();
            deleteHp.Visible = true;
        }

        private void lihatTabel_Click(object sender, EventArgs e)
        {
            TabelHp tabelHp = new TabelHp();
            tabelHp.Visible = true;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
