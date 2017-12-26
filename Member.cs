//members

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace лаб7
{
    public class Member : IComparable
    {
        public int memberID;
        public string surname;
        public int departmentID;
        public Member(int m, string s, int d)
        {
            memberID = m;
            surname = s;
            departmentID = d;
        }
        public override string ToString()
        {
            return ("\nMember ID= " + memberID + "\nSurname="+surname+"\nDepartment ID = "+departmentID );
        }
        public int CompareTo(object a)
        {
            Member p = (Member)a;
            if (p.departmentID > this.departmentID) return -1;
            else if (p.departmentID < this.departmentID) return 1;
            else return 0;
        }
    }
}