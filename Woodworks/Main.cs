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
        List<Customer> customers;
        List<Wood> woods;

        public Main()
        {
            InitializeComponent();
            init();
        }

        public async void init()
        {
            customers = await Customer.getCustomers();
            //woods = await Wood.getWoods(0);
            TransactionManagement trans = new TransactionManagement(customers);
            TabPage transaction = new TabPage("Order");
            transaction.Controls.Add(trans);
            mainTabCntrl.TabPages.Add(transaction);
            InventoryManagement inven = new InventoryManagement();
            TabPage inventory = new TabPage("Inventory");
            inventory.Controls.Add(inven);
            mainTabCntrl.TabPages.Add(inventory);
            CustomerManagement custom = new CustomerManagement(customers);
            TabPage cust = new TabPage("Customers");
            cust.Controls.Add(custom);
            mainTabCntrl.TabPages.Add(cust);
        }
        
        private void FormsClosed(object sender, FormClosedEventArgs e)
        {
            //this.Enabled = true;
        }
       

    }
}
