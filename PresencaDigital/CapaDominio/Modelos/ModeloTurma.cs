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
    public class ModeloTurma : IDisposable
    {
        //Campos
        private int id;
        private int idC;
        private string classe;
        private string turma;
        private string periodo;
        private int sala;
        private string curso;
        private string abreviacao;

        private IRepositorioTurmas repositorioTurmas;
        private List<ModeloTurma> listaTurma;
        public EstadoEntidade Estado { private get; set; }

        //Propriedades/ Modelos de vista/ Validação de Dados
        public int ID { get { return id; } set { id=value; } }
        public int IdC { get { return idC; } set { idC=value; } }
        [Required]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public string Classe { get { return classe; } set { classe=value; } }
        [Required]
        [StringLength(maximumLength: 2, MinimumLength = 1)]
        public string Turma { get { return turma; } set { turma=value; } }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 1)]
        public string Periodo { get { return periodo; } set { periodo=value; } }
        [Required]
        [RegularExpression("([0-9]+)", ErrorMessage = "Apena deves usar Números")]
        public int Sala { get { return sala; } set { sala=value; } }
        public string Curso { get { return curso; } set { curso=value; } }
        public string Abreviacao { get { return abreviacao; } set { abreviacao=value; } }


        //Construtor
        public ModeloTurma()
        {
            repositorioTurmas = new RepositorioTurmas();
        }

        //Metodos
        public string SalvarMudancas()
        {
            string message = null;
            try
            {
                var ModeloDadosTurma = new Turmas
                {
                    Id = id,
                    IdC = idC,
                    Classe = classe,
                    Turma = turma,
                    Sala = sala,
                    Periodo = periodo,
                };

                switch (Estado)
                {
                    case EstadoEntidade.Adicionando:
                        repositorioTurmas.Adicionar(ModeloDadosTurma);
                        message = "Gravado com Sucesso";
                        break;
                    case EstadoEntidade.Deletando:
                        repositorioTurmas.Remover(id);
                        message = "Eliminado com Sucesso";
                        break;
                    case EstadoEntidade.Modificando:
                        repositorioTurmas.Editar(ModeloDadosTurma);
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

        public List<ModeloTurma> BuscarTodos()
        {
            var modeloDadosTurma = repositorioTurmas.BuscaTodos();
            listaTurma = new List<ModeloTurma>();
            foreach (Turmas item in modeloDadosTurma)
            {
                var id_curso = item.IdC;
                listaTurma.Add(new ModeloTurma
                {
                    id = item.Id,
                    idC = item.IdC,
                    classe = item.Classe,
                    turma = item.Turma,
                    periodo = item.Periodo,
                    sala = item.Sala,
                    curso = item.CursoNome,
                    abreviacao = item.Abreviacao
                });
            }
            return listaTurma;
        }

        public int FiltroIdTurma(string classe, string turma, int idCurso)
        {
            var lista = listaTurma.Find(e => e.idC == idCurso && e.classe == classe && e.turma == turma);
            int idTurma = 0;
            if (lista == null) idTurma = 0;
            else idTurma = Convert.ToInt32(lista.id.ToString());
            return idTurma;
        }

        public IEnumerable<ModeloTurma> FiltroClasse(string filter)
        {
            return listaTurma.FindAll(e => e.classe.ToLower().Contains(filter.ToLower()));
        }

        public IEnumerable<ModeloTurma> FiltroTurma(string filter)
        {
            return listaTurma.FindAll(e => e.turma.ToLower().Contains(filter.ToLower()));
        }

        public IEnumerable<ModeloTurma> FiltroCurso(string filter)
        {
            return listaTurma.FindAll(e => e.curso.ToLower().Contains(filter.ToLower()) || 
            e.abreviacao.ToLower().Contains(filter.ToLower()));
        }

        public IEnumerable<ModeloTurma> FiltroPeriodo(string filter)
        {
            return listaTurma.FindAll(e => e.periodo.ToLower().Contains(filter.ToLower()));
        }

        public IEnumerable<ModeloTurma> FiltroSala(string filter)
        {
            return listaTurma.FindAll(e => e.sala.ToString().Contains(filter));
        }


        public void Dispose()
        {
         
        }
    }
}
