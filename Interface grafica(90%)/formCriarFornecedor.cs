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
    public partial class formCriarFornecedor : Form
    {
        public string Nome { get { return textBoxNomeEmpresa.Text; } }
        public string CNPJ { get { return textBoxCNPJ.Text; } }
        public string NomeContato { get { return textBoxNomeContato.Text; } }
        public string Telefone { get { return textBoxTelefone.Text; } }
        public string Email { get { return textBoxEmail.Text; } }

        public string Endereco
        {
            get
            {
                string endereco = "";
                endereco += $"({textBoxEnderecoRua.Text}), ";
                endereco += $"({textBoxEnderecoNumero.Text}), ";
                endereco += $"({textBoxEnderecoComplemento.Text}), ";
                endereco += $"({textBoxEnderecoCidade.Text} - {textBoxUF.Text}), ";
                endereco += $"({textBoxCEP.Text}), ";
                return endereco;
            }
        }

        public formCriarFornecedor()
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
