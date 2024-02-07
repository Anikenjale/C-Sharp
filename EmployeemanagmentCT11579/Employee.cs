public class Employee
{
    public int employeeId{get; set;}
    public string firstname{get; set;}
    public string lastname{get; set;}
    public double salary{get; set;}


//Default Constructor.....
    public Employee()
    {
        employeeId=0;
        firstname=string.Empty;
        lastname=string.Empty;
        salary=0;
    }

    //Parameterized Constructor
    public Employee(int empId, string Fname, string Lname, double Sal)
    {
        employeeId= empId;
        firstname= Fname;
        lastname= Lname;
        salary= Sal;
    }

    public virtual double CalculateSalary()
    {
        return salary;
    }
}