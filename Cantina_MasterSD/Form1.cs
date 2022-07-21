namespace Cantina_MasterSD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PainelAdministrativo painelAdm = new PainelAdministrativo();
            painelAdm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutenticacaoCliente aCliente = new AutenticacaoCliente();
            aCliente.ShowDialog();
        }
    }
}