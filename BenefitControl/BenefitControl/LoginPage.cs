using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenefitControl
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

            this.AcceptButton = loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入密码", "密码无效", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FrontPage frontPage;
            if (password.Equals("12345"))
            {
                frontPage = new FrontPage(false);
            }
            else if (password.Equals("569823"))
            {
                frontPage = new FrontPage(true);
            }
            else
            {
                MessageBox.Show("密码错误，请重新输入密码", "密码错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frontPage.Show();
            frontPage.Location = this.Location;
            frontPage.Owner = this;
            this.Hide();
        }
    }
}
