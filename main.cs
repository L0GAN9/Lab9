using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Lab 9 Code");

    Employee unknown = new Employee();
    unknown.Intro();

    Employee john = new Employee("John", "Smith", 1234, "45");
    john.Intro();
  }
}