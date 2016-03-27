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
    public partial class WoodView : Form
    {
        private Wood wood;
        List<UOM> uomlist;
        public WoodView()
        {
            InitializeComponent();
            init();
        }

        public WoodView(Wood wood)
        {
            InitializeComponent();
            this.wood = wood;
            init();
        }

        public async void init()
        {
            uomlist = await UOM.getUOMs();
            wdUOMCmboBx.DataSource = uomlist;
            wdUOMCmboBx.DisplayMember = "uom_cd";
            wdUOMCmboBx.ValueMember = "uom_cd";

            if (wood == null)
            {
                dscLbl.Text = "Add New Wood";
                wood = new Wood();
            }
            else
            {
                dscLbl.Text = "Edit Existing Wood";
                wdTypeTxtBx.Text = wood.wood_type;
                wdLngthTxtBx.Text = wood.wood_length.ToString();
                wdWidthTxtBx.Text = wood.wood_width.ToString();
                wdHghtTxtBx.Text = wood.wood_height.ToString();
                wdUOMCmboBx.SelectedValue = wood.wood_uom;
                wdPrceTxtBx.Text = wood.wood_price.ToString();
            }
        }

        private async void cnfrmBtn_Click(object sender, EventArgs e)
        {
            if (form_check())
            {
                wood.wood_type = wdTypeTxtBx.Text;
                wood.wood_length = float.Parse(wdLngthTxtBx.Text);
                wood.wood_width = float.Parse(wdWidthTxtBx.Text);
                wood.wood_height = float.Parse(wdHghtTxtBx.Text);
                wood.wood_uom = wdUOMCmboBx.SelectedValue.ToString();
                wood.wood_price = float.Parse(wdPrceTxtBx.Text);
                Boolean result;
                if (wood.wood_id == 0)
                    result = await Wood.addWoods<Wood>(wood);
                else
                    result = await Wood.editWoods(wood);
            }
        }

        private void cnclBtn_Click(object sender, EventArgs e)
        {

        }

        private Boolean form_check()
        {
            if (String.IsNullOrWhiteSpace(wdTypeTxtBx.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(wdLngthTxtBx.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(wdWidthTxtBx.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(wdHghtTxtBx.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(wdPrceTxtBx.Text))
            {
                return false;
            }
            return true;
        }
    }
}
