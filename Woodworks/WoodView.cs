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

        public void init()
        {

            if (wood == null)
            {
                this.Text = "Add New Wood";
                cnfrmBtn.Text = "Add";
                wood = new Wood();
            }
            else
            {
                this.Text = "Edit Existing Wood";
                cnfrmBtn.Text = "Edit";
                wdTypeTxtBx.Text = wood.wood_type;
                wdThcknssTxtBx.Text = wood.wood_thickness.ToString();
                wdWidthTxtBx.Text = wood.wood_width.ToString();
                wdLngthTxtBx.Text = wood.wood_length.ToString();
                wdPrceTxtBx.Text = wood.wood_price.ToString();
            }
        }

        private async void cnfrmBtn_Click(object sender, EventArgs e)
        {
            if (form_check())
            {
                wood.wood_type = wdTypeTxtBx.Text;
                wood.wood_thickness = float.Parse(wdThcknssTxtBx.Text);
                wood.wood_width = float.Parse(wdWidthTxtBx.Text);
                wood.wood_length = float.Parse(wdLngthTxtBx.Text);
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
            if (String.IsNullOrWhiteSpace(wdThcknssTxtBx.Text))
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
