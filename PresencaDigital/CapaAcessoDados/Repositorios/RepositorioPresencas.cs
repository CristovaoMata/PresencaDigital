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
    public class RepositorioPresencas : ReposiorioMae, IRepositorioPresencas
    {
        //Campos
        public readonly string selecionarTodos;
        public readonly string inserir;
        public readonly string modificar;
        public readonly string deletar;

        //Propriedades

        //Construtor
        public RepositorioPresencas()
        {
            selecionarTodos = "SELECT p.ID, p.IdA ,a.Nome, p.Referenca, p.Presenca, a.IdT FROM Alunos a " +
                              "JOIN Presencas p ON a.ID = p.IdA " +
                              "JOIN Dias d ON p.Referenca = d.ID ";

            inserir = "INSERT INTO Presencas VALUES(@ida, @referenca, @presenca)";

            modificar = "UPDATE Presencas SET Presenca = @presenca WHERE ID = @id";

            deletar = "DELETE FROM Presencas WHERE ID = @id";
        }

        public int Adicionar(Presenca entidade)
        {
            Parametros = new List<SqlParameter>{
               new SqlParameter("@ida",entidade.IdA),
               new SqlParameter("@referenca", entidade.Referenca),
               new SqlParameter("@presenca", entidade.Presencas)
           };
            return ExecuteNonQuery(inserir);
        }

        public IEnumerable<Presenca> BuscaTodos()
        {
            var tabelaResultado = ExecuteReader(selecionarTodos);
            var listaPresenca = new List<Presenca>();
            foreach (DataRow item in tabelaResultado.Rows)
            {
                listaPresenca.Add(new Presenca
                {
                    ID = Convert.ToInt32(item[0]),
                    IdA = Convert.ToInt32(item[1]),
                    Nome = item[2].ToString(),
                    Referenca = Convert.ToInt32(item[3]),
                    Presencas = item[4].ToString(),
                    IdT = Convert.ToInt32(item[5])
                });               
            }
            return listaPresenca;
        }

        public int Editar(Presenca entidade)
        {
            Parametros = new List<SqlParameter>
            {
                new SqlParameter("@presenca", entidade.Presencas)
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
