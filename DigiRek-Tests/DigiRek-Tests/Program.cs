using DigiRek_Tests.Controllers;
using DigiRek_Tests.Displayers;

namespace DigiRek_Tests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            Messages.PrintWelcome();
            MainController.MainProgram();
        }
    }
}