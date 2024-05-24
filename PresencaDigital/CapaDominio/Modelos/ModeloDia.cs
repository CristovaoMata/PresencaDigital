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
    public class ModeloDia : IDisposable
    {
        //Campos
        private int id;
        private DateTime data;
        private string descricao;
        private string stado;

        private IRepositorioDias repositorioDias;
        private List<ModeloDia> listaDia;
        public EstadoEntidade Estado { get; set; }

        //Propriedades /Modelo de Vista/ Validação de Dados
        public int Id { get { return id; } set { id = value; } }
        [Required]
        public DateTime Data { get{ return data;} set {data = value;}}
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public string Stado { get { return stado; } set { stado = value; } }

        //Construtor
        public ModeloDia()
        {
            repositorioDias = new RepositorioDias();
        }

        //Metodos
        public string SalvarMudancas()
        {
            string message = null;
            try
            {
                var ModeloDadosDias = new Dias
                {
                    ID = id,
                    Data = data,
                    Descricao = descricao,
                    Stado = stado
                };

                switch (Estado)
                {
                    case EstadoEntidade.Adicionando:
                        repositorioDias.Adicionar(ModeloDadosDias);
                        message = "Gravada com Sucesso";
                        break;
                    case EstadoEntidade.Deletando:
                        repositorioDias.Remover(id);
                        message = "Eliminado com Sucesso";
                        break;
                    case EstadoEntidade.Modificando:
                        repositorioDias.Editar(ModeloDadosDias);
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

        public IEnumerable<ModeloDia> BuscarTodos()
        {
            var modeloDadosDia = repositorioDias.BuscaTodos();
            listaDia = new List<ModeloDia>();
            foreach (Dias item in modeloDadosDia)
            {
                listaDia.Add(new ModeloDia
                {
                    id = item.ID,
                    data = item.Data,
                    descricao = item.Descricao,
                    stado = item.Stado
                });
            }
            return listaDia;
        }

        public int FiltroIdData(DateTime data)
        {
            var lista = listaDia.Find(e => e.data.ToShortDateString() == data.ToShortDateString());
            int idData = 0;
            if (lista == null) idData = 0;
            else idData = Convert.ToInt32(lista.Id);
            return idData;
        }

        public void Dispose()
        {

        }
    }
}
