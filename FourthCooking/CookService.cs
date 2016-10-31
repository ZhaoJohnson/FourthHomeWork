using FourthModel.BusinessModel;
using FourthModel.CuisineModel;
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
        private static bool IsChoice = true;

        static CookService()
        {
        }

        public static CookService CookFactory()
        {
            return _CookService;
        }

        public List<Action> GeneralCooking(FoodType foodType)
        {
            List<Action> listresult = new List<Action>();
            Action result;
            switch (foodType)
            {
                case FoodType.GuangdongCuisine:
                    do
                    {
                        showList<GuangdongCuisineModel>();
                        string intX = Console.ReadLine();
                        int intY;
                        if (int.TryParse(intX, out intY))
                        {
                            listresult.Add(choiceCuisine<GuangdongCuisineModel>(intY));
                            Console.WriteLine("选择成功");
                        }
                        if (intX.ToUpper() == "OK")
                        {
                            IsChoice = false;
                        }
                    } while (IsChoice);
                    break;

                case FoodType.HunanCuisine:
                    result = () =>
                    {
                        showList<HunanCuisineModel>();
                    };
                    break;

                case FoodType.SichuanCuisine:
                    result = () =>
                    {
                        showList<SichuanCuisineModel>();
                    };
                    break;

                default:
                    result = null;
                    break;
            }
            return listresult;
        }

        private void showList<TData>()
            where TData : BasicCuisine, new()
        {
            TData data = new TData();
            foreach (var item in data.privateCuisine.Values)
            {
                Console.WriteLine("***************菜单信息*****************");
                Console.WriteLine($"编号:{item.FoodId}：菜名{item.FoodName}");
                Console.WriteLine("****************************************");
                Console.WriteLine($"菜品介绍:{item.FoodInfo}");
                Console.WriteLine($"菜品价格:￥{item.FoodValue}");
                Console.WriteLine("****************************************");
            }
        }

        private Action choiceCuisine<TData>(int id)
            where TData : BasicCuisine, new()
        {
            TData data = new TData();
            var item = data.privateCuisine[id];
            return () =>
            {
                Console.WriteLine("****************************************");
                Console.WriteLine($"{item.FoodName}菜品制作:{item.FoodCooking}");
                Console.WriteLine("****************************************");
            };
        }
    }
}