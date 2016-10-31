using System;
using System.Collections.Generic;
using FourthCommon;

namespace FourthModel.CuisineModel
{
    public class SichuanCuisineModel 
    {
        public static Dictionary<int, BasicModel.FoodModel> SichuanCuisines { get; }

        static SichuanCuisineModel()
        {
            Type type = typeof(SichuanCuisineModel);
            SichuanCuisines = MyJsonHelper.Json2Object<Dictionary<int, BasicModel.FoodModel>>(type.Name);
        }
    }
}