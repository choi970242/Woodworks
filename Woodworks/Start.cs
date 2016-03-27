using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Woodworks.Models;
using Woodworks.Network;

namespace Woodworks
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usrTextbx.Text;
            String password = pswdTextbx.Text;
            Boolean test =  await User.login(username, password);
            if (test)
            {
                Console.WriteLine(Config.user.user_key);
                Main main = new Main();
                main.FormClosed += new FormClosedEventHandler(FormsClosed);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failure", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Console.WriteLine(Config.user.user_key);
        }

        private void FormsClosed(object sender, FormClosedEventArgs e)
        {
            usrTextbx.Text = "";
            pswdTextbx.Text = "";
            this.Show();
        }

    }
}
