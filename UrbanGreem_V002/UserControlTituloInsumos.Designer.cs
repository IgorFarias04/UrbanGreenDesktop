namespace UrbanGreem_V002
{
    partial class UserControlTituloInsumos
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
            this.btnAdicionarInsumos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Titulo__estoque;
            this.pictureBox1.Location = new System.Drawing.Point(-403, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1579, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdicionarInsumos
            // 
            this.btnAdicionarInsumos.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Botão_mais;
            this.btnAdicionarInsumos.Location = new System.Drawing.Point(1406, 0);
            this.btnAdicionarInsumos.Name = "btnAdicionarInsumos";
            this.btnAdicionarInsumos.Size = new System.Drawing.Size(80, 86);
            this.btnAdicionarInsumos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdicionarInsumos.TabIndex = 6;
            this.btnAdicionarInsumos.TabStop = false;
            this.btnAdicionarInsumos.Click += new System.EventHandler(this.btnAdicionarInsumos_Click);
            // 
            // UserControlTituloInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdicionarInsumos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlTituloInsumos";
            this.Size = new System.Drawing.Size(1579, 86);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarInsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAdicionarInsumos;
    }
}
