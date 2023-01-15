internal class Program
{
    public class Employee 
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Employee:\n-Name: {Name}, Profession: {Profession}, Salary: {Salary}\n";
        }
    }

    public class Boss : Employee 
    {
        public double Bonus { get; set; }
        public string Car { get; set; }

        public override string ToString()
        {
            return $"Boss:\n-Name: {Name}, Profession: {Profession}, Salary: {Salary}, Car: {Car}, Bonus: {Bonus}\n";
        }

    }
    private static void Main(string[] args)
    {
        Employee employee = new Employee() {Name = "Burak Dogan", Profession = "Software Developer", Salary = 3000 };
        Console.WriteLine(employee.ToString());
        Employee employee2 = new Employee() { Name = "Burak Dogan", Profession = "Senior Software Developer", Salary = 5000 };
        Console.WriteLine(employee2.ToString());

        Boss boss = new Boss() { Name = "No More", Profession = "Bossing Around", Salary = 10000, Car = "Big Car", Bonus = 5000 };
        Console.WriteLine(boss.ToString());
    }
}