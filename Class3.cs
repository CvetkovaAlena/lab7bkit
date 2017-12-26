//DepMemLink
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace лаб7
{
    class DepMemLink
    {
        public int memberID;
        public int departmentID;
        public DepMemLink(int mID, int dID)
        {
            this.memberID = mID;
            this.departmentID = dID;
        }
    }
}
