using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass() { change = "не изменено" };
            MyStruct myStruct = new MyStruct() { change = "не изменено" };
            Console.WriteLine( $"myClass.change - {myClass.change}\nmyStruct.change - {myStruct.change}");

            ClassTaker(myClass);
            StruktTaker(myStruct);


            Console.WriteLine($"myClass.change - {myClass.change}\nmyStruct.change - {myStruct.change}");
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
