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
            buttonRemoverFornecedor = new Button();
            buttonAdicionarCliente = new Button();
            buttonRemoverCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.Red;
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Location = new Point(12, 60);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(130, 23);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.BackColor = Color.Red;
            buttonRemover.FlatStyle = FlatStyle.Flat;
            buttonRemover.Location = new Point(12, 89);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(130, 23);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = false;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(857, 320);
            dataGridView1.TabIndex = 2;
            // 
            // buttonProdutos
            // 
            buttonProdutos.BackColor = Color.Red;
            buttonProdutos.FlatStyle = FlatStyle.Popup;
            buttonProdutos.Image = Properties.Resources.produto;
            buttonProdutos.ImageAlign = ContentAlignment.TopLeft;
            buttonProdutos.Location = new Point(12, 1);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(130, 52);
            buttonProdutos.TabIndex = 3;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = false;
            buttonProdutos.Click += buttonViewProdutos_Click;
            // 
            // buttonVendas
            // 
            buttonVendas.BackColor = Color.Gold;
            buttonVendas.FlatStyle = FlatStyle.Popup;
            buttonVendas.Image = Properties.Resources.venda;
            buttonVendas.ImageAlign = ContentAlignment.BottomLeft;
            buttonVendas.Location = new Point(185, 1);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(130, 52);
            buttonVendas.TabIndex = 4;
            buttonVendas.Text = "Vendas";
            buttonVendas.UseVisualStyleBackColor = false;
            buttonVendas.Click += buttonViewVendas_Click;
            // 
            // buttonCompra
            // 
            buttonCompra.BackColor = Color.GreenYellow;
            buttonCompra.FlatStyle = FlatStyle.Popup;
            buttonCompra.Image = Properties.Resources.compra;
            buttonCompra.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCompra.Location = new Point(359, 1);
            buttonCompra.Name = "buttonCompra";
            buttonCompra.Size = new Size(130, 52);
            buttonCompra.TabIndex = 5;
            buttonCompra.Text = "Compras";
            buttonCompra.UseVisualStyleBackColor = false;
            buttonCompra.Click += buttonViewCompra_Click;
            // 
            // buttonFornecedor
            // 
            buttonFornecedor.BackColor = Color.SaddleBrown;
            buttonFornecedor.FlatStyle = FlatStyle.Popup;
            buttonFornecedor.Image = Properties.Resources.fornecedor;
            buttonFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFornecedor.Location = new Point(534, 1);
            buttonFornecedor.Name = "buttonFornecedor";
            buttonFornecedor.Size = new Size(151, 52);
            buttonFornecedor.TabIndex = 6;
            buttonFornecedor.Text = "Fornecedores";
            buttonFornecedor.UseVisualStyleBackColor = false;
            buttonFornecedor.Click += buttonViewFornecedor_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.BackColor = Color.Salmon;
            buttonClientes.FlatStyle = FlatStyle.Popup;
            buttonClientes.Image = Properties.Resources.cliente;
            buttonClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClientes.Location = new Point(739, 1);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(130, 52);
            buttonClientes.TabIndex = 7;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = false;
            buttonClientes.Click += buttonViewClientes_Click;
            // 
            // buttonAdicionarVenda
            // 
            buttonAdicionarVenda.BackColor = Color.Gold;
            buttonAdicionarVenda.FlatStyle = FlatStyle.Flat;
            buttonAdicionarVenda.Location = new Point(185, 59);
            buttonAdicionarVenda.Name = "buttonAdicionarVenda";
            buttonAdicionarVenda.Size = new Size(130, 23);
            buttonAdicionarVenda.TabIndex = 8;
            buttonAdicionarVenda.Text = "Add Venda";
            buttonAdicionarVenda.UseVisualStyleBackColor = false;
            buttonAdicionarVenda.Click += buttonAdicionarVenda_Click;
            // 
            // buttonRemoverVenda
            // 
            buttonRemoverVenda.BackColor = Color.Gold;
            buttonRemoverVenda.FlatStyle = FlatStyle.Flat;
            buttonRemoverVenda.Location = new Point(185, 88);
            buttonRemoverVenda.Name = "buttonRemoverVenda";
            buttonRemoverVenda.Size = new Size(130, 23);
            buttonRemoverVenda.TabIndex = 9;
            buttonRemoverVenda.Text = "Remove Venda";
            buttonRemoverVenda.UseVisualStyleBackColor = false;
            buttonRemoverVenda.Click += buttonRemoverVenda_Click;
            // 
            // buttonAdicionarCompra
            // 
            buttonAdicionarCompra.BackColor = Color.YellowGreen;
            buttonAdicionarCompra.FlatStyle = FlatStyle.Flat;
            buttonAdicionarCompra.Location = new Point(359, 59);
            buttonAdicionarCompra.Name = "buttonAdicionarCompra";
            buttonAdicionarCompra.Size = new Size(130, 23);
            buttonAdicionarCompra.TabIndex = 10;
            buttonAdicionarCompra.Text = "Add Compra";
            buttonAdicionarCompra.UseVisualStyleBackColor = false;
            buttonAdicionarCompra.Click += buttonAdicionarCompra_Click;
            // 
            // buttonRemoverCompra
            // 
            buttonRemoverCompra.BackColor = Color.YellowGreen;
            buttonRemoverCompra.FlatStyle = FlatStyle.Flat;
            buttonRemoverCompra.Location = new Point(359, 89);
            buttonRemoverCompra.Name = "buttonRemoverCompra";
            buttonRemoverCompra.Size = new Size(130, 23);
            buttonRemoverCompra.TabIndex = 11;
            buttonRemoverCompra.Text = "Remove Compra";
            buttonRemoverCompra.UseVisualStyleBackColor = false;
            buttonRemoverCompra.Click += buttonRemoverCompra_Click;
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.BackColor = Color.SaddleBrown;
            buttonAdicionarFornecedor.FlatStyle = FlatStyle.Flat;
            buttonAdicionarFornecedor.Location = new Point(534, 59);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(151, 23);
            buttonAdicionarFornecedor.TabIndex = 12;
            buttonAdicionarFornecedor.Text = "Add Fornecedor";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = false;
            buttonAdicionarFornecedor.Click += buttonAdicionarFornecedor_Click;
            // 
            // buttonRemoverFornecedor
            // 
            buttonRemoverFornecedor.BackColor = Color.SaddleBrown;
            buttonRemoverFornecedor.FlatStyle = FlatStyle.Flat;
            buttonRemoverFornecedor.Location = new Point(534, 89);
            buttonRemoverFornecedor.Name = "buttonRemoverFornecedor";
            buttonRemoverFornecedor.Size = new Size(151, 23);
            buttonRemoverFornecedor.TabIndex = 13;
            buttonRemoverFornecedor.Text = "Remove Fornecedor";
            buttonRemoverFornecedor.UseVisualStyleBackColor = false;
            buttonRemoverFornecedor.Click += buttonRemoverFornecedor_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.BackColor = Color.Salmon;
            buttonAdicionarCliente.FlatStyle = FlatStyle.Flat;
            buttonAdicionarCliente.Location = new Point(739, 59);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(130, 23);
            buttonAdicionarCliente.TabIndex = 14;
            buttonAdicionarCliente.Text = "Add Cliente";
            buttonAdicionarCliente.UseVisualStyleBackColor = false;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.BackColor = Color.Salmon;
            buttonRemoverCliente.FlatStyle = FlatStyle.Flat;
            buttonRemoverCliente.Location = new Point(739, 89);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(130, 23);
            buttonRemoverCliente.TabIndex = 15;
            buttonRemoverCliente.Text = "Remove Cliente";
            buttonRemoverCliente.UseVisualStyleBackColor = false;
            buttonRemoverCliente.Click += buttonRemoverCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(884, 441);
            Controls.Add(buttonRemoverCliente);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(buttonRemoverFornecedor);
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
            ForeColor = SystemColors.ActiveCaptionText;
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
        private Button buttonRemoverFornecedor;
        private Button buttonAdicionarCliente;
        private Button buttonRemoverCliente;
    }
}
