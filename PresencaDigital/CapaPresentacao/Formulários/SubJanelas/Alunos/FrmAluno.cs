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
    public partial class FrmAluno : Form
    {
        private ModeloAluno ObjAluno = new ModeloAluno();
        public FrmAluno()
        {
            InitializeComponent();
        }        

        private void OrdenarColunas()
        {            
            dgv.Columns["IdT"].Visible = false;
            dgv.Columns["IdC"].Visible = false;
            dgv.Columns["TurmaId"].Visible = false;
            dgv.Columns["CursoId"].Visible = false;
            dgv.Columns["Disposicao"].Visible = false;            
            dgv.Columns["Idade"].DisplayIndex = 4;
            dgv.Columns["CursoNome"].DisplayIndex = 13;
            dgv.Columns["CursoNome"].HeaderText = "Curso";
            dgv.Columns["Periodo"].HeaderText = "Período";
            dgv.Columns["Abreviacao"].HeaderText = "Abreviação";
            dgv.Columns["NumeroTelefone"].HeaderText = "Nº de Telefone";
            dgv.Columns["NumeroBI"].HeaderText = "Nº Bilhete de Indentidade";
            dgv.Columns["DataNascimento"].HeaderText = "Data de Nascimento";              
        }

        private void ListarAlunos()
        {
            try
            {
                dgv.DataSource = ObjAluno.BuscarTodos();
                OrdenarColunas();
            }

            catch (Exception ex)
            {
                CMMessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            ListarAlunos();
        }

        private void FrmAluno_Activated(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroAluno frm = new FrmCadastroAluno();
            frm.Estado = EstadoEntidade.Adicionando;
            frm.ShowDialog();
            ListarAlunos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if  (dgv.SelectedRows.Count > 0)
            {
                FrmCadastroAluno frm = new FrmCadastroAluno();
                frm.Estado = EstadoEntidade.Modificando;
                frm.ListarCursos();
                frm.ListarTurmas();
                frm.txtID.Texts = dgv.CurrentRow.Cells["ID"].Value.ToString();
                frm.txtNome.Texts = dgv.CurrentRow.Cells["Nome"].Value.ToString();
                frm.txtNumeroBI.Texts = dgv.CurrentRow.Cells["NumeroBI"].Value.ToString();
                frm.txtNumeroTelefone.Texts = dgv.CurrentRow.Cells["NumeroTelefone"].Value.ToString();
                frm.txtEndereco.Texts = dgv.CurrentRow.Cells["Endereco"].Value.ToString();
                frm.pcbDataNascimento.Value = Convert.ToDateTime(dgv.CurrentRow.Cells["DataNascimento"].Value.ToString());
                frm.rbFemenino.Checked = dgv.CurrentRow.Cells["Sexo"].Value.ToString() == "Femenino" ? true : false;
                frm.rbInativo.Checked = dgv.CurrentRow.Cells["Disposicao"].Value.ToString() == "Inactivo" ? true : false;
                frm.cmbClasse.Texts = dgv.CurrentRow.Cells["Classe"].Value.ToString();
                frm.cmbTurma.Texts = dgv.CurrentRow.Cells["Turma"].Value.ToString();
                frm.cmbCurso.Texts = dgv.CurrentRow.Cells["CursoNome"].Value.ToString();               
                frm.lblTitulo.Text = "Editar Aluno";
                frm.ShowDialog();
                ListarAlunos();
            }
            else
                CMMessageBox.Show("Selecione uma liha na Tabela");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count>0)
            {
                var reusultado = CMMessageBox.Show("Deseja Eliminar o aluno: "+dgv.CurrentRow.Cells["Nome"].Value.ToString() + " da " + 
                    dgv.CurrentRow.Cells["Classe"].Value.ToString() + " Turma " + dgv.CurrentRow.Cells["Turma"].Value.ToString() +
                    " do Curso: " + dgv.CurrentRow.Cells["CursoNome"].Value.ToString() + " permanetemente", "",MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (reusultado == DialogResult.Yes)
                {
                    ObjAluno.Estado = EstadoEntidade.Deletando;
                    ObjAluno.Id = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value);
                    string msg = ObjAluno.SalvaMudancas();
                    CMMessageBox.Show(msg);
                    ListarAlunos();
                }
            }
            else CMMessageBox.Show("Ante deves selecionar  uma linha na Tabela");
            
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscaNomeId__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjAluno.FiltroNomeID(txtBuscaNomeId.Texts);
        }

        private void txtBuscaClasse__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjAluno.FiltroClasse(txtBuscaClasse.Texts);
        }

        private void txtBuscaCurso__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjAluno.FiltroCurso(txtBuscaCurso.Texts);
        }

        private void txtBuscaTurma__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjAluno.FiltroTurma(txtBuscaTurma.Texts); 
        }

        private void txtBuscaPeriodo__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjAluno.FiltroPeriodo(txtBuscaPeriodo.Texts);
        }

        private void txtBuscaIdade__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjAluno.FiltroIdade(txtBuscaIdade.Texts);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VerMais();
        }

        private void btnVerMais_Click(object sender, EventArgs e)
        {
            VerMais();
        }

        private void VerMais()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                FrmDetalheAluno frm = new FrmDetalheAluno();
                frm.lblId.Text = dgv.CurrentRow.Cells["Id"].Value.ToString();
                frm.lblNome.Text = dgv.CurrentRow.Cells["Nome"].Value.ToString();
                frm.lblSexo.Text = dgv.CurrentRow.Cells["Sexo"].Value.ToString();
                frm.lblIdade.Text = dgv.CurrentRow.Cells["Idade"].Value.ToString();
                frm.lblNumeroBI.Text = dgv.CurrentRow.Cells["NumeroBI"].Value.ToString();
                frm.lblNumeroTelefone.Text = dgv.CurrentRow.Cells["NumeroTelefone"].Value.ToString();
                frm.lblEndereco.Text = dgv.CurrentRow.Cells["Endereco"].Value.ToString();
                frm.lblClasse.Text = dgv.CurrentRow.Cells["Classe"].Value.ToString();
                frm.lblTurma.Text = dgv.CurrentRow.Cells["Turma"].Value.ToString();
                frm.lblCurso.Text = dgv.CurrentRow.Cells["CursoNome"].Value.ToString();
                frm.lblPeriodo.Text = dgv.CurrentRow.Cells["Periodo"].Value.ToString();
                frm.lblSala.Text = dgv.CurrentRow.Cells["Sala"].Value.ToString();
                frm.ShowDialog();
            }
            else CMMessageBox.Show("Antes deves selecionar uma linha na tabela");
        }
    }
}
