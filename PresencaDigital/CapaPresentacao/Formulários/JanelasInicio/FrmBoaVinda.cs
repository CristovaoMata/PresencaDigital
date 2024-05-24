using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacao.Formulários.JanelasMenu;

namespace CapaPresentacao.Formulários.JanelasInicio
{
    public partial class FrmBoaVinda : Form
    {
        public FrmBoaVinda()
        {
            InitializeComponent();
            timer1.Start();
        }
        int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            contador++;
            
            if (contador == 10)
            {
                timer1.Stop();
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Close();
            }
                
        }
    }
}
