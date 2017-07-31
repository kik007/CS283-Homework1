using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolPCLibrary;
using Empolyee;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Product a = new Product();
            //a.Price = 3300f;
            //Product b = new Product();
            //b.Price = 45.0f;
            //Console.WriteLine("修改前");
            //Console.WriteLine("a.id = {0},a.Price = {1}", a.Id, a.GetPrice());
            //Console.WriteLine("b.id = {0},b.Price = {1}", b.Id, b.GetPrice());

            //Product b = a;
            //b.Price = 45.0f;
            //Console.WriteLine("修改後");
            //Console.WriteLine("a.Price = {0}", a.GetPrice());
            //Console.WriteLine("b.Price = {0}", b.GetPrice());

            Emp c = new Emp();
            Console.WriteLine("請輸入基本工資");
            c.BaseSalary = Int32.Parse(Console.ReadLine());
            Console.WriteLine("請輸入獎金");
            c.Benfit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("員工編號:{0} 實際薪資 = {1}", c.Empid, c.Salary);
        }
    }
}