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
using Equin.ApplicationFramework;

namespace Woodworks
{
    public partial class TransactionManagement : UserControl
    {
        List<Customer> customers;
        List<Wood> woods;
        //List of all the order of woods
        Customer selectedCustomer;
        Wood selectedWood;
        List<Wood> orders;
        BindingListView<Wood> orderlist;

        public TransactionManagement()
        {
            InitializeComponent();
        }

        private void SetViewCustomer (Customer customer){
            //TODO: set all customer values to the corresponding customer
            cstmrAddrssTxtBx.Text = customer.company_address;
            cntctPrsnTxtBx.Text = customer.contact_person;
            cntctNmbrTxtBx.Text = customer.contact_number;
        }

        private void SetViewWood(Wood wood)
        {
            woodTypeTxtBx.Text = wood.wood_type;
            woodLengthTxtBx.Text = wood.wood_length.ToString();
            woodWidthTxtBx.Text = wood.wood_width.ToString();
            woodThcknssTxtBx.Text = wood.wood_thickness.ToString();
            qtyTxtBx.Text = "0";
        }
        public TransactionManagement(List<Customer> customers)
        {
            InitializeComponent();
            orders = new List<Wood>();
            orderlist = new BindingListView<Wood>(orders);
            ordersDGV.DataSource = orderlist;
            this.customers = customers;
            //this.woods = woods;
            customerCmboBx.DataSource = customers;
            customerCmboBx.DisplayMember = "company_name";
            //customerCmboBx.SelectedIndex = -1;
            var customerAutocomplete = new AutoCompleteStringCollection();
            customerAutocomplete.AddRange(customers.Select(customer => customer.company_name).ToArray());
            customerCmboBx.AutoCompleteCustomSource = customerAutocomplete;
            //searchWoodCmboBx.SelectedIndex = -1;
            this.Dock = DockStyle.Fill;
            ClearCustomer();
        }

        private void SetWoodCmboBx()
        {
            searchWoodCmboBx.DataSource = woods;
            searchWoodCmboBx.DisplayMember = "full_name";
            var woodAutocomplete = new AutoCompleteStringCollection();
            woodAutocomplete.AddRange(woods.Select(wood => wood.full_name).ToArray());
            searchWoodCmboBx.AutoCompleteCustomSource = woodAutocomplete;
        }

        private async void SetWoodList(Customer customer){
            woods = await Wood.getWoods(customer);
            SetWoodCmboBx();
            ClearWood();
            ClearOrders();
        }

        private void customerCmboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerCmboBx.SelectedIndex != -1)
            {
                selectedCustomer = ((Customer)customerCmboBx.SelectedItem);
                SetViewCustomer(selectedCustomer);
                SetWoodList(selectedCustomer);
            }
        }

        private void addWoodBtn_Click(object sender, EventArgs e)
        {
            if (selectedWood != null)
            {
                if (qtyTxtBx.Text != "" && qtyTxtBx.Text != "0" && qtyTxtBx.Text != null)
                {
                    selectedWood.wood_qty = Int32.Parse(qtyTxtBx.Text);
                    addWoodtoList(selectedWood);
                }
                else
                {
                    MessageBox.Show("Quantity is not set or set to 0. Please input another value.", "Quantity not set.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No wood is selected. Please select a wood.", "No wood is selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void remWoodBtn_Click(object sender, EventArgs e)
        {
            removeWoodtoList(selectedWood);
        }

        private void searchWoodCmboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchWoodCmboBx.SelectedIndex != -1)
            {
                selectedWood = ((Wood)searchWoodCmboBx.SelectedValue);
                SetViewWood(selectedWood);
            }
        }

        private void addWoodtoList(Wood wood)
        {
            if (!orders.Contains(wood))
            {
                orders.Add(wood);
            }
                orderlist.Refresh();
                ordersDGV.ClearSelection();
                ClearWood();
                setTotal();
        }

        private void removeWoodtoList(Wood wood)
        {
            if (orders.Contains(wood))
            {
                orders.Remove(wood);
            }
            orderlist.Refresh();
            ordersDGV.ClearSelection();
            ClearWood();
            setTotal();
        }

        private void ordersDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersDGV.CurrentCell != null)
            {
                selectedWood = orders.ElementAt(ordersDGV.CurrentCell.RowIndex);
                SetViewWood(selectedWood);
            }
        }

        private void ClearWood()
        {
            selectedWood = null;
            searchWoodCmboBx.SelectedIndex = -1;
            woodTypeTxtBx.Text = "";
            woodLengthTxtBx.Text = "";
            woodWidthTxtBx.Text = "";
            woodThcknssTxtBx.Text = "";
            qtyTxtBx.Text = "0";
        }

        private void ClearCustomer()
        {
            selectedCustomer = null;
            customerCmboBx.SelectedIndex = -1;
            cstmrAddrssTxtBx.Text = "";
            cntctPrsnTxtBx.Text = "";
            cntctNmbrTxtBx.Text = "";
        }

        private void setTotal()
        {
            double TotalPrice = 0;
            foreach (Wood onewood in orders)
            {

                TotalPrice = TotalPrice + onewood.total_price;

            }
            totalTxtBx.Text = TotalPrice.ToString();
        }

        private async void addTransactionBtn_Click(object sender, EventArgs e)
        {
            if (checkForm())
            {
                Transaction transaction = new Transaction();
                transaction.customer_id = selectedCustomer.customer_id;
                transaction.orders = orders;
                transaction.transaction_total = Double.Parse(totalTxtBx.Text);

                bool result = await Transaction.addTransactions<Transaction>(transaction);
                if (result)
                {
                    MessageBox.Show("Order was completed successfully!.", "Order Successful.", MessageBoxButtons.OK, MessageBoxIcon.None);
                    clearAll();
                }
            }
        }

        private bool checkForm()
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("There is no customer for this transaction! Please select a customer.", "No Customer Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (orders.Count == 0)
            {
                MessageBox.Show("There are no items in the list! Please select some items.", "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else{
                return true;
            }
        }

        private void ClearOrders()
        {
            orders.Clear();
            setTotal();
            orderlist.Refresh();
        }

        private void clearAll()
        {
            ClearCustomer();
            ClearWood();
            ClearOrders();
        }
    }
}
