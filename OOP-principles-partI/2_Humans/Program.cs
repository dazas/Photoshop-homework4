using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing 10 students and sort them by grade in ascending order:
            List<Student> students = new List<Student>();
            students.Add(new Student("Goro", "Pik", 2.76));
            students.Add(new Student("Goro", "K", 3.66));
            students.Add(new Student("Alex", "Tam", 6.75));
            students.Add(new Student("Zepi", "Ti", 8.75));
            students.Add(new Student("Kiti", "Ar", 2.75));
            students.Add(new Student("Lasen", "Q", 4.22));
            students.Add(new Student("Goro", "Zip", 2.75));
            students.Add(new Student("Boro", "Ti", 3.75));
            students.Add(new Student("Goro", "Ro", 5.75));

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());   
            }
            Console.WriteLine();

            students = new List<Student>(students.OrderBy(student => student.Grade));


            Console.WriteLine("Students by grade:");
            Console.WriteLine();
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
            // Initializing 10 workers and sort them by by money per hour in descending order:
            // Не знам защо не се пресмятат MoneyPerHour = 
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Goro", "Pik", 600m, 10m));
            workers.Add(new Worker("Goro", "R", 600m, 4m));
            workers.Add(new Worker("Alex", "Ram", 675m, 8m));
            workers.Add(new Worker("Pepi", "Ti", 875m, 5m));
            workers.Add(new Worker("Kiti", "Ar", 775m, 3m));
            workers.Add(new Worker("Iasen", "Q", 1422m, 10m));
            workers.Add(new Worker("Goro", "Zip", 675m, 5m));
            workers.Add(new Worker("Goro", "Ti", 775m, 4m));
            workers.Add(new Worker("Goro", "Ro", 575m, 6m));

            foreach (var worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }
            Console.WriteLine();

            workers = new List<Worker>(workers.OrderByDescending(worker => worker.MoneyPerHour).ToList());


            Console.WriteLine("by money per hour in descending order:");
            Console.WriteLine();
            foreach (var item in workers)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            // Merge the lists and sort them by first name and last name

            var fullList = workers.Concat<Human>(students).ToList();
            fullList = fullList.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();

            Console.WriteLine("Ordered full list:");
            foreach (Human human in fullList.OrderBy(human => human.FirstName).ThenBy(human => human.LastName))
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }

        }

    }
}
