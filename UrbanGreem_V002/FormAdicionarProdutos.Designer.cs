namespace UrbanGreem_V002
{
    partial class FormAdicionarProdutos
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
            this.txtAdicionarProduto = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadeEmEstoque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.imagemProduto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdicionarProduto
            // 
            this.txtAdicionarProduto.Location = new System.Drawing.Point(13, 55);
            this.txtAdicionarProduto.Name = "txtAdicionarProduto";
            this.txtAdicionarProduto.Size = new System.Drawing.Size(216, 20);
            this.txtAdicionarProduto.TabIndex = 0;
            this.txtAdicionarProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdicionarProduto_KeyPress);
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(13, 197);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(213, 20);
            this.txtValorProduto.TabIndex = 1;
            // 
            // txtQuantidadeEmEstoque
            // 
            this.txtQuantidadeEmEstoque.Location = new System.Drawing.Point(13, 125);
            this.txtQuantidadeEmEstoque.Name = "txtQuantidadeEmEstoque";
            this.txtQuantidadeEmEstoque.Size = new System.Drawing.Size(216, 20);
            this.txtQuantidadeEmEstoque.TabIndex = 2;
            this.txtQuantidadeEmEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeEmEstoque_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade em estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor:";
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProduto.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSalvarProduto.Location = new System.Drawing.Point(51, 241);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(145, 33);
            this.btnSalvarProduto.TabIndex = 6;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarImagem.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdicionarImagem.Location = new System.Drawing.Point(302, 223);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(162, 26);
            this.btnAdicionarImagem.TabIndex = 8;
            this.btnAdicionarImagem.Text = "Adicionar Imagem";
            this.btnAdicionarImagem.UseVisualStyleBackColor = true;
            this.btnAdicionarImagem.Click += new System.EventHandler(this.btnAdicionarImagem_Click);
            // 
            // imagemProduto
            // 
            this.imagemProduto.Image = global::UrbanGreem_V002.Properties.Resources._4211547;
            this.imagemProduto.Location = new System.Drawing.Point(302, 55);
            this.imagemProduto.Name = "imagemProduto";
            this.imagemProduto.Size = new System.Drawing.Size(162, 162);
            this.imagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemProduto.TabIndex = 7;
            this.imagemProduto.TabStop = false;
            // 
            // FormAdicionarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 286);
            this.Controls.Add(this.btnAdicionarImagem);
            this.Controls.Add(this.imagemProduto);
            this.Controls.Add(this.btnSalvarProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantidadeEmEstoque);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.txtAdicionarProduto);
            this.Name = "FormAdicionarProdutos";
            this.Text = "Adicionar Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.imagemProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdicionarProduto;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.TextBox txtQuantidadeEmEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.PictureBox imagemProduto;
        private System.Windows.Forms.Button btnAdicionarImagem;
    }
}