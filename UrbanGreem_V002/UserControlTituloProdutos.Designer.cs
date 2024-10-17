namespace UrbanGreem_V002
{
    partial class UserControlTituloProdutos
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
            this.btnAdicionarProdutos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Titulo__estoque;
            this.pictureBox1.Location = new System.Drawing.Point(-403, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1579, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdicionarProdutos
            // 
            this.btnAdicionarProdutos.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Botão_mais;
            this.btnAdicionarProdutos.Location = new System.Drawing.Point(1406, 0);
            this.btnAdicionarProdutos.Name = "btnAdicionarProdutos";
            this.btnAdicionarProdutos.Size = new System.Drawing.Size(80, 86);
            this.btnAdicionarProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdicionarProdutos.TabIndex = 5;
            this.btnAdicionarProdutos.TabStop = false;
            this.btnAdicionarProdutos.Click += new System.EventHandler(this.btnAdicionarProdutos_Click);
            // 
            // UserControlTituloProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdicionarProdutos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlTituloProdutos";
            this.Size = new System.Drawing.Size(1579, 86);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAdicionarProdutos;
    }
}
