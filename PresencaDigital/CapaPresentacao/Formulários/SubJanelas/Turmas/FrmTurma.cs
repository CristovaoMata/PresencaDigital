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


namespace CapaPresentacao.Formulários.SubJanelas.Turmas
{
    public partial class FrmTurma : Form
    {
        private ModeloTurma ObjTurma = new ModeloTurma();        

        public FrmTurma()
        {
            InitializeComponent();
            panelCampos.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTurma_Load(object sender, EventArgs e)
        {
            ListarTurmas();
            ListarCursos();
        }

        private void OrdenarColunas()
        {
            dgv.Columns["ID"].Visible = false;
            dgv.Columns["IdC"].Visible = false;
            dgv.Columns["Curso"].DisplayIndex = 4;
            dgv.Columns["Periodo"].HeaderText = "Período";
            dgv.Columns["Abreviacao"].Visible = false;
        }

        private void ListarTurmas()
        {
            try
            {
                dgv.DataSource = ObjTurma.BuscarTodos();
                OrdenarColunas();
            }

            catch (Exception ex)
            {
                CMMessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarCursos()
        {
            ModeloCursos ObjCursos = new ModeloCursos();
            cmbCurso.DataSource = ObjCursos.BuscarTodos();
            cmbCurso.DisplayMember = "Curso";
            cmbCurso.ValueMember = "Id";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            panelCampos.Enabled = true;
            ObjTurma.Estado = EstadoEntidade.Adicionando;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                panelCampos.Enabled = true;
                ObjTurma.Estado = EstadoEntidade.Modificando;
                ObjTurma.ID = Convert.ToInt32(dgv.CurrentRow.Cells["ID"].Value);
                txtClasse.Texts = dgv.CurrentRow.Cells["Classe"].Value.ToString();
                txtTurma.Texts = dgv.CurrentRow.Cells["Turma"].Value.ToString();
                txtSala.Texts = dgv.CurrentRow.Cells["Sala"].Value.ToString();
                cmbPeriodo.Texts = dgv.CurrentRow.Cells["Periodo"].Value.ToString();
                cmbCurso.Texts = dgv.CurrentRow.Cells["Curso"].Value.ToString();

            }
            else CMMessageBox.Show("Antes deves Selecione uma linha na tabela");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                var resultado = CMMessageBox.Show("Desejas Eliminar a " + dgv.CurrentRow.Cells["Classe"].Value.ToString() +
                    " Classe Turma: " + dgv.CurrentRow.Cells["Turma"].Value.ToString() + " Curso: " +
                    dgv.CurrentRow.Cells["Curso"].Value.ToString() + "\n Será Eliminado permanentemente","",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    panelCampos.Enabled = true;
                    ObjTurma.Estado = EstadoEntidade.Deletando;
                    ObjTurma.ID = Convert.ToInt32(dgv.CurrentRow.Cells["ID"].Value);
                    string msg = ObjTurma.SalvarMudancas();
                    CMMessageBox.Show(msg);
                    ListarTurmas();
                }

            }
            else CMMessageBox.Show("Antes deves Selecione uma linha na tabela");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ObjTurma.IdC = Convert.ToInt32(cmbCurso.SelectedValue);
            ObjTurma.Classe = txtClasse.Texts;
            ObjTurma.Turma = txtTurma.Texts;
            if (txtSala.Texts != "")                
                ObjTurma.Sala = Convert.ToInt32(txtSala.Texts);
            ObjTurma.Periodo = cmbPeriodo.Texts;

            bool validado = new Ajudas.ValidacaoDados(ObjTurma).validar();
            if (validado)
            {
                string message = ObjTurma.SalvarMudancas();
                CMMessageBox.Show(message);
                ListarTurmas();
                Voltar();
            }
        }

        private void Voltar()
        {
            panelCampos.Enabled = false;
            txtClasse.Texts = "";
            txtSala.Texts = "";
            txtTurma.Texts = "";
        }

        private void btnVerMais_Click(object sender, EventArgs e)
        {
            VerMais();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VerMais();
        }
        private void VerMais()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                FrmDetalheTurma frm = new FrmDetalheTurma();
                frm.lblClasse.Text = dgv.CurrentRow.Cells["Classe"].Value.ToString();
                frm.lblTurma.Text = dgv.CurrentRow.Cells["Turma"].Value.ToString();
                frm.lblSala.Text = dgv.CurrentRow.Cells["Sala"].Value.ToString();
                frm.lblPeriodo.Text = dgv.CurrentRow.Cells["Periodo"].Value.ToString();
                frm.lblCurso.Text = dgv.CurrentRow.Cells["Curso"].Value.ToString();
                frm.ShowDialog();
            }
            else CMMessageBox.Show("Antes deves Selecionar uma linha na tabela");
        }

        private void txtBuscaClasse__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjTurma.FiltroClasse(txtBuscaClasse.Texts);
        }

        private void txtBuscaTurma__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjTurma.FiltroTurma(txtBuscaTurma.Texts);
        }

        private void txtBuscaCurso__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjTurma.FiltroCurso(txtBuscaCurso.Texts);
        }

        private void txtBuscaPeriodo__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjTurma.FiltroPeriodo(txtBuscaPeriodo.Texts);
        }

        private void txtBuscaSala__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjTurma.FiltroSala(txtBuscaSala.Texts);
        }
    }
}
