using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var someclass = new SomeClass();
            someclass.OneMethod1(2,3,new object[]{"DSf",344,3434L});
            var result=someclass.GetSomeNumbers();
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
    }
}
