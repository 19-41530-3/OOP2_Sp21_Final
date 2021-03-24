using System;

namespace Studentcourse
{
    class Program
    {
        static void Main(string[] args)
        {

           
            var s1 = new Student("19-41743-3","Rakib", 3.33F);
            var s2 = new Student("19-41753-3","Sham", 3.55F);
            var s3 = new Student("19-45603-3","Raian", 3.33F);
            var s4 = new Student("17-41743-3","Alif", 3.45F);
            var s5 = new Student("18-51745-3","kabir", 3.55F);
            var s6 = new Student("19-41743-2","Sajjad", 3.66F);
            var s7 = new Student("19-44743-1","Rokeya", 3.77F);
         

            

            var c0 = new Course("19-41743-3","OOP 1");
            var c1 = new Course("18-51745-3","OOP 2");
            var c2 = new Course("18-51745-3","Algorithm");


           

            c0.AddStudent(s1, s3, s5, s7);

            c0.PrintStudent();

            c0.RemoveStudent(s5);


            Console.WriteLine("");
            Console.WriteLine("After Remove Student");

            s5.PrintCourse();
            c0.PrintStudent();

            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");


            s2.AddCourse(c1, c2);
            s2.PrintCourse();

            s2.RemoveCourse(c1);

            Console.WriteLine("");
            Console.WriteLine("After Remove Course");
            Console.WriteLine("");

            s2.PrintCourse();
            c1.PrintStudent();
        }
    }
    }

