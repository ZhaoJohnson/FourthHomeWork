using FourthCooking;
using FourthInterface;
using FourthModel.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthService
{
    public class CustomerService : ICustomer, ICooking, IOrder

    {
        public void Cooking(int i)
        {
            CookService cook = new CookService();
            switch (i)
            {
                default:
                    break;
            }
        }

        public void Dispose()
        {
        }

        public void Order()
        {
        }

        private void eat()
        {
        }
    }
}