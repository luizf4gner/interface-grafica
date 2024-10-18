using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoLuiz
{
    public partial class formCriarCompra : Form
    {
        public BindingList<Fornecedor> Fornecedores {  get; set; }
        private Fornecedor Fornecedor { get { return Fornecedores.FirstOrDefault(f => f.Id == (int)comboBoxFornecedor.SelectedValue);  } }
        public int IdFornecedor { get { return (int)comboBoxFornecedor.SelectedValue; } }

        public BindingList<Produto> Produtos { get; set; }
        private Produto Produto { get { return Produtos.FirstOrDefault(p => p.Id == (int)comboBoxProduto.SelectedValue); } }
        public int IdProduto { get { return (int)comboBoxProduto.SelectedValue; } }

        public decimal Quantidade { get { return numericUpDownQuantidade.Value; } }
        public decimal Desconto { get { return numericUpDownDesconto.Value; } }

        private decimal PrecoUnitario { get { return Produto.PrecoCompra; } }
        private decimal ValorTotal { get { return PrecoUnitario * Quantidade; } }
        private decimal ValorComDesconto { get { return ValorTotal * (1 - (Desconto / 100)); } }
        public formCriarCompra(BindingList<Fornecedor> fornecedores, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Fornecedores = fornecedores;
            comboBoxFornecedor.DataSource = Fornecedores;
            comboBoxFornecedor.ValueMember = "Id";
            comboBoxFornecedor.DisplayMember = "NomeEmpresa";

            Produtos = produtos;
            comboBoxProduto.DataSource = Produtos;
            comboBoxProduto.ValueMember = "Id";
            comboBoxProduto.DisplayMember = "Nome";
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }
        
        private void numericUpDownDesconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void AtualizarValores()
        {
            if (Produto != null)
            {
                textBoxPrecoUnitario.Text = PrecoUnitario.ToString("C", CultureInfo.CurrentCulture);
                textBoxValorTotal.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                textBoxTotalComDesconto.Text = ValorComDesconto.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }
    }
}
