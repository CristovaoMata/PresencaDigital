using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAcessoDados.Entidades
{
    public class Turmas
    {
        public int Id { get; set; }
        public int IdC { get; set; }
        public string Classe { get; set; }
        public string Turma { get; set; }
        public string Periodo { get; set; }
        public int Sala { get; set; }

        //Dados do Curso da Turma
        public int CursoID { get; set; }
        public string CursoNome { get; set; }
        public string Abreviacao { get; set; }
    }
}
