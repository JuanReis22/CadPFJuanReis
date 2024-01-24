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
    public partial class TelaCadUsu : Form
    {
        public TelaCadUsu()
        {
            InitializeComponent();
        }

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            //Grava o usuário cadastrado
            objComandosSql.InsertCadUsu(txt_NomeCadUsu.Text,txt_Email.Text,txt_Telefone.Text,txt_SenhaCadUsu.Text);
            MessageBox.Show("Usuário cadastrado com sucesso!");
            foreach(Control btn_CadastrarUsuario in this.Controls)
            {
                if(btn_CadastrarUsuario is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)btn_CadastrarUsuario).Text = "";
                    this.Controls["txt_Telefone"].Text = "";
                }
            }
            return;
        }

        private void btn_VoltarCadUsu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastros TelaCadastros = new TelaCadastros();
            TelaCadastros.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abre os arquivos da máquina para selecionar a imagem
            openFileDialog1.ShowDialog();
            pb_FotoUsu.ImageLocation = openFileDialog1.FileName;
        }
    }
}
