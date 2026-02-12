using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    //If you want to create any class as abstarct class,class before use abstract keyword.
    //In normal class whaterver you are perfomr all the things you can do in abstarct class also.
    //here abstarct class we just add abstact methods,abstact properties....create for future implemetation
    //
    public abstract class Employee
    {//at a time if you want to create 2 varaibles with same datatype..you can go with below process
        protected int eid, eage;//2 varaiables declared(but value not assigned to these variables)
        protected string ename, eaddress;//2 varaiables declared(but value not assigned to these variables)
        public double bonous, ca;//2 varaiables declared(but value not assigned to these variables)
        public static string collegeName;//In abstarct class we can also create static variables
        private string employeeName;//In abstarct class we can also create non static variables
        public string EmployeeName //In abstarct class we can create properties also.
        {
            get {  return employeeName; }
            set { employeeName = value; }
        }
        public Employee()//In abstarct class we can create norm constructor  also.
        {//normal construtor usage is assign the data to non static variables
            eid = 10;
            ename = "sachin";
        }
        //public static Employee(int a)//static constructor not allowed accessmodifiers and parameters.if you write it wll throw compiletime error.
        //{
        //    collegeName = "JNTU";
        //}
        static Employee()//In abstarct class we can create static constructor  also.
        {//static  construtor usage is assign the data to  static variables
            collegeName = "JNTU";//in static constuctor we can assign the data for sttaic variables only.
          //  employeeName = "vasu";//you can't assign the data to non static variables in satic constructor.it will throw error
        }
        public abstract void DislayManagerData();//this is abstarctmethod,it conatins only method heading(or)method declartion.it doesnot conatin method body.
        public static void DisplayCollegeName()//this is Static method,it contains method heading+methodbody
        {
            //only static constructor doesnot having accessmodfiers and parameters.if you apply parameters and accessmodifiers it will throw compiletime error.
            Console.WriteLine(collegeName);
        }
        //public  abstract void DisplayCollegeName(int a)//static memebres can't marked as abstarct,it will throw error.
        //{
        //    //abstact method doesnot conatin method body,if you create method body,it will throw compiletime error.
        //    Console.WriteLine(collegeName);
        //}
        public void GetEmpDetails()//this is normal method,it contains method heading+methodbody
        {
            Console.WriteLine("enter employee id details");
            eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ename");
            ename = Console.ReadLine();
            Console.WriteLine("bonous is");
            bonous = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter CA");
            ca = Convert.ToDouble(Console.ReadLine());
        }
    }
}


/*
 * A class which contains one or more abstract function or non-abstract functions is known as abstract class.
* To make any class as abstract use abstract keyword
* It is compulsory to create new derived class from abstract class.
* Abstract METHODS contains only method heading but not method body
* Abstract METHOD Tells “what to do” In Future,if you want you can implement in child class.
* It contain both abstract and non-abstract function/Method
* We can’t declare static methods as abstract method but inside a abstract class we can declare static method (non abstract method)
* Abstract class always acts like a base class.
 *In one abstact class writing atleast one abstarct method is optional.
 *if you are not writing any one abstarct method abstact class will not throw any error.
 *
 *
 */