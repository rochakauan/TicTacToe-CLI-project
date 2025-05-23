using System;
using TicTacToe.Utils;

namespace TicTacToe.Events
{
    public static class OnPlayerJoinEvent
    {
        public static void StartMenu()
        {
            ConsoleUtils.Message("TicTacToe > Welcome to the game!", ConsoleColor.Green, true);
            ConsoleUtils.Message("Choose the option you want to do", ConsoleColor.Yellow);
            ConsoleUtils.Message("-------------");

            ConsoleUtils.Message("1 - Start a new game", ConsoleColor.DarkYellow);
            ConsoleUtils.Message("2 - Settings", ConsoleColor.DarkYellow);
            ConsoleUtils.Message("0 - Quit", ConsoleColor.DarkYellow);

            ConsoleUtils.Message("-------------");

            HandleMenuOption(ConsoleUtils.Ask("Type your reply", ConsoleColor.Gray));
        }

        private static void HandleMenuOption(string option)
        {
            switch (option)
            {
                case "1": Console.Clear(); break; //TODO
                case "2": Console.Clear(); break; //TODO
                case "0": ConsoleUtils.KillTerminal(1000); break; //TODO
                default: StartMenu(); break;
            }
        }
    }
}