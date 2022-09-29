// See https://aka.ms/new-console-template for more information
using Advance;

Delegate1 d = new Delegate1();

math math1 = new math(d.add);

math1 += d.sub;
math1 += d.divide;
math1 += d.multiply;
foreach (math v in math1.GetInvocationList()) 
{
    try
    {
        int a = v(3, 0);
        Console.WriteLine(a);
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message); 
    }
}



