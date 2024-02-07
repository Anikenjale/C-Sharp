
using System.ComponentModel;

public class Manager:Employee
{
public double PerformanceBonus{get;set;}

    //Default Constructor
    public Manager():base()
    {
        PerformanceBonus=7000; 
    }

    public Manager(int empId,string Fname,string Lname,double Sal,double incentive)
    {
        PerformanceBonus=incentive;
    }

    public override double CalculateSalary()
   {
        return base.CalculateSalary()+PerformanceBonus;
   }
}