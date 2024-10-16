namespace UrbanGreem_V002
{
    partial class UserControlProdutos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdicionarProduto = new System.Windows.Forms.Label();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditaarProduto = new System.Windows.Forms.Button();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.lblQuantidadeEmEstoque = new System.Windows.Forms.Label();
            this.imagemProdutosUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProdutosUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblAdicionarProduto);
            this.panel1.Controls.Add(this.btnExcluirProduto);
            this.panel1.Controls.Add(this.btnEditaarProduto);
            this.panel1.Controls.Add(this.lblValorProduto);
            this.panel1.Controls.Add(this.lblQuantidadeEmEstoque);
            this.panel1.Controls.Add(this.imagemProdutosUser);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1551, 123);
            this.panel1.TabIndex = 0;
            // 
            // lblAdicionarProduto
            // 
            this.lblAdicionarProduto.AutoSize = true;
            this.lblAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarProduto.Location = new System.Drawing.Point(160, 51);
            this.lblAdicionarProduto.Name = "lblAdicionarProduto";
            this.lblAdicionarProduto.Size = new System.Drawing.Size(61, 16);
            this.lblAdicionarProduto.TabIndex = 5;
            this.lblAdicionarProduto.Text = "Produto";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(737, 51);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(33, 23);
            this.btnExcluirProduto.TabIndex = 4;
            this.btnExcluirProduto.Text = "excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditaarProduto
            // 
            this.btnEditaarProduto.Location = new System.Drawing.Point(649, 51);
            this.btnEditaarProduto.Name = "btnEditaarProduto";
            this.btnEditaarProduto.Size = new System.Drawing.Size(33, 23);
            this.btnEditaarProduto.TabIndex = 3;
            this.btnEditaarProduto.Text = "Editar";
            this.btnEditaarProduto.UseVisualStyleBackColor = true;
            this.btnEditaarProduto.Click += new System.EventHandler(this.btnEditaarProduto_Click);
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProduto.Location = new System.Drawing.Point(56, 127);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(44, 16);
            this.lblValorProduto.TabIndex = 2;
            this.lblValorProduto.Text = "Valor";
            // 
            // lblQuantidadeEmEstoque
            // 
            this.lblQuantidadeEmEstoque.AutoSize = true;
            this.lblQuantidadeEmEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeEmEstoque.Location = new System.Drawing.Point(303, 51);
            this.lblQuantidadeEmEstoque.Name = "lblQuantidadeEmEstoque";
            this.lblQuantidadeEmEstoque.Size = new System.Drawing.Size(91, 16);
            this.lblQuantidadeEmEstoque.TabIndex = 1;
            this.lblQuantidadeEmEstoque.Text = "Quantidade \r\n";
            // 
            // imagemProdutosUser
            // 
            this.imagemProdutosUser.Location = new System.Drawing.Point(21, 11);
            this.imagemProdutosUser.Name = "imagemProdutosUser";
            this.imagemProdutosUser.Size = new System.Drawing.Size(100, 101);
            this.imagemProdutosUser.TabIndex = 0;
            this.imagemProdutosUser.TabStop = false;
            // 
            // UserControlProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlProdutos";
            this.Size = new System.Drawing.Size(1579, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProdutosUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuantidadeEmEstoque;
        private System.Windows.Forms.PictureBox imagemProdutosUser;
        private System.Windows.Forms.Label lblValorProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditaarProduto;
        private System.Windows.Forms.Label lblAdicionarProduto;
    }
}
