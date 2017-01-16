using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Employee> employeeList = new List<Employee>()
                          {
            new Employee { ID = 1, Name = "Mark", DepartmentID = 1 },
            new Employee { ID = 2, Name = "Steve", DepartmentID = 2 },
            new Employee { ID = 3, Name = "Ben", DepartmentID = 1 },
            new Employee { ID = 4, Name = "Philip", DepartmentID = 1 },
            new Employee { ID = 5, Name = "Mary" }
           
                         };
            IEnumerator<Employee> enumerator = employeeList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current.Name);
            }
            //IEnumerable<int> result =  Enumerable.Range(1, 10).Where(x=>x%2==0);
           //foreach (int i in result)
           //{
           //    Console.WriteLine(i);
           //}

            
            //var result = from d in Department.GetAllDepartments()
            //             join e in Employee.GetAllEmployees()
            //             on d.ID equals e.DepartmentID into eGroup
            //             select new
            //             {
            //                 //Department = d,
            //                 //Employees = eGroup
            //             };
            //Console.WriteLine(result.Count());
            
            //var employeesByDepartment = Employee.GetAllEmployees()
            //                                    .GroupJoin(Department.GetAllDepartments(),
            //                                      e => e.DepartmentID, d => d.ID,
            //                                      (emp, depts) => new
            //                                      {
            //                                          emp,
            //                                          depts
            //                                      })
            //                                      .SelectMany(newtype => newtype.depts.DefaultIfEmpty(),
            //                                      (a, b) => new
            //                                      { 
            //                                          EmployeeName = a.emp.Name,
            //                                          DepartmentName = b==null ? "No Department": b.Name

            //                                      });
            //  foreach(var va in employeesByDepartment)                                  
            //  {

                
            //          Console.WriteLine(va.EmployeeName + "---" + va.DepartmentName);
                  
                  

            //  }




            //var employeesByDepartment = from d in Department.GetAllDepartments()
            //                            join e in Employee.GetAllEmployees()
            //                            on d.ID equals e.DepartmentID into eGroup
            //                            select eGroup;

            //Console.WriteLine(employeesByDepartment.Count());
            //var employeesByDepartment = Department.GetAllDepartments()
            //                                      .GroupJoin(Employee.GetAllEmployees(),
            //                                                 d => d.ID,
            //                                                 e => e.DepartmentID,
            //                                                 (department, employees) => new
            //                                                 {
            //                                                     Department = department,
            //                                                     Employees = employees
            //                                                 }
            //                                                 );
            
            //foreach (var department in employeesByDepartment)
            //{
            //    Console.WriteLine(department.Department.Name);
            //    foreach (var employee in department.Employees)
            //    {
            //        Console.WriteLine(" " + employee.Name);
            //    }
            //    Console.WriteLine();
            //}


//          #region groupby 
//            var employeeGroup = Employee.GetAllEmployees()
//                                .GroupBy(x => new { x.Department, x.Gender, })
//                                ;
//            Console.WriteLine(employeeGroup.Count());

//            /*var employeeGroup = from employee in Employee.GetAllEmployees()
//                                group employee by new { employee.Department, employee.Gender } into egroup
//                                orderby egroup.Key.Department, egroup.Key.Gender
//                                select new
//                                {
//                                    Dept = egroup.Key.Department,
//                                    Gender = egroup.Key.Gender,
//                                    Employees = egroup.OrderBy(x => x.Name)
//                                };
                            
//            foreach(var group in employeeGroup)
//           {
//               Console.WriteLine(group.Dept + " - " + group.Gender );
//               foreach (Employee emp in group.Employees)
//               {
//                   Console.WriteLine(emp.Name + "--" + emp.Department);
//               }
//               Console.WriteLine("-----------------------------------");
//           }*/
//#endregion 
            
            
          #region toDictionary
            //Dictionary<string, Employee> result = listEmployees.ToDictionary(x => x.Name);
            // Group employees by JobTitle
            /* ILookup<string, Employee> employeesByJobTitle  = listEmployees.ToLookup(x => x.JobTitle);
             //IEnumerable<Employee> ie = employeesByJobTitle["Developer"];
             foreach (IGrouping<string,Employee> item in employeesByJobTitle)
             {
                 foreach (Employee e in employeesByJobTitle[item.Key])
                 {
                     Console.WriteLine("\t" + e.Name + "\t" + e.JobTitle + "\t" + e.City);
                 }
                 //Console.WriteLine(item);
             }
             Console.WriteLine("Employees Grouped By JobTitle");
             Console.WriteLine();
             foreach (var kvp in employeesByJobTitle)
             {
                 //Console.WriteLine(kvp.Key);
                 // Lookup employees by JobTitle
                 foreach (var item in employeesByJobTitle[kvp.Key])
                 {
                    // Console.WriteLine("\t" + item.Name + "\t" + item.JobTitle + "\t" + item.City);
                 }
             }*/
            #endregion

            /*List<Student> listStudents = new List<Student>
            {
                new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
                new Student { StudentID= 101, Name = "Mary", TotalMarks = 900 },
                new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            };

           Dictionary<int, string> result = listStudents.ToDictionary(x=>x.StudentID, y=>y.Name);
           var va = listStudents.ToLookup(x => x.StudentID);
          // IEnumerable<Student> li = va[101];*/
           
            //IEnumerable<Student> students = Student.GetAllStudents();
            /*int pageNumber = 0;
            if (int.TryParse(Console.ReadLine(), out pageNumber))
            {
                if (pageNumber >= 1 && pageNumber <= 4)
                {
                    int pageSize = 3;
                    students.Skip(3);
                }
                else
                {
                    Console.WriteLine("Page number must be an integer between 1 and 4");
                }


            }
            else 
            {
                Console.WriteLine("Page number must be an integer");
            }*/

            
            /*string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
            IEnumerable<string> result = (from ctry in countries
                                          select ctry).TakeWhile(s => s.Length > 2);
            foreach (string s in result)
            {
                Console.WriteLine(s + "\n");
            }*/
           /*IOrderedEnumerable<Student> result = from s in Student.GetAllStudents()
                                                 orderby s.TotalMarks, s.Name, s.Name descending
                                                 select s;
            foreach (Student s in result)
            {
                Console.WriteLine(s.TotalMarks + "\t" + s.Name + "\t" + s.StudentID);
            }*/
            /*IOrderedEnumerable<Student> result = Student.GetAllStudents().OrderBy(s => s.TotalMarks).OrderBy(s => s.Name);
            Console.WriteLine("Faulty Sort\n");
            foreach (Student s in result)
            {
                Console.WriteLine(s.TotalMarks + "\t" + s.Name+ "\t" + s.StudentID);
            }
            IOrderedEnumerable<Student> result2 = Student.GetAllStudents().OrderBy(s => s.TotalMarks).ThenBy(s => s.Name);
            Console.WriteLine("\nCorrect Sort\n");
            foreach (Student s in result2)
            {
                Console.WriteLine(s.TotalMarks + "\t" + s.Name + "\t" + s.StudentID);
            }*/

            /*Console.WriteLine("Student names before sorting");

            List<Student> students = Student.GetAllStudents();

            foreach (Student s in students)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            IOrderedEnumerable<Student> result = from student in students
                                                 orderby student.Name descending
                                                 select student;

            //IOrderedEnumerable<Student> result = Student.GetAllStudents().OrderBy(s => s.Name);
            
            Console.WriteLine("Student names after sorting");
            
            foreach (Student s in result)
            {
                Console.WriteLine(s.Name);
            }*/
          

            /*var result = from student in Student.GetAllStudetns()
                         from subject in student.Subjects
                         select new { SName = student.Name, SubName = subject };*/

            /* var result = Student.GetAllStudetns().SelectMany(s => s.Subjects, (student, subject) =>
                                                                  new { StudentName = student.Name, SubjectName = subject });*/
            /*foreach (var i in result)
            {
                Console.WriteLine(i.SName + "-" + i.SubName);
            }*.
            
            /*string[] stringArray =
            {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };

            IEnumerable<char> resultchar = from str in stringArray
                                           from c in str
                                           select c;
            foreach (char i in resultchar)
            {
                Console.WriteLine(i);
            }*/
            
            
           /*IEnumerable<string> result = (from student in Student.GetAllStudetns()
                                        from subject in student.Subjects
                                        select subject).Distinct();
           foreach (string i in result)
           {
               Console.WriteLine(i);
           }*/

            /*IEnumerable<string> result = Student.GetAllStudetns().SelectMany(s => s.Subjects);
           foreach (string i in result)
           {
               Console.WriteLine(i);
           }*/
            
           //-----------------------------------------------------------------------------------

            /*IEnumerable<int> result = Employee.GetAllEmployees().Select((emp => emp.EmployeeID ));
            foreach (int i in result)
            {
                //Console.WriteLine(i);
            }

            var result2 = Employee.GetAllEmployees().Select(emp => new { FirstName = emp.FirstName, Gender = emp.Gender });
            foreach (var i in result2)
            {
                Console.WriteLine(i.FirstName);
            }*/
        }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int DepartmentID { get; set; }

            public static List<Employee> GetAllEmployees()
            {
                return new List<Employee>()
                          {
            new Employee { ID = 1, Name = "Mark", DepartmentID = 1 },
            new Employee { ID = 2, Name = "Steve", DepartmentID = 2 },
            new Employee { ID = 3, Name = "Ben", DepartmentID = 1 },
            new Employee { ID = 4, Name = "Philip", DepartmentID = 1 },
            new Employee { ID = 5, Name = "Mary" }
           
                         };
            }
           
        }

        public class Department
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public static List<Department> GetAllDepartments()
            {
                return new List<Department>()
        {
            new Department { ID = 1, Name = "IT"},
            new Department { ID = 2, Name = "HR"}
            
        };
            }
        }
    }
   
}
