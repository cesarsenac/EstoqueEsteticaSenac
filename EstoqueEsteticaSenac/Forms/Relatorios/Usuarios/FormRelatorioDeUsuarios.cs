using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueEsteticaSenac.Forms.Relatorios
{
    public partial class FormRelatorioDeUsuarios : Form
    {
        public FormRelatorioDeUsuarios()
        {
            InitializeComponent();
        }

        private void FormRelatorioDeUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueEsteticaDataSet.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.estoqueEsteticaDataSet.usuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
