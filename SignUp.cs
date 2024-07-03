using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANAWA
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)//탭1에서 전화번호로 가입 버튼 눌러서 탭2로 가기
        {
            this.tabControl1.SelectedIndex++;
        }

        private void pictureBox4_Click(object sender, EventArgs e)//탭2에서 확인버튼 누르기
        {
            if (Nameinput.Text != "" && RegNumFore.Text != "" && RegNumBack.Text != "" && PhoneNumInput.Text != "")
            {
                LoginPage.PhoneNumber = PhoneNumInput.Text;
                LoginPage.name = Nameinput.Text;
                this.tabControl1.SelectedIndex++;
            }
            else
                MessageBox.Show("정보를 모두 기입해주세요.");

        }

        private void pictureBox5_Click(object sender, EventArgs e)//탭2에서 취소버튼누르기
        {
            Close();
        }

        private void CheckAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PasswordMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordCheck_TextChanged(object sender, EventArgs e)
        {

        }
        static int Cnt = 0;
        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Cnt += 1;
            }
            else
            {
                Cnt -= 1;
            }
            if (Cnt == 3)
            {
                checkBoxAll.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Cnt += 1;
            }
            else
            {
                Cnt -= 1;
            }
            if (Cnt == 3)
            {
                checkBoxAll.Checked = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Cnt += 1;
            }
            else
            {
                Cnt -= 1;
            }
            if (Cnt == 3)
            {
                checkBoxAll.Checked = true;
            }
        }

        private void SingUpComplete_Click(object sender, EventArgs e)
        {

            if (IDMake.Text != "" && PasswordMake.Text != "" && PasswordCheck.Text != "" && checkBox1.Checked == true && Cnt == 3)
            {
                if (PasswordMake.Text != PasswordCheck.Text)
                    MessageBox.Show("비밀번호가 일치하지 않습니다.");
                else
                {
                    LoginPage.ID = IDMake.Text;
                    LoginPage.Password = PasswordMake.Text;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("회원가입을 위해 모든 정보 기입과 약관 전체에 동의 해주세요.");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
