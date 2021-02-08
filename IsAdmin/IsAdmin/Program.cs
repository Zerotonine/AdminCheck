using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IsAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            if(admin())
                Console.WriteLine("Herzlich Willkommen Chef!");
            else
                Console.WriteLine("Ey du nix Admin! Du kommst hier net rein!");


            Console.ReadKey();
        }

        static bool admin()
        {
            WindowsPrincipal wp = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            return wp.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
