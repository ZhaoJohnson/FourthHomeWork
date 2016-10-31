using FourthCommon;
using FourthModel.BasicModel;
using FourthModel.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //try
            //{
            //    Dictionary<int, FoodModel> foodDictionary = new Dictionary<int, FoodModel>();
            //    foodDictionary.Add(1, new FoodModel()
            //    {
            //        FoodId = 1,
            //        FoodName = "name",
            //        FoodCooking = "cook",
            //        FoodFormula = "Formula",
            //        FoodInfo = "info",
            //        FoodValue = 99
            //    });
            //    foodDictionary.Add(2, new FoodModel()
            //    {
            //        FoodId = 2,
            //        FoodName = "name2",
            //        FoodCooking = "cook2",
            //        FoodFormula = "Formula2",
            //        FoodInfo = "info2",
            //        FoodValue = 88
            //    });
            //    MyJsonHelper.Object2JsonFile(foodDictionary);

                Menu.StarMenu();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}