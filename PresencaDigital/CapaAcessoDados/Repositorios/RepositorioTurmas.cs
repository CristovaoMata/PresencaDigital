using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAcessoDados.Entidades;
using CapaAcessoDados.Contactos;
using System.Data;
using System.Data.SqlClient;

namespace CapaAcessoDados.Repositorios
{
    public class RepositorioTurmas : ReposiorioMae, IRepositorioTurmas
    {
        //Campos
        private readonly string selecionaTodos;
        private readonly string inserir;
        private readonly string modificar;
        private readonly string deletar;

        //Proprieddades...

        //Construtor 
        public RepositorioTurmas()
        {
            selecionaTodos = "SELECT * FROM Turmas t "+
                             "JOIN Cursos c ON c.ID = t.IdC";

            inserir = "INSERT INTO Turmas VALUES(@idc, @classe, @turma, @periodo, @sala)";

            modificar = "UPDATE Turmas SET IdC = @idc, Classe = @classe, Turma = @turma," +
                        "Periodo = @periodo , Sala = @sala where ID = @id";

            deletar = "DELETE FROM Turmas where ID = @id";

        }
        public int Adicionar(Turmas entidade)
        {
            Parametros = new List<SqlParameter>
            {
               new SqlParameter("@idc", entidade.IdC),
               new SqlParameter("@classe", entidade.Classe),
               new SqlParameter("@turma", entidade.Turma),
               new SqlParameter("@periodo", entidade.Periodo),
               new SqlParameter("@sala", entidade.Sala)
            };
            return ExecuteNonQuery(inserir);
        }

        public IEnumerable<Turmas> BuscaTodos()
        {
            var tabelaResultado = ExecuteReader(selecionaTodos);
            var listaTurmas = new List<Turmas>();
            foreach (DataRow item in tabelaResultado.Rows)
            {
                listaTurmas.Add(new Turmas
                {
                    Id = Convert.ToInt32(item[0]),
                    IdC = Convert.ToInt32(item[1]),
                    Classe = item[2].ToString(),
                    Turma = item[3].ToString(),
                    Periodo = item[4].ToString(),
                    Sala = Convert.ToInt32(item[5]),
                    CursoID = Convert.ToInt32(item[6]),
                    CursoNome = item[7].ToString(),
                    Abreviacao = item[8].ToString()
                });
            }
            return listaTurmas;

        }

        public int Editar(Turmas entidade)
        {
            Parametros = new List<SqlParameter>
            {
               new SqlParameter("@id", entidade.Id),
               new SqlParameter("@idc", entidade.IdC),
               new SqlParameter("@classe", entidade.Classe),
               new SqlParameter("@turma", entidade.Turma),
               new SqlParameter("@periodo", entidade.Periodo),
               new SqlParameter("@sala", entidade.Sala)
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
