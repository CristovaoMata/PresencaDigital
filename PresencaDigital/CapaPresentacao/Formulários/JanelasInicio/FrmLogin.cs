using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacao.Formulários.JanelasInicio
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            label1.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbVerSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = tbVerSenha.Checked == false ? true : false;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Texts == "Cristovao" && txtSenha.Texts == "0604")
            {
                FrmBoaVinda frm = new FrmBoaVinda();
                frm.Show();
                this.Close();
            }
            else
            {
                pbErro.Visible = true;
                lblErro.Visible = true;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            pbErro.Visible = false;
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }
    }
}
