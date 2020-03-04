
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CollegeParkAutoParts2
{
    public partial class Central : Form
    {
        PartDescription[] parts = new PartDescription[100];

        public Central()
        {
            InitializeComponent();
        }

        private void Central_Load(object sender, EventArgs e)
        {
            TreeNode nodRoot = tvwAutoParts.Nodes.Add("College Park Auto-Parts",
                                              "College Park Auto-Parts", 0, 1);

            // This is simply used to initialize the whole array with empty parts
            // This is just to make sure that each member of the array is defined
            for (int n = 0; n < 100; n++)
                parts[n] = new PartDescription(0, 1960, "", "", "", "", 0.00M);

            parts[0] = new PartDescription(447093, 2002, "Ford",
                "Escort SE L4 2.0", "Engine Electrical",
                "Alternator 75amp  Remanufactured; w/ 75 Amp",
                205.05M);
            parts[1] = new PartDescription(203815, 2006, "Dodge",
                "Caravan SE L4 2.4", "Cooling System",
                "Radiator Cap", 6.65M);
            parts[2] = new PartDescription(293047, 2000, "Toyota",
                "RAV4 2WD/4-DOOR", "Cooling System",
                "Thermostat Gasket", 4.95M);
            parts[3] = new PartDescription(990468, 2002, "Honda",
                "Civic 1.7 EX 4DR", "Exhaust",
                "Bolt & Spring Kit (Manifold outlet, Muffler Inlet)",
                85.75M);
            parts[4] = new PartDescription(304158, 1996, "Buick",
                "Regal Custom V6 3.8", "Fuel Injection",
                "Fuel Injector", 82.75M);
            parts[5] = new PartDescription(807245, 2004, "Acura",
                "MDX 3.5 4WD", "Driveshaft & Axle",
                "CV Boot Clamp 7 x 750mm; 1 Large + 1 Small Clamp",
                1.60M);
            parts[6] = new PartDescription(203485, 2001, "Ford",
                "Taurus LX V6 3.0", "Fuel Injection",
                "Oxygen Sensor OE Style 4Wire; Front; 2 Required",
                52.65M);
            parts[7] = new PartDescription(248759, 1999, "Jeep",
                "Wrangler Sahara", "Air Intake",
                "Air Filter AirSoft Panel", 7.95M);
            parts[8] = new PartDescription(202848, 1998, "Honda",
                "Accord 2.3 LX 4DR", "Air Intake",
                "Air Filter", 12.55M);
            parts[10] = new PartDescription(932759, 2006, "Kia",
                "Rio 1.6DOHC16V 4-DR", "Cooling System",
                "Thermostat", 14.45M);
            parts[11] = new PartDescription(304975, 2000, "Honda",
                "Civic 1.6 EX 4DR", "Suspension",
                "Ball Joint; Front Lower; 2 per car", 40.55M);
            parts[12] = new PartDescription(208450, 2003, "Chevrolet",
                "Monte Carlo LS V6 3.4", "Fuel Injection",
                "Oxygen Sensor OE connector; Rear", 65.55M);
            parts[13] = new PartDescription(209480, 2002, "Ford",
                "Focus SE DOHC L4 2.0", "Steering",
                "Steering Rack Remanufactured", 170.85M);
            parts[9] = new PartDescription(203495, 2004, "Honda",
                "Civic 1.7 EX 4DR", "Climate Control",
                "A/C Clutch; OE compressor = Sanden", 184.95M);
            parts[14] = new PartDescription(203480, 2007, "Toyota",
                "Corolla", "Air Intake",
                "Air Filter", 12.65M);
            parts[15] = new PartDescription(109379, 2005, "Volvo",
                "S40 2.5L T5 AWD", "Fuel Delivery",
                "Fuel Filter; Early Design; Outer Diameter = 55mm",
                30.95M);
            parts[16] = new PartDescription(935794, 2002, "Ford",
                "Escape XLS 4WD", "Brake",
                "Brake Caliper Remanufactured; Front Right",
                65.55M);
            parts[17] = new PartDescription(203485, 2006, "BMW",
                "325i", "Climate Control",
                "AC High Pressure Side Switch",
                49.95M);
            parts[18] = new PartDescription(204875, 1996, "Chevrolet",
                "Monte Carlo Z34 V6 3.4", "Fuel Delivery",
                "Fuel Filter", 8.05M);
            parts[19] = new PartDescription(937485, 2007, "Toyota",
                "Camry V6", "Air Intake", "Air Filter", 12.95M);
            parts[20] = new PartDescription(294759, 2001, "Ford",
                "Escape XLT 4WD", "Air Intake",
                "Air Filter Panel", 7.25M);
            parts[21] = new PartDescription(297495, 2003, "Honda",
                "Civic 1.7 EX 4DR", "Brake",
                "Brake Caliper Reman; w/ ProAct Pads; Front Right",
                82.55M);
            parts[22] = new PartDescription(794735, 2006, "BMW",
                "325i", "Climate Control",
                "Cabin Air/Pollen Filter; With Activated Carbon",
                28.05M);
            parts[23] = new PartDescription(937485, 2007, "Toyota",
                "Corolla", "Body Electrical",
                "Halogen  SilverStar; 12V 65W; inner-high beam",
                22.85M);
            parts[24] = new PartDescription(492745, 2005, "Ford",
                "Focus ZX3 L4 2.0", "Air Intake",
                "Fuel Injection Perf Kit", 342.95M);
            parts[25] = new PartDescription(937005, 2004, "Acura",
                "MDX 3.5 4WD", "Driveshaft & Axle",
                "CV Boot Clamp 7 x 750mm; For Large End of Boot; inner boot",
                1.60M);
            parts[26] = new PartDescription(293749, 2004, "Acura",
                "MDX 3.5 4WD", "Driveshaft & Axle",
                "Axle Nut 24mm x 1;5; rear ",
                2.35M);
            parts[27] = new PartDescription(920495, 2006, "BMW",
                "325i", "Climate Control",
                "Adjustable Telescoping Mirror", 7.95M);
            parts[28] = new PartDescription(204075, 2004, "Acura",
                "MDX 3.5 4WD", "Driveshaft & Axle",
                "Wheel Bearing; Rear; 1 per wheel",
                70.15M);
            parts[29] = new PartDescription(979304, 2000, "Toyota",
                "RAV4 2WD/4-DOOR", "Cooling System",
                "Thermostat Housing", 20.95M);
            parts[30] = new PartDescription(300456, 2004, "Acura",
                "MDX 3.5 4WD", "Driveshaft & Axle",
                "Wheel Bearing; Front; 1 per wheel",
                66.65M);
            parts[31] = new PartDescription(404860, 2001, "Ford",
                "Taurus LX V6 3.0", "Suspension",
                "Shock Absorber GR2; Rear; Wagon only",
                39.40M);
            parts[32] = new PartDescription(585688, 2007, "Buick",
                "Lacrosse CXS V6 3.6", "Brake",
                "Climate Control", 10.65M);
            parts[33] = new PartDescription(739759, 2001, "Ford",
                "Taurus LX V6 3.0", "Suspension",
                "Shock Absorber GasaJust; Rear; Wagon only",
                30.95M);
            parts[34] = new PartDescription(927495, 2005, "Volvo",
                "S40 2.5L T5 AWD", "Engine Mechanical",
                "Timing Belt Idler Pulley Original Equipment INA",
                65.55M);
            parts[40] = new PartDescription(979374, 2000, "Toyota",
                "RAV4 2WD/4-DOOR", "Cooling System",
                "Thermostat Gasket", 4.95M);
            parts[35] = new PartDescription(542347, 2007, "Buick",
                "Lacrosse CXS V6 3.6", "Brake",
                "Brake Pad Set ProACT Ceramic w/Shims; Front", 80.05M);
            parts[36] = new PartDescription(683064, 2000, "Toyota",
                "RAV4 2WD/4-DOOR", "Cooling System",
                "Radiator Hose; Upper", 103.75M);
            parts[37] = new PartDescription(248759, 1999, "Jeep",
                "Wrangler Sahara", "Air Intake",
                "Air Filter", 50.95M);
            parts[38] = new PartDescription(973974, 2007, "Toyota",
                "Corolla", "Air Intake",
                "Air Mass Meter; W/o Housing; Meter/sensor only",
                134.95M);
            parts[39] = new PartDescription(285800, 2001, "Ford",
                "Escape XLT 4WD", "Transmission",
                "AT Filter", 34.95M);
            parts[41] = new PartDescription(207495, 2007, "Toyota",
                "Corolla", "Body Electrical",
                "Headlight Bulb; 12V 65W; inner-high beam", 9.35M);
            parts[42] = new PartDescription(566676, 2000, "Toyota",
                "RAV4 2WD/4-DOOR", "Cooling System",
                "Auxiliary Fan Switch", 42.95M);
            parts[43] = new PartDescription(304950, 2007, "Toyota",
                "Corolla", "Body Electrical",
                "Headlight Bulb; 12V 51W; outer", 7.85M);
            parts[44] = new PartDescription(797394, 2000, "Toyota",
                "RAV4 2WD/4-DOOR", "Cooling System",
                "Water Flange Gasket", 0.85M);
            parts[45] = new PartDescription(910203, 2007, "Buick",
                "Lacrosse CXS V6 3.6", "Suspension",
                "Strut Mount Inc; Sleeve; Rear Right", 80.85M);
            parts[46] = new PartDescription(790794, 2000, "Toyota",
                "RAV4 2WD/4-DOOR", "Cooling System",
                "Radiator Hose; Lower", 9.45M);
            parts[47] = new PartDescription(970394, 2007, "Buick",
                "Lacrosse CXS V6 3.6", "Suspension",
                "Coil Spring Insulator; Front Lower",
                14.55M);
            parts[48] = new PartDescription(290840, 2005, "Volvo",
                "S40 2.5L T5 AWD", "Engine Mechanical",
                "Rod Bearing Set 1 per Rod; Standard; Reqs. 5-per Engine",
                26.95M);
            parts[49] = new PartDescription(209704, 2007, "Toyota",
                "Corolla", "Body Electrical",
                "Wiper Blade Excel+; Front Right", 7.25M);
            parts[50] = new PartDescription(200368, 2000, "Toyota",
                "RAV4 2WD/4-DOOR", "Cooling System",
                "Radiator Drain Plug incl; gasket", 3.15M);
            parts[51] = new PartDescription(200970, 2005, "Volvo",
                "S40 2.5L T5 AWD", "Engine Mechanical",
                "Reference Sensor; Flywheel Engine Speed",
                62.05M);
            parts[52] = new PartDescription(542347, 2007, "Buick",
                "Lacrosse CXS V6 3.6", "Air Intake",
                "Air Filter", 50.25M);
            parts[53] = new PartDescription(927045, 2001, "Ford",
                "Escape XLT 4WD", "Air Intake",
                "Air Filter", 62.95M);
            parts[54] = new PartDescription(990659, 2000, "Toyota",
                "RAV4 2WD/4-DOOR", "Cooling System",
                "Radiator OE Plastic tank", 136.85M);
            parts[55] = new PartDescription(440574, 2007, "Buick",
                "Lacrosse CXS V6 3.6", "Suspension",
                "Strut Mount Inc; Sleeve; Rear Left",
                80.80M);

            // Showing the years nodes
            for (int years = DateTime.Today.Year + 1; years > 1960; years--)
                nodRoot.Nodes.Add(years.ToString(), years.ToString(), 2, 3);

            // Expand the root node
            tvwAutoParts.ExpandAll();

            // Showing the makes nodes
            foreach (TreeNode nodYear in nodRoot.Nodes)
            {
                ArrayList lstMakes = new ArrayList();

                foreach (PartDescription part in parts)
                {
                    if (nodYear.Text == part.CarYear.ToString())
                    {
                        if (!lstMakes.Contains(part.Make))
                            lstMakes.Add(part.Make);
                    }
                }

                foreach (string strMake in lstMakes)
                    nodYear.Nodes.Add(strMake, strMake, 4, 5);
            }

            // Showing the models nodes
            foreach (TreeNode nodYear in nodRoot.Nodes)
            {
                foreach (TreeNode nodMake in nodYear.Nodes)
                {
                    ArrayList lstModels = new ArrayList();

                    foreach (PartDescription part in parts)
                    {

                        if ((nodYear.Text == part.CarYear.ToString()) &&
                            (nodMake.Text == part.Make))
                        {
                            if (!lstModels.Contains(part.Model))
                                lstModels.Add(part.Model);

                        }
                    }

                    foreach (string strModel in lstModels)
                        nodMake.Nodes.Add(strModel, strModel, 6, 7);
                }
            }

            // Showing the categories nodes
            foreach (TreeNode nodYear in nodRoot.Nodes)
            {
                foreach (TreeNode nodMake in nodYear.Nodes)
                {
                    foreach (TreeNode nodModel in nodMake.Nodes)
                    {
                        ArrayList lstCategories = new ArrayList();

                        foreach (PartDescription part in parts)
                        {

                            if ((nodYear.Text == part.CarYear.ToString()) &&
                                (nodMake.Text == part.Make) &&
                                (nodModel.Text == part.Model))
                            {
                                if (!lstCategories.Contains(part.Category))
                                    lstCategories.Add(part.Category);
                            }
                        }

                        foreach (string strCategory in lstCategories)
                            nodModel.Nodes.Add(strCategory, strCategory, 8, 9);
                    }
                }
            }

            tvwAutoParts.SelectedNode = nodRoot;
        }


        private void tvwAutoParts_NodeMouseClick(object sender,
                    TreeNodeMouseClickEventArgs e)
        {
            TreeNode nodClicked = e.Node;

            if (nodClicked.Level == 4)
                lvwAutoParts.Items.Clear();

            try
            {
                try
                {
                    foreach (PartDescription part in parts)
                    {
                        if ((part.Category == nodClicked.Text) &&
                            (part.Model == nodClicked.Parent.Text) &&
                            (part.Make == nodClicked.Parent.Parent.Text) &&
                            (part.CarYear.ToString() ==
                    nodClicked.Parent.Parent.Parent.Text))
                        {
                            ListViewItem lviAutoPart =
                    new ListViewItem(part.PartNumber.ToString());

                            lviAutoPart.SubItems.Add(part.PartName);
                            lviAutoPart.SubItems.Add(part.UnitPrice.ToString());
                            lvwAutoParts.Items.Add(lviAutoPart);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
            }
            catch (NullReferenceException)
            {
            }
        }

        internal void CalculateOrder()
        {
            // Calculate the current total order and update the order
            decimal subTotal1 = 0.00M, subTotal2 = 0.00M, subTotal3 = 0.00M,
                        subTotal4 = 0.00M, subTotal5 = 0.00M, subTotal6 = 0.00M;
            decimal orderTotal = 0.00M;

            // Retrieve the value of each sub total
            try
            {
                subTotal1 = decimal.Parse(this.txtSubTotal1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            try
            {
                subTotal2 = decimal.Parse(this.txtSubTotal2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            try
            {
                subTotal3 = decimal.Parse(this.txtSubTotal3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            try
            {
                subTotal4 = decimal.Parse(this.txtSubTotal4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            try
            {
                subTotal5 = decimal.Parse(this.txtSubTotal5.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            try
            {
                subTotal6 = decimal.Parse(this.txtSubTotal6.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            // Calculate the total value of the sub totals
            orderTotal = subTotal1 + subTotal2 + subTotal3 +
                         subTotal4 + subTotal5 + subTotal6;

            // Display the total order in the appropriate text box
            this.txtTotalOrder.Text = orderTotal.ToString();
        }

        private void txtQuantity1_Leave(object sender, EventArgs e)
        {
            int qty = 0;
            decimal unitPrice = 0.00M, subTotal = 0.00M;

            // Get the quantity of the current item
            try
            {
                qty = int.Parse(this.txtQuantity1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            // Get the unit price of the current item
            try
            {
                unitPrice = decimal.Parse(this.txtUnitPrice1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            // Calculate the current sub total
            subTotal = qty * unitPrice;

            // Display the new sub total in the corresponding text box
            this.txtSubTotal1.Text = subTotal.ToString();
            // Update the order
            CalculateOrder();
        }

        private void txtQuantity2_Leave(object sender, EventArgs e)
        {
            int qty = 0;
            decimal unitPrice = 0.00M, subTotal = 0.00M;

            try
            {
                qty = int.Parse(this.txtQuantity2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            try
            {
                unitPrice = decimal.Parse(this.txtUnitPrice2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            subTotal = qty * unitPrice;
            this.txtSubTotal2.Text = subTotal.ToString();

            CalculateOrder();
        }

        private void txtQuantity3_Leave(object sender, EventArgs e)
        {
            int qty = 0;
            decimal unitPrice = 0.00M, subTotal = 0.00M;

            try
            {
                qty = int.Parse(this.txtQuantity3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            try
            {
                unitPrice = decimal.Parse(this.txtUnitPrice3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            subTotal = qty * unitPrice;
            this.txtSubTotal3.Text = subTotal.ToString();

            CalculateOrder();
        }
        private void txtQuantity4_Leave(object sender, EventArgs e)
        {
            int qty = 0;
            decimal unitPrice = 0.00M, subTotal = 0.00M;

            try
            {
                qty = int.Parse(this.txtQuantity4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            try
            {
                unitPrice = decimal.Parse(this.txtUnitPrice4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            subTotal = qty * unitPrice;
            this.txtSubTotal4.Text = subTotal.ToString();

            CalculateOrder();
        }

        private void txtQuantity5_Leave(object sender, EventArgs e)
        {
            int qty = 0;
            decimal unitPrice = 0.00M, subTotal = 0.00M;

            try
            {
                qty = int.Parse(this.txtQuantity5.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            try
            {
                unitPrice = decimal.Parse(this.txtUnitPrice5.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            subTotal = qty * unitPrice;
            this.txtSubTotal5.Text = subTotal.ToString();

            CalculateOrder();
        }

        private void txtQuantity6_Leave(object sender, EventArgs e)
        {
            int qty = 0;
            decimal unitPrice = 0.00M, subTotal = 0.00M;

            try
            {
                qty = int.Parse(this.txtQuantity6.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            try
            {
                unitPrice = decimal.Parse(this.txtUnitPrice6.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Value");
            }

            subTotal = qty * unitPrice;
            this.txtSubTotal6.Text = subTotal.ToString();

            CalculateOrder();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            txtPartNumber1.Text = "";
            txtPartName1.Text = "";
            txtUnitPrice1.Text = "0.00";
            txtQuantity1.Text = "0";
            txtSubTotal1.Text = "0.00";

            CalculateOrder();
        }
        private void btnRemove2_Click(object sender, EventArgs e)
        {
            txtPartNumber2.Text = "";
            txtPartName2.Text = "";
            txtUnitPrice2.Text = "0.00";
            txtQuantity2.Text = "0";
            txtSubTotal2.Text = "0.00";

            CalculateOrder();
        }

        private void btnRemove3_Click(object sender, EventArgs e)
        {
            txtPartNumber3.Text = "";
            txtPartName3.Text = "";
            txtUnitPrice3.Text = "0.00";
            txtQuantity3.Text = "0";
            txtSubTotal3.Text = "0.00";

            CalculateOrder();
        }

        private void btnRemove4_Click(object sender, EventArgs e)
        {
            txtPartNumber4.Text = "";
            txtPartName4.Text = "";
            txtUnitPrice4.Text = "0.00";
            txtQuantity4.Text = "0";
            txtSubTotal4.Text = "0.00";

            CalculateOrder();
        }


        private void btnRemove5_Click(object sender, EventArgs e)
        {
            txtPartNumber5.Text = "";
            txtPartName5.Text = "";
            txtUnitPrice5.Text = "0.00";
            txtQuantity5.Text = "0";
            txtSubTotal5.Text = "0.00";

            CalculateOrder();
        }

        private void btnRemove6_Click(object sender, EventArgs e)
        {
            txtPartNumber6.Text = "";
            txtPartName6.Text = "";
            txtUnitPrice6.Text = "0.00";
            txtQuantity6.Text = "0";
            txtSubTotal6.Text = "0.00";

            CalculateOrder();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvwAutoParts_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lviAutoPart = lvwAutoParts.SelectedItems[0];

            if (lvwAutoParts.SelectedItems.Count == 0 ||
                        lvwAutoParts.SelectedItems.Count > 1)
                return;

            if (txtPartNumber1.Text == "")
            {
                txtPartNumber1.Text = lviAutoPart.Text;
                txtPartName1.Text = lviAutoPart.SubItems[1].Text;
                txtUnitPrice1.Text = lviAutoPart.SubItems[2].Text;

                txtQuantity1.Text = "1";
                txtSubTotal1.Text = lviAutoPart.SubItems[2].Text;

                txtQuantity1.Focus();
            }// If the previous Part # text box is not empty, then use the next one
            else if (txtPartNumber2.Text == "")
            {
                txtPartNumber2.Text = lviAutoPart.Text;
                txtPartName2.Text = lviAutoPart.SubItems[1].Text;
                txtUnitPrice2.Text = lviAutoPart.SubItems[2].Text;

                txtQuantity2.Text = "1";
                txtSubTotal2.Text = txtUnitPrice2.Text;
                txtQuantity2.Focus();
            }
            else if (txtPartNumber3.Text == "")
            {
                txtPartNumber3.Text = lviAutoPart.Text;
                txtPartName3.Text = lviAutoPart.SubItems[1].Text;
                txtUnitPrice3.Text = lviAutoPart.SubItems[2].Text;

                txtQuantity3.Text = "1";
                txtSubTotal3.Text = txtUnitPrice3.Text;
                txtQuantity3.Focus();
            }
            else if (txtPartNumber4.Text == "")
            {
                txtPartNumber4.Text = lviAutoPart.Text;
                txtPartName4.Text = lviAutoPart.SubItems[1].Text;
                txtUnitPrice4.Text = lviAutoPart.SubItems[2].Text;

                txtQuantity4.Text = "1";
                txtSubTotal4.Text = txtUnitPrice4.Text;
                txtQuantity4.Focus();
            }
            else if (txtPartNumber5.Text == "")
            {
                txtPartNumber5.Text = lviAutoPart.Text;
                txtPartName5.Text = lviAutoPart.SubItems[1].Text;
                txtUnitPrice5.Text = lviAutoPart.SubItems[2].Text;

                txtQuantity5.Text = "1";
                txtSubTotal5.Text = txtUnitPrice5.Text;
                txtQuantity5.Focus();
            }
            else if (txtPartNumber6.Text == "")
            {
                txtPartNumber6.Text = lviAutoPart.Text;
                txtPartName6.Text = lviAutoPart.SubItems[1].Text;
                txtUnitPrice6.Text = lviAutoPart.SubItems[2].Text;

                txtQuantity6.Text = "1";
                txtSubTotal6.Text = txtUnitPrice6.Text;
                txtQuantity6.Focus();
            } // If all Part # text boxes are filled, don't do anything
            else
                return;

            CalculateOrder();
        }
    }
}