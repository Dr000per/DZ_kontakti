using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NumCheck
    {
        public Boolean checknum(char e)
        {
            if (char.IsNumber(e) || e == '+' || e == '\b')
            {
                return true;
            }

            return false;

        }
    }
}
