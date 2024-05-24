using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAcessoDados.Contactos;
using CapaAcessoDados.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaAcessoDados.Repositorios
{
    public class RepositorioDias : ReposiorioMae, IRepositorioDias
    {
        //Campos
        private readonly string selecionaTodos;
        private readonly string inserir;
        private readonly string modificar;
        private readonly string deletar;

        //Propriedades

        //Construtor
        public RepositorioDias()
        {
            selecionaTodos = "SELECT * FROM Dias";

            inserir = "INSERT INTO Dias VALUES (@data, @descricao, @estado)";

            modificar = "UPDATE Dias SET Descricao = @descricao, Stado = @estado WHERE ID = @id";

            deletar = "DELETE FROM Dias WHERE ID = @id";

        }
        

        public int Adicionar(Dias entidade)
        {
            Parametros = new List<SqlParameter>
            {
                new SqlParameter("@data", entidade.Data),
                new SqlParameter("@descricao", entidade.Descricao),
                new SqlParameter("@estado", entidade.Stado)
            };
            return ExecuteNonQuery(inserir);
        }

        public IEnumerable<Dias> BuscaTodos()
        {
            var tabelaResultado = ExecuteReader(selecionaTodos);
            var listaDias = new List<Dias>();
            foreach (DataRow item in tabelaResultado.Rows)
            {
                listaDias.Add(new Dias
                {
                    ID = Convert.ToInt32(item[0]),
                    Data = Convert.ToDateTime(item[1]),
                    Descricao = item[2].ToString(),
                    Stado = item[3].ToString()
                });                    
            }
            return listaDias;
        }

        public int Editar(Dias entidade)
        {
            Parametros = new List<SqlParameter>
            {
                new SqlParameter("@id", entidade.ID),
                new SqlParameter("@descricao",entidade.Descricao),
                new SqlParameter("@estado", entidade.Stado)
            };
            return ExecuteNonQuery(modificar);
        }

        public int Remover(int id)
        {
            Parametros = new List<SqlParameter>
            {
               new SqlParameter("@id", id)
            };
            return ExecuteNonQuery(deletar);
        }
    }
}
