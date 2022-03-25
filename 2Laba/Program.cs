namespace _2Laba
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(@"D:\“ËÃœ\2Laba\2Laba\TextFile1.txt"));
        }
    }
}