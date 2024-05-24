using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacao.Formulários.SubJanelas.Cursos
{
    public partial class FrmDetalheCurso : Form
    {
        public FrmDetalheCurso()
        {
            InitializeComponent();
        }

        #region Arrastar o Formulário

        private Point _mousePosition;

        //pnlBarra de Titulo 
        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            this.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            _mousePosition = new Point(e.X, e.Y);
        }
        //
        private void pnlBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - _mousePosition.X;
                this.Top = e.Y + this.Top - _mousePosition.Y;
            }

        }
        #endregion

        private void FrmCadastroAluno_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(40, 45, 60), ButtonBorderStyle.Solid);            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
