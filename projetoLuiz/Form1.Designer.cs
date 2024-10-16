namespace projetoLuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            dataGridView1 = new DataGridView();
            buttonProdutos = new Button();
            buttonVendas = new Button();
            buttonCompra = new Button();
            buttonFornecedor = new Button();
            buttonClientes = new Button();
            buttonAdicionarVenda = new Button();
            buttonRemoverVenda = new Button();
            buttonAdicionarCompra = new Button();
            buttonRemoverCompra = new Button();
            buttonAdicionarFornecedor = new Button();
            button6 = new Button();
            buttonAdicionarCliente = new Button();
            buttonRemoverCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(70, 42);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(75, 23);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(70, 71);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(548, 349);
            dataGridView1.TabIndex = 2;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Location = new Point(70, 12);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(75, 23);
            buttonProdutos.TabIndex = 3;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = true;
            buttonProdutos.Click += buttonViewProdutos_Click;
            // 
            // buttonVendas
            // 
            buttonVendas.Location = new Point(161, 12);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(105, 23);
            buttonVendas.TabIndex = 4;
            buttonVendas.Text = "Vendas";
            buttonVendas.UseVisualStyleBackColor = true;
            buttonVendas.Click += buttonViewVendas_Click;
            // 
            // buttonCompra
            // 
            buttonCompra.Location = new Point(272, 13);
            buttonCompra.Name = "buttonCompra";
            buttonCompra.Size = new Size(105, 23);
            buttonCompra.TabIndex = 5;
            buttonCompra.Text = "Compras";
            buttonCompra.UseVisualStyleBackColor = true;
            buttonCompra.Click += buttonViewCompra_Click;
            // 
            // buttonFornecedor
            // 
            buttonFornecedor.Location = new Point(383, 13);
            buttonFornecedor.Name = "buttonFornecedor";
            buttonFornecedor.Size = new Size(124, 23);
            buttonFornecedor.TabIndex = 6;
            buttonFornecedor.Text = "Fornecedores";
            buttonFornecedor.UseVisualStyleBackColor = true;
            buttonFornecedor.Click += buttonViewFornecedor_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.Location = new Point(513, 13);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(105, 23);
            buttonClientes.TabIndex = 7;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonViewClientes_Click;
            // 
            // buttonAdicionarVenda
            // 
            buttonAdicionarVenda.Location = new Point(161, 42);
            buttonAdicionarVenda.Name = "buttonAdicionarVenda";
            buttonAdicionarVenda.Size = new Size(105, 23);
            buttonAdicionarVenda.TabIndex = 8;
            buttonAdicionarVenda.Text = "Add Venda";
            buttonAdicionarVenda.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverVenda
            // 
            buttonRemoverVenda.Location = new Point(161, 71);
            buttonRemoverVenda.Name = "buttonRemoverVenda";
            buttonRemoverVenda.Size = new Size(105, 23);
            buttonRemoverVenda.TabIndex = 9;
            buttonRemoverVenda.Text = "Remove Venda";
            buttonRemoverVenda.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarCompra
            // 
            buttonAdicionarCompra.Location = new Point(272, 41);
            buttonAdicionarCompra.Name = "buttonAdicionarCompra";
            buttonAdicionarCompra.Size = new Size(105, 23);
            buttonAdicionarCompra.TabIndex = 10;
            buttonAdicionarCompra.Text = "Add Compra";
            buttonAdicionarCompra.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverCompra
            // 
            buttonRemoverCompra.Location = new Point(272, 71);
            buttonRemoverCompra.Name = "buttonRemoverCompra";
            buttonRemoverCompra.Size = new Size(105, 23);
            buttonRemoverCompra.TabIndex = 11;
            buttonRemoverCompra.Text = "Remove Compra";
            buttonRemoverCompra.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.Location = new Point(383, 42);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(124, 23);
            buttonAdicionarFornecedor.TabIndex = 12;
            buttonAdicionarFornecedor.Text = "Add Fornecedor";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(383, 71);
            button6.Name = "button6";
            button6.Size = new Size(124, 23);
            button6.TabIndex = 13;
            button6.Text = "Remove Fornecedor";
            button6.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.Location = new Point(513, 42);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(105, 23);
            buttonAdicionarCliente.TabIndex = 14;
            buttonAdicionarCliente.Text = "Add Cliente";
            buttonAdicionarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.Location = new Point(513, 71);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(105, 23);
            buttonRemoverCliente.TabIndex = 15;
            buttonRemoverCliente.Text = "Remove Cliente";
            buttonRemoverCliente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRemoverCliente);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(button6);
            Controls.Add(buttonAdicionarFornecedor);
            Controls.Add(buttonRemoverCompra);
            Controls.Add(buttonAdicionarCompra);
            Controls.Add(buttonRemoverVenda);
            Controls.Add(buttonAdicionarVenda);
            Controls.Add(buttonClientes);
            Controls.Add(buttonFornecedor);
            Controls.Add(buttonCompra);
            Controls.Add(buttonVendas);
            Controls.Add(buttonProdutos);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionar;
        private Button buttonRemover;
        private DataGridView dataGridView1;
        private Button buttonProdutos;
        private Button buttonVendas;
        private Button buttonCompra;
        private Button buttonFornecedor;
        private Button buttonClientes;
        private Button buttonAdicionarVenda;
        private Button buttonRemoverVenda;
        private Button buttonAdicionarCompra;
        private Button buttonRemoverCompra;
        private Button buttonAdicionarFornecedor;
        private Button button6;
        private Button buttonAdicionarCliente;
        private Button buttonRemoverCliente;
    }
}
