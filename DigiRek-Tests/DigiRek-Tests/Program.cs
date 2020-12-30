using DigiRek_Tests.Controllers;
using DigiRek_Tests.Displayers;
using DigiRek_Tests.Handlers;
using System;

namespace DigiRek_Tests
{
    class Program
    {
        static void Main(string[] args)
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
