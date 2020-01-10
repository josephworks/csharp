using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            helpProvider1.SetShowHelp(textBox1, true);
            helpProvider1.SetHelpString(textBox1, "This is a help string.");
        }

        private void accountsTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ebooksDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ebooksDBDataSet.accountsTbl' table. You can move, or remove it, as needed.
            this.accountsTblTableAdapter.Fill(this.ebooksDBDataSet.accountsTbl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter a username.");
            input.Trim();
            var accounts =
                from acc in ebooksDBDataSet.accountsTbl
                where acc.username.StartsWith(input)
                select acc;
            accountsTblDataGridView.DataSource = accounts.AsDataView<ebooksDBDataSet.accountsTblRow>();
        }
    }
}
