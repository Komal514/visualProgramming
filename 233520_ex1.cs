

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Department
{
    None,
    Science,
    Arts,
    Commerce
}

public class Person
{

    private string name;

 
    public Person()
    {
        name = null; 
    }

    public Person(string name)
    {
        this.name = name;
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

public class Student : Person
{
   
    private string regNo;
    private int age;
    private Department program;


    public Student() : base() 
    {
        regNo = null; 
        age = 0;      
        program = Department.None; 
    }

 
    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }

  
    public string RegNo
    {
        get { return regNo; }
        set { regNo = value; }
    }


    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Department Program
    {
        get { return program; }
        set { program = value; }
    }
}



namespace Lab_05_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine($"Student 1 - Name: {student1.Name}, RegNo: {student1.RegNo}, Age: {student1.Age}, Program: {student1.Program}");

         
            Student student2 = new Student("Alice", "S123", 20, Department.Science);
            Console.WriteLine($"Student 2 - Name: {student2.Name}, RegNo: {student2.RegNo}, Age: {student2.Age}, Program: {student2.Program}");

        
            student1.Name = "Komal";
            student1.RegNo = "233520";
            student1.Age = 22;
            student1.Program = Department.Arts;

            Console.WriteLine($"Student 1 (after setting values) - Name: {student1.Name}, RegNo: {student1.RegNo}, Age: {student1.Age}, Program: {student1.Program}");

        }
    }
}







