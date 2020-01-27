
using System;
using System.Drawing;
using Wisej.Web;
using System.Linq;

namespace HelloWorld
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void Window1_Load(object sender, EventArgs e)
		{
			// load the enumeration in the combobox.
			this.comboBox1.Items.AddRange(Enum.GetNames(typeof(ContentAlignment)));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// parse the selected alignment and default to TopCenter
			// if the selection in the combo is not a valid ContentAlignment.
			ContentAlignment alignment = ContentAlignment.TopCenter;
			if (!Enum.TryParse(this.comboBox1.Text, out alignment))
				alignment = ContentAlignment.TopCenter;

			// hello world!
			AlertBox.Show("Hello World!", alignment: alignment);
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.ApplicationExit)
				return;

			var result = MessageBox.Show(
				@"Are you sure you want to close this window?
				<br/><br/>
				This is the only window, closing it will close the app!",
				"Application Question",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == Wisej.Web.DialogResult.No)
				e.Cancel = true;
			else
				Application.Exit();

			base.OnFormClosing(e);
		}
	}
}
