using System;
using System.Collections.Generic;

public interface IEmployeeRepo{

    List<Employee>employee();
    void AddEmployee(Employee employee);
    void UpdateEmployee(Employee employee);
    void DeleteEmployee(int employeeId);
    void DisplayAllEmployees();
    void DisplyEmployeeById(int employeeId);   
}

class EmployeeRepository:IEmployeeRepo
{
    
    List<Employee> employees=new List<Employee>();

     List<Employee> IEmployeeRepo.employee()
    {
        return employees;
    }

    
    public EmployeeRepository()
    {
        this.employees=new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        if(string.IsNullOrEmpty(employee.firstname)||string.IsNullOrEmpty(employee.lastname))
        {
             throw new InputException("Name Cannot empty");
        }
       
        employees.Add(employee);
    }

    
    public void UpdateEmployee(Employee employee)
    {
         for(int i=0;i<employees.Count;i++)
        {
            if(employees[i].employeeId==employee.employeeId)
            {
                employees[i]=employee;
                return;
            }
        }
        throw new InputException("Employee not found");
    }
    public void DeleteEmployee(int employeeId)
    {
       employees.RemoveAll(emp=>emp.employeeId==employeeId);
    }

    public void DisplayAllEmployees()
    {
        foreach(var emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
    public void DisplyEmployeeById(int employeeId)
    {
       var employee=employees.Find(emp=>emp.employeeId==employeeId);
       if(employee!=null)
       {
        Console.WriteLine(employee);
       }

       throw new InputException("Employee not found");
    }

   
}