using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaAcessoDados.Contactos;
using CapaAcessoDados.Entidades;
using System.Data;

namespace CapaAcessoDados.Repositorios
{
    public class RepositorioAlunos : ReposiorioMae, IRepositorioAlunos
    {
        //Campos
        private readonly string selecionaTodos;
        private readonly string inserir;
        private readonly string modificar;
        private readonly string deletar;

        //propriedades...

        //Construtores
        public RepositorioAlunos()
        {
            selecionaTodos = "SELECT * FROM Alunos a " +
                             "JOIN Turmas t ON idt = t.ID " +
                             "JOIN Cursos c ON idc = c.ID";

            inserir = "INSERT INTO Alunos VALUES( @idt," +
                      "@nome, @sexo, @numeroBI, @disposicao," +
                      "@numeroTelefone, @Endereco, @dataNascimento)";
            
            modificar = "UPDATE Alunos SET IdT = @idt, Nome = @nome," +
                        "Sexo = @sexo, NumeroBI = @numeroBI, Disposicao = @disposicao," +
                        "NumeroTelefone = @numeroTelefone, Endereco = @endereco," +
                        "DataNascimento = @dataNascimento WHERE ID = @id";

            deletar = "DELETE FROM Alunos WHERE ID = @id";
        }

        public int Adicionar(Aluno entidade)
        {
            Parametros = new List<SqlParameter>
            {
                new SqlParameter("@idt", entidade.IdT), 
                new SqlParameter("@nome", entidade.Nome),
                new SqlParameter("@sexo", entidade.Sexo),
                new SqlParameter("@numeroBI", entidade.NumeroBI),
                new SqlParameter("@disposicao", entidade.Disposicao),
                new SqlParameter("@numeroTelefone", entidade.NumeroTelefone),
                new SqlParameter("@Endereco", entidade.Endereco),
                new SqlParameter("@dataNascimento", entidade.DataNascimeto)
            };

            return ExecuteNonQuery(inserir);
        }

        public IEnumerable<Aluno> BuscaTodos()
        {
            var tabelaResultado = ExecuteReader(selecionaTodos);
            var listaAlunos = new List<Aluno>();
            foreach (DataRow item in tabelaResultado.Rows)
            {
                listaAlunos.Add(new Aluno
                {
                    //Aluno
                    Id = Convert.ToInt32(item[0]),
                    IdT = Convert.ToInt32(item[1]),
                    Nome = item[2].ToString(),
                    Sexo = item[3].ToString(),
                    NumeroBI = item[4].ToString(),
                    Disposicao = item[5].ToString(),
                    NumeroTelefone = item[6].ToString(),
                    Endereco = item[7].ToString(),
                    DataNascimeto = Convert.ToDateTime(item[8]),
                    //Turma
                    TurmaId = Convert.ToInt32(item[9]),
                    IdC = Convert.ToInt32(item[10]),
                    Classe = item[11].ToString(),
                    Turma = item[12].ToString(),
                    Periodo = item[13].ToString(),
                    Sala = Convert.ToInt32(item[14]),
                    //Curso
                    CursoID = Convert.ToInt32(item[15]),
                    CursoNome = item[16].ToString(),
                    Abreviacao = item[17].ToString()
                });
            }
            return listaAlunos;
        }

        public int Editar(Aluno entidade)
        {
            Parametros = new List<SqlParameter>
            {
                new SqlParameter("@id", entidade.Id),
                new SqlParameter("@idt", entidade.IdT),
                new SqlParameter("@nome", entidade.Nome),
                new SqlParameter("@sexo", entidade.Sexo),
                new SqlParameter("@numeroBI", entidade.NumeroBI),
                new SqlParameter("@disposicao", entidade.Disposicao),
                new SqlParameter("@numeroTelefone", entidade.NumeroTelefone),
                new SqlParameter("@Endereco", entidade.Endereco),
                new SqlParameter("@dataNascimento", entidade.DataNascimeto)
            };

            return ExecuteNonQuery(modificar);
        }

        public int Remover(int id)
        {
            Parametros = new List<SqlParameter>
            {
                new SqlParameter("@id",id)
            };
            return ExecuteNonQuery(deletar);
        }
    }
}
