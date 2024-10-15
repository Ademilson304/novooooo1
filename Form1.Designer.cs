namespace Exercicio_de_multiplas_janelas
{
    partial class Form1 : Form
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
            Forncedor = new Button();
            Produto = new Button();
            Cliente = new Button();
            Compra = new Button();
            Venda = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(12, 81);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(140, 23);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(12, 52);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(140, 23);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 328);
            dataGridView1.TabIndex = 2;
            // 
            // Forncedor
            // 
            Forncedor.Location = new Point(469, 12);
            Forncedor.Name = "Forncedor";
            Forncedor.Size = new Size(163, 23);
            Forncedor.TabIndex = 3;
            Forncedor.Text = "Fornecedores";
            Forncedor.UseVisualStyleBackColor = true;
            Forncedor.Click += Forncedor_Click;
            // 
            // Produto
            // 
            Produto.Location = new Point(12, 12);
            Produto.Name = "Produto";
            Produto.Size = new Size(140, 23);
            Produto.TabIndex = 4;
            Produto.Text = "Produtos";
            Produto.UseVisualStyleBackColor = true;
            Produto.Click += Produto_Click;
            // 
            // Cliente
            // 
            Cliente.Location = new Point(170, 14);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(144, 23);
            Cliente.TabIndex = 5;
            Cliente.Text = "Clientes";
            Cliente.UseVisualStyleBackColor = true;
            Cliente.Click += Cliente_Click;
            // 
            // Compra
            // 
            Compra.Location = new Point(638, 12);
            Compra.Name = "Compra";
            Compra.Size = new Size(149, 23);
            Compra.TabIndex = 6;
            Compra.Text = "Compras";
            Compra.UseVisualStyleBackColor = true;
            Compra.Click += Compra_Click;
            // 
            // Venda
            // 
            Venda.Location = new Point(330, 12);
            Venda.Name = "Venda";
            Venda.Size = new Size(133, 23);
            Venda.TabIndex = 7;
            Venda.Text = "Vendas";
            Venda.UseVisualStyleBackColor = true;
            Venda.Click += Venda_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(Venda);
            Controls.Add(Compra);
            Controls.Add(Cliente);
            Controls.Add(Produto);
            Controls.Add(Forncedor);
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
        private Button Forncedor;
        private Button Produto;
        private Button Cliente;
        private Button Compra;
        private Button Venda;
    }
}
