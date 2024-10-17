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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdicionarProduto = new System.Windows.Forms.Label();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.lblQuantidadeEmEstoque = new System.Windows.Forms.Label();
            this.imagemProdutosUser = new System.Windows.Forms.PictureBox();
            this.btnEditaarProduto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProdutosUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditaarProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnEditaarProduto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAdicionarProduto);
            this.panel1.Controls.Add(this.btnExcluirProduto);
            this.panel1.Controls.Add(this.lblValorProduto);
            this.panel1.Controls.Add(this.lblQuantidadeEmEstoque);
            this.panel1.Controls.Add(this.imagemProdutosUser);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1551, 123);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(715, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(405, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade em Estoque:";
            // 
            // lblAdicionarProduto
            // 
            this.lblAdicionarProduto.AutoSize = true;
            this.lblAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarProduto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAdicionarProduto.Location = new System.Drawing.Point(151, 48);
            this.lblAdicionarProduto.Name = "lblAdicionarProduto";
            this.lblAdicionarProduto.Size = new System.Drawing.Size(116, 31);
            this.lblAdicionarProduto.TabIndex = 5;
            this.lblAdicionarProduto.Text = "Produto";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExcluirProduto.Location = new System.Drawing.Point(1051, 37);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(73, 35);
            this.btnExcluirProduto.TabIndex = 4;
            this.btnExcluirProduto.Text = "excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProduto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblValorProduto.Location = new System.Drawing.Point(710, 59);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(51, 20);
            this.lblValorProduto.TabIndex = 2;
            this.lblValorProduto.Text = "Valor";
            // 
            // lblQuantidadeEmEstoque
            // 
            this.lblQuantidadeEmEstoque.AutoSize = true;
            this.lblQuantidadeEmEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeEmEstoque.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblQuantidadeEmEstoque.Location = new System.Drawing.Point(422, 59);
            this.lblQuantidadeEmEstoque.Name = "lblQuantidadeEmEstoque";
            this.lblQuantidadeEmEstoque.Size = new System.Drawing.Size(107, 20);
            this.lblQuantidadeEmEstoque.TabIndex = 1;
            this.lblQuantidadeEmEstoque.Text = "Quantidade \r\n";
            // 
            // imagemProdutosUser
            // 
            this.imagemProdutosUser.Location = new System.Drawing.Point(21, 11);
            this.imagemProdutosUser.Name = "imagemProdutosUser";
            this.imagemProdutosUser.Size = new System.Drawing.Size(100, 101);
            this.imagemProdutosUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemProdutosUser.TabIndex = 0;
            this.imagemProdutosUser.TabStop = false;
            // 
            // btnEditaarProduto
            // 
            this.btnEditaarProduto.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Lapis_editar;
            this.btnEditaarProduto.Location = new System.Drawing.Point(929, 21);
            this.btnEditaarProduto.Name = "btnEditaarProduto";
            this.btnEditaarProduto.Size = new System.Drawing.Size(80, 80);
            this.btnEditaarProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditaarProduto.TabIndex = 16;
            this.btnEditaarProduto.TabStop = false;
            this.btnEditaarProduto.Click += new System.EventHandler(this.btnEditaarProduto_Click);
            // 
            // UserControlProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlProdutos";
            this.Size = new System.Drawing.Size(1579, 149);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProdutosUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditaarProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuantidadeEmEstoque;
        private System.Windows.Forms.Label lblValorProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Label lblAdicionarProduto;
        private System.Windows.Forms.PictureBox imagemProdutosUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnEditaarProduto;
    }
}
