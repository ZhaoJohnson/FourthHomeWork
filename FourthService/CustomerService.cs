﻿using FourthCooking;
using FourthInterface;
using FourthModel.BusinessModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourthModel;

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
                            CookingFactory.ConfigCookingFood(settingconfig.ToString());
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

        private void eat()
        {
        }
    }
}