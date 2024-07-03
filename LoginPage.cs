using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANAWA
{
    public partial class LoginPage : Form
    {
        static public string ID = "";
        static public string Password = "";
        static public string name = "신동민";
        static public string PhoneNumber = "01046696388";
        Danawa d1;

        public LoginPage(Danawa danawa)
        {
            InitializeComponent();
            d1 = danawa;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Danawa danawa = new Danawa();

            if (IDInput.Text == ID && PasswordInput.Text == Password)
            {
                d1.Login.Text = name+" 님께서 접속하셨습니다.";
                MessageBox.Show("로그인 되었습니다.");
                Close();
            }
            else
                MessageBox.Show("회원정보가 일치하지 않습니다.");

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }
    }
}
