namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var abstractYorkie = new AbstractYorkie();
            abstractYorkie.Bark("Abstract Bark");

            var yorkie = new Yorkie();
            yorkie.Bark("Bark");

            var abstractGreatDane = new AbstractGreatDane();
            abstractGreatDane.Bark("BARK!!!");
        }
    }
}
