using System;
using System.Text;

namespace Csharp.作业
{
    /// <summary>
    /// 
    /// </summary>
    public class Work
    {












        public  static void Login()
        {
            Console.WriteLine("请输入验证码");
            if (Console.ReadLine() != "1234")
            {
                Console.WriteLine("*验证码错误");
            }
            else
            {
                Console.WriteLine("请输入用户名");
                if (Console.ReadLine() != "zl")
                {
                    Console.WriteLine("用户名不存在");
                }
                else
                {
                    Console.WriteLine("请输入密码");
                    if (Console.ReadLine() != "123456")
                    {
                        Console.WriteLine("用户名或密码错误");

                    }
                    else
                    {
                        Console.WriteLine("恭喜！登录成功！");
                    }
                }
            }
        }
        // 4、实现 int GetCount(string container, string target)方法，可以统计出container中有多少个target
        public static int GetCount(string container, string target)
        {

            // 方法2 
            //return Regex.Matches(container, target).Count;

            int result = 0;
            while (container.Contains(target))
            {
                container = container.Substring(container.IndexOf(target) + target.Length);
                // Console.WriteLine(container);
                result += 1;
            }

            return result;
        }

        // 5、不使用string自带的Join()方法，定义一个mimicJoin()方法，能将若干字符串用指定的分隔符连接起来，
        //比如：mimicJoin("-", "a", "b", "c", "d")，其运行结果为：a - b - c - d*/

        public static string MimicJoin(string separator, string[] value)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                sb = sb.Append(value[i]);//a
                if (i != value.Length - 1)
                {
                    sb.Append(separator);
                }

            }
            return sb.ToString();


        }
    }
}
