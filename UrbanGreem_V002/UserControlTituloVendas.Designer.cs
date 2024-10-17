namespace UrbanGreem_V002
{
    partial class UserControlTituloVendas
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtComprador = new System.Windows.Forms.TextBox();
            this.txtProdutosVendas = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFinalizarPedidos = new System.Windows.Forms.Button();
            this.btnCarrinho = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Titulo__vendas;
            this.pictureBox1.Location = new System.Drawing.Point(-403, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1579, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtComprador
            // 
            this.txtComprador.Location = new System.Drawing.Point(409, 35);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.Size = new System.Drawing.Size(212, 20);
            this.txtComprador.TabIndex = 2;
            // 
            // txtProdutosVendas
            // 
            this.txtProdutosVendas.Location = new System.Drawing.Point(976, 33);
            this.txtProdutosVendas.Name = "txtProdutosVendas";
            this.txtProdutosVendas.Size = new System.Drawing.Size(212, 20);
            this.txtProdutosVendas.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Botão_pesquisar;
            this.pictureBox2.Location = new System.Drawing.Point(1180, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btnFinalizarPedidos
            // 
            this.btnFinalizarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedidos.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnFinalizarPedidos.Location = new System.Drawing.Point(627, 33);
            this.btnFinalizarPedidos.Name = "btnFinalizarPedidos";
            this.btnFinalizarPedidos.Size = new System.Drawing.Size(131, 24);
            this.btnFinalizarPedidos.TabIndex = 24;
            this.btnFinalizarPedidos.Text = "Finalizar Pedido";
            this.btnFinalizarPedidos.UseVisualStyleBackColor = true;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Icone_carrinho;
            this.btnCarrinho.Location = new System.Drawing.Point(1485, 0);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(91, 86);
            this.btnCarrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCarrinho.TabIndex = 25;
            this.btnCarrinho.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(412, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome do comprador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(980, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Pesquisar Produto:";
            // 
            // UserControlTituloVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.btnFinalizarPedidos);
            this.Controls.Add(this.txtProdutosVendas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtComprador);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlTituloVendas";
            this.Size = new System.Drawing.Size(1579, 86);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtComprador;
        private System.Windows.Forms.TextBox txtProdutosVendas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFinalizarPedidos;
        private System.Windows.Forms.PictureBox btnCarrinho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
