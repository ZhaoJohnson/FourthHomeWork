using FourthCommon;
using FourthModel;
using FourthModel.CuisineModel;
using FourthModel.Enum;
using FourthModel.FoodModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FourthCooking
{
    public class CookingSimpleFactory
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

        public static BasicCuisine ConfigCookingFood(SettingModel setting)
        {
            //var mysetting = MyXmlHelper.DeserializeXMLFileToObject<SettingModel>(setting, "XmlSetting");
            string objectName = setting.Cuisine + "CuisineModel";
            Assembly assembly = Assembly.Load(setting.Name);
            var cust = assembly.GetExportedTypes().First(p => p.Name == objectName);
            if(cust==null)throw new Exception("无法找到对应菜系");
            return (BasicCuisine)Activator.CreateInstance(cust);
        }
    }
}