using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace TicTacToe.Utils
{
    public static class ConsoleUtils
    {
        public static void Message(string message, ConsoleColor color = ConsoleColor.White, bool clearConsoleBefore = false)
        {
            if (clearConsoleBefore)
                Console.Clear();

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static string Ask(string message, ConsoleColor color = ConsoleColor.DarkYellow, bool clearConsoleBefore = false, int cursorLeft = 0, int cursorTop = 0)
        {
            if (clearConsoleBefore)
                Console.Clear();

            Message(message, color);
            if (cursorLeft != 0 || cursorTop != 0)

                Console.SetCursorPosition(cursorLeft, cursorTop);

            Console.Write("> ");
            return Console.ReadLine();
        }

        public static void Pause(string message = "Pressione qualquer tecla para continuar...", bool clearConsoleBefore = true)
        {
            if (clearConsoleBefore)
                Console.Clear();

            Message(message, ConsoleColor.DarkGray);
            Console.ReadKey(true);
        }

        public static void KillTerminal(int threadInterval = 900)
        {
            Console.Clear();
            Message("Stopping the application...", ConsoleColor.DarkRed);
            Thread.Sleep(threadInterval);
            Console.Clear();
            Environment.Exit(0);
        }
    }
}