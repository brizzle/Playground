namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var writer = new FileLogger();

            writer.LogMessage("Hello World!!");
        }
    }
}
