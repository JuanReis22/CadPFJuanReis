using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private byte[] ConvertImageToByteArray(System.Windows.Forms.PictureBox pictureBox)
        {
            //criado a array para utilizar o metodo de gravação de imagem
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            return ms.ToArray();
        }

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            //Convertido a pb_FotoUsu para variável imagemBytes, para ser chamado
            byte[] imagemBytes = ConvertImageToByteArray(pb_FotoUsu);

            //Grava o usuário cadastrado
            objComandosSql.InsertCadUsu(txt_NomeCadUsu.Text,txt_Email.Text,txt_Telefone.Text,txt_SenhaCadUsu.Text, imagemBytes);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Abre os arquivos da máquina para selecionar a imagem
            openFileDialog1.ShowDialog();
            pb_FotoUsu.ImageLocation = openFileDialog1.FileName;
        }
    }
}
