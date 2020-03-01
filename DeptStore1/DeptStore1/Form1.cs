using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeptStore1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLargeIcons_CheckedChanged(object sender, EventArgs e)
        {
            lvwStoreItems.View = View.LargeIcon;
        }

        private void btnSmallIcons_CheckedChanged(object sender, EventArgs e)
        {
            lvwStoreItems.View = View.SmallIcon;
        }

        private void btnList_CheckedChanged(object sender, EventArgs e)
        {
            lvwStoreItems.View = View.List;
        }

        private void btnDetails_CheckedChanged(object sender, EventArgs e)
        {
            lvwStoreItems.View = View.Details;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
