namespace Exercicio_de_multiplas_janelas
{
    partial class FormCriarProduto
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
            buttonOk = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            textBoxNome = new TextBox();
            inputPrecoCompra = new NumericUpDown();
            inputPrecoVenda = new NumericUpDown();
            textBoxFabricante = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(12, 122);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(169, 122);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do produto:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(124, 6);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(120, 23);
            textBoxNome.TabIndex = 0;
            // 
            // inputPrecoCompra
            // 
            inputPrecoCompra.DecimalPlaces = 2;
            inputPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoCompra.Location = new Point(124, 64);
            inputPrecoCompra.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            inputPrecoCompra.Name = "inputPrecoCompra";
            inputPrecoCompra.Size = new Size(120, 23);
            inputPrecoCompra.TabIndex = 2;
            inputPrecoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // inputPrecoVenda
            // 
            inputPrecoVenda.DecimalPlaces = 2;
            inputPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoVenda.Location = new Point(124, 93);
            inputPrecoVenda.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            inputPrecoVenda.Name = "inputPrecoVenda";
            inputPrecoVenda.Size = new Size(120, 23);
            inputPrecoVenda.TabIndex = 3;
            inputPrecoVenda.Tag = "";
            inputPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(124, 35);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(120, 23);
            textBoxFabricante.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Fabricante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 1;
            label3.Text = "Preço de compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 95);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 1;
            label4.Text = "Preço de Venda";
            // 
            // FormCriarProduto
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(259, 156);
            Controls.Add(inputPrecoVenda);
            Controls.Add(inputPrecoCompra);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "FormCriarProduto";
            Text = "FormCriarProduto";
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancel;
        private Label label1;
        private TextBox textBoxNome;
        private NumericUpDown inputPrecoCompra;
        private NumericUpDown inputPrecoVenda;
        private TextBox textBoxFabricante;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}