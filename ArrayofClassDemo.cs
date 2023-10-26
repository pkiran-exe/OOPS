using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class ArrayOfClassDemo
    {
        static void Main(string[] args)
        {
            Laptop[] laptops = new Laptop[2];//Array object
            laptops[0] = new Laptop();
            laptops[0].RAM = 8;
            laptops[0].HardDisk = 212;
            laptops[0].Processor = "Intel 5";
            laptops[0].FingerSensor = true;
            laptops[0].Price = 70000;

            laptops[1] = new Laptop();
            laptops[1].RAM = 16;
            laptops[1].HardDisk = 512;
            laptops[1].Processor = "Core 7";
            laptops[1].FingerSensor = true;
            laptops[1].Price = 90000;
            foreach (var item in laptops)
            {
                Console.WriteLine(item.RAM);
                Console.WriteLine(item.HardDisk);
                Console.WriteLine(item.FingerSensor);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Processor);
                Console.WriteLine("--------------------------");

            }


            Console.ReadLine();
        }
    }
}