namespace UrbanGreem_V002
{
    partial class UserControlVendas
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
            this.panela = new System.Windows.Forms.Panel();
            this.btnSubtrairVendas = new System.Windows.Forms.PictureBox();
            this.btnAdicionarVendas = new System.Windows.Forms.PictureBox();
            this.lblProdutoVendas = new System.Windows.Forms.Label();
            this.imagemProdutosVendas = new System.Windows.Forms.PictureBox();
            this.lblQuantidadePedidos = new System.Windows.Forms.Label();
            this.panela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubtrairVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProdutosVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // panela
            // 
            this.panela.BackColor = System.Drawing.Color.White;
            this.panela.Controls.Add(this.lblQuantidadePedidos);
            this.panela.Controls.Add(this.btnSubtrairVendas);
            this.panela.Controls.Add(this.btnAdicionarVendas);
            this.panela.Controls.Add(this.lblProdutoVendas);
            this.panela.Controls.Add(this.imagemProdutosVendas);
            this.panela.Location = new System.Drawing.Point(14, 13);
            this.panela.Name = "panela";
            this.panela.Size = new System.Drawing.Size(1551, 124);
            this.panela.TabIndex = 2;
            // 
            // btnSubtrairVendas
            // 
            this.btnSubtrairVendas.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Botão_menos;
            this.btnSubtrairVendas.Location = new System.Drawing.Point(1024, 0);
            this.btnSubtrairVendas.Name = "btnSubtrairVendas";
            this.btnSubtrairVendas.Size = new System.Drawing.Size(120, 124);
            this.btnSubtrairVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSubtrairVendas.TabIndex = 4;
            this.btnSubtrairVendas.TabStop = false;
            // 
            // btnAdicionarVendas
            // 
            this.btnAdicionarVendas.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Botão_mais;
            this.btnAdicionarVendas.Location = new System.Drawing.Point(724, 0);
            this.btnAdicionarVendas.Name = "btnAdicionarVendas";
            this.btnAdicionarVendas.Size = new System.Drawing.Size(117, 124);
            this.btnAdicionarVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdicionarVendas.TabIndex = 3;
            this.btnAdicionarVendas.TabStop = false;
            // 
            // lblProdutoVendas
            // 
            this.lblProdutoVendas.AutoSize = true;
            this.lblProdutoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoVendas.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProdutoVendas.Location = new System.Drawing.Point(205, 46);
            this.lblProdutoVendas.Name = "lblProdutoVendas";
            this.lblProdutoVendas.Size = new System.Drawing.Size(137, 37);
            this.lblProdutoVendas.TabIndex = 2;
            this.lblProdutoVendas.Text = "Produto";
            // 
            // imagemProdutosVendas
            // 
            this.imagemProdutosVendas.Location = new System.Drawing.Point(16, 0);
            this.imagemProdutosVendas.Name = "imagemProdutosVendas";
            this.imagemProdutosVendas.Size = new System.Drawing.Size(124, 124);
            this.imagemProdutosVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemProdutosVendas.TabIndex = 1;
            this.imagemProdutosVendas.TabStop = false;
            // 
            // lblQuantidadePedidos
            // 
            this.lblQuantidadePedidos.AutoSize = true;
            this.lblQuantidadePedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadePedidos.ForeColor = System.Drawing.Color.Green;
            this.lblQuantidadePedidos.Location = new System.Drawing.Point(885, 46);
            this.lblQuantidadePedidos.Name = "lblQuantidadePedidos";
            this.lblQuantidadePedidos.Size = new System.Drawing.Size(109, 39);
            this.lblQuantidadePedidos.TabIndex = 5;
            this.lblQuantidadePedidos.Text = "label1";
            // 
            // UserControlVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panela);
            this.Name = "UserControlVendas";
            this.Size = new System.Drawing.Size(1579, 150);
            this.panela.ResumeLayout(false);
            this.panela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubtrairVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProdutosVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panela;
        private System.Windows.Forms.PictureBox btnAdicionarVendas;
        private System.Windows.Forms.Label lblProdutoVendas;
        private System.Windows.Forms.PictureBox imagemProdutosVendas;
        private System.Windows.Forms.PictureBox btnSubtrairVendas;
        private System.Windows.Forms.Label lblQuantidadePedidos;
    }
}
