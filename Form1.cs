using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendadeContatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaDeContatosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaDeContatosDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.agendaDeContatosDataSet.Table);

        }

        private void nOMELabel_Click(object sender, EventArgs e)
        {

        }

        private void tELEFONELabel_Click(object sender, EventArgs e)
        {

        }

        private void aNIVERSARIOLabel_Click(object sender, EventArgs e)
        {

        }

        private void iD_CONTATOLabel_Click(object sender, EventArgs e)
        {

        }

        private void fAMILIALabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgContatos.DataSource = tableTableAdapter.PesquisarContato(txtPesquisa.Text);
        }
    }
}
