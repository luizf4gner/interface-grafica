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
    public partial class formCriarCliente : Form
    {
        public string Nome { get { return textBoxNome.Text; } }
        public string Telefone { get { return textBoxTelefone.Text; } }
        public string Email { get { return textBoxEmail.Text; } }

        public string Endereco
        {
            get {
                string endereco = "";
                endereco += $"({textBoxRua.Text}), ";
                endereco += $"({textBoxNumero.Text}), ";
                endereco += $"({textBoxComplemento.Text}), ";
                endereco += $"({textBoxCidade.Text} - { textBoxEstado.Text}), ";
                endereco += $"({textBoxCep.Text}), ";
                return endereco;
            }
        }

        public formCriarCliente()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close();
        }
    }
}