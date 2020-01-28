using System;
using static System.Console;
using Wisej.Web;

namespace HelloWorld
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Window1 window = new Window1();
			window.Show();
			Desktop1 desktop = new Desktop1();
			desktop.Show();
			Beep();
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}