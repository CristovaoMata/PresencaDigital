using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAcessoDados.Entidades
{
    public class Aluno
    {
        //Dados do Aluno
        public int Id { get; set; } 
        public int IdT { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string NumeroBI { get; set; }
        public string Disposicao { get; set; }
        public string NumeroTelefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimeto { get; set; }
        
        //Dados da Turma do Aluno
        public int TurmaId { get; set; }
        public int IdC { get; set; }
        public string Classe { get; set; }
        public string Turma { get; set; }
        public string Periodo { get; set; }
        public int Sala { get; set; }

        //Dados do Curso do Aluno
        public int CursoID { get; set; }
        public string CursoNome { get; set; }
        public string Abreviacao { get; set; }


    }
}
