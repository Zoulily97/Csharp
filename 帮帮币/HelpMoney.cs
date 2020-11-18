using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    //作业：
    //观察“一起帮”的：
    //注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
    //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
    //为这些类的字段和方法设置合适的访问修饰符
    public class HelpMoney : Entity<int>
    {
        private DateTime time;
        private int availableNum;
        private int frozenNum;
        private string moneytype;
        public  int helpmoney;
        
        public int AvailableNum { get => availableNum; set => availableNum = value; }//可用数量
       
        public int FrozenNum { get => frozenNum; set => frozenNum = value; }//冻结数量
     
        public string Moneytype { get => moneytype; set => moneytype = value; }//帮帮币种类
        public DateTime Time { get => time; set => time = value; }
        // public int Helpmoney { get => helpmoney; set => helpmoney = value; }
    }
}
