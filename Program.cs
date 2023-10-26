using OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop hp = new Laptop();
            hp.RAM = 8;
            hp.HardDisk = 212;
            hp.Processor = "Intel3";
            hp.FingerSensor = false;
            hp.Price = 70000;
            Console.WriteLine("Hp configuration");
            Console.WriteLine(hp.RAM);
            Console.WriteLine(hp.HardDisk);
            Console.WriteLine(hp.Processor);
            Console.WriteLine(hp.Price);
            Console.WriteLine(hp.FingerSensor);
            Console.WriteLine("---------");
            Laptop Dell = new Laptop();
            Dell.RAM = 16;
            Dell.HardDisk = 512;
            //reference types only can be assigned a null
            Dell.Processor = "core 5";
            //Dell.Processor = null;
            Dell.FingerSensor = true;
            Dell.Price = 80000;
            Console.WriteLine("Dell configuration");
            Console.WriteLine(Dell.RAM);
            Console.WriteLine(Dell.HardDisk);
            Console.WriteLine(Dell.Processor);
            Console.WriteLine(Dell.FingerSensor);
            Console.WriteLine(Dell.Price);
            Console.ReadLine();
        }
    }
}