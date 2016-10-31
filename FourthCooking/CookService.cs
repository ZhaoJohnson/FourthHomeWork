using FourthModel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourthModel.CuisineModel;
using FourthModel.FoodModel;

namespace FourthCooking
{
    public sealed class CookService
    {
        private static CookService _CookService = new CookService();

        static CookService()
        {
        }

        public static CookService CookFactory()
        {
            return _CookService;
        }

        public Action GeneralCooking(FoodType foodType)
        {
            Action result;
            switch (foodType)
            {
                case FoodType.GuangdongCuisine:
                    result = () =>
                    {
                        showList<GuangdongCuisineModel>();
                    };
                    break;

                case FoodType.HunanCuisine:
                    result = () =>
                    {
                        Console.WriteLine();
                        HunanCuisineModel hnCuisine = new HunanCuisineModel();
                    };
                    break;

                case FoodType.SichuanCuisine:
                    result = () =>
                    {
                        Console.WriteLine();
                        SichuanCuisineModel scCuisine = new SichuanCuisineModel();
                    };
                    break;

                default:
                    result = null;
                    break;
            }
            return result;
        }

        private void showList<TData>()
            where TData: BasicCuisine,new ()
        {
            TData date=new TData();
            foreach (var item in date.privateCuisine.Values)
            {
                Console.WriteLine($"编号:{item.FoodId}：菜名{item.FoodName}");
            }
        }
    }
}