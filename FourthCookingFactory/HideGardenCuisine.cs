using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourthModel.CuisineModel;

namespace FourthCookingFactory
{
    public class HideGardenCuisine: IBasicCookFactory
    {
        public BasicCuisine CreatedCuisine()
        {
            return new SichuanCuisineModel();
        }
    }
}
