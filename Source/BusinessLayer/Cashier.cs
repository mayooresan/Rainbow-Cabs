using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class Cashier
    {
        private int EmpID;
        private String Name;
        private String NIC;

        

        //getter setter for empID
        public int empid
        {
            get { return EmpID; }
            set { EmpID = value; }
        }

        //getter setter for Name
        public String name
        {
            get { return Name; }
            set { Name = value; }
        }

        //getter setter for NIC
        public String nic
        {
            get { return NIC; }
            set { NIC = value; }
        }

    }
}
