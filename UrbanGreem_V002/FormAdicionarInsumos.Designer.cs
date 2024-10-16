namespace UrbanGreem_V002
{
    partial class FormAdicionarInsumos
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
            this.btnSalvarInsumos = new System.Windows.Forms.Button();
            this.txtValorInsumo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidadeInsumo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvarInsumos
            // 
            this.btnSalvarInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarInsumos.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSalvarInsumos.Location = new System.Drawing.Point(143, 132);
            this.btnSalvarInsumos.Name = "btnSalvarInsumos";
            this.btnSalvarInsumos.Size = new System.Drawing.Size(161, 37);
            this.btnSalvarInsumos.TabIndex = 34;
            this.btnSalvarInsumos.Text = "Salvar";
            this.btnSalvarInsumos.UseVisualStyleBackColor = true;
            this.btnSalvarInsumos.Click += new System.EventHandler(this.btnSalvarInsumos_Click);
            // 
            // txtValorInsumo
            // 
            this.txtValorInsumo.Location = new System.Drawing.Point(143, 91);
            this.txtValorInsumo.Name = "txtValorInsumo";
            this.txtValorInsumo.Size = new System.Drawing.Size(161, 20);
            this.txtValorInsumo.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(77, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Valor:";
            // 
            // txtQuantidadeInsumo
            // 
            this.txtQuantidadeInsumo.Location = new System.Drawing.Point(143, 53);
            this.txtQuantidadeInsumo.Name = "txtQuantidadeInsumo";
            this.txtQuantidadeInsumo.Size = new System.Drawing.Size(161, 20);
            this.txtQuantidadeInsumo.TabIndex = 29;
            this.txtQuantidadeInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeInsumo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantidade:";
            // 
            // txtInsumo
            // 
            this.txtInsumo.Location = new System.Drawing.Point(143, 12);
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.Size = new System.Drawing.Size(161, 20);
            this.txtInsumo.TabIndex = 27;
            this.txtInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsumo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Insumo:";
            // 
            // FormAdicionarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 201);
            this.Controls.Add(this.btnSalvarInsumos);
            this.Controls.Add(this.txtValorInsumo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantidadeInsumo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInsumo);
            this.Controls.Add(this.label1);
            this.Name = "FormAdicionarInsumos";
            this.Text = "FormAdicionarInsumos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarInsumos;
        private System.Windows.Forms.TextBox txtValorInsumo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidadeInsumo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.Label label1;
    }
}