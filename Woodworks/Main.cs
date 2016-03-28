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

namespace Woodworks
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Test2();
        }

        public void Test2()
        {
            InventoryManagement inven = new InventoryManagement();
            TabPage inventory = new TabPage("Inventory");
            inventory.Controls.Add(inven);
            mainTabCntrl.TabPages.Add(inventory);
        }
        
        private void FormsClosed(object sender, FormClosedEventArgs e)
        {
            //this.Enabled = true;
        }
        private void newWoodBtn_Click(object sender, EventArgs e)
        {
            WoodView view = new WoodView();
            showView(view);
            
        }

        private void editWoodBtn_Click(object sender, EventArgs e)
        {
            Wood wood = new Wood();
            wood.wood_id = 17;
            wood.wood_type = "SUPERWOOD";
            wood.wood_length = 51121;
            wood.wood_width = 21651;
            wood.wood_height = 1;
            wood.wood_uom = "M";
            wood.wood_price = 40;
            wood.wood_qty = 0;
           
            WoodView view = new WoodView(wood);
            showView(view);
        }

        public void showView(Form view){
            view.FormClosed += new FormClosedEventHandler(FormsClosed);
            //this.Enabled = false;
            view.ShowDialog();
        }

        private void uomBtn_Click(object sender, EventArgs e)
        {
            UomView view = new UomView();
            showView(view);
        }

    }
}
