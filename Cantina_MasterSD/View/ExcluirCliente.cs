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
    public partial class ExcluirCliente : Form
    {
        public ExcluirCliente()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ExcluirCliente_Load(object sender, EventArgs e)
        {
            foreach (var item in Dados.cliente)
            {
                combo_clientes.Items.Add(item.Nome + " - " + item.CpfCnpj);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dados.cliente.RemoveAt(combo_clientes.SelectedIndex);
            this.Close();
        }
    }
}
