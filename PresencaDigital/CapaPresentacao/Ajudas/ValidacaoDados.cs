using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CapaPresentacao.Ajudas
{
    public class ValidacaoDados
    {
        private ValidationContext contexto;
        private List<ValidationResult> resultado;
        private bool valido;
        private string message;

        public ValidacaoDados(object instancia)
        {
            contexto = new ValidationContext(instancia);
            resultado = new List<ValidationResult>();
            valido = Validator.TryValidateObject(instancia, contexto, resultado, true);
        }

        public bool validar()
        {
            if (!valido)
            {
                foreach (ValidationResult item in resultado)
                {
                    message += item.ErrorMessage + "\n";
                }
                MessageBoxCustomizada.CMMessageBox.Show(message,"Erro",System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }
            return valido;
        }
    }
}
