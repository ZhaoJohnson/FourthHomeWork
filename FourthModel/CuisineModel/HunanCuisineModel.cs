using System;
using System.Collections.Generic;
using FourthCommon;
using FourthInterface;

namespace FourthModel.CuisineModel
{
    public class HunanCuisineModel : BasicCuisine
    {
        public static Dictionary<int, BasicModel.FoodModel> HuNaCuisines { get; }

        static HunanCuisineModel()
        {
            Type type = typeof(HunanCuisineModel);
            HuNaCuisines = MyJsonHelper.Json2Object<Dictionary<int, BasicModel.FoodModel>>(type.Name);
        }

        public override Dictionary<int, BasicModel.FoodModel> privateCuisine { get; set; } = HuNaCuisines;
    }
}