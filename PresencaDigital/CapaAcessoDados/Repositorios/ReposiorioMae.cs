using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAcessoDados.Repositorios
{
    public abstract class ReposiorioMae : Repositorio
    {
        //Lista de parmetros
        protected List<SqlParameter> Parametros;

        /*Medoto que executa qualquer insturnção SQL sem retornar linhas ou registos
         Como: INSERT, DELETE, UPDATE*/
        protected int ExecuteNonQuery(string transactsql)
        {
            using (var conexao = BuscarConexao())
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = transactsql;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter item in Parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    int resultado = comando.ExecuteNonQuery();
                    Parametros.Clear();
                    return resultado;
                }
            } 
        }

        /*Metodo que executa instrunções do tipo SELECT que retorna linhas ou registos*/
        protected DataTable ExecuteReader(string transactsql)
        {
            using (var conexao  = BuscarConexao())
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = transactsql;
                    comando.CommandType = CommandType.Text;
                    SqlDataReader leitor = comando.ExecuteReader();
                    using ( var tabela = new DataTable())
                    {
                        tabela.Load(leitor);
                        leitor.Dispose();
                        return tabela;
                    }
                }
            }
        }
    }
}
