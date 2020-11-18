
using System;
namespace Csharp.其他
{
    /*
            声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
               使用：
                 方法
                 匿名方法
                 lambda表达式
                 给上述委托赋值，并运行该委托
                 声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出*/
    public class Person
    {

        public int waternumber { get; set; } = 10;

        //大水
        public static int GetWater(ProvideWater provideWater)
        {
            Person person = new Person();
            return provideWater(person);
        }
        static int BigFriend(Person person)
        {
            Console.WriteLine("我是大朋友，我在打水");
            return person.waternumber += 3;
        }
        static int SmallFriend(Person person)
        {
            Console.WriteLine("我是小朋友，我在打水");
            return person.waternumber += 1;

        }
        //定义委托
        public delegate int ProvideWater(Person person);


        public static void ExecuteWeituo()
        {   
            //方法给委托赋值
            ProvideWater provideWater = new ProvideWater(BigFriend);
            Console.WriteLine(Person.GetWater(provideWater));
            ProvideWater provideWater1 = new ProvideWater(SmallFriend);
            Console.WriteLine(Person.GetWater(provideWater1));

            //匿名方法
            ProvideWater provideWater3 = delegate (Person person)
              {
                  Console.WriteLine("匿名方法");
                  return person.waternumber += 5;
              };
            Console.WriteLine(Person.GetWater(provideWater3));
            //lambda表达式

            ProvideWater provideWater4 =  (Person person)=>
            {
                Console.WriteLine("lambda表达式方法");
                return person.waternumber += 6;
            };
            Console.WriteLine(Person.GetWater(provideWater4));
        }
    }
}
