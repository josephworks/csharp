using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltairRealtors2
{
    public partial class AltairRealtor : Form
    {
        public AltairRealtor()
        {
            InitializeComponent();
        }

        private void btnNewProperty_Click(object sender, EventArgs e)
        {
            AvailableProperty dlgProperty = new AvailableProperty();

            Random rndNumber = new Random(DateTime.Now.Millisecond);
            int number1 = rndNumber.Next(100, 999);
            int number2 = rndNumber.Next(100, 999);
            string propNumber = number1 + "-" + number2;

            dlgProperty.txtPropertyNumber.Text = propNumber;
            dlgProperty.Text = "Altair Realtors - New Property";

            if (dlgProperty.ShowDialog() == DialogResult.OK)
            {
                string strPropertyType = dlgProperty.cbxPropertyTypes.Text;
                string strAddress = dlgProperty.txtAddress.Text;
                string strCity = dlgProperty.txtCity.Text;
                string strState = dlgProperty.cbxStates.Text;
                string strZIPCde = dlgProperty.txtZIPCode.Text;
                string strBedrooms = dlgProperty.txtBedrooms.Text;
                string strBathrooms = dlgProperty.txtBathrooms.Text;
                string strMarketValue = dlgProperty.txtMarketValue.Text;

                ListViewItem lviProperty =
                new ListViewItem(dlgProperty.txtPropertyNumber.Text);

                if (strPropertyType == "Single Family")
                {
                    lviProperty.BackColor = Color.Navy;
                    lviProperty.ForeColor = Color.LightBlue;
                }
                else if (strPropertyType == "Townhouse")
                {
                    lviProperty.BackColor = Color.Brown;
                    lviProperty.ForeColor = Color.White;
                }
                else
                {
                    lviProperty.BackColor = Color.DarkGreen;
                    lviProperty.ForeColor = Color.Lime;
                }

                lviProperty.SubItems.Add(strPropertyType);
                lviProperty.SubItems.Add(strAddress);
                lviProperty.SubItems.Add(strCity);
                lviProperty.SubItems.Add(strState);
                lviProperty.SubItems.Add(strZIPCde);
                lviProperty.SubItems.Add(strBedrooms);
                lviProperty.SubItems.Add(strBathrooms);
                lviProperty.SubItems.Add(strMarketValue);
                lvwProperties.Items.Add(lviProperty);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvwProperties_DoubleClick(object sender, EventArgs e)
        {
            // Prepare to open the AvailableProperties dialog box
            AvailableProperty dlgProperty = new AvailableProperty();

            // Make sure an item, and only one, is selected
            if ((lvwProperties.SelectedItems.Count == 0) ||
                    (lvwProperties.SelectedItems.Count > 1))
                return;

            // Identify the item that is currently selected
            ListViewItem lviCurrent = lvwProperties.SelectedItems[0];

            // Display the ItemDetails dialog box with the item number
            dlgProperty.txtPropertyNumber.Text = lviCurrent.Text;
            dlgProperty.ShowDialog();
        }
    }
}
