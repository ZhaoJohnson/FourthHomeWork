using FourthCooking;
using FourthModel.BusinessModel;
using FourthModel.Enum;
using FourthService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FourthWork
{
    public static class Menu
    {
        private static string x;

        /// <summary>
        /// 菜单的可选菜用配置文件生成
        /// </summary>
        public static void StarMenu()
        {
            Console.WriteLine("程序进行加载中请稍后………………………………");
            CustomerService cService = new CustomerService();

            do
            {
                Console.WriteLine("欢迎使用xx系统");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1.学习做菜");
                Console.WriteLine("2.简单工厂实现客人点菜");
                Console.WriteLine("3.工厂方法实现客人点菜");
                Console.WriteLine("4.抽象工厂,每个工厂都能做三个菜");
                Console.WriteLine("5.点菜系统，用单例模式生成菜单");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("请选择:");
                int type = IsMenu(Console.ReadLine());
                switch (type)
                {
                    case 1:
                        var cookAction = cService.Cooking();
                        CustomerModel customer = new CustomerModel();
                        foreach (Action item in cookAction)
                        {
                            customer.PersonDoing += item;
                        }
                        customer.WorkMyJobs();
                        Console.WriteLine("学习做菜完毕");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("简单工厂实现客人点菜");
                        CustomerModel customerOrder = new CustomerModel();
                        foreach (Action item in cService.Order())
                        {
                            customerOrder.PersonDoing += item;
                        }
                        customerOrder.WorkMyJobs();
                        Console.WriteLine("简单工厂点菜完毕");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("工厂方法实现客人点菜");
                        Console.WriteLine("工厂实现客人点菜");
                        CustomerModel customerFactory = new CustomerModel();
                        foreach (Action item in cService.FactoryOrder())
                        {
                            customerFactory.PersonDoing += item;
                        }
                        customerFactory.WorkMyJobs();
                        Console.WriteLine("工厂点菜完毕");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("抽象工厂,每个工厂都能做三个菜");
                        break;

                    case 5:
                        Console.WriteLine("点菜系统，用单例模式生成菜单");
                        break;

                    default:
                        Console.WriteLine("按任意键重新选择");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (true);
        }

        private static int IsMenu(string str)
        {
            int result;
            if (str.Length == 0) return 0;
            if (int.TryParse(str, out result))
            {
                return result;
            }

            return 0;
        }
    }
}