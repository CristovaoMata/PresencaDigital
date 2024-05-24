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
    public class RepositorioCursos : ReposiorioMae, IRepositorioCursos
    {
        //Campos
        private readonly string selecionaTodos;
        private readonly string inserir;
        private readonly string modificar;
        private readonly string deletar;

        //Proprieddades...

        //Construtor 
        public RepositorioCursos()
        {
            selecionaTodos = "SELECT * FROM Cursos";

            inserir = "INSERT INTO Cursos VALUES(@nome, @abreviacao)";

            modificar = "UPDATE Cursos SET Nome = @nome, Abreviacao = @abreviacao WHERE ID = @id";

            deletar = "DELETE FROM Cursos WHERE ID = @id";
        }
        public int Adicionar(Cursos entidade)
        {
            Parametros = new List<SqlParameter>
            {
                new SqlParameter("@nome", entidade.Nome),
                new SqlParameter("@abreviacao", entidade.Abreviacao)
            };

            return ExecuteNonQuery(inserir);
        }

        public IEnumerable<Cursos> BuscaTodos()
        {
            var tabelaResultado = ExecuteReader(selecionaTodos);
            var listaCuros = new List<Cursos>();
            foreach (DataRow item in tabelaResultado.Rows)
            {
                listaCuros.Add(new Cursos
                {
                    ID = Convert.ToInt32(item[0]),
                    Nome = item[1].ToString(),
                    Abreviacao = item[2].ToString()
                });
            }
            return listaCuros;
        }

        public int Editar(Cursos entidade)
        {
            Parametros = new List<SqlParameter>
            {
                new SqlParameter("@id", entidade.ID),
                new SqlParameter("@nome", entidade.Nome),
                new SqlParameter("@abreviacao", entidade.Abreviacao)
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
