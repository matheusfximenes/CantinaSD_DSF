using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_MasterSD.Model
{
    public partial class RelatorioClientes : Form
    {
        public RelatorioClientes()
        {
            InitializeComponent();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RelatorioClientes_Load(object sender, EventArgs e)
        {
            Dados dadosArmazenados = new Dados();

            foreach (var item in Dados.cliente)
            {
                list_box_clientes.Items.Add(item.Nome + " - " + item.CpfCnpj);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
