using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BNTN_Ass02_Opt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserAction user = new UserAction();
            user.Perform();
            ReadLine();
        }
    }
}
