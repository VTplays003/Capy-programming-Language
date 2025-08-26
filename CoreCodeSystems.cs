using CapySystem;
using System;
using System.Text;
#pragma warning disable CA1416
namespace CapySystem
{
    public static class CapyConsole
    {
        public static void Beep(int frequency, int duration)
        {
            Console.Beep(frequency, duration);
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
            return Console.ReadLine()!;
        }
        public static string Say()
        {
            return Console.ReadKey().KeyChar.ToString();
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
        public static void CapyStringB_or_C(string starter)
        {
            StringBuilder stringBuilder = new(starter);
            StringBuilder loaf = stringBuilder;
            loaf.Append("🦫");
        }
    }
}


