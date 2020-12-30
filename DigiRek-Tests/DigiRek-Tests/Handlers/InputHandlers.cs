using System;
using System.Collections.Generic;

namespace DigiRek_Tests.Handlers
{
    public sealed class InputHandlers
    {
        private InputHandlers()
        {
        }
        private string userInput = string.Empty;
        public static InputHandlers Instance { get; }
            = new InputHandlers();
        private static CalculationsHandlers calcs
            = CalculationsHandlers.Instance;
        private static Dictionary<string, Action> userChoicesAndResponsesDic =
            new Dictionary<string, Action>
            {
                {"SUM",new Action(calcs.HandleSum)},
                {"AVERAGE",new Action(calcs.HandleAverage)},
                {"TOP",new Action(calcs.HandleTopThree)},
                {"MAP",new Action(calcs.HandleMapping)},
                {"QUIT",new Action(Instance.HandleQuit)},
            };
        public string ReadInput()
        {
            return Console.ReadLine()
                .ToUpper()
                .Trim();
        }
        public void HandleInput(string input,out bool askedToQuit)
        {
            var inputAsArray = input.Split(' ');
            var loopShouldEnd = false;
            askedToQuit = false;
            foreach (var inputElement in inputAsArray)
            {
                foreach (var handler in userChoicesAndResponsesDic)
                {
                    var inputContainsKey =
                        handler.Key == inputElement;
                    if (inputContainsKey)
                    {
                        InvokeHandler(handler,out loopShouldEnd,out askedToQuit);
                        break;
                    }
                }
                if (loopShouldEnd)
                    break;
            }
            if(!loopShouldEnd)
                HandleWrongInput();
        }
        public void InvokeHandler
            (KeyValuePair<string, Action> handler
            ,out bool loopShouldEnd
            ,out bool askedToQuit)
        {
            askedToQuit = false;
            handler.Value.Invoke();
            loopShouldEnd = true;
            if (handler.Key == "QUIT")
                askedToQuit = true;
        }
        public void HandleWrongInput()
        {
            Console.WriteLine("Wrong input. Please try again.");
        }
        public void HandleQuit()
        {
            Console.WriteLine("Thank's for using this application!");
        }
    }
}
