using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculator iphone = new Calculator();
            int[] numbers = new int[] { 1, 3, 19 };
            int result = iphone.Sum(numbers);
            Console.WriteLine(result);

            Person elsa = new Person()
            {
                Name = "Elsa",
                Pos = new Position()
                {
                    X = 0,
                    Y = 0
                },
                Angle = 0
            };

            for (int count = 0; count < 3; count++)
            {
                elsa.DrawSquare(100);
                elsa.TrueRight(120);
            }
        }
    }
}