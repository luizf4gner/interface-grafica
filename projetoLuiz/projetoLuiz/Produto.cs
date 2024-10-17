using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLuiz
{
    public class Produto
    {
        public int Id { get; set; }
        [DisplayName("Produto")]
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        [DisplayName("Preço de compra")]
        public float PrecoCompra { get; set; }
        [DisplayName("Preço de venda")]
        public float PrecoVenda { get; set; }
    }
    public class Venda
    {
        public int Id { get; set; }
        [DisplayName("Id do Produto")] public int IdProduto { get; set; }
        [DisplayName("Id do Cliente")] public int IdCliente { get; set; }
        [DisplayName("Quantidade Vendida")] public int quantidade { get; set; }
        [DisplayName("Porcentagem de Desconto")] public float desconto { get; set; }
    }
    public class Compra
    {
        public int Id { get; set; }
        [DisplayName("Id do Produto")] public int IdProduto { get; set; }
        [DisplayName("Id do Fornecedor")] public int IdFornecedor { get; set; }
        [DisplayName("Quantidade Comprada")] public int quantidade { get; set; }
        [DisplayName("Porcentagem de Desconto")] public float desconto { get; set; }
    }
    public class Fornecedor
    {
        internal string cnpj;
        internal string nomecontato;

        [DisplayName ("Id")] public int Id { get; set; }
        [DisplayName("Nome do Fornecedor")] public string nome { get; set; }
        [DisplayName("Número de Telefone")] public string telefone { get; set; }
        [DisplayName("Endereço de E-mail")] public string email { get; set; }
        [DisplayName("Endereço Físico")] public string endereco { get; set; }

    }
    public class  Cliente
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Nome do cliente")] public string nome { get; set; }
        [DisplayName("Número de Telefone")] public string telefone { get; set; }
        [DisplayName("Endereço de E-mail")] public string email { get; set; }
        [DisplayName("Endereço Físico")] public string endereco { get; set; }
    }

}
