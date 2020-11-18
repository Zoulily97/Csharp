using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    //考虑求助（Problem）的以下方法 / 属性，哪些适合实例，哪些适合静态，然后添加到类中：
    public class Problem : Content 
    {
        //标题 内容 作者 关键字
        //crtl+r+e
        private string body;
        private int reward;
        private DateTime publishDateTime;     
        public string Body { get; set ; }
        //  3、problem.Reward不能为负数
        public int Reward 
        { get => reward;
            set
            {
                if (value<0)
                {
                    Console.WriteLine("Reward不能为负数");
                }
                else
                {
                    reward = value;
                }
            }
        }   
        public DateTime PublishDateTime { get => publishDateTime; set => publishDateTime = value; }
        public Problem()
        {

        }

        public Problem(string body)
        {
            this.body = body;

        }
        public static  void  Load(int Id)//根据Id从数据库获取一条求助
        {
            Id++;
        }
        public static void Delete(int Id)//：根据Id删除某个求助
        {
            Id--;
        }

        [HelpMoneyChanged(5)]
        public override void Publish()
        {
            Author.HelpMoney -= Reward;//发布减少帮帮比
           
            Reward--;//需要消耗其设置悬赏数量的帮帮币
        }

        
    }
}
