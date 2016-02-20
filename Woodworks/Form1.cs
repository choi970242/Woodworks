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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Console.WriteLine(Wood.getWoods());
            test();
        }

        public void test()
        {
            Wood.addWoods();
        }


    }
}
