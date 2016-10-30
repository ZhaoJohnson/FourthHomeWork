using FourthModel.Enum;
using FourthModel.FoodModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        Console.WriteLine();
                        GuangdongCuisineModel gdCuisine = new GuangdongCuisineModel();
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
    }
}