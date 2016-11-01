using FourthModel.BusinessModel;
using FourthModel.CuisineModel;
using FourthModel.Enum;
using FourthModel.FoodModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourthModel.BasicModel;

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

        public List<Action> FactoryCooking(FoodType foodType)
        {
            IBasicCookFactory cookFactory;
            switch (foodType)
            {
                case FoodType.GuangdongCuisine:
                    cookFactory = new ThirdVictoryCuisine();
                    break;

                case FoodType.HunanCuisine:
                    cookFactory = new FireTempleCuisine();
                    break;

                case FoodType.SichuanCuisine:
                    cookFactory = new HideGardenCuisine();
                    break;
                default:
                    cookFactory = null;
                    break;
            }
            if (cookFactory == null) throw new Exception("找不到厨房");
            BasicCuisine cuisine = cookFactory.CreatedCuisine();
            return LoadFoodAction(cuisine);
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
            Console.WriteLine("选择完毕请输入：OK");
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

        private Action choiceFactory<TData>(int id)
              where TData : BasicCuisine, new()
        {
            BasicCuisine basic = new TData();
            var item = basic.privateCuisine[id];
            return () =>
            {
                Console.WriteLine("****************************************");
                Console.WriteLine($"{item.FoodName}菜品制作:{item.FoodCooking}");
                Console.WriteLine("****************************************");
            };
        }

        private List<Action> LoadFoodAction(BasicCuisine basicCuisine)
        {
            List<Action> resultList = new List<Action>();
            foreach (var pair in basicCuisine.privateCuisine.Values)
            {
                resultList.Add(() =>
                {
                    Console.WriteLine($"客人点的{pair.FoodName}已经被做好了");
                });
            }

            return resultList;
        }

    }
}