using System;

namespace NKHook6_Impl
{
    public class Logger
    {
        /*internal static GameObject ingameMsgPopup;
        internal static AssetBundle assetBundle;*/

        public enum Level
        {
            Normal,
            Warning,
            Error,
            UpdateNotify
        }

        public static void Log(string text) => Log(text, Level.Normal, "");

        public static void Log(string text, string sender) => Log(text, Level.Normal, sender);

        public static void Log(string text, Level level, string sender = "") =>
            Log(text, (int)ConsoleColor.Red, level, sender);

        public static void Log(string text, int color, Level level, string sender = "")
        {
            string modName;
            if (String.IsNullOrEmpty(sender))
                modName = "NKHook6";//(Toolkit.GetCallingModInfo() == null ? "NKHook6" : Toolkit.GetCallingModInfo().Name);
            else
                modName = sender;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            String time = DateTime.Now.ToString("HH:mm:ss.fff");
            Console.Write(time);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("] ");
            Console.ResetColor();
            Console.Write("[");
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(modName);
            Console.ResetColor();
            Console.Write("] ");
            Console.ForegroundColor = GetLoggerColor(level);  //Change color of message to match logger level
            Console.WriteLine(text);
            Console.ResetColor();
        }

        private static ConsoleColor GetLoggerColor(Level level)
        {
            switch ((int)level)
            {
                case 1: //warning
                    return ConsoleColor.Yellow;
                case 2:  //error
                    return ConsoleColor.Red;
                case 3:
                    return ConsoleColor.Green;
                default:  //normal
                    return ConsoleColor.Gray;
            }
        }
    }
}