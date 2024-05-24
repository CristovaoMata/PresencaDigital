using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAcessoDados.Contactos
{
    //Interface que define o comportamento das entidades
    public interface IRepositorioGeral<Entidade> where Entidade : class 
    {         
        int Adicionar(Entidade entidade);
        int Editar(Entidade entidade);
        int Remover(int id);
        IEnumerable<Entidade> BuscaTodos();
            
    }
}
