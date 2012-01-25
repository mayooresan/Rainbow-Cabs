using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Driver
    {
        private String GoogleID = "579295285979160295";
        private String Name;
        private String NIC;
        private int EmpID;

        public int getEmpID()
        {
            return EmpID;
        }

        public void setEmpID(int empid)
        {
            EmpID = empid;
        }

        //getter method for GoogleID
        public String getGoogleID()
        {
           return this.GoogleID;
        }
        //setter method for GoogleID
        public void setGoogleID(String Googleid)
        {
            GoogleID = Googleid;
        }

        //getter method for Name
        public String getName()
        {
            return Name;
        }
        //setter method for Name
        public void setName(String name)
        {
            Name = name;
        }
        //NIC getter
        public String getNIC()
        {
            return NIC;
        }
        //NIC setter
        public void setNIC(String nic)
        {
            NIC = nic;
        }
            
    }
}
