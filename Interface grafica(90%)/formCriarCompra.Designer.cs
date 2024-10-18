namespace projetoLuiz
{
    partial class formCriarCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxProduto = new ComboBox();
            comboBoxFornecedor = new ComboBox();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownDesconto = new NumericUpDown();
            textBoxPrecoUnitario = new TextBox();
            textBoxValorTotal = new TextBox();
            textBoxTotalComDesconto = new TextBox();
            buttonOk = new Button();
            buttonCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            SuspendLayout();
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(161, 12);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(152, 23);
            comboBoxProduto.TabIndex = 0;
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(161, 41);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(152, 23);
            comboBoxFornecedor.TabIndex = 1;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(161, 70);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(152, 23);
            numericUpDownQuantidade.TabIndex = 2;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.Location = new Point(161, 99);
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(152, 23);
            numericUpDownDesconto.TabIndex = 3;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.BackColor = SystemColors.WindowFrame;
            textBoxPrecoUnitario.ForeColor = SystemColors.MenuBar;
            textBoxPrecoUnitario.Location = new Point(161, 128);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.ReadOnly = true;
            textBoxPrecoUnitario.Size = new Size(152, 23);
            textBoxPrecoUnitario.TabIndex = 4;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.BackColor = SystemColors.WindowFrame;
            textBoxValorTotal.ForeColor = SystemColors.MenuBar;
            textBoxValorTotal.Location = new Point(161, 157);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.ReadOnly = true;
            textBoxValorTotal.Size = new Size(152, 23);
            textBoxValorTotal.TabIndex = 5;
            // 
            // textBoxTotalComDesconto
            // 
            textBoxTotalComDesconto.BackColor = SystemColors.WindowFrame;
            textBoxTotalComDesconto.ForeColor = SystemColors.MenuBar;
            textBoxTotalComDesconto.Location = new Point(161, 186);
            textBoxTotalComDesconto.Name = "textBoxTotalComDesconto";
            textBoxTotalComDesconto.ReadOnly = true;
            textBoxTotalComDesconto.Size = new Size(152, 23);
            textBoxTotalComDesconto.TabIndex = 6;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(161, 215);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(238, 215);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 15);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 9;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 49);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 10;
            label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 78);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 11;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 107);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 12;
            label4.Text = "Desconto (%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 136);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 13;
            label5.Text = "Preço Unitário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 165);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 14;
            label6.Text = "Valor Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 194);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 15;
            label7.Text = "Total com Desconto:";
            // 
            // formCriarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 240);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Controls.Add(textBoxTotalComDesconto);
            Controls.Add(textBoxValorTotal);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(comboBoxFornecedor);
            Controls.Add(comboBoxProduto);
            Name = "formCriarCompra";
            Text = "formCriarCompra";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxProduto;
        private ComboBox comboBoxFornecedor;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownDesconto;
        private TextBox textBoxPrecoUnitario;
        private TextBox textBoxValorTotal;
        private TextBox textBoxTotalComDesconto;
        private Button buttonOk;
        private Button buttonCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}