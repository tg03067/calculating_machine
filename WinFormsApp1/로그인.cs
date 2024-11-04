using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class 로그인 : Form
    {
        public 로그인()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            String userId = id.Text;
            String userPassword = password.Text;

            if (userId.Equals("MyId") && userPassword.Equals("MyPassword"))
            {
                MessageBox.Show("로그인에 성공했습니다.", "로그인");
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "로그인");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
