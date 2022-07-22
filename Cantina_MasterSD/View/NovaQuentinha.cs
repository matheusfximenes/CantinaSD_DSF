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
    public partial class NovaQuentinha : Form
    {
        public NovaQuentinha()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Quentinha quentinha = new Quentinha();
            quentinha.Nome=(nome_quentinha.Text);
            quentinha.Descricao=(descricao_quentinha.Text);
            quentinha.Preco=(preco_quentinha.Value);

            Dados.quentinhas.Add(quentinha);
            this.Close();
        }
    }
}
