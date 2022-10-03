// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using DelegateRealLife;
Console.WriteLine("Hello, World!");
DelegateRealLife1 d1 = new DelegateRealLife1(promoted);
d1 += promoted1;
Employee employee1 = new Employee() {id = 1, name = "Divyansh", salary = 500, age = 20};
Employee employee2 = new Employee() { id = 2, name = "Abhisjhek", salary = 1000, age = 21 };
List<Employee> Employees = new List<Employee>();

Employees.Add(employee1);
Employees.Add(employee2);

Employee employee = new Employee();
employee.promtotion(Employees, d1);


static bool promoted(Employee employee) 
{
    if (employee.salary > 750)
    {
        return true;
    }
    else 
    {
        return false;
    }
};

static bool promoted1(Employee employee) 
{
    if (employee.age > 20)
    {
        return true;
    }
    else 
    {
        return false;
    }
}