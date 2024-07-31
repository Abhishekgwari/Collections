using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                      
namespace Collections                                // Icomparable Interface
{
    internal class Student :IComparable<Student>

    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }
        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else

                return 0;
        }
    
        class CompareStudents : IComparer<Student>           // I comparer interface
        {
            public int Compare(Student x, Student y)
            {
                if (x.Marks > y.Marks)
                    return 1;
                else if (x.Marks < y.Marks)
                    return -1;
                else
                    return 0;
            }
        }

        class TestStudent
        {
            //public static int CompareNames(Student S1, Student S2)
            //{
            //   return  S1.Name.CompareTo(S2.Name);
            //}

            static void Main(string[] args)
            {
                Student s1 = new Student { Sid = 31, Name = "Abhishek", Class = 12, Marks = 70.90f };
                Student s2 = new Student { Sid = 22, Name = "Aman", Class = 11, Marks = 97.90f };
                Student s3 = new Student { Sid = 36, Name = "Lokesh", Class = 10, Marks = 90.90f };
                Student s4 = new Student { Sid = 14, Name = "Neha", Class = 9, Marks = 80.90f };
                Student s5 = new Student { Sid = 5, Name = "Ayushman", Class = 8, Marks = 74.90f };
                Student s6 = new Student { Sid = 64, Name = "Rachit", Class = 4, Marks = 80.90f };

                List<Student> Students = new List<Student>() { s1, s2, s3, s4, s5, s6, };
                //  Students.Sort();
                //  CompareStudents obj = new CompareStudents();
                // Students.Sort(obj);

                //  Students.Reverse();

                //    Students.Sort(1,5,obj);

                // option 1
                //   Comparison<Student> obj = new  Comparison<Student>
                //     (CompareNames);
                // Students.sort(obj);


                // option 2
                //     Students.Sort(obj);

                // option 3         //Students.Sort(delegate(Student S1 , Student S2) { 
                //    return S1.Name.CompareTo(S2.Name); });

                // option 4
                Students.Sort((S1, S2) => S1.Name.CompareTo(S2.Name));

                foreach (Student S in Students)
                {
                    Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
                }
                Console.ReadLine();
            }
        }
        }
    }
    
