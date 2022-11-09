using ConsoleApplication;

internal class Program
{
    private static void Main(string[] args)
    {
        GeographyObject styr = new River("styr", new Point(1, 2), "gread view", 1002, 140);

        GeographyObject karpaty = new Mountain("karpaty", new Point(3,4), "the highest ", 2040);

        styr.ShowInfoAboutObject();

        karpaty.ShowInfoAboutObject();
    }
}