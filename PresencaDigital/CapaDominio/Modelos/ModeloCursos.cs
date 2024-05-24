using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAcessoDados.Contactos;
using CapaAcessoDados.Entidades;
using CapaAcessoDados.Repositorios;
using CapaDominio.ValorObjectos;
using System.ComponentModel.DataAnnotations;

namespace CapaDominio.Modelos
{
    public class ModeloCursos : IDisposable
    {
        //Campos
        private int id;
        private string curso;
        private string abreviacao;

        private IRepositorioCursos repositorioCursos;
        private List<ModeloCursos> listaCursos;
        public EstadoEntidade Estado { private get; set; }

        //Propriedades /Modelo de Vista/ Validação de Dados
        public int Id { get { return id; } set { id=value; } }
        [Required]
        //[RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "O Nome do Curso apenas deve receber letras")]
        [StringLength(maximumLength: 70, MinimumLength = 5)]
        public string Curso { get { return curso; } set { curso=value; } }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 2)]
        public string Abreviacao { get { return abreviacao; } set { abreviacao=value; } }

        //Construtor
        public ModeloCursos()
        {
            repositorioCursos = new RepositorioCursos();
        }

        //Metodos
        public string SalvaMudancas()
        {
            string message = null;
            try
            {
                var ModeloDadosCurso = new Cursos
                {
                    ID = id,
                    Nome = curso,
                    Abreviacao = abreviacao
                };

                switch (Estado)
                {
                    case EstadoEntidade.Adicionando:
                        repositorioCursos.Adicionar(ModeloDadosCurso);
                        message = "Gravado com Sucesso";
                        break;
                    case EstadoEntidade.Deletando:
                        repositorioCursos.Remover(id);
                        message = "Eliminado com Sucesso";
                        break;
                    case EstadoEntidade.Modificando:
                        repositorioCursos.Editar(ModeloDadosCurso);
                        message = "Editado com Sucesso";
                        break;                    
                }
            }
            catch (Exception ex)
            {
                message = ex.ToString();               
            }
            return message;
        }

        public List<ModeloCursos> BuscarTodos()
        {
            var modeloDadosCurso = repositorioCursos.BuscaTodos();
            listaCursos = new List<ModeloCursos>();
            foreach (Cursos item in modeloDadosCurso)
            {
                listaCursos.Add(new ModeloCursos
                {
                    id = item.ID,
                    curso = item.Nome,
                    abreviacao = item.Abreviacao
                });
            }
            return listaCursos;
        }

        public IEnumerable<ModeloCursos> FiltroNome(string filter)
        {
            return listaCursos.FindAll(e => e.curso.ToLower().Contains(filter.ToLower()));
        }

        public IEnumerable<ModeloCursos> FiltroAbreviacao(string filter)
        {
            return listaCursos.FindAll(e => e.abreviacao.ToLower().Contains(filter.ToLower()));
        }

        public IEnumerable<ModeloCursos> FiltroID(int filter)
        {
            return listaCursos.FindAll(e => e.id == filter);
        }

        public void Dispose()
        {
           
        }
    }
}

