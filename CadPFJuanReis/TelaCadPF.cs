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
    public partial class TelaCadPF : Form
    {
        int ID_Tipo;
        public TelaCadPF()
        {
            InitializeComponent();

            DataTable DtTipoContato = objComandosSql.TipoContato();

            // Adiciona uma linha em branco no início do DataTable
            DataRow emptyRow = DtTipoContato.NewRow();
            emptyRow["ID_Tipo"] = DBNull.Value;
            emptyRow["Tipo"] = "";
            DtTipoContato.Rows.InsertAt(emptyRow, 0);

            // Define o ComboBox como o DataSource do DataTable
            cb_TipoContato.DataSource = DtTipoContato;
            cb_TipoContato.ValueMember = "ID_Tipo";
            cb_TipoContato.DisplayMember = "Tipo";
            cb_TipoContato.SelectedItem = "";

            cb_TipoContato.Refresh(); // Faz uma nova busca no BD para preencher os valores do ComboBox de locais.
        }

        private void txt_Cpf_Leave(object sender, EventArgs e)
        {
            if ((txt_Cpf.Text.Length < 11) || (txt_Cpf.Text == "00000000000"))
            {
                MessageBox.Show("O CPF não é valido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cpf.Focus();
                return;
            }
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 }; //Primeiro vetor para 1º multiplicação
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 }; //Segundo vetor para 2º multiplicação
            string CPF = txt_Cpf.Text; //Recebe o CPF
            string auxCPF;
            string Digito;
            int soma;
            int resto;

            CPF = CPF.Trim();//Remove todos os espaçps em branco se tiver, tanto no começo quanto no final
            CPF = CPF.Replace(".", "").Replace("-", "");//Remove todos os espaçps em branco se tiver, tanto no começo quanto no final

            auxCPF = CPF.Substring(0, 9);//aux do cpf pega todos 9 primeiros digitodo valor digitado
            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                //Vai multiplicando e somando ao mesmo tempo para economizar linha com ver multiplicador1
                soma += int.Parse(auxCPF[i].ToString()) * multiplicador1[i];
            }
            resto = soma % 11; //Descrobre o resto de divisão

            if (resto < 2)
            {
                resto = 0; //se menor que 2 vai vaer 0
            }
            else
            {
                resto = 11 - resto; // senao é 11 menos o resto
            }
            Digito = resto.ToString();
            auxCPF = auxCPF + Digito;

            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                //Vai multiplicando e somando ao mesmo tempo para economizar linha com ver multricador2
                soma += int.Parse(auxCPF[i].ToString()) * multiplicador2[i];
            }
            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;

            }
            else
            {
                resto = 11 - resto;
            }
            auxCPF = auxCPF + resto; //Passa o ultimo digito restante pra comparar

            if (CPF == auxCPF == (false))
            {
                MessageBox.Show("O CPF não é valido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cpf.Focus();
                return;
            }
        }

        private void btn_AddNovoEnd_Click(object sender, EventArgs e)
        {
            //Executa as funcionalidades de limpar e habilitar os campos na tela onde recebe dados
            if(sender == btn_AddNovoEnd)
            {
                txt_Logradouro.Enabled = true;
                txt_NumeroEnd.Enabled = true;
                txt_CEP.Enabled = true;
                txt_Complemento.Enabled = true;
                txt_Cidade.Enabled = true;
                cb_Estado.Enabled = true;
            }
            foreach (Control btn_AddNovoEnd in this.Controls)
            {
                if (btn_AddNovoEnd is System.Windows.Forms.TextBox)
                {
                    this.Controls["txt_Logradouro2"].Text = "";
                    this.Controls["txt_NumeroEnd2"].Text = "";
                    this.Controls["txt_CEP2"].Text = "";
                    this.Controls["txt_Complemento2"].Text = "";
                    this.Controls["txt_Cidade2"].Text = "";
                    this.Controls["cb_Estado2"].Text = "";
                }
            }

            if (sender == btn_Remover)
            {
                txt_Logradouro2.Enabled = false;
                txt_NumeroEnd2.Enabled = false;
                txt_CEP2.Enabled = false;
                txt_Complemento2.Enabled = false;
                txt_Cidade2.Enabled = false;
                cb_Estado2.Enabled = false;
            }
        }

        private void btn_AddNovoContato_Click(object sender, EventArgs e)
        {
            //Executa as funcionalidades de limpar e habilitar os campos na tela onde recebe dados
            if (sender == btn_AddNovoContato)
            {
                txt_NomeContato.Enabled = true;
                txt_Contato.Enabled = true;
                cb_TipoContato.Enabled = true;
            }

            foreach (Control btn_RemoverContatos2 in this.Controls)
            {
                if (btn_RemoverContatos2 is System.Windows.Forms.TextBox)
                {
                    this.Controls["txt_NomeContato2"].Text = "";
                    this.Controls["txt_Contato2"].Text = "";
                    this.Controls["cb_TipoContato2"].Text = "";
                }
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txt_DtNascimento.Text, out DateTime dataNascimento))
                objComandosSql.InsertCadPF(txt_Nome.Text, txt_Sobrenome.Text, dataNascimento, txt_EmailCadPF.Text, txt_Cpf.Text, txt_RG.Text,
                                       txt_Logradouro.Text, txt_NumeroEnd.Text, txt_CEP.Text, txt_Complemento.Text, txt_Cidade.Text, cb_Estado.Text,
                                       txt_NomeContato.Text, txt_Contato.Text, ID_Tipo);

            MessageBox.Show("Salva com sucesso", "Aviso");
        }

        private void cb_TipoContato_SelectedValueChanged(object sender, EventArgs e)
        {
            //Vai no banco na tabela TipoContato buscar a identificação pra preencher o cb_TipoContato
            if (cb_TipoContato.SelectedItem != null)
            {
                string ID_Tipo2 = ((DataRowView)cb_TipoContato.SelectedItem)["ID_Tipo"].ToString();

                if(!string.IsNullOrEmpty(ID_Tipo2))
                ID_Tipo = Convert.ToInt32(ID_Tipo2);
            }
            else
            {
                ID_Tipo = 0;
            }
        }

        private void cb_TipoContato2_SelectedValueChanged(object sender, EventArgs e)
        {
            //Vai no banco na tabela TipoContato buscar a identificação pra preencher o cb_TipoContato2
            if (cb_TipoContato.SelectedItem != null)
            {
                string ID_Tipo2 = ((DataRowView)cb_TipoContato.SelectedItem)["ID_Tipo"].ToString();

                if (!string.IsNullOrEmpty(ID_Tipo2))
                    ID_Tipo = Convert.ToInt32(ID_Tipo2);
            }
            else
            {
                ID_Tipo = 0;
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            //Executa as funcionalidades de limpar e habilitar os campos na tela onde recebe dados
            foreach (Control btn_Remover in this.Controls)
            {
                if(btn_Remover is System.Windows.Forms.TextBox)
                {
                    this.Controls["txt_Logradouro"].Text = "";
                    this.Controls["txt_NumeroEnd"].Text = "";
                    this.Controls["txt_CEP"].Text = "";
                    this.Controls["txt_Complemento"].Text = "";
                    this.Controls["txt_Cidade"].Text = "";
                    this.Controls["cb_Estado"].Text = "";
                }
                
                if(sender == btn_Remover)
                {
                    txt_Logradouro.Enabled = false;
                    txt_NumeroEnd.Enabled = false;
                    txt_CEP.Enabled = false;
                    txt_Complemento.Enabled = false;
                    txt_Cidade.Enabled = false;
                    cb_Estado.Enabled = false;
                }

                if(sender == btn_Remover)
                {
                    txt_Logradouro2.Enabled = true;
                    txt_NumeroEnd2.Enabled = true;
                    txt_CEP2.Enabled = true;
                    txt_Complemento2.Enabled = true;
                    txt_Cidade2.Enabled = true;
                    cb_Estado2.Enabled = true;
                }
            }
        }

        private void btn_Remover2_Click(object sender, EventArgs e)
        {
            //Executa as funcionalidades de limpar e habilitar os campos na tela onde recebe dados
            foreach (Control btn_Remover2 in this.Controls)
            {
                if (btn_Remover2 is System.Windows.Forms.TextBox)
                {
                    this.Controls["txt_Logradouro2"].Text = "";
                    this.Controls["txt_NumeroEnd2"].Text = "";
                    this.Controls["txt_CEP2"].Text = "";
                    this.Controls["txt_Complemento2"].Text = "";
                    this.Controls["txt_Cidade2"].Text = "";
                    this.Controls["cb_Estado2"].Text = "";
                }

                if (sender == btn_Remover2)
                {
                    txt_Logradouro2.Enabled = false;
                    txt_NumeroEnd2.Enabled = false;
                    txt_CEP2.Enabled = false;
                    txt_Complemento2.Enabled = false;
                    txt_Cidade2.Enabled = false;
                    cb_Estado2.Enabled = false;
                }
            }
        }

        private void btn_RemoverContatos_Click(object sender, EventArgs e)
        {
            //Executa as funcionalidades de limpar e habilitar os campos na tela onde recebe dados
            foreach (Control btn_RemoverContatos in this.Controls)
            {
                if(btn_RemoverContatos is System.Windows.Forms.TextBox)
                {
                    this.Controls["txt_NomeContato"].Text = "";
                    this.Controls["txt_Contato"].Text = "";
                    this.Controls["cb_TipoContato"].Text = "";
                }

                if(sender == btn_RemoverContatos)
                {
                    txt_NomeContato.Enabled = false;
                    txt_Contato.Enabled = false;
                    cb_TipoContato.Enabled = false;
                }

                if(sender == btn_RemoverContatos)
                {
                    txt_NomeContato2.Enabled = true;
                    txt_Contato2.Enabled = true;
                    cb_TipoContato2.Enabled = true;
                }
            }
        }

        private void btn_RemoverContatos2_Click(object sender, EventArgs e)
        {
            //Executa as funcionalidades de limpar e habilitar os campos na tela onde recebe dados
            foreach (Control btn_RemoverContatos2 in this.Controls)
            {
                if (btn_RemoverContatos2 is System.Windows.Forms.TextBox)
                {
                    this.Controls["txt_NomeContato2"].Text = "";
                    this.Controls["txt_Contato2"].Text = "";
                    this.Controls["cb_TipoContato2"].Text = "";
                }

                if (sender == btn_RemoverContatos2)
                {
                    txt_NomeContato2.Enabled = false;
                    txt_Contato2.Enabled = false;
                    cb_TipoContato2.Enabled = false;
                }
            }
        }
    }
}