namespace UrbanGreem_V002
{
    partial class UserControlTituloFuncionarios
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
            this.btnAdicionarFuncionarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Titulo_funcionarios;
            this.pictureBox1.Location = new System.Drawing.Point(-402, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1579, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdicionarFuncionarios
            // 
            this.btnAdicionarFuncionarios.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdicionarFuncionarios.Location = new System.Drawing.Point(1328, 19);
            this.btnAdicionarFuncionarios.Name = "btnAdicionarFuncionarios";
            this.btnAdicionarFuncionarios.Size = new System.Drawing.Size(128, 53);
            this.btnAdicionarFuncionarios.TabIndex = 2;
            this.btnAdicionarFuncionarios.Text = "Adicionar Funcionário";
            this.btnAdicionarFuncionarios.UseVisualStyleBackColor = true;
            this.btnAdicionarFuncionarios.Click += new System.EventHandler(this.btnAdicionarFuncionarios_Click);
            // 
            // UserControlTituloFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAdicionarFuncionarios);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlTituloFuncionarios";
            this.Size = new System.Drawing.Size(1579, 86);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdicionarFuncionarios;
    }
}
