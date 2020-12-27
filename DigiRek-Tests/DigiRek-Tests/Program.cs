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
            Messages.Instance.PrintWelcome();
            while (true)
            {
                var askedToQuit = false;
                Messages.Instance.PrintChoices();
                var input=InputHandlers.Instance.ReadInput();
                InputHandlers.Instance.HandleInput(input,out askedToQuit);
                if (askedToQuit)
                    break;
            }
        }
    }
    
}  
