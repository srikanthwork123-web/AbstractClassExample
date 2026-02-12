using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    internal class Salary : Employee  //abstarct class is always base class.this is the rule.
    {
        // public abstarct void DislayManagerData();//this is abstact classs,abstact method
        //public override void DislayManagerData()//by default if you implement it will come like this way
        //{
        //    throw new NotImplementedException();
        //}
        //To implement the abstarct method in the child class.you must use "override" keyword.
        public override void DislayManagerData()
        {
            Console.WriteLine("I am overirde method for abstact class");
        }
    }
}
/*
 Abstract function/Method:
A function/method which contains only method Heading but not method body  is known as abstract function/method.
To make any function/method as abstract we use keyword "abstract” keyword. 
If you inherit abstact class to derived class ,Overriding is compulsory for abstract function in child class.
*/