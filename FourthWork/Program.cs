using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Menu.StarMenu();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}