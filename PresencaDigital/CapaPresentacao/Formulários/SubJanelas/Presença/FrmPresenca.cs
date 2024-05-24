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

namespace CapaPresentacao.Formulários.SubJanelas.Presença
{
    public partial class FrmPresenca : Form
    {
        ModeloPresenca ObjPresenca = new ModeloPresenca();
        int Referenca;
        public FrmPresenca()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            ValoresEntidade.IdT = 0;
            this.Close();
        }

        private void FrmPresenca_Load(object sender, EventArgs e)
        {           
            VerificaData();
            AdicionarColunas();
            CarregarDados();
        }

        private void CarregarDados()
        {
            using (var objPresenca = new ModeloPresenca())
            {
                objPresenca.BuscarTodos();
                foreach (var item in  objPresenca.FiltroTurma(ValoresEntidade.IdT, Referenca))
                {
                    //Adicionar uma linha a DataGridView
                    int linhaIndice = dgv.Rows.Add();

                    //Preecher as celulas
                    dgv.Rows[linhaIndice].Cells["id"].Value = item.Id;
                    dgv.Rows[linhaIndice].Cells["nome"].Value = item.Nome;
                }
            }
        }

        private void VerificaData()
        {
            //Vai levar um mecanismo que irá de buscar a data(dia,mês, ano) a ctual...
            //...
            using (var ObjDia = new ModeloDia())
            {
                ObjDia.BuscarTodos();
                Referenca = ObjDia.FiltroIdData(Convert.ToDateTime("2024-03-02"));
            }
        }

        private void AdicionarColunas()
        {
            //Criar Colunas CheckBox
            DataGridViewCheckBoxColumn clnPresenca = new DataGridViewCheckBoxColumn();
            //configurar coluna  checkBox         
            clnPresenca.Name = "presenca";
            clnPresenca.HeaderText = "Presença";
            //Adicionar as colunas na DataGridView
            dgv.Columns.Add("id", "ID");
            dgv.Columns.Add("nome", "Nome");
            dgv.Columns.Add(clnPresenca);
            //configurar colunas somente de leitura
            dgv.ReadOnly = false;
            dgv.Columns["id"].ReadOnly = true;
            dgv.Columns["nome"].ReadOnly = true;
            //Configurar o tamanho das colunas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //define a porcentagem do tamanho das colunas
            dgv.Columns["id"].FillWeight = 15;// 15% para a primeira coluna
            dgv.Columns["nome"].FillWeight = 70;// 70% para a segunda coluna
            dgv.Columns["presenca"].FillWeight = 15;// 15% para a terceira coluna
            
        }
    }
}
