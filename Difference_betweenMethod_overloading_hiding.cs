/***
Method overloading 

1.In method overriding, 
you need to define the method of a parent class as a virtual method using virtual keyword and the method of child class as an overridden method using 
override keyword.
2. It only redefines the implementation of the method.
3.Here overriding is an object type.
4.If you do not use override keyword, then the compiler will not override the method. Instead of the overriding compiler will hide the method.
5.In method overriding, when base class reference variable pointing to the object of the derived class,
then it will call the overridden method in the derived class.

Method Hiding
1.In method hiding, you just simply create a method in a parent class and in child class you need to define that method using new keyword.
2.In method hiding, you can completely redefine the method.
3.Here hiding is a reference type.
4.if you do not use the new keyword, then the compiler will automatically hide the method of the base class.
5.In the method hiding, when base class reference variable pointing to the object of the derived class,
then it will call the hidden method in the base class.


****/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpProject
{
 
    public class child : over
    {
        public override void printi()
        {
            Console.WriteLine("Hello, World!");
        }
        public  void hide()
        {
            Console.WriteLine("child class hiding!");
        }
    }
    public class over 
    {
        public virtual void printi()
        {
            Console.WriteLine("Hello, parent");
        }
        public void hide()
        {
            Console.WriteLine("parent base hide ");
        }
    }

    public class overrideandhiding
    {
       public static void Main() 
        {
            over child = new child(); //vice versa is not possible 
            //child parent=new over(); -- not possible

            child.printi();
            child.hide();
            child c=new child();
            ((over)c).hide();
            //(c(over)).hide(); typecasting parent to child class is not possible

            //ways to call base  class method in method hiding 
            //1. child.hide();
            //2. typecasting the child class to parent class     ((over)c).hide();
            //3. using base keyword in child class link invoking   base.hide()  in child class 

            //Note you can only typecast child class as child class is a perfect replacement for parent class 
            // 

        }


    }
}
