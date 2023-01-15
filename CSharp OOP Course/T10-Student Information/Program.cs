using System.Diagnostics.Contracts;

public class Student 
{
    public int StNum { get; set; }
    public string Name { get; set; }
    public string Sname { get; set; }

    public virtual string ToString() 
    {
        return $"Name: {Name} \nSurname: {Sname} \nStudent Number: {StNum}";
    }

}

public class StudyInfo : Student 
{
    public string StudyField { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return base.ToString() + "\nStudy Field: " + StudyField.ToString() +
            "\nYear: " + Year.ToString();
    }


}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> StudentList = new List<Student>();

        //Make some students
        StudyInfo student1 = new StudyInfo() { StNum = 1, Name = "Burak", Sname = "Dogan", StudyField = "Software Development", Year = 2 };
        StudyInfo student2 = new StudyInfo() { StNum = 2, Name = "Kubra", Sname = "Cakir Dogan", StudyField = "Laboratory Technician", Year = 1 };
        StudyInfo student3 = new StudyInfo() { StNum = 3, Name = "Ali", Sname = "Vele", StudyField = "Torna Tesfiye", Year = 3 };
        StudyInfo student4 = new StudyInfo() { StNum = 4, Name = "Kutay", Sname = "Calisir", StudyField = "Molecular Biology", Year = 4 };
        StudyInfo student5 = new StudyInfo() { StNum = 5, Name = "Dennis", Sname = "The Menace", StudyField = "Rascal", Year = 2 };

        StudentList.Add(student1);
        StudentList.Add(student2);
        StudentList.Add(student3);
        StudentList.Add(student4);
        StudentList.Add(student5);


        Console.WriteLine("\n============***=============\n");
        foreach (var item in StudentList)
        {
            Console.WriteLine(item.ToString());
            Console.WriteLine("\n=========================\n");
        }
    }
}