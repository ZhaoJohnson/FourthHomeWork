using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 抽象工厂模式适用于父类已经囊括了子类产品的一切
/// 缺点：如果需要增加新的属性，那么就要新增三个产品类，比如VolvoCar，VolvoSportCar,VolvoSportCar，并且要修改三个工厂类
/// </summary>
namespace FourthWorkModel.AbstractFactory
{
    public class VegetableFood : BasicModel
    {
    }

    public class MeatFood : BasicModel
    {
    }

    public class FruitJuice : BasicModel
    {
    }

    public abstract class RestaurantFactory
    {
        public abstract BasicModel GetFood();
    }

    public class VegetableFoodFactory : RestaurantFactory
    {
        public override BasicModel GetFood()
        {
            return new VegetableFood();
        }
    }

    public class MeatFoodFactory : RestaurantFactory
    {
        public override BasicModel GetFood()
        {
            return new MeatFood();
        }
    }

    public class FruitJuiceFactory : RestaurantFactory
    {
        public override BasicModel GetFood()
        {
            return new FruitJuice();
        }
    }
}