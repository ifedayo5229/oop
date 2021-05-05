using System;

namespace oop
{
    class Program
         /*Create a class with a method that prints "This is parent class" and its
          subclass with another method that prints "This is child class". Now, create an object for each of the class and call
1 - method of parent class by object of parent class
2 - method of child class by object of child class
3 - method of parent class by object of child class*/

    {
        static void Main(string[] args)
        { 
            // inheritance allow to point to a derived class object usinig base class ref var
            // Employee employee = new parttimeemployee();
            // employee.printfullname();
        //    parttimeemployee pte = new parttimeemployee();

        //    pte.firstName="muiz";
        //    pte.lastName="atos";
        //    pte.printfullname();

        //    ContractEmployee cte = new ContractEmployee();
        //    cte.firstName="ife";
        //    cte.lastName="seun";
        //    cte.printfullname();
        parentclass parent = new parentclass();
        parent.printparentclass();
         subclass sub = new subclass();
        sub.printanothersubclass();
        sub.printparentclass();
        }
    }

      /*  Polymorphism(many forms)in c# is a concept by which we can perform a single action in different ways.
     We can perform polymorphism in c# by method overloading and method overriding. 
     If you overload a method in c#, it is the example of compile time(static) polymorphism
     If you override a method in c#, it is the example of run time(dynamic) polymorphism*/

       // child class or derived
    //  public class parttimeemployee:Employee
    //  {
    //       public new void printfullname() // override can be used
    //   {
    //       Console.WriteLine(firstName+ " " + lastName +"  cte staff");
    //   }
    //  }

     //child class or derived
    //  public class ContractEmployee:Employee
     public class subclass:parentclass
     
     {



    //   public new void  printfullname() // override can be used
    public  new void printanothersubclass()
      {
        //   Console.WriteLine(firstName+ " " + lastName +"  pte staff");
         Console.WriteLine(" this is subclass");
      }
     }
       //  base clASS their father
    //  public class Employee
    public class parentclass
     {
        //  public string firstName;
        //  public string lastName;

    //   public void printfullname()
     // override with virtual here
     public  void printparentclass()
      {
        //   Console.WriteLine(firstName+ " " + lastName);
           Console.WriteLine( " this is a parent class ");
      }

    
     }

     
}
