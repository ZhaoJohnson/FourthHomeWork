using FourthCommon;
using FourthModel;
using FourthModel.CuisineModel;
using FourthModel.Enum;
using FourthModel.FoodModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FourthCooking
{
    public class CookingFactory
    {
        public static BasicCuisine EnumCookingFood(FoodType foodType)
        {
            switch (foodType)
            {
                case FoodType.GuangdongCuisine:
                    return new GuangdongCuisineModel();

                case FoodType.HunanCuisine:
                    return new HunanCuisineModel();

                case FoodType.SichuanCuisine:
                    return new SichuanCuisineModel();

                default:
                    throw new Exception("没有这个菜系");
            }
        }

        public static BasicCuisine ConfigCookingFood()
        {
            AppSettingsReader configRead = new AppSettingsReader();
            var settingconfig = configRead.GetValue("SettingXml", typeof(string));
            var Mysetting = MyXmlHelper.Deserialize<SettingModel>(settingconfig.ToString());
            string objectName = Mysetting.Cuisine + "CuisineModel";
            Assembly assembly = Assembly.Load(objectName);
            Type type = assembly.GetType();
            return (BasicCuisine)Activator.CreateInstance(type);
        }
    }
}