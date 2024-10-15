using Exercicio_de_multiplas_janelas;
using System.ComponentModel;
using static System.Net.WebRequestMethods;

namespace Exercicio_de_multiplas_janelas
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public BindingList<Cliente> clientes { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }
        public BindingList<Venda> vendas { get; set; }
        public BindingList<Compra> compras { get; set; }



        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            clientes = new BindingList<Cliente>();
            fornecedores = new BindingList<Fornecedor>();
            vendas = new BindingList<Venda>();
            compras = new BindingList<Compra>();
            this.dataGridView1.DataSource = produtos;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormCriarProduto fcp = new FormCriarProduto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();

                if (produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(x => x.Id) + 1;

                produto.Nome = fcp.Nome;
                produto.Fabricante = fcp.Fabricante;
                produto.PrecoVenda = fcp.PrecoVenda;
                produto.PrecoCompra = fcp.PrecoCompra;

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

        private void Produto_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = produtos; }

        private void Cliente_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = clientes; }
       
        private void Venda_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = vendas; }

        private void Forncedor_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = fornecedores; }

        private void Compra_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = compras; }

    }
}
