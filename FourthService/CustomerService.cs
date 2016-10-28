using FourthInterface;
using FourthModel.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthService
{
    public class CustomerService<TCustomerModel> : ICustomer, ICooking, IOrder
        where TCustomerModel : Customer
    {
        public void Cooking()
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Order()
        {
            throw new NotImplementedException();
        }
    }
}