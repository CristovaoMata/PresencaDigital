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
using CapaPresentacao.Formulários.SubJanelas.Turmas;
using CapaPresentacao.Formulários.JanelasMenu;

namespace CapaPresentacao.Formulários.SubJanelas.Presença
{
    public partial class FrmSelecaoTurma : Form
    {
        private ModeloTurma ObjTurma =  new ModeloTurma();
        public FrmSelecaoTurma()
        {
            InitializeComponent();
        }

        private void FrmSelecaoTurma_Load(object sender, EventArgs e)
        {
            ListarCursos();
            ListarTurmas();
            ListarTurmas2();
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

        private void ListarTurmas2()
        {
            using (var ObjTurma2 = new ModeloTurma())
            {
                foreach( var tur in ObjTurma2.BuscarTodos())
                {
                    if (!cmbClasse.Items.Contains(tur.Classe))
                        cmbClasse.Items.Add(tur.Classe);
                    if (cmbClasse.Items.Count != 0)
                        cmbClasse.SelectedIndex = 0;
                    if (!cmbTurma.Items.Contains(tur.Turma))
                        cmbTurma.Items.Add(tur.Turma);
                    if (cmbTurma.Items.Count != 0)
                        cmbTurma.SelectedIndex = 0;
                }
            }
           
        }

        private void ListarCursos()
        {
            ModeloCursos ObjCursos = new ModeloCursos();
            cmbCurso.DataSource = ObjCursos.BuscarTodos();
            cmbCurso.DisplayMember = "Curso";
            cmbCurso.ValueMember = "Id";
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

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ValoresEntidade.IdT= Convert.ToInt32(dgv.CurrentRow.Cells["ID"].Value.ToString());
                this.Close();
            }
            else CMMessageBox.Show("Antes deves Selecionar uma linha na tabela");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
