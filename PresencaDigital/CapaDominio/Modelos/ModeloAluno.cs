using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.ValorObjectos;
using CapaAcessoDados.Contactos;
using CapaAcessoDados.Entidades;
using CapaAcessoDados.Repositorios;
using System.ComponentModel.DataAnnotations;

namespace CapaDominio.Modelos
{
    public class ModeloAluno : IDisposable
    {
        //Campos
        private int id;
        private int idT;
        private string nome;
        private string sexo;
        private string numeroBI;
        private string disposicao;
        private string numeroTelefone;
        private string endereco;
        private DateTime dataNascimento;
        private int turmaId;
        private int idC;
        private string classe;
        private string turma;
        private string periodo;
        private int sala;
        private int cursoID;
        private string cursoNome;
        private string abreviacao;
        private int idade;

        private IRepositorioAlunos repositorioAluno;
        private List<ModeloAluno> listaAlunos;
        public EstadoEntidade Estado { private get; set; }

        //Propriedades / Modelos de Vista/ Validação de Dados
        /* public int ID { get => id; set => id = value; }
         public int IdT { get => idT; set => idT = value; }
         public string Nome { get => nome; set => nome = value; }
         public string Sexo { get => sexo; set => sexo = value; }
         public string NumeroBI { get => numeroBI; set => numeroBI = value; }
         public string Disposicao { get => disposicao; set => disposicao = value; }
         public string NumeroTelefone { get => numeroTelefone; set => numeroTelefone = value; }
         public string Endereco { get => endereco; set => endereco = value; }
         public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
         public int TurmaId { get => turmaId; set => turmaId = value; }
         public int IdC { get => idC; set => idC = value; }
         public string Classe { get => classe; set => classe = value; }
         public string Turma { get => turma; set => turma = value; }
         public string Periodo { get => periodo; set => periodo = value; }
         public int Sala { get => sala; set => sala = value; }
         public int CursoID { get => cursoID; set => cursoID = value; }
         public string CursoNome { get => cursoNome; set => cursoNome = value; }
         public string Abreviacao { get => abreviacao; set => abreviacao = value; }
         public int Idade { get => idade; set => idade = value; }

     */
        //Construtor 
        public ModeloAluno()
        {
            repositorioAluno = new RepositorioAlunos();
        }

        //Metoos
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int IdT
        {
            get
            {
                return idT;
            }

            set
            {
                idT = value;
            }
        }
        [Required]
        [StringLength(maximumLength: 70, MinimumLength = 4)]
        [RegularExpression(@"^[a-zA-ZÀ-ú\s]+$", ErrorMessage = "O Nome do Aluno apenas deve receber letras")]
        //[RegularExpression(@"^\p{L}+$", ErrorMessage = "O Nome do Aluno apenas deve receber letras")]
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        [Required]
        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 10)]
        public string NumeroBI
        {
            get
            {
                return numeroBI;
            }

            set
            {
                numeroBI = value;
            }
        }

        [Required]
        public string Disposicao
        {
            get
            {
                return disposicao;
            }

            set
            {
                disposicao = value;
            }
        }

        [StringLength(maximumLength: 15)]
        public string NumeroTelefone
        {
            get
            {
                return numeroTelefone;
            }

            set
            {
                numeroTelefone = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                dataNascimento = value;
            }
        }

        public int TurmaId
        {
            get
            {
                return turmaId;
            }

            set
            {
                turmaId = value;
            }
        }

        public int IdC
        {
            get
            {
                return idC;
            }

            set
            {
                idC = value;
            }
        }

        public string Classe
        {
            get
            {
                return classe;
            }

            set
            {
                classe = value;
            }
        }

        public string Turma
        {
            get
            {
                return turma;
            }

            set
            {
                turma = value;
            }
        }

        public string Periodo
        {
            get
            {
                return periodo;
            }

            set
            {
                periodo = value;
            }
        }

        public int Sala
        {
            get
            {
                return sala;
            }

            set
            {
                sala = value;
            }
        }

        public int CursoID
        {
            get
            {
                return cursoID;
            }

            set
            {
                cursoID = value;
            }
        }

        public string CursoNome
        {
            get
            {
                return cursoNome;
            }

            set
            {
                cursoNome = value;
            }
        }

        public string Abreviacao
        {
            get
            {
                return abreviacao;
            }

            set
            {
                abreviacao = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        //Metoos
        public string SalvaMudancas()
        {
            string message = null;
            try
            {
                var ModeloDadosAluno = new Aluno
                {
                    Id = id,
                    IdT = idT,
                    Nome = nome,
                    Sexo = sexo,
                    NumeroBI = numeroBI,
                    Disposicao = disposicao,
                    Endereco = endereco,
                    NumeroTelefone = numeroTelefone,
                    DataNascimeto = dataNascimento,
                    TurmaId = turmaId,
                    IdC = idC,
                    Classe = classe,
                    Turma = turma,
                    Periodo = periodo,
                    Sala = sala,
                    CursoID = cursoID,
                    CursoNome = cursoNome,
                    Abreviacao = abreviacao,
                };

                switch (Estado)
                {
                    case EstadoEntidade.Adicionando:
                        //Executar regras comerciais calculos
                        repositorioAluno.Adicionar(ModeloDadosAluno);
                        message = "Gravado com Sucesso";
                        break;
                    case EstadoEntidade.Deletando:
                        repositorioAluno.Remover(id);
                        message = "Eliminado com Sucesso";
                        break;
                    case EstadoEntidade.Modificando:
                        repositorioAluno.Editar(ModeloDadosAluno);
                        message = "Editdo com Sucesso";
                        break;
                }
            }
            catch (Exception ex)
            {
                message = ex.ToString();
            }
            return message;
        }

        public List<ModeloAluno> BuscarTodos()
        {
            var modeloDadosAluno = repositorioAluno.BuscaTodos();
            listaAlunos = new List<ModeloAluno>();
            foreach (Aluno item in modeloDadosAluno)
            {
                var data = item.DataNascimeto;
                listaAlunos.Add(new ModeloAluno
                {
                    id = item.Id,
                    idT = item.IdT,
                    nome = item.Nome,
                    sexo = item.Sexo,
                    numeroBI = item.NumeroBI,
                    disposicao = item.Disposicao,
                    numeroTelefone = item.NumeroTelefone,
                    endereco = item.Endereco,
                    dataNascimento = item.DataNascimeto,
                    turmaId = item.TurmaId,
                    idC = item.IdC,
                    classe = item.Classe,
                    turma = item.Turma,
                    periodo = item.Periodo,
                    sala = item.Sala,
                    cursoID = item.CursoID,
                    cursoNome = item.CursoNome,
                    abreviacao = item.Abreviacao,
                    idade = CalcularIdade(data)
                });
            }
            return listaAlunos;
        }

        private int CalcularIdade(DateTime data)
        {
            DateTime dateNow = DateTime.Now;
            return dateNow.Year - data.Year;
        }

        public IEnumerable<ModeloAluno> FiltroNomeID(string filtro)
        {
            return listaAlunos.FindAll(e => e.id.ToString().ToLower().Contains(filtro.ToLower()) ||
            e.nome.ToLower().Contains(filtro.ToLower()));
        }

        public IEnumerable<ModeloAluno> FiltroClasse(string filtro)
        {
            return listaAlunos.FindAll(e => e.classe.ToLower().Contains(filtro.ToLower()));
        }

        public IEnumerable<ModeloAluno> FiltroTurma(string filtro)
        {
            return listaAlunos.FindAll(e => e.turma.ToLower().Contains(filtro.ToLower()));
        }

        public IEnumerable<ModeloAluno> FiltroCurso(string filtro)
        {
            return listaAlunos.FindAll(e => e.cursoNome.ToLower().Contains(filtro.ToLower()) ||
            e.abreviacao.ToLower().Contains(filtro.ToLower()));
        }

        public IEnumerable<ModeloAluno> FiltroPeriodo(string filtro)
        {
            return listaAlunos.FindAll(e => e.periodo.ToLower().Contains(filtro.ToLower()));
        }

        public IEnumerable<ModeloAluno> FiltroIdade(string filtro)
        {
            return listaAlunos.FindAll(e => e.idade.ToString() == filtro);
        }

        public IEnumerable<ModeloAluno> FiltroIdTurma(int idTurma)
        {
            return listaAlunos.FindAll(e => e.idT == idTurma);
        }

        public void Dispose()
        {

        }
    }
}