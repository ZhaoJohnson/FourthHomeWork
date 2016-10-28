using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthModel.BasicModel
{
    public class Food
    {
        /// <summary>
        /// 菜品Id
        /// </summary>
        public int FoodId { get; set; }

        /// <summary>
        /// 菜名
        /// </summary>
        public string FoodName { get; set; }

        /// <summary>
        /// 菜价
        /// </summary>
        public decimal FoodValue { get; set; }

        /// <summary>
        /// 菜品信息
        /// </summary>
        public string FoodInfo { get; set; }

        /// <summary>
        /// 制作配方
        /// </summary>
        public string FoodFormula { get; set; }

        /// <summary>
        /// 制作方式
        /// </summary>
        public string FoodCooking { get; set; }
    }
}