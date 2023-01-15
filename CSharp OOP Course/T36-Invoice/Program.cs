namespace T36
{
 
    public class Items 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get { return Price * Quantity; } }

        public Items(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;

        }
        public override string ToString()
        {
            return $"- {Name} Price: {Price} euros | {Quantity} pcs | Total: {Total} euros";
        }
    }
    
    public class Invoice
    {
        public List<Items> Items = new List<Items>();

        public string Customer { get; set; }           
        public int EachItemCount { get { return Items.Count; } }
        public int ItemsTotal { get { return Items.Sum(item => item.Quantity); } }
        public double PriceTotal { get { return Math.Round(Items.Sum(item => item.Total), 4); } }
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {  
            
            Invoice invoice = new();


            invoice.Customer = "Karhu Gryls";
            invoice.Items.Add(new Items("Milk", 1, 6));
            invoice.Items.Add(new Items("Butter", 3.78, 2));
            invoice.Items.Add(new Items("Coffee", 7, 3));
            invoice.Items.Add(new Items("Chocolate", 2.50, 3));


            Invoice invoice2 = new();

            invoice2.Customer = "Burak Dogan";

            invoice2.Items.Add(new Items("Battery", 4, 7));
            invoice2.Items.Add(new Items("Beer", 2.99, 12));
            invoice2.Items.Add(new Items("Cup", 14.90, 1));
            invoice2.Items.Add(new Items("Bread", 2.50, 2));



            string PrintInvoice(Invoice invoice)
            {
                Console.WriteLine($"\nCustomer: {invoice.Customer}'s invoice:");

                Console.WriteLine("==========================================");
                foreach (Items item in invoice.Items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("==========================================");

      
                return $"**  Total: {invoice.EachItemCount} items, {invoice.ItemsTotal} pieces {invoice.PriceTotal} euros";
            }

            Console.WriteLine(PrintInvoice(invoice));

            Console.WriteLine(PrintInvoice(invoice2));


        }
    }
}