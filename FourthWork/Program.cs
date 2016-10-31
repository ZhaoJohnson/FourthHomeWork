using FourthCommon;
using FourthModel;
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
            try
            {
                SettingModel smodel = new SettingModel()
                {
                    Name = "demon",
                    Cuisine = "Guangdong",
                    ChoiceFood = new int[] { 1, 2 }
                };

                MyXmlHelper.Serializer(smodel, "SettingModel");
                Menu.StarMenu();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}