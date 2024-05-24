using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio.ValorObjectos;
using CapaPresentacao.Formulários.SubJanelas.Alunos;
using CapaPresentacao.Formulários.SubJanelas.Cursos;
using CapaPresentacao.Formulários.SubJanelas.Turmas;
using CapaPresentacao.Formulários.SubJanelas.Presença;
using MessageBoxCustomizada;

namespace CapaPresentacao.Formulários.JanelasMenu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            tmContageHoraa.Start();
        }

        private void tmContageHoraa_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToString("D");            
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            AbrirFormularioPanel<FrmAluno>();
            btnAluno.BackColor = Color.FromArgb(40, 45, 60);
            pnlSeparador.Visible = true;
            _btnAluno.Visible = true;           
            pnlAluno.Visible = true;
            
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            AbrirFormularioPanel<FrmCurso>();
            btnCurso.BackColor = Color.FromArgb(40, 45, 60);
            pnlSeparador.Visible = true;
            pnlCurso.Visible = true;
            _btnCurso.Visible = true;
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            AbrirFormularioPanel<FrmTurma>();
            btnTurma.BackColor = Color.FromArgb(40, 45, 60);
            pnlSeparador.Visible = true;
            pnlTurma.Visible = true;
            _btnTurma.Visible = true;
        }

        private void btnPresenca_Click(object sender, EventArgs e)
        {
            // metodo que escolhe qual formulário ele deverá abrir
            FormularioDesejado();
            btnPresenca.BackColor = Color.FromArgb(40, 45, 60);
            pnlSeparador.Visible = true;
            pnlPresenca.Visible = true;
            _btnPresenca.Visible = true;            
        }

        private void FormularioDesejado()
        {
            FrmPresenca formulario;
            formulario = panelPrincipal.Controls.OfType<FrmPresenca>().FirstOrDefault();
            if (formulario == null)
                AbrirFormularioPanel<FrmSelecaoTurma>();
            else
                AbrirFormularioPanel<FrmPresenca>();
        }

        #region Funcionamento do Formulário

        #region Redimencionamento do formulário
        //Metodo para redimencionamenteo O tamanho de um formulário
        private int toleranca = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //Ajustar o Rectangulo/ Excluir a esquema do Panel
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - toleranca, this.ClientRectangle.Height - toleranca, toleranca, toleranca);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }

        //Color do Recrangulo Inferior
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(40, 45, 60));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        #endregion

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

        #region Botões de Controle do Formulário
        //variaveis que capturam a posicão e tamanho da janela antes de maximizar
        int lx, ly;
        int sw, sh;
        private void btnRestorar_Click(object sender, EventArgs e)
        {
            //Restaurar a janela Normal

            btnRestorar.Visible = false;
            btnMaximizar.Visible = true;

            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //Maximizar a janela

            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            btnMaximizar.Visible = false;
            btnRestorar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fechar a Janela
            var resultado = CMMessageBox.Show("Desejas Sair da Aplicação", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.Yes)
                Application.Exit();
            else return;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizar a Janela

            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #endregion

        #region Abrir Formularios

        //Metodo que abre os formulario no panel
        void AbrirFormularioPanel<MeuForm>() where MeuForm : Form, new()
        {
            Form formulario;
            formulario = panelPrincipal.Controls.OfType<MeuForm>().FirstOrDefault();//Busca a conexao
            //Se a instacia não existe instanca o formulario
            if (formulario == null)
            {
                formulario = new MeuForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(formulario);
                panelPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(FechaFormulario);
            }
            //Se a instacia existe abre apenas o formulario
            else
            {
                formulario.BringToFront();                
            }
        }       

        private void FechaFormulario(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmAluno"] == null)
            {
                btnAluno.BackColor = Color.FromArgb(55, 60, 80);
                pnlAluno.Visible = false;
                _btnAluno.Visible = false;
            }
            if (Application.OpenForms["FrmCurso"] == null)
            {
                btnCurso.BackColor = Color.FromArgb(55, 60, 80);
                pnlCurso.Visible = false;
                _btnCurso.Visible = false;
            }
            if(Application.OpenForms["FrmTurma"] == null)
            {
                btnTurma.BackColor = Color.FromArgb(55, 60, 80);
                pnlTurma.Visible = false;
                _btnTurma.Visible = false;
            }
            if(Application.OpenForms["FrmSelecaoTurma"] == null)
            {
                if (ValoresEntidade.IdT != 0)
                {
                    AbrirFormularioPanel<FrmPresenca>();
                }
            }
            if (Application.OpenForms["FrmSelecaoTurma"] == null &&
                Application.OpenForms["FrmPresenca"] == null)
            {
                btnPresenca.BackColor = Color.FromArgb(55, 60, 80);
                pnlPresenca.Visible = false;
                _btnPresenca.Visible = false;
            }


            if (Application.OpenForms["FrmAluno"] == null &&
                Application.OpenForms["FrmCurso"] == null &&
                Application.OpenForms["FrmTurma"] == null &&
                Application.OpenForms["FrmPresenca"] == null &&
                Application.OpenForms["FrmSelecaoTurma"] == null)
                pnlSeparador.Visible = false;

        }

        #endregion

       
        private void FrmMenu_Activated(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirFormularioPanel<FrmHome>();
        }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            panelLateral.Visible = panelLateral.Visible == true ? false : true;
        }
        
        private void FrmMenu_ResizeBegin(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void FrmMenu_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

    }
}
