using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace лаб7
{
    class Department
    {
        int departmentID;
        string NameOfDepartment;
        public Department(int id, string name)
        {
            this.departmentID = id;
            this.NameOfDepartment = name;
        }
        public int property_1
        {
            get { return this.departmentID; }
            set { }
        }
        public override string ToString()
        {
            return ("\nDepartment ID= " + departmentID + "\nName of department " + NameOfDepartment);
        }
    }
}
