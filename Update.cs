using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    class Update
    {
        private string memberIC;
        public string MemberIC { get => memberIC; set => memberIC = value;  }

        public Update(string IC)
        {
            this.MemberIC = IC;
            return;
        }
    }
}
