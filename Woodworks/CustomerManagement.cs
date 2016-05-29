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

namespace Woodworks
{
    public partial class CustomerManagement : UserControl
    {
        List<Customer> customers;
        List<Transaction> selectedCustomersTransaction;

        Customer selectedCustomer;
        Transaction selectedTransaction;

        public CustomerManagement()
        {
            InitializeComponent();
            init();
        }

        public CustomerManagement(List<Customer> customers)
        {
            InitializeComponent();
            this.customers = customers;
            init();
        }
        private void init()
        {
            //customers = await Customer.getCustomers();
            customerDGV.DataSource = customers;
            //transactionsDGV.DataSource = selectedCustomersTransaction;
            this.Dock = DockStyle.Fill;
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            CustomerView view = new CustomerView();
            showView(view);
        }

        private void editCustBtn_Click(object sender, EventArgs e)
        {
            selectedCustomer = customers.ElementAt<Customer>(customerDGV.CurrentCell.RowIndex);
            CustomerView view = new CustomerView(selectedCustomer);
            showView(view);
        }

        private void delCustButton_Click(object sender, EventArgs e)
        {

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

        private void transactionsDGV_SelectionChanged(object sender, EventArgs e)
        {

        }

        private async void customerDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (customerDGV.CurrentCell != null)
            {
                selectedCustomer = customers.ElementAt<Customer>(customerDGV.CurrentCell.RowIndex);
                Transaction transaction = new Transaction();
                transaction.customer_id = selectedCustomer.customer_id;
                selectedCustomersTransaction = await Transaction.getTransactions(transaction);
                transactionsDGV.DataSource = selectedCustomersTransaction;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpecialPriceView view = new SpecialPriceView(selectedCustomer);
            showView(view);
        }

    }
}
