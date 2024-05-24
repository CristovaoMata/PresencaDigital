using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.ValorObjectos
{
    public static class ValoresEntidade
    {
        static int idT;

        public static int IdT
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
    }
}
