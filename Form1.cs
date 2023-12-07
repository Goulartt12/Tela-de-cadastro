using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace CadastroGUI
{
    public partial class Form1 : Form
    {
        Classes c = new Classes();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            c.Emailinput = txtemail.Text;
            c.Passwordinput = txtsenha.Text;
            c.Cadastro();
            txtemail.Clear();
            txtsenha.Clear();
        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSenha.Checked)
            {
                txtsenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtsenha.UseSystemPasswordChar = true;
            }
        }
    }
}
