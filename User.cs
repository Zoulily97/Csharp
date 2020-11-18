using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp
{
    //作业：
    //1、将之前User / Problem / HelpMoney类的字段封装成属性，其中：
    //  1、user.Password在类的外部只能改不能读
    //  2、如果user.Name为“admin”，输入时修改为“系统管理员”
    //  3、problem.Reward不能为负数
    //2、调用这些类的有参 / 无参构造函数，生成这些类的对象，调用他们的方法
    //3、一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
    //4、设计一种方式，保证：
    //  1、每一个Problem对象一定有Body赋值
    //  2、每一个User对象一定有Name和Password赋值

    //1、让User类无法被继承

    // 3、确保用户（User）的密码（Password）：
    //    长度不低于6
    //  必须由大小写英语字母、数字和特殊符号（~!@#$%^&*()_+）组成
   

    public sealed class User : Entity<int>, ISendMessage, IChat
    {

        private string name;
        private string _password;
        //private User invitesBy;
        public string Password
        {
            set
            {
                string Str = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz~!@#$%^&*()_+";

                if (_password.Length > 6)
                {
                    for (int i = 0; i < _password.Length; i++)
                    {
                        if (!Str.Contains(_password[i]))
                        {
                            Console.WriteLine("输入有误");
                            break;
                        }
                    }
                  
                    
                }
                else
                {
                    Console.WriteLine("输入有误");
                }
                _password = value;
            }


        }
        //  user.Password在类的外部只能改不能读
        public User InvitesBy { get; set; }
        //如果user.Name为“admin”，输入时修改为“系统管理员”

        // 2、设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词。
        public string Name
        {
           
            set
            {
                if (value.Contains("admin") || value.Contains("17bang") || value.Contains("管理员"))
                {
                    Console.WriteLine("你输入的名字有错误！");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                if (name=="admin")
                {
                    return "系统管理员";
                }
                else
                {
                    return name;
                }
                 
            }
        }
        public int HelpMoney { get; set; }
        public TokenManager Tokens { get; set; }

        public IList<Article> Article { get; set; }
        public User(string name, string password)  //有参构造函数//赋值
        {
            this.name = name;
            this.Password = password;
        }
        public User()
        {

        }

        public static void Register()
        {

        }
        public static void Login()
        {

        }


        void ISendMessage.Send()
        {
            throw new NotImplementedException();
        }

        void IChat.Send()
        {
            throw new NotImplementedException();
        }


    }
}
