using DigiRek_Tests.Displayers;
using DigiRek_Tests.Handlers;

namespace DigiRek_Tests.Controllers
{
    public class MainController
    {
        public static void MainProgram()
        {
            while (true)
            {
                var askedToQuit = false;
                Messages.PrintChoices();
                var input = InputHandlers.Instance.ReadInput();
                InputHandlers.Instance.HandleInput(input, out askedToQuit);
                if (askedToQuit)
                    break;
            }
        }
    }
}