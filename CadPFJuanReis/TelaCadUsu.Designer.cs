namespace CadPFJuanReis
{
    partial class TelaCadUsu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadUsu));
            this.txt_NomeCadUsu = new System.Windows.Forms.TextBox();
            this.txt_SenhaCadUsu = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_NomeUsu = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_SenhaCadUsu = new System.Windows.Forms.Label();
            this.btn_CadastrarUsuario = new System.Windows.Forms.Button();
            this.lbl_CadastrarUsuario = new System.Windows.Forms.Label();
            this.pb_FotoUsu = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_VoltarCadUsu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NomeCadUsu
            // 
            this.txt_NomeCadUsu.Location = new System.Drawing.Point(15, 74);
            this.txt_NomeCadUsu.Name = "txt_NomeCadUsu";
            this.txt_NomeCadUsu.Size = new System.Drawing.Size(128, 22);
            this.txt_NomeCadUsu.TabIndex = 1;
            // 
            // txt_SenhaCadUsu
            // 
            this.txt_SenhaCadUsu.Location = new System.Drawing.Point(175, 133);
            this.txt_SenhaCadUsu.Name = "txt_SenhaCadUsu";
            this.txt_SenhaCadUsu.PasswordChar = '*';
            this.txt_SenhaCadUsu.Size = new System.Drawing.Size(168, 22);
            this.txt_SenhaCadUsu.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(175, 74);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(168, 22);
            this.txt_Email.TabIndex = 2;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(15, 133);
            this.txt_Telefone.Mask = "(00)00000-0000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(128, 22);
            this.txt_Telefone.TabIndex = 3;
            // 
            // lbl_NomeUsu
            // 
            this.lbl_NomeUsu.AutoSize = true;
            this.lbl_NomeUsu.Location = new System.Drawing.Point(12, 55);
            this.lbl_NomeUsu.Name = "lbl_NomeUsu";
            this.lbl_NomeUsu.Size = new System.Drawing.Size(54, 16);
            this.lbl_NomeUsu.TabIndex = 4;
            this.lbl_NomeUsu.Text = "Usuário";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(172, 55);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(45, 16);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(12, 112);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(107, 16);
            this.lbl_Telefone.TabIndex = 6;
            this.lbl_Telefone.Text = "Telefone/Celular";
            // 
            // lbl_SenhaCadUsu
            // 
            this.lbl_SenhaCadUsu.AutoSize = true;
            this.lbl_SenhaCadUsu.Location = new System.Drawing.Point(172, 114);
            this.lbl_SenhaCadUsu.Name = "lbl_SenhaCadUsu";
            this.lbl_SenhaCadUsu.Size = new System.Drawing.Size(46, 16);
            this.lbl_SenhaCadUsu.TabIndex = 7;
            this.lbl_SenhaCadUsu.Text = "Senha";
            // 
            // btn_CadastrarUsuario
            // 
            this.btn_CadastrarUsuario.Location = new System.Drawing.Point(15, 174);
            this.btn_CadastrarUsuario.Name = "btn_CadastrarUsuario";
            this.btn_CadastrarUsuario.Size = new System.Drawing.Size(328, 23);
            this.btn_CadastrarUsuario.TabIndex = 5;
            this.btn_CadastrarUsuario.Text = "Cadastrar usuário";
            this.btn_CadastrarUsuario.UseVisualStyleBackColor = true;
            this.btn_CadastrarUsuario.Click += new System.EventHandler(this.btn_CadastrarUsuario_Click);
            // 
            // lbl_CadastrarUsuario
            // 
            this.lbl_CadastrarUsuario.AutoSize = true;
            this.lbl_CadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CadastrarUsuario.Location = new System.Drawing.Point(10, 9);
            this.lbl_CadastrarUsuario.Name = "lbl_CadastrarUsuario";
            this.lbl_CadastrarUsuario.Size = new System.Drawing.Size(198, 25);
            this.lbl_CadastrarUsuario.TabIndex = 9;
            this.lbl_CadastrarUsuario.Text = "Cadastrar Usuários";
            // 
            // pb_FotoUsu
            // 
            this.pb_FotoUsu.Image = ((System.Drawing.Image)(resources.GetObject("pb_FotoUsu.Image")));
            this.pb_FotoUsu.Location = new System.Drawing.Point(359, 12);
            this.pb_FotoUsu.Name = "pb_FotoUsu";
            this.pb_FotoUsu.Size = new System.Drawing.Size(214, 173);
            this.pb_FotoUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FotoUsu.TabIndex = 10;
            this.pb_FotoUsu.TabStop = false;
            // 
            // btn_VoltarCadUsu
            // 
            this.btn_VoltarCadUsu.Image = ((System.Drawing.Image)(resources.GetObject("btn_VoltarCadUsu.Image")));
            this.btn_VoltarCadUsu.Location = new System.Drawing.Point(15, 203);
            this.btn_VoltarCadUsu.Name = "btn_VoltarCadUsu";
            this.btn_VoltarCadUsu.Size = new System.Drawing.Size(46, 28);
            this.btn_VoltarCadUsu.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_VoltarCadUsu, "Voltar para tela de cadastros");
            this.btn_VoltarCadUsu.UseVisualStyleBackColor = true;
            this.btn_VoltarCadUsu.Click += new System.EventHandler(this.btn_VoltarCadUsu_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(433, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 36);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TelaCadUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_VoltarCadUsu);
            this.Controls.Add(this.pb_FotoUsu);
            this.Controls.Add(this.lbl_CadastrarUsuario);
            this.Controls.Add(this.btn_CadastrarUsuario);
            this.Controls.Add(this.lbl_SenhaCadUsu);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_NomeUsu);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_SenhaCadUsu);
            this.Controls.Add(this.txt_NomeCadUsu);
            this.MaximizeBox = false;
            this.Name = "TelaCadUsu";
            this.Text = "Cadastro Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomeCadUsu;
        private System.Windows.Forms.TextBox txt_SenhaCadUsu;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.Label lbl_NomeUsu;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_SenhaCadUsu;
        private System.Windows.Forms.Button btn_CadastrarUsuario;
        private System.Windows.Forms.Label lbl_CadastrarUsuario;
        private System.Windows.Forms.PictureBox pb_FotoUsu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_VoltarCadUsu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}