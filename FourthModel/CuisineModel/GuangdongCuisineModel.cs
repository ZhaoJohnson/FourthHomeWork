using FourthModel.BasicModel;
using FourthModel.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FourthCommon;
using FourthInterface;
using FourthModel;
using FourthModel.CuisineModel;

namespace FourthModel.FoodModel
{
    public  class GuangdongCuisineModel : BasicCuisine
    {
        public static Dictionary<int, BasicModel.FoodModel> GuangDongCuisines { get;}

        static GuangdongCuisineModel()
        {
            Type type = typeof (GuangdongCuisineModel);
            GuangDongCuisines = MyJsonHelper.Json2Object<Dictionary<int, BasicModel.FoodModel>>(type.Name);
            
        }

        public override Dictionary<int, BasicModel.FoodModel> privateCuisine { get; set; } = GuangDongCuisines;
    }
}