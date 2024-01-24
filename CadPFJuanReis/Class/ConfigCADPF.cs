using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CadPFJuanReis
{
    public class ConfigCADPF
    {
        public static void SalvarXml(string Servidor, string Banco, string Padrao)
        {
            // Criar um novo documento XML
            XmlDocument xmlDoc = new XmlDocument();

            // Criar o elemento raiz <Config>
            XmlElement configElement = xmlDoc.CreateElement("Config");
            configElement.SetAttribute("Configuracao", "CADPF");

            // Adicionar elementos filhos dentro de <Config>
            configElement.AppendChild(CreateElement(xmlDoc, "Servidor", Servidor));
            configElement.AppendChild(CreateElement(xmlDoc, "Banco", Banco));
            configElement.AppendChild(CreateElement(xmlDoc, "Padrao", Padrao));
            configElement.AppendChild(CreateElement(xmlDoc, "Filial", ""));

            // Adicionar o elemento <Config> ao documento
            xmlDoc.AppendChild(configElement);

            // Salvar o documento XML em um arquivo
            string filePath = "C:\\CADPF\\ConfigCADPF.xml";

            try
            {
                xmlDoc.Save(filePath);
                Console.WriteLine("Arquivo XML salvo com sucesso em: " + filePath);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Erro de permissão: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar o arquivo XML: {ex.Message}");
            }
        }

        // Método auxiliar para criar elementos XML
        static XmlElement CreateElement(XmlDocument xmlDoc, string tagName, string innerText)
        {
            XmlElement element = xmlDoc.CreateElement(tagName);
            element.InnerText = innerText;
            return element;
        }

        public static DataTable ConfigCADPFGrid()
        {

            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            string filePath = @"C:\CADPF\ConfigCADPF.xml";

            if (System.IO.File.Exists(filePath))
            {
                dataSet.ReadXml(@filePath);
                // Obter a primeira tabela do DataSet (assumindo que há apenas uma tabela)
                dataTable = dataSet.Tables.Count > 0 ? dataSet.Tables[0] : null;

                // Verificar se a tabela foi carregada
                if (dataTable != null)
                {
                    DataGridView dataGridView = new DataGridView();
                }
                else
                {
                    Console.WriteLine("Não foi possível carregar o XML ou não há dados na tabela.");
                }

            }
            return dataTable;
        }
    }
}
