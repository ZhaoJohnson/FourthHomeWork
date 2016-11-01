using FourthCooking;
using FourthInterface;
using FourthModel.BusinessModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourthCommon;
using FourthModel;
using FourthModel.Enum;

namespace FourthService
{
    public class CustomerService : ICustomer, ICooking, IOrder
    {
        private static bool isCook = true;

        public List<Action> Cooking()
        {
            CookService cook = new CookService();
            List<Action> listResult = new List<Action>();
            do
            {
                Console.WriteLine("请选择1：粤菜");
                Console.WriteLine("请选择2：湘菜");
                Console.WriteLine("请选择3：川菜");
                Console.WriteLine("请选择0：退出");
                string stri = Console.ReadLine();
                int i;
                if (int.TryParse(stri, out i))
                {
                    switch (i)
                    {
                        case 1:
                            listResult = cook.GeneralCooking(FourthModel.Enum.FoodType.GuangdongCuisine);
                            break;

                        case 0:
                            isCook = false;
                            break;
                    }
                }
            } while (isCook);
            return listResult;
        }

        public void Dispose()
        {
        }

        public List<Action> Order()
        {
            AppSettingsReader configRead = new AppSettingsReader();
            var settingconfig = configRead.GetValue("SettingXml", typeof(string));
            var mysetting = MyXmlHelper.DeserializeXMLFileToObject<SettingModel>(settingconfig.ToString(), "XmlSetting");
            List<Action> listResult = new List<Action>();
            listResult.Add(() =>
            {
                Console.WriteLine($"顾客点了以下菜品：");
            });
            var foodBase = CookingSimpleFactory.ConfigCookingFood(mysetting);
            int y = 1;
            foreach (int i in mysetting.ChoiceFood)
            {
                int no = y;
                var getFood = foodBase.privateCuisine[i];
                listResult.Add(() =>
                {
                    Console.WriteLine($"序号：{no} 菜名：{getFood.FoodName} 价格：{getFood.FoodValue}");
                });
                y++;
            }

            return listResult;
        }

        public List<Action> FactoryOrder()
        {
            List<Action> listResult = new List<Action>();
            CookService cook = new CookService();
            Console.WriteLine("请选择1：炳胜——餐厅");
            Console.WriteLine("请选择2：火宫殿");
            Console.WriteLine("请选择3：隐园——餐厅");
            Console.WriteLine("请选择0：退出");
            string stri = Console.ReadLine();
            int i;
            if (int.TryParse(stri, out i))
            {
                switch (i)
                {
                    case 1:
                        listResult = cook.FactoryCooking(FoodType.GuangdongCuisine);
                        break;
                    case 2:
                        listResult = cook.FactoryCooking(FoodType.HunanCuisine);
                        break;
                    case 3:
                        listResult = cook.FactoryCooking(FoodType.SichuanCuisine);
                        break;
                    case 0:
                        isCook = false;
                        break;
                }
            }

            return listResult;
        }

        private void eat()
        {
        }
    }
}