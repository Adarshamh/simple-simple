using System;
using System.Diagnostics.CodeAnalysis;
using sample1;


namespace externalMethods
{
    public class class1
    {
        static void Main(string[] args)
        {
            //Instantiated class1 and named it as constructorClass
            Class1 constructorClass = new Class1();

            //here we call method printOut() 
            constructorClass.printOut("Adarsh");
            constructorClass.printOut(26);
            constructorClass.printOut();
        }
      
    }
}