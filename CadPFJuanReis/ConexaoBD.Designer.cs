namespace CadPFJuanReis
{
    partial class ConexaoBD
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
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.lbl_Servidor = new System.Windows.Forms.Label();
            this.txt_Instancia = new System.Windows.Forms.TextBox();
            this.lbl_Banco = new System.Windows.Forms.Label();
            this.txt_Banco = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_BuscarServidor = new System.Windows.Forms.Button();
            this.dgv_Instancia = new System.Windows.Forms.DataGridView();
            this.Servidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Padrao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Configuracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Conexao = new System.Windows.Forms.Label();
            this.btn_TestarConexao = new System.Windows.Forms.Button();
            this.lbl_StatusDeInstancia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Instancia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.Location = new System.Drawing.Point(167, 163);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(145, 32);
            this.btn_Gravar.TabIndex = 3;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click_1);
            // 
            // lbl_Servidor
            // 
            this.lbl_Servidor.AutoSize = true;
            this.lbl_Servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Servidor.Location = new System.Drawing.Point(14, 12);
            this.lbl_Servidor.Name = "lbl_Servidor";
            this.lbl_Servidor.Size = new System.Drawing.Size(79, 20);
            this.lbl_Servidor.TabIndex = 1;
            this.lbl_Servidor.Text = "Servidor";
            // 
            // txt_Instancia
            // 
            this.txt_Instancia.Location = new System.Drawing.Point(17, 31);
            this.txt_Instancia.Name = "txt_Instancia";
            this.txt_Instancia.Size = new System.Drawing.Size(217, 22);
            this.txt_Instancia.TabIndex = 1;
            // 
            // lbl_Banco
            // 
            this.lbl_Banco.AutoSize = true;
            this.lbl_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Banco.Location = new System.Drawing.Point(14, 68);
            this.lbl_Banco.Name = "lbl_Banco";
            this.lbl_Banco.Size = new System.Drawing.Size(62, 20);
            this.lbl_Banco.TabIndex = 2;
            this.lbl_Banco.Text = "Banco";
            // 
            // txt_Banco
            // 
            this.txt_Banco.Location = new System.Drawing.Point(17, 87);
            this.txt_Banco.Name = "txt_Banco";
            this.txt_Banco.Size = new System.Drawing.Size(217, 22);
            this.txt_Banco.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_BuscarServidor);
            this.panel1.Controls.Add(this.btn_Gravar);
            this.panel1.Controls.Add(this.lbl_Servidor);
            this.panel1.Controls.Add(this.txt_Instancia);
            this.panel1.Controls.Add(this.lbl_Banco);
            this.panel1.Controls.Add(this.txt_Banco);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 209);
            this.panel1.TabIndex = 11;
            // 
            // btn_BuscarServidor
            // 
            this.btn_BuscarServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarServidor.Location = new System.Drawing.Point(16, 163);
            this.btn_BuscarServidor.Name = "btn_BuscarServidor";
            this.btn_BuscarServidor.Size = new System.Drawing.Size(145, 32);
            this.btn_BuscarServidor.TabIndex = 7;
            this.btn_BuscarServidor.Text = "Buscar Servidor";
            this.btn_BuscarServidor.UseVisualStyleBackColor = true;
            this.btn_BuscarServidor.Click += new System.EventHandler(this.btn_BuscarServidor_Click_1);
            // 
            // dgv_Instancia
            // 
            this.dgv_Instancia.AllowUserToAddRows = false;
            this.dgv_Instancia.AllowUserToDeleteRows = false;
            this.dgv_Instancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Instancia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Servidor,
            this.Padrao,
            this.Banco,
            this.Filial,
            this.Configuracao});
            this.dgv_Instancia.Location = new System.Drawing.Point(357, 39);
            this.dgv_Instancia.Name = "dgv_Instancia";
            this.dgv_Instancia.ReadOnly = true;
            this.dgv_Instancia.RowHeadersWidth = 10;
            this.dgv_Instancia.RowTemplate.Height = 24;
            this.dgv_Instancia.Size = new System.Drawing.Size(374, 159);
            this.dgv_Instancia.TabIndex = 14;
            // 
            // Servidor
            // 
            this.Servidor.DataPropertyName = "Servidor";
            this.Servidor.HeaderText = "Servidor";
            this.Servidor.MinimumWidth = 6;
            this.Servidor.Name = "Servidor";
            this.Servidor.ReadOnly = true;
            this.Servidor.Width = 125;
            // 
            // Padrao
            // 
            this.Padrao.DataPropertyName = "Padrao";
            this.Padrao.HeaderText = "Padrão";
            this.Padrao.MinimumWidth = 6;
            this.Padrao.Name = "Padrao";
            this.Padrao.ReadOnly = true;
            this.Padrao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Padrao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Padrao.Width = 125;
            // 
            // Banco
            // 
            this.Banco.DataPropertyName = "Banco";
            this.Banco.HeaderText = "Banco";
            this.Banco.MinimumWidth = 6;
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            this.Banco.Width = 125;
            // 
            // Filial
            // 
            this.Filial.DataPropertyName = "Filial";
            this.Filial.HeaderText = "Filial";
            this.Filial.MinimumWidth = 6;
            this.Filial.Name = "Filial";
            this.Filial.ReadOnly = true;
            this.Filial.Visible = false;
            this.Filial.Width = 125;
            // 
            // Configuracao
            // 
            this.Configuracao.DataPropertyName = "Configuracao";
            this.Configuracao.HeaderText = "Configuracao";
            this.Configuracao.MinimumWidth = 6;
            this.Configuracao.Name = "Configuracao";
            this.Configuracao.ReadOnly = true;
            this.Configuracao.Visible = false;
            this.Configuracao.Width = 125;
            // 
            // lbl_Conexao
            // 
            this.lbl_Conexao.AutoSize = true;
            this.lbl_Conexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Conexao.Location = new System.Drawing.Point(12, 4);
            this.lbl_Conexao.Name = "lbl_Conexao";
            this.lbl_Conexao.Size = new System.Drawing.Size(213, 20);
            this.lbl_Conexao.TabIndex = 13;
            this.lbl_Conexao.Text = "Informações de conexão";
            // 
            // btn_TestarConexao
            // 
            this.btn_TestarConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestarConexao.Location = new System.Drawing.Point(597, 204);
            this.btn_TestarConexao.Name = "btn_TestarConexao";
            this.btn_TestarConexao.Size = new System.Drawing.Size(134, 32);
            this.btn_TestarConexao.TabIndex = 12;
            this.btn_TestarConexao.Text = "Testar Conexão";
            this.btn_TestarConexao.UseVisualStyleBackColor = true;
            this.btn_TestarConexao.Click += new System.EventHandler(this.btn_TestarConexao_Click_1);
            // 
            // lbl_StatusDeInstancia
            // 
            this.lbl_StatusDeInstancia.AutoSize = true;
            this.lbl_StatusDeInstancia.Location = new System.Drawing.Point(354, 20);
            this.lbl_StatusDeInstancia.Name = "lbl_StatusDeInstancia";
            this.lbl_StatusDeInstancia.Size = new System.Drawing.Size(10, 16);
            this.lbl_StatusDeInstancia.TabIndex = 15;
            this.lbl_StatusDeInstancia.Text = ".";
            // 
            // ConexaoBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Instancia);
            this.Controls.Add(this.lbl_Conexao);
            this.Controls.Add(this.btn_TestarConexao);
            this.Controls.Add(this.lbl_StatusDeInstancia);
            this.MaximizeBox = false;
            this.Name = "ConexaoBD";
            this.Text = "ConexaBD";
            this.Load += new System.EventHandler(this.ConexaoBD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Instancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Label lbl_Servidor;
        private System.Windows.Forms.TextBox txt_Instancia;
        private System.Windows.Forms.Label lbl_Banco;
        private System.Windows.Forms.TextBox txt_Banco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_BuscarServidor;
        private System.Windows.Forms.DataGridView dgv_Instancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Padrao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Configuracao;
        private System.Windows.Forms.Label lbl_Conexao;
        private System.Windows.Forms.Button btn_TestarConexao;
        private System.Windows.Forms.Label lbl_StatusDeInstancia;
    }
}