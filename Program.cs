namespace forum_12_12_2022_input_output_file
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
            public class Example_Remove_Du // метод удаления дубликатов НЕ ИСПОЛЬЗУЕТСЯ
        {
            public static List<T> removeDuplicates<T>(List<T> list)
            {
                return new HashSet<T>(list).ToList();
            }
        }
    
    
    }
}