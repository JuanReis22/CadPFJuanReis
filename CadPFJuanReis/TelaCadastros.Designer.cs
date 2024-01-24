namespace CadPFJuanReis
{
    partial class TelaCadastros
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
            this.btn_CadastrarUsuario = new System.Windows.Forms.Button();
            this.btn_CadastrarPessoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CadastrarUsuario
            // 
            this.btn_CadastrarUsuario.Location = new System.Drawing.Point(3, 28);
            this.btn_CadastrarUsuario.Name = "btn_CadastrarUsuario";
            this.btn_CadastrarUsuario.Size = new System.Drawing.Size(352, 44);
            this.btn_CadastrarUsuario.TabIndex = 0;
            this.btn_CadastrarUsuario.Text = "CADASTRAR NOVO USUÁRIO";
            this.btn_CadastrarUsuario.UseVisualStyleBackColor = true;
            this.btn_CadastrarUsuario.Click += new System.EventHandler(this.btn_CadastrarUsuario_Click);
            // 
            // btn_CadastrarPessoa
            // 
            this.btn_CadastrarPessoa.Location = new System.Drawing.Point(3, 78);
            this.btn_CadastrarPessoa.Name = "btn_CadastrarPessoa";
            this.btn_CadastrarPessoa.Size = new System.Drawing.Size(352, 44);
            this.btn_CadastrarPessoa.TabIndex = 1;
            this.btn_CadastrarPessoa.Text = "CADASTRAR UMA PESSOA FÍSICA";
            this.btn_CadastrarPessoa.UseVisualStyleBackColor = true;
            this.btn_CadastrarPessoa.Click += new System.EventHandler(this.btn_CadastrarPessoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clique na opção desejável:";
            // 
            // TelaCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CadastrarPessoa);
            this.Controls.Add(this.btn_CadastrarUsuario);
            this.MaximizeBox = false;
            this.Name = "TelaCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CadastrarUsuario;
        private System.Windows.Forms.Button btn_CadastrarPessoa;
        private System.Windows.Forms.Label label1;
    }
}