using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CadPFJuanReis
{
    public class ConexaoClass
    {
        SqlConnection con = new SqlConnection();

        //Construtor
        public ConexaoClass()
        {
            //Server.MapPath - serve para pegar o caminho completo no sistema.
            string sCaminhoDoArquivo = @"C:\CADPF\ConfigCADPF.xml";

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(sCaminhoDoArquivo); //Carregando o arquivo

            //Pegando elemento pelo nome da TAG
            XmlNodeList xnList = xmlDoc.GetElementsByTagName("Config");

            //Usando for para imprimir na tela
            for (int i = 0; i < xnList.Count; i++)
            {
                string Padrao = xnList[i]["Padrao"].InnerText;

                if (Padrao == "SIM") //Pegando o campo que tá como padrão
                {
                    string Servidor = xnList[i]["Servidor"].InnerText;
                    string Banco = xnList[i]["Banco"].InnerText;
                    con.ConnectionString = "Data Source=" + Servidor + ";Initial Catalog=" + Banco + ";User ID=SA;Password=masterkey123";
                }
            }
        }

        //Metodo Conectar
        public SqlConnection conectar()
        {
            //verificndo se a minha conexão está Aberto caso não ABRIR
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;

        }
        //Metodo Desconectar
        public void desconectar()
        {
            //verificndo se a minha conexão está Aberto caso sim fecha
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
