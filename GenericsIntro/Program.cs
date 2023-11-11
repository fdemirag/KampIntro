using GenericsIntro;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<string> isimler = new MyList<string>();
        isimler.Add("Engin");

        List<string> liste = new List<string>();
        Console.WriteLine(liste.Count);

    }
}