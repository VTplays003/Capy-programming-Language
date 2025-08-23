using CapySystem;

namespace CapySystem 
{

    public static class CapyConsole 
    {
        public static void Talk(string message)
        {
            Console.WriteLine(message);
        }
        public static void Answer()
        {
            Console.ReadLine();
        }
    }
    public static class CapyFileConsole
    {
        private static bool hasPaper = false;
        private static readonly string CapyFolder = Path.Combine(Directory.GetCurrentDirectory(), "CapyFiles");

        static CapyFileConsole()
        {
            // Ensure folder exists when the class is first used
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

