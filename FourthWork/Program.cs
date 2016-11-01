using FourthCommon;
using FourthModel;
using FourthModel.BasicModel;
using FourthModel.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourthCooking;
using FourthModel.Enum;

namespace FourthWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {

                //var t= CookingFactory.EnumCookingFood(FoodType.GuangdongCuisine);

                SettingModel smodel = new SettingModel()
                {
                    Name = "demon",
                    Cuisine = "Guangdong",
                    ChoiceFood = new int[] { 1, 2 }
                };

                MyXmlHelper.Serializer(smodel, "SettingModel");
                Menu.StarMenu();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}