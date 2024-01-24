using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadPFJuanReis
{
    public class DatabaseManager
    {
        public void ExecuteNonQuery(string sqlQuery, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new ConexaoClass().conectar())
                {
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) //fim do tratamento de exceções 
            {
                MessageBox.Show("Erro ao obter os dados!\n\n" + ex + ".", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Error); //mostra exceção, se houver 
            }
        }

        public DataTable ExecuteQuery(string sqlQuery, params SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new ConexaoClass().conectar())
                {
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            command.Parameters.AddRange(parameters);

                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex) //fim do tratamento de exceções 
            {
                MessageBox.Show("Erro ao obter os dados!\n\n" + ex + ".", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Error); //mostra exceção, se houver 
            }
            return dataTable;
        }
        public SqlDataReader ExecuteReader(string query, params SqlParameter[] parameters)
        {
            try
            {
                SqlConnection connection = new ConexaoClass().conectar();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddRange(parameters);

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;

            }
            catch (Exception ex) //fim do tratamento de exceções 
            {
                MessageBox.Show("Erro ao obter os dados!\n\n" + ex + ".", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public SqlDataReader ExecuteQuery2(string query, params SqlParameter[] parameters)
        {
            try
            {
                SqlConnection connection = new ConexaoClass().conectar();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddRange(parameters);
                command.CommandTimeout = 80;

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;

            }
            catch (Exception ex) //fim do tratamento de exceções 
            {
                MessageBox.Show("Erro ao obter os dados!\n\n" + ex + ".", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
