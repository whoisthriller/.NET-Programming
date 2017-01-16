using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testcode
{
    class Program
    {   
        
        static void Main(string[] args)
        {
            //List<Person> persons = new List<Person>();
            //persons.Add(new Person("John",30));
            //persons.Add(new Person("Jack", 27));


            //ICollection<Person> personCollection = persons;
            //IEnumerable<Person> personEnumeration = persons;

            //IEnumeration
            //IEnumration Contains only GetEnumerator method to get Enumerator and make a looping
            //foreach (Person p in personEnumeration)
            //{                                   
            //  //Console.WriteLine("Name:{0}, Age:{1}", p.Name, p.Age);
            //}

            //ICollection
            //ICollection Add/Remove/Contains/Count/CopyTo
            //ICollection is inherited from IEnumerable
            //    personCollection.Add(new Person("Tim", 10));

            //    foreach (Person p in personCollection)
            //    {
            //        //Console.WriteLine("Name:{0}, Age:{1}", p.Name, p.Age);        
            //    }

            //    //Console.WriteLine(persons.Count); // 3, means add a new element in the original list






            //    EmployeeDBContext context = new EmployeeDBContext();
            //    IEnumerable<Department> departments = context.Departments.Where(x => x.Name == "IT" || x.Name == "HR");

            //    foreach (Department dept in departments)
            //    {
            //        //Console.WriteLine("Department - " + dept.Name);
            //        IEnumerable<Employee> employees = dept.Employees.Where( x => x.Gender == "Male");
            //        foreach(Employee e in employees)
            //        {
            //           // Console.WriteLine("\tEmployee - " + e.FirstName + " " + e.LastName);
            //        }
            //    }

            //    //----------------------------------------------------------
            //    List<int> listint = new List<int>(){1,2,3,4,5,6,7,8,9,10};
            //    IEnumerable<int> nums = from num in listint
            //                            where num % 2 == 0
            //                            select num;
            //    IEnumerable<int> result2 = listint.Where((x, y) => y % 5 == 0);
            //    //IEnumerable<int> result2 = listint.Select((num, index) => new { Number = num, Index = index }).Where(x => x.Number % 2 == 0).Select(x => x.Index);
            //    //IEnumerable<int> nums2 = listint.Where(x => x%2 == 0);


            //    foreach(var i in result2)
            //    {
            //       // Console.WriteLine(i);
            //    }

            //    //------------------------------------------------------
            //    List<Student> listStudent = new List<Student>()
            //    {
            //       new Student(){ID=1, Name="Quincy",Gender="Male"},
            //       new Student(){ID=2, Name="Rod",Gender="Male"},
            //       new Student(){ID=3, Name="Siedah",Gender="Female"}
            //    };
            //    IEnumerable<Student> students = listStudent.Where(student => student.Gender == "Male");
            //    IEnumerator<Student> enumer = students.GetEnumerator();
            //    //pre p = new pre(check);
            //    //Predicate<Student> pre;
            //   // delegate bool pred(Student s);
            //    Predicate<Student> pre = check;
            //    //delegate bool pre1(Student s);
            //    Student s = listStudent.Find(pre);
            //    //Console.WriteLine("s is" + s.Nadelegate bool pre(Student s);me);

            //    string[] countries = { "India", "USA"};
            //    int[] numbers = { 1, 2, 3};
            //    int minint = numbers.Where(x => x % 2 == 0).Min();
            //    int min = countries.Min(x => x.Length);
            //    Func<int, bool> evendelegate = new Func<int, bool>(even);
            //    //Predicate<int> evendelegate = new Predicate<int>(even);
            //    //double avg = numbers.Where(x => x % 2 == 0).Average();
            //    double avg = numbers.Where(evendelegate).Average();
            //    //Console.WriteLine(avg);

            //    int result = numbers.Aggregate((a,b) => a*b);
            //    //Console.WriteLine(result);

            //    bool abc = checkI(listint);
            //    //Console.WriteLine(abc);

            //}
            //public static bool checkI(IEnumerable<int> i)
            //{
            //    return true;  
            //}

            //public static bool check(Student s)
            //{
            //    return s.Name == "Quincy";
            //}

            //public static bool even(int i)
            //{
            //   if(i % 2 == 0)
            //   {
            //       return true;
            //   }
            //   return false;
            //}
        }
        
    }

    class A 
    {
        public void print()
        {
            Console.WriteLine("A method");
        }
       
    }

     class B : A
    { 
        //public void print()
        //{
        //    Console.WriteLine("B method");
        //}
    }

     class C : i1
    {
         public void print()
         {
             Console.WriteLine("C method");
         }
    }

    class D : B
    {
        
    }

    interface i1
    {

    }


    class Student 
    {
       
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

     


    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

 
}
