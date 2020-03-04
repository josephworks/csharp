using Wisej.Web;

namespace MultiHtml.Customers
{
    internal static class CustomersStartup
    {
        private static void Main()
        {
            Application.MainPage = new CustomerPage();
        }
    }
}