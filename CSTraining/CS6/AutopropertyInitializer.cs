using static System.Console;

namespace CS6
{
    public static class AutopropertyInitializer
    {

        public static void Test()
        {
            var emp = new EmployeeWithCS6();
            WriteLine(emp.Name);
            WriteLine(emp.Salary);
        }
        
    }

    public class EmployeeWithCS6
    {
        public string Name { get; } = "Sammy Jenkins";
        public decimal Salary { get; set; } = 5000;

    }

    public class EmployeeOld
    {
        public string Name { get;}
        public decimal Salary { get; set; }
        public EmployeeOld()
        {
            /* Initializing property through constructor */
            Name = "Sammy Jenkins";
            Salary = 10000;
        }
    }
}
