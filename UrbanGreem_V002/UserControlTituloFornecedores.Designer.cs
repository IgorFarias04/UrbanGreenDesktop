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
            this.btnAdicionarFornecedores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarFornecedores
            // 
            this.btnAdicionarFornecedores.Location = new System.Drawing.Point(1328, 19);
            this.btnAdicionarFornecedores.Name = "btnAdicionarFornecedores";
            this.btnAdicionarFornecedores.Size = new System.Drawing.Size(128, 53);
            this.btnAdicionarFornecedores.TabIndex = 1;
            this.btnAdicionarFornecedores.Text = "Adicionar Fornecedor";
            this.btnAdicionarFornecedores.UseVisualStyleBackColor = true;
            this.btnAdicionarFornecedores.Click += new System.EventHandler(this.btnAdicionarFornecedores_Click);
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
            // UserControlTituloFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdicionarFornecedores);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlTituloFornecedores";
            this.Size = new System.Drawing.Size(1579, 86);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdicionarFornecedores;
    }
}
