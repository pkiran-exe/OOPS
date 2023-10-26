using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Employee
    {
        //constructor---method with same name as that of class without any return type
        //default constructor
        public Employee()
        { }
        int _empid;
        string _ename;
        string _loc;

        //Parameterised constructor
        public Employee(int empid, string name)
        {
            _empid = empid;
            _ename = name;


        }

        //Parameterised Constructor
        public Employee(int empid, string name, string loc)
        {
            _empid = empid;
            _ename = name;
            _loc = loc;

        }

        //Read only property

        public dynamic Details
        {
            get
            {
                string d = _empid.ToString() + _ename + _loc;
                return d;
            }
        }

        public int Employeeid
        {
            get
            {
                return _empid;
            }
        }

        public string EmpName
        {
            get
            {
                return _ename;
            }
        }

        public string Location
        {
            get
            {
                return _loc;
            }

        }



    }
}