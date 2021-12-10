using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CafedraA
    {
        public int GetAllStudents(int girlCount, int menCount)
        {
            int result = Mathematic.Sum(girlCount, menCount);
            return result;
        }
    }
}
