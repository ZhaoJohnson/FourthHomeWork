using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthCooking
{
    public sealed class CookService
    {
        private static CookService _CookService = new CookService();

        static CookService()
        {
        }

        public static CookService CookFactory()
        {
            return _CookService;
        }
    }
}