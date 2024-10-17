using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoLuiz
{
    public partial class formCriarProduto : Form
    {
        public string nomeProduto { get { return this.textBoxNome.Text; } }
        public string nomeFabricante { get { return this.textBoxFabricante.Text; } }
        public float precoCompra { get { return (float)this.inputPrecoCompra.Value; } }
        public float precoVenda { get { return (float)this.inputPrecoVenda.Value; } }

        public formCriarProduto()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
