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
    public partial class CustomerView : Form
    {
        private Customer customer;

        public CustomerView()
        {
            InitializeComponent();
            init();
        }

        public CustomerView(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            init();
        }

        private void init()
        {
            if (customer == null)
            {
                this.Text = "Add New Customer";
                cnfrmBtn.Text = "Add";
                customer = new Customer();
            }
            else
            {
                this.Text = "Edit Existing Customer";
                cnfrmBtn.Text = "Edit";

                cmpnyNmTextBx.Text = customer.company_name;
                cmpnyAddrsTextBx.Text = customer.company_address;
                cntctPrsnTxtBx.Text = customer.contact_person;
                cntctNmbrTxtBx.Text = customer.contact_number;
            }

        }
        private async void cnfrmBtn_Click(object sender, EventArgs e)
        {
            if (form_check())
            {
                customer.company_name = cmpnyNmTextBx.Text;
                customer.company_address = cmpnyAddrsTextBx.Text;
                customer.contact_person = cntctPrsnTxtBx.Text;
                customer.contact_number = cntctNmbrTxtBx.Text;
                Boolean result;
                if (customer.customer_id == 0)
                    result = await Customer.addCustomers<Customer>(customer);
                else
                    result = await Customer.editCustomers(customer);

            }

        }

        private void cnclBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean form_check()
        {
            if (String.IsNullOrWhiteSpace(cmpnyNmTextBx.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(cntctPrsnTxtBx.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(cntctNmbrTxtBx.Text))
            {
                return false;
            }
            return true;
        }
    }
}
