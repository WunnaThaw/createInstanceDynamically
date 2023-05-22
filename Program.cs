using System;

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("MyClass constructor is invoked");
    }
}

class Program
{
    static void Main()
    {
        //Console.WriteLine("Enter the class name:");
        //string className = Console.ReadLine();

        string className = "MyClass";

        Type classType = Type.GetType(className)!;

        if (classType != null)
        {
            object instance = Activator.CreateInstance(classType)!;
            Console.WriteLine("Instance of {0} created", instance?.GetType().Name);
        }
        else
        {
            Console.WriteLine("Invalid class name");
        }

        Console.ReadKey();
    }
}
