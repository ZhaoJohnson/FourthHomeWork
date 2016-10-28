using FourthInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthModel.BusinessModel
{
    public class Customer
    {
        public Person MyPerson { get; set; }

        public event Action PersonDoing;
    }
}