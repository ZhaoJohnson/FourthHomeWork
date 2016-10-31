using System;
using System.Collections.Generic;
using FourthCommon;
using FourthInterface;

namespace FourthModel.CuisineModel
{
    public class SichuanCuisineModel : BasicCuisine
    {
        public static Dictionary<int, BasicModel.FoodModel> SichuanCuisines { get; }

        static SichuanCuisineModel()
        {
            Type type = typeof(SichuanCuisineModel);
            SichuanCuisines = MyJsonHelper.Json2Object<Dictionary<int, BasicModel.FoodModel>>(type.Name);
        }

        public override Dictionary<int, BasicModel.FoodModel> privateCuisine { get; set; } = SichuanCuisines;
    }
}