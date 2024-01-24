namespace CadPFJuanReis
{
    partial class TelaLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.panel_Login = new System.Windows.Forms.Panel();
            this.lbl_títuloTela = new System.Windows.Forms.Label();
            this.pb_Login = new System.Windows.Forms.PictureBox();
            this.btn_EntrarLogin = new System.Windows.Forms.Button();
            this.lbl_UsuarioLogin = new System.Windows.Forms.Label();
            this.txt_SenhaLogin = new System.Windows.Forms.TextBox();
            this.lbl_SenhaLogin = new System.Windows.Forms.Label();
            this.txt_UsuarioLogin = new System.Windows.Forms.TextBox();
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_Login.Controls.Add(this.lbl_títuloTela);
            this.panel_Login.Controls.Add(this.pb_Login);
            this.panel_Login.Controls.Add(this.btn_EntrarLogin);
            this.panel_Login.Controls.Add(this.lbl_UsuarioLogin);
            this.panel_Login.Controls.Add(this.txt_SenhaLogin);
            this.panel_Login.Controls.Add(this.lbl_SenhaLogin);
            this.panel_Login.Controls.Add(this.txt_UsuarioLogin);
            this.panel_Login.Location = new System.Drawing.Point(0, 0);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(474, 253);
            this.panel_Login.TabIndex = 6;
            // 
            // lbl_títuloTela
            // 
            this.lbl_títuloTela.AutoSize = true;
            this.lbl_títuloTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_títuloTela.Location = new System.Drawing.Point(26, 19);
            this.lbl_títuloTela.Name = "lbl_títuloTela";
            this.lbl_títuloTela.Size = new System.Drawing.Size(175, 25);
            this.lbl_títuloTela.TabIndex = 8;
            this.lbl_títuloTela.Text = "Login de Usuário";
            // 
            // pb_Login
            // 
            this.pb_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Login.Image = ((System.Drawing.Image)(resources.GetObject("pb_Login.Image")));
            this.pb_Login.Location = new System.Drawing.Point(251, 41);
            this.pb_Login.Name = "pb_Login";
            this.pb_Login.Size = new System.Drawing.Size(210, 156);
            this.pb_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login.TabIndex = 7;
            this.pb_Login.TabStop = false;
            // 
            // btn_EntrarLogin
            // 
            this.btn_EntrarLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_EntrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EntrarLogin.Location = new System.Drawing.Point(31, 180);
            this.btn_EntrarLogin.Name = "btn_EntrarLogin";
            this.btn_EntrarLogin.Size = new System.Drawing.Size(188, 42);
            this.btn_EntrarLogin.TabIndex = 4;
            this.btn_EntrarLogin.Text = "ENTRAR";
            this.btn_EntrarLogin.UseVisualStyleBackColor = false;
            this.btn_EntrarLogin.Click += new System.EventHandler(this.btn_EntrarLogin_Click);
            // 
            // lbl_UsuarioLogin
            // 
            this.lbl_UsuarioLogin.AutoSize = true;
            this.lbl_UsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsuarioLogin.Location = new System.Drawing.Point(28, 54);
            this.lbl_UsuarioLogin.Name = "lbl_UsuarioLogin";
            this.lbl_UsuarioLogin.Size = new System.Drawing.Size(67, 18);
            this.lbl_UsuarioLogin.TabIndex = 0;
            this.lbl_UsuarioLogin.Text = "Usuário";
            // 
            // txt_SenhaLogin
            // 
            this.txt_SenhaLogin.Location = new System.Drawing.Point(31, 127);
            this.txt_SenhaLogin.Name = "txt_SenhaLogin";
            this.txt_SenhaLogin.PasswordChar = '*';
            this.txt_SenhaLogin.Size = new System.Drawing.Size(188, 22);
            this.txt_SenhaLogin.TabIndex = 3;
            // 
            // lbl_SenhaLogin
            // 
            this.lbl_SenhaLogin.AutoSize = true;
            this.lbl_SenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SenhaLogin.Location = new System.Drawing.Point(28, 106);
            this.lbl_SenhaLogin.Name = "lbl_SenhaLogin";
            this.lbl_SenhaLogin.Size = new System.Drawing.Size(55, 18);
            this.lbl_SenhaLogin.TabIndex = 1;
            this.lbl_SenhaLogin.Text = "Senha";
            // 
            // txt_UsuarioLogin
            // 
            this.txt_UsuarioLogin.Location = new System.Drawing.Point(31, 75);
            this.txt_UsuarioLogin.Name = "txt_UsuarioLogin";
            this.txt_UsuarioLogin.Size = new System.Drawing.Size(188, 22);
            this.txt_UsuarioLogin.TabIndex = 2;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 253);
            this.Controls.Add(this.panel_Login);
            this.MaximizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Button btn_EntrarLogin;
        private System.Windows.Forms.Label lbl_UsuarioLogin;
        private System.Windows.Forms.TextBox txt_SenhaLogin;
        private System.Windows.Forms.Label lbl_SenhaLogin;
        private System.Windows.Forms.TextBox txt_UsuarioLogin;
        private System.Windows.Forms.PictureBox pb_Login;
        private System.Windows.Forms.Label lbl_títuloTela;
    }
}

