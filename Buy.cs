using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANAWA
{

    public partial class Buy : Form
    {

        public Buy()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //잘못입력됨
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            BuyName.Text = LoginPage.name;
            BuyPhoneNumaber.Text = LoginPage.PhoneNumber;
            BuyTotalPrice.Text = Danawa.TransPrice;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (BuyAddress.Text != "" && BuyWant.Text != "")
            {
                tabControl1.SelectedIndex = 1;
            }

            else
                MessageBox.Show("정보를 모두 기입해주세요.");
        }

        private void BuyComplete_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            CompletePrice.Text = Danawa.TransPrice;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
