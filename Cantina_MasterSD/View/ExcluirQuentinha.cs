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
    public partial class ExcluirQuentinha : Form
    {
        public ExcluirQuentinha()
        {
            InitializeComponent();
        }
        private void combo_quentinhas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExcluirQuentinha_Load(object sender, EventArgs e)
        {
            foreach (var item in Dados.quentinhas)
            {
                combo_quentinhas.Items.Add(item.Nome + " - " + item.Descricao + " - " + item.Preco.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dados.quentinhas.RemoveAt(combo_quentinhas.SelectedIndex);
            this.Close();
        }
    }
}
