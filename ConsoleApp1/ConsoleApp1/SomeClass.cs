using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// My super dupper class.
    /// </summary>
    public class SomeClass
    {
        public void OneMethod1(int x, double y, object[] mass)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            var result = x + y + mass.Length;
            Console.WriteLine(result);
            foreach (var massObject in mass)
            {
                Console.WriteLine(massObject);
            }
        }

        public IEnumerable<int> GetSomeNumbers()
        {
            return GetListOfNumbers();
        }

        private readonly Random _random=new Random();

        private IEnumerable<int> GetListOfNumbers()
        {
            for(int i=0;i<10;i++)
                yield return _random.Next(100);
        }
    }
}
