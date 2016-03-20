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
            //Console.WriteLine(Wood.getWoods());
            //test();
        }

        public void test()
        {
            Wood.getWoods();
            //User.login;
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usrTextbx.Text;
            String password = pswdTextbx.Text;
            Boolean test =  await User.login(username, password);
            if (test)
            {
                Console.WriteLine(Config.user.user_key);
                this.test();
                MessageBox.Show("Success","Hello",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Failure", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Console.WriteLine(Config.user.user_key);
        }


    }
}
