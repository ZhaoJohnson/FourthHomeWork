using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourthWorkModel.DetailFood;

namespace FourthWorkModel.SimpleFactory
{
    public class PersonModel: OrderModel
    {
        /// <summary>
        /// 简单工厂
        /// 免除了直接创建菜品的责任
        /// 只要符合抽象产品制定的合同
        /// 那么只要通知工厂类知道就可以被客户使用了
        /// 对于产品部分来说，它是符合开闭原则的——对扩展开放、对修改关闭
        /// 但是工厂类不太理想，因为每增加一辆车，都要在工厂类中增加相应的商业逻辑和判 断逻辑，这显自然是违背开闭原则的
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public override GeneralFoodModel OrderFood(FoodType Type)
        {
            switch (Type )
            {
                case FoodType.ChairmanFavouriteofRoastMeat:
                    return CreatedChairmanFavouriteofRoastMeat();
                case FoodType.HotPepperOfFishHead:
                    return CreatedHotPepperFishHead();
                case FoodType.OverFryofFrog:
                    return CreatedOverFryofFrog();
                default:
                    throw new Exception("还没准备这道菜啊！！");
            }
        }

        public GeneralFoodModel CreatedChairmanFavouriteofRoastMeat()
        {
            return new ChairmanFavouriteofRoastMeat();
        }
        public GeneralFoodModel CreatedHotPepperFishHead()
        {
            return  new HotPepperFishHead();
        }
        public GeneralFoodModel CreatedOverFryofFrog()
        {
            return new OverFryofFrog();
        }
    }







}

