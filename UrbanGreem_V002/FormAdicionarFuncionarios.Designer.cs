namespace UrbanGreem_V002
{
    partial class FormAdicionarFuncionarios
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
            this.btnSalvarFuncioarios = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailFuncionarios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvarFuncioarios
            // 
            this.btnSalvarFuncioarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFuncioarios.Location = new System.Drawing.Point(152, 173);
            this.btnSalvarFuncioarios.Name = "btnSalvarFuncioarios";
            this.btnSalvarFuncioarios.Size = new System.Drawing.Size(161, 37);
            this.btnSalvarFuncioarios.TabIndex = 25;
            this.btnSalvarFuncioarios.Text = "Salvar";
            this.btnSalvarFuncioarios.UseVisualStyleBackColor = true;
            this.btnSalvarFuncioarios.Click += new System.EventHandler(this.btnSalvarFuncioarios_Click);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(152, 129);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(161, 20);
            this.txtRole.TabIndex = 20;
            this.txtRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRole_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Role:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(152, 92);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(161, 20);
            this.txtSenha.TabIndex = 18;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Senha:";
            // 
            // txtEmailFuncionarios
            // 
            this.txtEmailFuncionarios.Location = new System.Drawing.Point(152, 54);
            this.txtEmailFuncionarios.Name = "txtEmailFuncionarios";
            this.txtEmailFuncionarios.Size = new System.Drawing.Size(161, 20);
            this.txtEmailFuncionarios.TabIndex = 16;
            this.txtEmailFuncionarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailFuncionarios_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "E-mail:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(152, 13);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(161, 20);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuário:";
            // 
            // FormAdicionarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 255);
            this.Controls.Add(this.btnSalvarFuncioarios);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailFuncionarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FormAdicionarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdicionarFuncionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarFuncioarios;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailFuncionarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
    }
}