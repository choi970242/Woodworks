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
        List<Wood> woods;

        public InventoryManagement()
        {
            InitializeComponent();
        }

        public async void init()
        {
            woods = await Wood.getWoods(null);
            woodDGV.DataSource = woods;
        }

        private void addWoodBtn_Click(object sender, EventArgs e)
        {
            WoodView view = new WoodView();
            showView(view);
        }

        private void editWoodBtn_Click(object sender, EventArgs e)
        {
            Wood wood = woods.ElementAt<Wood>(woodDGV.CurrentCell.RowIndex);
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
