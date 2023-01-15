internal class Program
{
    public class BookShelf 
    {
        public int Shelf { get; set; }

        public virtual string ToString() 
        {
            return $"Shelf : {Shelf}\n";
        }

    }

    public class Books : BookShelf 
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Name : {Name}\nCategory : {Category}\n";
        }
    }

    public class Media : BookShelf
    {
        public string Type { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Name : {Name}\nType : {Type}\n";
        }
    }

    public class Devices : BookShelf
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Name : {Name}\nType : {Type}\nSize : {Size} Gb\n";
        }
    }

    private static void Main(string[] args)
    {
        Books book1 = new Books() {Shelf = 1, Name = "Book1", Category = "Technical Handbook"};
        Books book2 = new Books() { Shelf = 1, Name = "Book2", Category = "Sci-Fi" };

        Media magazine = new Media() { Shelf = 2, Name = "Uykusuz", Type = "Weekly Comic Maganize" };
        Media magazine2 = new Media() { Shelf = 2, Name = "Insinööri Liitto", Type = "Monthly" };

        Devices massStorage = new Devices() { Shelf = 3, Name = "Maxtor", Size = 500, Type = "Storage Device" };
        Devices camera = new Devices() { Shelf = 3, Name = "Cannon", Size = 5, Type = "Professinal Camera" };

        Console.WriteLine(book1.ToString());
        Console.WriteLine(book2.ToString());
        Console.WriteLine(magazine.ToString());
        Console.WriteLine(magazine2.ToString());
        Console.WriteLine(massStorage.ToString());
        Console.WriteLine(camera.ToString());
    }
}