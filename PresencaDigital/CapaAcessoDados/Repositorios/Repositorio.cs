using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaAcessoDados.Repositorios
{
    public abstract class Repositorio
    {
        //variavel que armazena a cadeia de conexão
        private readonly string conexaoString;
        //Construtor da Classe
        public Repositorio()
        {
            //Recebendo a conexão atravez das configurações do sistema 
            conexaoString = ConfigurationManager.ConnectionStrings["conListaPresenca"].ToString();
        }
        //Metodo que retorna uma conexão do SQL
        protected SqlConnection BuscarConexao()
        {
            return new SqlConnection(conexaoString);        
        }
            
    }
}
