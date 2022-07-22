﻿using System;
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
    public partial class RelatorioCliente : Form
    {
        public RelatorioCliente()
        {
            InitializeComponent();
        }
        private void RemoverCliente_Load(object sender, EventArgs e)
        {
            foreach (var item in Dados.clientes)
            {
                listview_clientes.Items.Add(item.GetNome() + " - " + item.GetCpfCnpj() + " - " + item.GetTelefone() + " - " + item.GetEndereco());
            }

            nClientesCadastrados.Text = "Número de clientes cadastrados: " + Dados.clientes.Count();
        }
    }
}
