using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadPFJuanReis
{
    public class objComandosSql
    {
        public static void InsertCadUsu(string Usuario, string Email, string Telefone, string Senha, byte[] Imagem)
        {
            DatabaseManager InsertCadUsu = new DatabaseManager();
            string InsertQuery = @"INSERT INTO CadUsu (usuario,email,telefone,senha,imagem)
            VALUES (@usuario,@email,@telefone,@senha,@imagem)";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@usuario", Usuario),
                new SqlParameter("@email", Email),
                new SqlParameter("@telefone", Telefone),
                new SqlParameter("@senha", Senha),
                new SqlParameter("@imagem",Imagem)
            };

            InsertCadUsu.ExecuteNonQuery(InsertQuery, parameters);
        }

        public static void InsertCadPF(string Nome, string Sobrenome, DateTime DtNasc, string Email, string CPF, string RG, string Logradouro,
                                        string Numero, string CEP, string Complemento, string Cidade, string Estado, string NomeContato,
                                        string Contato, int TipoContato)
        {
            DatabaseManager InsertCadPF = new DatabaseManager();
            string InsertQuery = @" DECLARE @ID_PF_OUTPUT INT; 
                                    EXEC sp_CadFicha @TIPO = 'I',@ID_PF = @ID_PF_OUTPUT,@NOME = @NOME,@SOBRENOME = @SOBRENOME, @DtNasc = @DtNasc,
                                    @EMAIL = @EMAIL,@CPF = @CPF,@RG = @RG,@LOGRADOURO = @LOGRADOURO,@NUMERO = @NUMERO,@CEP = @CEP,
                                    @COMPLEMENTO = @COMPLEMENTO,@CIDADE = @CIDADE,@ESTADO = @ESTADO,@NOMECONTATO = @NOMECONTATO,@CONTATO = @CONTATO,
                                    @TIPOCONTATO = @TIPOCONTATO";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@NOME", Nome),
                new SqlParameter("@SOBRENOME", Sobrenome),
                new SqlParameter("@DTNASC", DtNasc),
                new SqlParameter("@EMAIL",Email),
                new SqlParameter("@CPF",CPF),
                new SqlParameter("@RG",RG),
                new SqlParameter("@LOGRADOURO",Logradouro),
                new SqlParameter("@NUMERO",Numero),
                new SqlParameter("@CEP",CEP),
                new SqlParameter("@COMPLEMENTO",Complemento),
                new SqlParameter("@CIDADE",Cidade),
                new SqlParameter("@ESTADO",Estado),
                new SqlParameter("@NOMECONTATO",NomeContato),
                new SqlParameter("@CONTATO",Contato),
                new SqlParameter("@TIPOCONTATO",TipoContato)
            };

            InsertCadPF.ExecuteNonQuery(InsertQuery, parameters);
        }

        public static void UpdateCAdPF()
        {

        }
        public static bool AcessoUsuario(string Usuario, string Senha)
        {
            DatabaseManager dbManager = new DatabaseManager();
            string query = @"SELECT * FROM CadUsu Where Usuario = @Usuario and Senha = @Senha";

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Usuario", Usuario);
            parameters[1] = new SqlParameter("@Senha", Senha);

            SqlDataReader reader = dbManager.ExecuteQuery2(query, parameters);

            bool ValidadeAcesso = false;

            if (reader.HasRows)
            {
                reader.Read();
                string usuario = reader["Usuario"].ToString();
                string senha = reader["Senha"].ToString();

                if (usuario == Usuario && senha == Senha)
                    ValidadeAcesso = true;
            }
            return ValidadeAcesso;
        }
        public static DataTable TipoContato()
        {
            DataTable dtTipoContato = new DataTable();

            DatabaseManager dbManager = new DatabaseManager();
            string result = @"select * from TipoContato";

            SqlParameter[] parameters = {};

            dtTipoContato = dbManager.ExecuteQuery(result, parameters);

            return dtTipoContato;
        }
    }
}
