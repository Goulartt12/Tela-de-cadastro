
using System.Text.RegularExpressions;

namespace sla
{
    public class Classes
    {
        public string Emailinput { get; set; }
        public string Passwordinput { get; set; }

        public void Cadastro()
        {
            var emailregex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            var emailinput = Emailinput;
            if (emailinput == "")
            {
                MessageBox.Show("Digite seu email");
            }
            else if (!emailregex.IsMatch(emailinput))
            {
                MessageBox.Show("Digite um email válido");
            }

            Regex senharegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            var senhainput = Passwordinput;
            if (senhainput == "")
            {
                MessageBox.Show("Digite sua senha");
            }
            else if (!senharegex.IsMatch(senhainput))
            {
                MessageBox.Show("A senha precisa ter pelo menos 8 caracteres, uma letra maiúscula, um número e um símbolo");
            }

            if (emailregex.IsMatch(emailinput) && senharegex.IsMatch(senhainput))
            {
                MessageBox.Show("Cadastro efetuado!");

            }
        }
    }
}
