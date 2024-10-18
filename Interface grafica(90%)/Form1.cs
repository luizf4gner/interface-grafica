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
                produto.PrecoCompra = (decimal) fcp.precoCompra;

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

        private void buttonAdicionarVenda_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoverVenda_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdicionarCompra_Click(object sender, EventArgs e)
        {
            if (fornecedores.Count == 0)
            {
                MessageBox.Show("Voçê precisa cadastrar Fornecedores antes de efetuar uma compra.");
                return;
            }
            if (produtos.Count == 0)
            {
                MessageBox.Show("Voçê precisa cadastrar produtos antes de efetuar uma compra.");
                return;
            }

            formCriarCompra fcc = new formCriarCompra(fornecedores, produtos);
            var resultado = fcc.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (compras.Count == 0) compra.Id = 1;
                else compra.Id = compras.Max(x => x.Id) + 1;

                compra.IdProduto = fcc.IdProduto;
                compra.IdFornecedor = fcc.IdFornecedor;
                compra.quantidade = (int) fcc.Quantidade;
                compra.desconto = (float) fcc.Desconto;
                compra.DataCompra = DateTime.Now;
                compras.Add(compra);

            }
        }

        private void buttonRemoverCompra_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                compras.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            formCriarFornecedor fcf = new formCriarFornecedor();
            var resultado = fcf.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                if (fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = fornecedores.Max(x => x.Id) + 1;

                fornecedor.nome = fcf.Nome;
                fornecedor.nomecontato = fcf.NomeContato;
                fornecedor.cnpj = fcf.CNPJ;
                fornecedor.endereco = fcf.Endereco;
                fornecedor.email = fcf.Email;
                fornecedor.telefone = fcf.Telefone;
                fornecedores.Add(fornecedor);
            }
        }

        private void buttonRemoverFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            formCriarCliente fcc = new formCriarCliente();
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();

                if (clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = clientes.Max(x => x.Id) + 1;

                cliente.nome = fcc.Nome;
                cliente.telefone = fcc.Telefone;
                cliente.email = fcc.Email;
                cliente.endereco = fcc.Endereco;
                clientes.Add(cliente);
            }
        }

        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                clientes.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }
    }
}
