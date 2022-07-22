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
    public partial class RelatorioQuentinhas : Form
    {
        public RelatorioQuentinhas()
        {
            InitializeComponent();
        }
        private void RelatorioQuentinhas_Load(object sender, EventArgs e)
        {
            foreach (var item in Dados.quentinhas)
            {
                listview_quentinhas.Items.Add(item.GetNome() + " - " + item.GetDescricao() + " - R$ " + item.GetPreco());
            }

            nQuentinhasCadastradas.Text = "Número de quentinhas cadastradas: " + Dados.quentinhas.Count();
        }
    }
}
