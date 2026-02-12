using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
//salary is the child class.if you create object for child class,you can access parent class variables and methods and child class variables and methods.
            Salary obj =new Salary();//by using class object we can access only non static varaibles and methods only
            obj.DislayManagerData();
            obj.EmployeeName = "vasu";
            obj.ca = 100;
            obj.bonous = 100;
            //if you want to access static variables and methods by using(classname.methodname)(classname.variablename)we can access.
            Salary.collegeName = "Jntuhyd";
            Salary.DisplayCollegeName();


            //*******************************************
// Employee obj1=new Employee();//we can't create object/instance for abstarct class,if you create object for abstarct class it will throw compiletime error.
//due to that always abstarct class is parent class,abstarct class inherit into child class and abastract methods implement in child class only by using override keyword with new method body.

      
        }
    }
}
