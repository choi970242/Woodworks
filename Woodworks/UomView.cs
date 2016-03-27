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
    public partial class UomView : Form
    {
        List<UOM> uomlist;
        public UomView()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            refresh();
        }

        public async void refresh()
        {
            uomlist = await UOM.getUOMs();
            uomLstBx.DataSource = uomlist;
            uomLstBx.DisplayMember = "uom_desc";
        }

        private void setTextbx()
        {
            uomCdTxtBx.Text = ((UOM)uomLstBx.SelectedItem).uom_cd;
            uomDscTxtBx.Text = ((UOM)uomLstBx.SelectedItem).uom_desc;
        }
        private async void cnfrmBtn_Click(object sender, EventArgs e)
        {
            UOM editUOM = (UOM)uomLstBx.SelectedItem;
            editUOM.uom_cd = uomCdTxtBx.Text;
            editUOM.uom_desc = uomDscTxtBx.Text;
            Boolean result = await UOM.editUOMs(editUOM);
            if (result)
            {
                refresh();
            }
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            UOM newUOM = new UOM();
            newUOM.uom_cd = uomCdTxtBx1.Text;
            newUOM.uom_desc = uomDscTxtBx1.Text;

            Boolean result = await UOM.addUOMs(newUOM);
            if (result)
            {
                refresh();
            }
        }

        private void uomLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            setTextbx();
        }

        private async void dltBtn_Click(object sender, EventArgs e)
        {
            UOM deleteUOM = (UOM)uomLstBx.SelectedItem;
            Boolean result = await UOM.deleteUOMs(deleteUOM);
            if (result)
            {
                refresh();
            }
        }
    }
}
