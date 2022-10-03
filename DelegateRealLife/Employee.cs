using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateRealLife
{
    public delegate bool DelegateRealLife1(Employee IsPromoted);
    public class Employee
    {
        public int id { get; set; }

        public string name { get; set; }

        public int salary { get; set; }

        public int age { get; set; }

        public void promtotion(List<Employee> employees, DelegateRealLife1 d1) 
        {
            foreach (var employee1 in employees) 
            {
                if (d1(employee1)) 
                {
                    Console.WriteLine($"{employee1.name} is promoted");
                }
            }    
        }
    }
}
