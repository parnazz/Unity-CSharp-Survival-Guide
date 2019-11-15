using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Abstract1
{
    public string companyName;
    public string employeeName;

    public abstract void CalculateMonthlySalary();
}

[System.Serializable]
public class FullTime : Abstract1
{
    public int salary;

    public FullTime(int salary)
    {
        this.salary = salary;
    }

    public override void CalculateMonthlySalary()
    {
        int monthlySalary = salary / 12;
        Debug.Log("Monthly salary for fulltime worker: " + monthlySalary);
    }
}

[System.Serializable]
public class PartTime : Abstract1
{
    public int hoursWorked;
    public int hourlyRate;

    public PartTime(int hoursWorked, int hourlyRate)
    {
        this.hoursWorked = hoursWorked;
        this.hourlyRate = hourlyRate;
    }

    public override void CalculateMonthlySalary()
    {
        int monthlySalary = hoursWorked * hourlyRate;
        Debug.Log("Monthly salary for parttime worker: " + monthlySalary);
    }
}
