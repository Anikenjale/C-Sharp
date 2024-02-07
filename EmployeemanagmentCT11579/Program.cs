internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


    // try{

    //          Manager manager = new Manager()
    //         {employeeId=11579,firstname="Aniruddh",lastname="Kenjale",salary=40000};
    //         double Salary=manager.CalculateSalary();
    //         System.Console.WriteLine("Salary of manager is:"+Salary);

    //         Employee employee=new Employee()
    //         {employeeId= 11579, firstname="Aniruddh",lastname="Kenjale",salary=50000};
    //         double salary=employee.CalculateSalary();

    //         System.Console.WriteLine("Salary of employee is:"+salary);
    //     }
    // catch(InputException ex)
    //     {
    //         System.Console.WriteLine(ex.Message);
    //     }

         EmployeeRepository Emrepo= new EmployeeRepository();


        // Emrepo.AddEmployee(new Employee(1,"Aniruddh","Kenjale",40000));
        // Emrepo.AddEmployee(new Employee(2,"Aniruddh","Kenjale",45000));
        // Emrepo.AddEmployee(new Employee(3,"Aniruddh","Kenjale",48000));
        // Emrepo.AddEmployee(new Employee(4,"Aniruddh","Kenjale",42000));

        Console.WriteLine("All Employess");
        Emrepo.DisplayAllEmployees();

        // Emrepo.UpdateEmployee(new Employee(1,"Virat","Kohali",55000));
        // Console.WriteLine("Emplyoees after Update");
        // Emrepo.DisplayAllEmployees();

        // Emrepo.DeleteEmployee(2);
        // Console.WriteLine("Emplyoees after Update");
        // Emrepo.DisplayAllEmployees();

        // Console.WriteLine("First Employee");
        // Emrepo.DisplyEmployeeById(1);

    } 

        
}