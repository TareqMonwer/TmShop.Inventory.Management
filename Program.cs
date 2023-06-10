using TmShop.Inventory.Management.Domain.General;
using TmShop.Inventory.Management.Domain.ProductManagement;

namespace TmShop.Inventory.Management
{
    internal class Program
    {

        static void Main(string[] args)
        {
            PrintWelcome();

            Utilities.InitializeStock();

            Utilities.ShowMainMenu();

            Console.WriteLine("Application shutting down...");

            Console.ReadLine();

        }

        static void PrintWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
            #   /$$$$$$$$             /$$$$$$  /$$                          
            #  |__  $$__/            /$$__  $$| $$                          
            #     | $$ /$$$$$$/$$$$ | $$  \__/| $$$$$$$   /$$$$$$   /$$$$$$ 
            #     | $$| $$_  $$_  $$|  $$$$$$ | $$__  $$ /$$__  $$ /$$__  $$
            #     | $$| $$ \ $$ \ $$ \____  $$| $$  \ $$| $$  \ $$| $$  \ $$
            #     | $$| $$ | $$ | $$ /$$  \ $$| $$  | $$| $$  | $$| $$  | $$
            #     | $$| $$ | $$ | $$|  $$$$$$/| $$  | $$|  $$$$$$/| $$$$$$$/
            #     |__/|__/ |__/ |__/ \______/ |__/  |__/ \______/ | $$____/ 
            #                                                     | $$      
            #                                                     | $$      
            #                                                     |__/      
            ");
            Console.ResetColor();
            Console.WriteLine("Press enter key to start logging in!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}