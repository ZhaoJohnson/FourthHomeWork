using System;
using System.Collections.Generic;
using FourthCommon;

namespace FourthModel.CuisineModel
{
    public class HunanCuisineModel 
    {
        public static Dictionary<int, BasicModel.FoodModel> HuNaCuisines { get; }

        static HunanCuisineModel()
        {
            Type type = typeof(HunanCuisineModel);
            HuNaCuisines = MyJsonHelper.Json2Object<Dictionary<int, BasicModel.FoodModel>>(type.Name);
        }
    }
}