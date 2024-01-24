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
    public partial class TelaCadastros : Form
    {
        public TelaCadastros()
        {
            InitializeComponent();
        }

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            TelaCadUsu TelaCadUsu = new TelaCadUsu();
            TelaCadUsu.ShowDialog();
        }

        private void btn_CadastrarPessoa_Click(object sender, EventArgs e)
        {
            TelaCadPF TelaCadPF = new TelaCadPF();
            TelaCadPF.ShowDialog();
        }
    }
}
