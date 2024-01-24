using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadPFJuanReis
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btn_EntrarLogin_Click(object sender, EventArgs e)
        {
            //Vai no banco verificar usuário e senha ou entra com o usuário sistema
            bool ValidaAcesso = objComandosSql.AcessoUsuario(txt_UsuarioLogin.Text, txt_SenhaLogin.Text);
            if(txt_UsuarioLogin.Text == "sistema" && txt_SenhaLogin.Text == "123")
            {
                this.Hide();
                TelaCadastros TelaCadastros = new TelaCadastros();
                TelaCadastros.ShowDialog();
            }

            if( ValidaAcesso == true )
            {
                this.Hide();
                TelaCadastros TelaCadastros = new TelaCadastros();
                TelaCadastros.ShowDialog();
            }

            if(ValidaAcesso == false)
            {
                MessageBox.Show("Usuário ou senha incorreto, por favor digite corretamente!","Aviso", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
