using CapySystem;
using System;
using System.Text;
using System.IO;

namespace CapySystem
{
    public static class CapyConsole
    {

        public static class CapyConsoleProperties
        {
            
        }
        public static class CapyConsoleMethods
        {
            public static void Beep(int frequency, int duration)
            {
                if (OperatingSystem.IsWindows())
                {
                    Console.Beep(frequency, duration);
                }
                else
                {
                    Console.Write("\a");
                }
            }

            public static void Erase()
            {
                Console.Clear();
            }

            public static (int Left, int Top) GetMousePosition()
            {
                return Console.GetCursorPosition();
            }
            //Get Cursor Position is not going to be coded for now


            //OpenStandardError, OpenStandardInput, and OpenStandardOutput are not going to be coded for now

            public static int ReadIt()
            {
                return Console.Read();
            }

            public static ConsoleKeyInfo ReadTheKey()
            {
                return Console.ReadKey();
            }

            public static void Talk(string message)
            {
                Console.WriteLine(message);
            }

            public static void Speak(string message)
            {
                Console.Write(message);
            }

            public static string Answer()
            {
                return Console.ReadLine() ?? string.Empty;
            }

            public static string Say()
            {
                return Console.ReadKey().KeyChar.ToString();
            }

            public static void ColorReset()
            {
                Console.ResetColor();
            }

            public static void CapyBufferSize(int width, int height)
            {
                Console.SetBufferSize(width, height);
            }

            public static void SetCapyPosition(int left, int top)
            {
                Console.SetCursorPosition(left, top);
            }

            public static void SetCapyError(System.IO.TextWriter newError)
            {
                Console.SetError(newError);
            }

            public static void CapyIn(System.IO.TextReader newIn)
            {
                Console.SetIn(newIn);
            }

            public static void CapyOut(System.IO.TextWriter newOut)
            {
                Console.SetOut(newOut);
            }

            public static void SetCapyWposition(int left, int top)
            {
                Console.SetWindowPosition(left, top);
            }

            public static void SetCapyWSize(int width, int height)
            {
                Console.SetWindowSize(width, height);
            }
        }
    }
}

namespace CapyFileSystem
{
    public static class CapyFileConsole
    {
        private static bool hasPaper = false;
        private static readonly string CapyFolder = Path.Combine(Directory.GetCurrentDirectory(), "CapyFiles");

        static CapyFileConsole()
        {
            if (!Directory.Exists(CapyFolder))
                Directory.CreateDirectory(CapyFolder);
        }

        public static void Write(string filename, string content)
        {
            if (!hasPaper)
            {
                CapyConsole.Talk("Your capy needs a piece of paper to write on!");
                return;
            }

            string fullPath = Path.Combine(CapyFolder, filename);
            File.WriteAllText(fullPath, content);
            CapyConsole.Talk($"Your capy wrote on paper and saved it at {fullPath}!");
        }

        public static string Read(string filename)
        {
            string fullPath = Path.Combine(CapyFolder, filename);

            if (!File.Exists(fullPath))
            {
                CapyConsole.Talk("The file does not exist! Your capy is sad, maybe he should write one?");
                return string.Empty;
            }

            return File.ReadAllText(fullPath);
        }

        public static void GetPaper()
        {
            hasPaper = true;
            CapyConsole.Talk("Your capy got a piece of paper!");
        }
    }
}

namespace CapyTextSystem
{
    public static class CapyTextConsole
    {
        public static string CapyStringB_or_C(string starter)
        {
            StringBuilder stringBuilder = new(starter);
            stringBuilder.Append("🦫");
            return stringBuilder.ToString();
        }
    }
}




