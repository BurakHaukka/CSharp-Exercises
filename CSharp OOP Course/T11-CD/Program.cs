public class CD 
{ 
    public string Artist { get; set;  }
    public string Title { get; set; }
    public string Genre { get; set; }
    public double Price { get; set; }

    public Tuple<string, string, string, string, string, string> Songs = new Tuple <string, string, string, string, string, string>
                                                                ("Song 1", "Song 2", "Song 3", "Song 4", "Song 5", "Song 6");

    public virtual string ToString()
    {

        return $"Artist: {Artist} \nTitle: {Title} \nGenre: {Genre}\nPrice: {Price} euros \n==========\n\nSongs: \n\n{Songs.Item1}" +
            $"\n{Songs.Item2}\n{Songs.Item3}\n{Songs.Item4}\n{Songs.Item5}\n{Songs.Item6}";
    }

    

}



internal class Program
{
    private static void Main(string[] args)
    {
        CD cd1 = new CD() { Artist = "Solar Fields", Title = "Random Friday", Genre = "Electronic", Price = 9.99 };
        //cd1.Songs.Item1 = "heheh"; 
        Console.WriteLine(cd1.ToString());
    }
}