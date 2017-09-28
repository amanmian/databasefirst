using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            amanmianEntities context = new amanmianEntities();
            //   Console.WriteLine("");
            context.products.ToList();
            context.products.Add
                (new Product                                              //To Add....
                 {
                    id = 21,
                    name = "ammu"
                });

            //var del = from employee in context.employees                  //To Delete...
            //          where employee.id == 50
            //          select employee;
            //foreach(var employee in del)
            //{
            //    context.employees.Remove(employee);
            //}
            //context.SaveChanges();

            /*   var update = from employee in context.employees            //To Update Employee Details...
                            where employee.id == 2
                            select employee;
               foreach(var employee in update)
               {
                   employee.name = "shubham";
               } */

            /*       var update1 = from student in context.students             //To Update Student Details...
                                 where student.id == 59
                                 select student;
                   foreach(var student in update1)
                   {
                       student.name = "aman khan";
                       student.phone = 9707654342; 
                   } */
            //  throw new

            /*    var a = context.students
                    .Join(context.employees,
                    student => student.id,
                    employee => employee.name,
                    (student, employee) => new
                    {
                        student.id,
                        employee.name

                    }
                    )
                    .OrderByDescending(student => student.name)
                    .ThenBy(student => student.id);

               foreach(var x in a)
                {
                    Console.WriteLine($"{x.name} {x.id}");
                }
                Console.ReadKey(); */

            /*    var a = context.employees
                    .Join(context.students,
                    x => x.id,
                    y => y.id,
                    (x, y) => new { employee = x, student = y })
                    .Where((z) => z.employee.id == 1)
                    .FirstOrDefault();

                Console.WriteLine(a.employee.id + " - " + a.student.name);
                Console.ReadKey(); */

            amanmianEntities context1 = new amanmianEntities();
            {
                var m = context1.products.ToList();
                foreach (var x in m)
                {
                    Console.WriteLine();


                    Console.ReadKey();

                }
            }


            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException e)
            {
                Console.WriteLine("Key already exist..... Enter the correct key", e);
                Console.ReadKey();
            }



        }
    }
}
