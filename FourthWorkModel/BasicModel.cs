using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthWorkModel
{
    public abstract class BasicModel
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

    public abstract class WorkingModel
    {
        public abstract void Cooking();
        public abstract void Tasting();
        public abstract void Scoring();
    }


    public abstract class GeneralFoodModel 
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
        public abstract void Cooking();
        public abstract void Tasting();
        public abstract void Scoring();

    }

    public abstract class OrderModel
    {
        public abstract GeneralFoodModel OrderFood(FoodType Type);
    }

    public enum FoodType
    {
        ChairmanFavouriteofRoastMeat=1,
        HotPepperOfFishHead=2,
        OverFryofFrog=3
    }
}
