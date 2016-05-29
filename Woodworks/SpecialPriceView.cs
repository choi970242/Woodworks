using Equin.ApplicationFramework;
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
    public partial class SpecialPriceView : Form
    {
        BindingListView<Wood> woodsview;
        List<Wood> woods;
        BindingListView<Wood> pricesview;
        List<Wood> prices;
        Customer customer;
        Wood selectedWood;

        public SpecialPriceView(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            init();
        }

        private async void init()
        {
            prices = await Wood.getSpecialPrices(customer);
            woods = await Wood.getWoods(null);
            cmpnyNameTxtBx.Text = customer.company_name;
            cmpnyAddrssTxtBx.Text = customer.company_address;
            cntctPrsnTxtBx.Text = customer.contact_person;
            cntctNmbrTxtBx.Text = customer.contact_number;
            woodsview = new BindingListView<Wood>(woods);
            pricesview = new BindingListView<Wood>(prices);
            productLstDGV.DataSource = woodsview;
            specialPriceDGV.DataSource = pricesview;
        }

        private void cnfrmBtn_Click(object sender, EventArgs e)
        {
            if (!prices.Contains(selectedWood))
            {
                selectedWood.wood_price = float.Parse(woodPrceTxtBx.Text);
                prices.Add(selectedWood);
                pricesview.Refresh();
            }
            ClearDGVs();
        }

        private void ClearDGVs()
        {
            productLstDGV.ClearSelection();
            specialPriceDGV.ClearSelection();
        }

        private void SetWoodInfo(Wood wood)
        {
            woodTypeTxtBx.Text = wood.wood_type;
            woodThcknessTxtBx.Text = wood.wood_thickness.ToString();
            woodWidthTxtBx.Text = wood.wood_width.ToString();
            woodLengthTxtBx.Text = wood.wood_length.ToString();
            woodPrceTxtBx.Text = wood.wood_price.ToString();
        }

        private void selectedDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).CurrentCell != null)
            {
                string sendername = ((DataGridView)sender).Name;
                if (sendername.Equals(productLstDGV.Name))
                {
                    selectedWood = woods.ElementAt<Wood>(((DataGridView)sender).CurrentCell.RowIndex);
                    SetWoodInfo(selectedWood);
                }
                else
                {
                    selectedWood = prices.ElementAt<Wood>(((DataGridView)sender).CurrentCell.RowIndex);
                    SetWoodInfo(selectedWood);
                }
            }
        }

        private void txtBx_TextChanged(object sender, EventArgs e)
        {
            string sendername = ((TextBox)sender).Name;
            if (sendername.Equals(productLstSearchTxtBx.Name))
            {
                woodsview.ApplyFilter(
                    delegate(Wood wood)
                    {
                        return wood.wood_type.ToLower().Contains(((TextBox)sender).Text.ToLower());
                    }
                    );
            }
            else
            {
                pricesview.ApplyFilter(
                    delegate(Wood wood)
                    {
                        return wood.wood_type.ToLower().Contains(((TextBox)sender).Text.ToLower());
                    }
                    );
            }
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            if (prices.Contains(selectedWood))
            {
                prices.Remove(selectedWood);
                pricesview.Refresh();
            }
            ClearDGVs();
        }
    }
}
