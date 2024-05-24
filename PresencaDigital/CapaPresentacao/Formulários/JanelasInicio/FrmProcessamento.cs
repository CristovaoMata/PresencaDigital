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
    public partial class FrmProcessamento : Form
    {

        public FrmProcessamento()
        {
            InitializeComponent();
        }
        private void FrmProcessamento_Load(object sender, EventArgs e)
        {
            cmProgressBar1.Value = 0;
            timer1.Start();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //FrmProcessamento_Load(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cmProgressBar1.Value == 100)
            {
                timer1.Stop();
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
            else
                cmProgressBar1.Value += 1;
        }

        private void FrmProcessamento_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);

        }

       
    }
}
