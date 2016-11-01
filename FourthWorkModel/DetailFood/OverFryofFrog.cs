using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthWorkModel.DetailFood
{
    public class OverFryofFrog : GeneralFoodModel
    {
        public override void Cooking()
        {
            Console.WriteLine("正在制作"+this.FoodName+"。");
        }

        public override void Tasting()
        {
            Console.WriteLine("正在品尝" + this.FoodName + "。");
        }

        public override void Scoring()
        {
            Console.WriteLine("" + this.FoodName + "得到评分为："+ new Random().Next(50, 200));
        }
    }
}
