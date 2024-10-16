using System.ComponentModel;

namespace projetoLuiz
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public BindingList<Venda> vendas { get; set; }
        public BindingList<Compra> compras { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }
        public BindingList<Cliente> clientes { get; set; }

        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            vendas = new BindingList<Venda>();
            compras = new BindingList<Compra>();
            fornecedores = new BindingList<Fornecedor>();
            clientes = new BindingList<Cliente>();
            this.dataGridView1.DataSource = produtos;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            formCriarProduto fcp = new formCriarProduto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();
                if (produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(x => x.Id) + 1;
                produto.Nome = fcp.nomeProduto;
                produto.Fabricante = fcp.nomeFabricante;
                produto.PrecoVenda = fcp.precoVenda;
                produto.PrecoCompra = fcp.precoCompra;

                produtos.Add(produto);
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonViewProdutos_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = produtos; }
        private void buttonViewVendas_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = vendas; }
        private void buttonViewCompra_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = compras; }
        private void buttonViewFornecedor_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = fornecedores; }
        private void buttonViewClientes_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = clientes; }
    }
}
