using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio.Modelos;
using CapaDominio.ValorObjectos;
using MessageBoxCustomizada;

namespace CapaPresentacao.Formulários.SubJanelas.Alunos
{
    public partial class FrmCadastroAluno : Form
    {
        private ModeloAluno ObjAluno = new ModeloAluno();
        private ModeloTurma ObjTurma1 = new ModeloTurma();
        int idTurma = 0;

        public EstadoEntidade Estado { private get; set; }
        public FrmCadastroAluno()
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
            //ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(40, 45, 60), ButtonBorderStyle.Solid);            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroAluno_Load(object sender, EventArgs e)
        {
            if (Estado == EstadoEntidade.Adicionando)
            {
                ListarCursos();
                ListarTurmas();
            }
            ObjAluno.BuscarTodos();                
        }

        public void ListarCursos()
        {
            using (var Objcurso = new ModeloCursos())
            {
                cmbCurso.DataSource = Objcurso.BuscarTodos();
                cmbCurso.DisplayMember = "Curso";
                cmbCurso.ValueMember = "Id";
            }
        }

        public void ListarTurmas()
        {
            using (var ObjTurma = new ModeloTurma())
            {
                foreach (var turma in ObjTurma.BuscarTodos())
                {
                    if (!cmbClasse.Items.Contains(turma.Classe))
                        cmbClasse.Items.Add(turma.Classe);
                    if (cmbClasse.Items.Count != 0)
                        cmbClasse.SelectedIndex = 0;
                    if (!cmbTurma.Items.Contains(turma.Turma))
                        cmbTurma.Items.Add(turma.Turma);
                    if (cmbTurma.Items.Count != 0)
                        cmbTurma.SelectedIndex = 0;
                }
            }
        }

        private void IdTurma()
        {
            ObjTurma1.BuscarTodos();
            idTurma = ObjTurma1.FiltroIdTurma(cmbClasse.Texts, cmbTurma.Texts, Convert.ToInt32(cmbCurso.SelectedValue)); 
        }
         
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            IdTurma();
            if (idTurma != 0)
            {
                switch (Estado)
                {
                    case EstadoEntidade.Adicionando:                        
                         ObjAluno.IdT = idTurma;
                         ObjAluno.Nome = txtNome.Texts;
                         ObjAluno.NumeroBI = txtNumeroBI.Texts;
                         ObjAluno.NumeroTelefone = txtNumeroTelefone.Texts;
                         ObjAluno.Endereco = txtEndereco.Texts;
                         ObjAluno.Estado = EstadoEntidade.Adicionando;
                         ObjAluno.Sexo = rbMasculino.Checked == true ? "Masculino" : "Femenino";
                         ObjAluno.Disposicao = rbActivo.Checked == true ? "Activo" : "Inactivo";
                         ObjAluno.DataNascimento = Convert.ToDateTime(pcbDataNascimento.Value);
                         Validar();
                        break;

                    case EstadoEntidade.Modificando:                        
                         ObjAluno.Id = Convert.ToInt32(txtID.Texts);
                         ObjAluno.IdT = idTurma;
                         ObjAluno.Nome = txtNome.Texts;
                         ObjAluno.NumeroBI = txtNumeroBI.Texts;
                         ObjAluno.NumeroTelefone = txtNumeroTelefone.Texts;
                         ObjAluno.Endereco = txtEndereco.Texts;
                         ObjAluno.Estado = EstadoEntidade.Modificando;
                         ObjAluno.Sexo = rbMasculino.Checked == true ? "Masculino" : "Femenino";
                         ObjAluno.Disposicao = rbActivo.Checked == true ? "Activo" : "Inactivo";
                         ObjAluno.DataNascimento = Convert.ToDateTime(pcbDataNascimento.Value);
                         Validar();
                        break;
                }
            }
            else
                CMMessageBox.Show("No Curso: "+cmbCurso.Texts +" não foi encontrada a "+ cmbClasse.Texts+" Turma: "+
                   cmbTurma.Texts + ", verifique se existe mesmo esta turma, caso contrário cadastra ", "Atenção",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Validar()
        {
            bool validado = new Ajudas.ValidacaoDados(ObjAluno).validar();

            if (validado)
            {
                string resultado = ObjAluno.SalvaMudancas();
                CMMessageBox.Show(resultado);
                this.Close();
            }
        }
    }
}
