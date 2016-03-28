using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Woodworks.Models;
using System.Diagnostics;

namespace Woodworks
{
    public partial class InventoryManagement : UserControl
    {
        List<Wood> woodlist;

        public InventoryManagement()
        {
            InitializeComponent();
        }

        public async void init()
        {
            woodlist = await Wood.getWoods();
            woodDGV.DataSource = woodlist;
        }

        private void addWoodBtn_Click(object sender, EventArgs e)
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

        public void showView(Form view)
        {
            view.FormClosed += new FormClosedEventHandler(FormsClosed);
            //this.Enabled = false;
            view.ShowDialog();
        }

        private void FormsClosed(object sender, FormClosedEventArgs e)
        {
            //this.Enabled = true;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            init();
            this.Dock = DockStyle.Fill;
        }

        private void dltWoodBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
