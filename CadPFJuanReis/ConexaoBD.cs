using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadPFJuanReis
{
    public partial class ConexaoBD : Form
    {
        public ConexaoBD()
        {
            InitializeComponent();
        }
       

        private void btn_BuscarServidor_Click_1(object sender, EventArgs e)
        {
            lbl_StatusDeInstancia.Text = "Buscando Instâncias, Por favor aguarde...";
            dgv_Instancia.DataSource = null;
            SqlDataSourceEnumerator sqls = SqlDataSourceEnumerator.Instance;
            Refresh();
            dgv_Instancia.DataSource = sqls.GetDataSources();
            if (dgv_Instancia.Rows.Count == 0)
            {
                lbl_StatusDeInstancia.Text = ("Não foi possível encontrar nenhum servidor!");
            }
            else
            {
                lbl_StatusDeInstancia.Text = ("Servidor encontrado.");
            }
        }

        private void btn_TestarConexao_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=" + txt_Instancia.Text + ";Initial Catalog=" + txt_Banco.Text + ";User ID=SA;Password=masterkey123";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                MessageBox.Show("Conexão com sucesso", "Conectado", MessageBoxButtons.OK);
                cnn.Close();
            }
            catch (SqlException erro) //SqlException é usado para especificar o erro exato de banco de dados
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + "Verifique os dados informados" + erro);
            }
        }

        private void btn_Gravar_Click_1(object sender, EventArgs e)
        {
            ConfigCADPF.SalvarXml(txt_Instancia.Text, txt_Banco.Text, "SIM");
            ListaConexao();
        }

        private void ListaConexao()
        {
            DataTable dataTable = ConfigCADPF.ConfigCADPFGrid();
            dgv_Instancia.DataSource = dataTable;

            string padrao = "SIM";
            foreach (DataGridViewRow row in dgv_Instancia.Rows)
            {
                if (!row.IsNewRow)
                {
                    string PADRAO = row.Cells["Padrao"].Value.ToString();

                    if (padrao.Contains(PADRAO))
                    {
                        row.Cells["Padrao"].Value = true; // Substitua "NomeDaColunaCheckbox" pelo nome correto da coluna
                    }
                    else
                    {
                        row.Cells["Padrao"].Value = false;
                    }
                }
            }
        }

        private void ConexaoBD_Load(object sender, EventArgs e)
        {
            ListaConexao();

            if (dgv_Instancia.RowCount > 0)
            {
                TelaLogin TelaLogin = new TelaLogin();
                TelaLogin.ShowDialog();
                this.Close();
                return;
            }
        }
    }
}