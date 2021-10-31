using System;

class Employee
{
  string firstname;
  string lastname;
  string id;
  int age;
  string address;
  string phonenum;
  string title;
  double yearlysalary;
  string employmentstatus;
  
  public Employee()
  {
    firstname = "Unknown";
    lastname = "Unknown";
    id = Convert.ToString("Unknown");
    age = 0;
    employmentstatus = "Active";
    Console.WriteLine("A new employee has been created");
  }

  public Employee(string employeefirstname, string employeelastname, int employeeage, string employeeid)
  {
    firstname = employeefirstname;
    lastname = employeelastname;
    age = employeeage;
    id = employeeid;
    employmentstatus = "Active";
  }
  
  public void Intro()
  {
    Console.WriteLine("My first name is " + firstname);
    Console.WriteLine("My last name is " + lastname);
    Console.WriteLine("My ID is " + id);
    Console.WriteLine("My age is " + age);
    Console.WriteLine("My employment status is " + employmentstatus);
  }
}