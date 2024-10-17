namespace UrbanGreem_V002
{
    partial class UserControlTituloFornecedores
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdicionarFornecedores = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Titulo_fornecedores;
            this.pictureBox1.Location = new System.Drawing.Point(-403, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1579, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdicionarFornecedores
            // 
            this.btnAdicionarFornecedores.Image = global::UrbanGreem_V002.Properties.Resources.URBAN_GREEN___Botão_mais;
            this.btnAdicionarFornecedores.Location = new System.Drawing.Point(1406, 0);
            this.btnAdicionarFornecedores.Name = "btnAdicionarFornecedores";
            this.btnAdicionarFornecedores.Size = new System.Drawing.Size(80, 86);
            this.btnAdicionarFornecedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdicionarFornecedores.TabIndex = 4;
            this.btnAdicionarFornecedores.TabStop = false;
            this.btnAdicionarFornecedores.Click += new System.EventHandler(this.btnAdicionarFornecedores_Click);
            // 
            // UserControlTituloFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdicionarFornecedores);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlTituloFornecedores";
            this.Size = new System.Drawing.Size(1579, 86);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAdicionarFornecedores;
    }
}
