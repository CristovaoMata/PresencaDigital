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

namespace CapaPresentacao.Formulários.SubJanelas.Cursos
{
    public partial class FrmCurso : Form
    {
        private ModeloCursos ObjCurso = new ModeloCursos();
        public FrmCurso()
        {
            InitializeComponent();
            panelCampos.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            ListarCursos();
        }

        private void OrdenarColunas()
        {
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["Abreviacao"].HeaderText = "Abreviação";
        }

        private void ListarCursos()
        {
            try
            {
                dgv.DataSource = ObjCurso.BuscarTodos();
                OrdenarColunas();
            }

            catch (Exception ex)
            {
                CMMessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            panelCampos.Enabled = true;
            ObjCurso.Estado = EstadoEntidade.Adicionando;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                panelCampos.Enabled = true;
                ObjCurso.Estado = EstadoEntidade.Modificando;
                ObjCurso.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                txtNome.Texts    = dgv.CurrentRow.Cells[1].Value.ToString();
                txtAbreviacao.Texts = dgv.CurrentRow.Cells[2].Value.ToString();
            }
            else CMMessageBox.Show("Antes deves Selecione uma linha na tabela");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                var resultado = CMMessageBox.Show("Desejas Eliminar o Curso: " + dgv.CurrentRow.Cells[1].Value.ToString() +
                    "(" + dgv.CurrentRow.Cells[2].Value.ToString() + ")\n Será Eliminado permanentemente", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    ObjCurso.Estado = EstadoEntidade.Deletando;
                    ObjCurso.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    string msg = ObjCurso.SalvaMudancas();
                    CMMessageBox.Show(msg);
                    ListarCursos();
                }
                
            }
            else CMMessageBox.Show("Antes deves Selecione uma linha na tabela");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ObjCurso.Curso = txtNome.Texts;
            ObjCurso.Abreviacao = txtAbreviacao.Texts;

            bool validado = new Ajudas.ValidacaoDados(ObjCurso).validar();
            if (validado)
            {
                string resultado = ObjCurso.SalvaMudancas();
                CMMessageBox.Show(resultado);
                ListarCursos();
                Voltar();
            }
        }

        private void Voltar()
        {
            panelCampos.Enabled = false;
            txtAbreviacao.Texts = "";
            txtNome.Texts = "";
        }

        private void txtBuscaNome__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjCurso.FiltroNome(txtBuscaNome.Texts);
        }

        private void txtBuscaAbreviacao__textChaged(object sender, EventArgs e)
        {
            dgv.DataSource = ObjCurso.FiltroAbreviacao(txtBuscaAbreviacao.Texts);
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
                FrmDetalheCurso frm = new FrmDetalheCurso();
                frm.lblNome.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                frm.lblAbreviacao.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                frm.ShowDialog();
            }
            else CMMessageBox.Show("Antes deves Selecionar uma linha na tabela");
        }
    }
}
