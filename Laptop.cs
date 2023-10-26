using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Laptop
    {
        private int _ram;

        public int RAM
        {
            get { return _ram; }
            set { _ram = value; }
        }

        private DateTime _mfgDate;

        public DateTime MfgDate
        {
            get { return _mfgDate; }
            set { _mfgDate = value; }
        }

        private bool _fingerSensor;

        public bool FingerSensor
        {
            get { return _fingerSensor; }
            set { _fingerSensor = value; }
        }



        //propfull tab tab
        private Nullable<decimal> _price;//(down arrow key)
                                         //(tab)
        public Nullable<decimal> Price
        {
            get
            {
                if (_price == 0)
                {
                    Console.WriteLine("Price is 0");
                    return 0;
                }
                else
                    return _price;
            }
            set
            {
                if (value > 0)
                    _price = value;
                else
                    Console.WriteLine("Not a valid value");
            }
        }
        int _hd;
        public int HardDisk
        {
            set
            {
                if (value > 0)
                {
                    _hd = value;
                }
                else
                {
                    Console.WriteLine("not a valid value");
                }

            }
            get { return _hd; }
        }

        string _processor;
        public string Processor
        {
            set
            {
                if (value != null)
                {
                    _processor = value;
                }
                else
                {
                    Console.WriteLine("not a valid value");
                }
            }
            get { return _processor; }
        }





    }
}