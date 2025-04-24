using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPi
{
    public partial class CriarPedido : Form
    {
        public CriarPedido()
        {
            InitializeComponent();
        }

        private void CriarPedido_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();
            this.Hide();
        }
    }
}
