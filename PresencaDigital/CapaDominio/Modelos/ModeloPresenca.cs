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
    public class ModeloPresenca : IDisposable
    {
        //Campos 
        private int id;
        private int idA;
        private string nome;
        private int referenca;
        private string presencas;
        private int idT;


        private IRepositorioPresencas repositorioPresenca;
        private List<ModeloPresenca> listaPresenca;
        private EstadoEntidade Estado { get; set; }

        //Propriedades /Medelo de Vista/ Validação de Dados
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

        public int IdA
        {
            get
            {
                return idA;
            }

            set
            {
                idA = value;
            }
        }

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

        public int Referenca
        {
            get
            {
                return referenca;
            }

            set
            {
                referenca = value;
            }
        }

        public string Presencas
        {
            get
            {
                return presencas;
            }

            set
            {
                presencas = value;
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

        //Construtor
        public ModeloPresenca()
        {
            repositorioPresenca = new RepositorioPresencas();
        }

        //Metodos
        public string SalvarMudancas()
        {
            string message = null;
            try
            {
                var ModeloDadosPresenca = new Presenca
                {
                    ID = id,
                    IdA = idA,
                    Nome = nome,
                    Referenca = referenca,
                    Presencas = presencas,
                    IdT = idT
                };

                switch (Estado)
                {
                    case EstadoEntidade.Adicionando:
                        repositorioPresenca.Adicionar(ModeloDadosPresenca);
                        message = "Gravado com Sucesso";
                        break;
                    case EstadoEntidade.Deletando:
                        repositorioPresenca.Remover(id);
                        message = "Eliminado com Sucesso";
                        break;
                    case EstadoEntidade.Modificando:
                        repositorioPresenca.Editar(ModeloDadosPresenca);
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

        public IEnumerable<ModeloPresenca> BuscarTodos()
        {
            var modeloDadosPresenca = repositorioPresenca.BuscaTodos();
            listaPresenca = new List<ModeloPresenca>();
            foreach (Presenca item in modeloDadosPresenca)
            {
                listaPresenca.Add(new ModeloPresenca
                {
                    id = item.ID,
                    idA = item.IdA,
                    nome = item.Nome,
                    referenca = item.Referenca,
                    presencas = item.Presencas,
                    idT = item.IdT
                });
            }
            return listaPresenca;
        }

        public IEnumerable<ModeloPresenca> FiltroTurma(int idTurma, int referenca)
        {
            return listaPresenca.FindAll(e => e.idT == idTurma && e.referenca == referenca);
        }
        

        public void Dispose()
        {
           
        }
    }
}
