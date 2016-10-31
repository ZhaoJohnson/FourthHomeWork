using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourthInterface;

namespace FourthModel.CuisineModel
{
    public abstract class BasicCuisine :ICuisineModel
    {
      public abstract Dictionary<int, BasicModel.FoodModel> privateCuisine { get; set; }
    }
}
