using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class Employee // Make Employee public
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }

    public class Organization : IEnumerable<Employee> // Use generic IEnumerable
    {
        private List<Employee> Emps = new List<Employee>();

        public void Add(Employee emp)
        {
            Emps.Add(emp);
        }

        public int Count
        {
            get { return Emps.Count; }
        }

        public Employee this[int index]
        {
            get
            {
                return Emps[index];
            }
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return new OrganizationEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class OrganizationEnumerator : IEnumerator<Employee> // Use generic IEnumerator
    {
        private Organization OrgColl;
        private int CurrentIndex;
        private Employee CurrentEmployee;

        public OrganizationEnumerator(Organization org)
        {
            OrgColl = org;
            CurrentIndex = -1;
        }

        public Employee Current
        {
            get
            {
                return CurrentEmployee;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            if (++CurrentIndex >= OrgColl.Count)
                return false;
            else
                CurrentEmployee = OrgColl[CurrentIndex];
            return true;
        }

        public void Reset()
        {
            CurrentIndex = -1;
        }

        public void Dispose()
        {
            // No resources to release
        }
    }

    class TestEmployee
    {
        static void Main(string[] args)
        {
            Organization Employees = new Organization();

            Employees.Add(new Employee { Id = 101, Name = "Abhishek", Job = "Developer", Salary = 45000.00 });
            Employees.Add(new Employee { Id = 102, Name = "Aman", Job = "Manager", Salary = 95000.00 });
            Employees.Add(new Employee { Id = 103, Name = "Lokesh", Job = "Tester", Salary = 43000.00 });
            Employees.Add(new Employee { Id = 104, Name = "Neha", Job = "Trainee", Salary = 4000.00 });
            Employees.Add(new Employee { Id = 105, Name = "Ayushman", Job = "Clerk", Salary = 45000.00 });
            Employees.Add(new Employee { Id = 106, Name = "Rachit", Job = "Developer", Salary = 45000.00 });

            foreach (Employee emp in Employees)
                Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Job + " " + emp.Salary);

            Console.ReadLine();
        }
    }
}
