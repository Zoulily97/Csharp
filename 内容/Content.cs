using System;
using System.Reflection;
using System.Xml.Schema;

namespace Csharp
{
    // Article  //标题,内容，关键字，评论，作者，赞，踩
    //Problem   //标题 内容 作者 关键字
    //Suggest //标题,内容，作者，评论，赞，踩
    //2、观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）



    // 4、其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
    //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/ 踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
    //引入两个子类EmailMessage和DBMessage，和他们继承的接口ISendMessage（含Send()方法声明），用Console.WriteLine()实现Send()。
    //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。假设User类同时继承了ISendMessage和IChat，如何处理？
    public abstract class Content: Entity<int>
    {
        //kind 作者 标题 关键字 内容 赞 踩    
        private string _title;
        public string kind;
        private DateTime createTime;
        //3、一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        private string[] keyword = new string[10];
        public string this[int index]
        {
            get { return keyword[index]; }
            set { keyword[index] = value; }
        }
        public DateTime PublishTime { get; protected set; }

        public User Author { get; set; }
        //User Author { get; set; }

        //*1、确保文章（Article）的标题不能为null值，也不能为一个或多个空字符组成的字符串；
       // 而且如果标题前后有空格，将空格予以删除
        public string Title
        {
            get { return _title; }
            set
            {

                if (value.Contains(""))
                {
                    _title = value.Trim();

                }
                _title = value;

            }

        }
        public Content()//createTime赋值
        {
            createTime = DateTime.Now;
        }
        public virtual void Publish()
        {

        }
        public Content(string kind)
        {
            this.kind = kind;
        }
        /*之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，想一想他们应该在哪里赋值比较好，并完成相应代码
             在Content之外封装一个方法，可以修改Content的CreateTime和PublishTime
             自定义一个特性HelpMoneyChanged（帮帮币变化）：
             该特性只能用于方法
             有一个构造函数，可以接受一个int类型的参数amount，表示帮帮币变化的数量
             有一个string类型的Message属性，记录帮帮币变化的原因
             将HelpMoneyChanged应用于Publish()方法
             用反射获取Publish()上的特性实例，输出其中包含的信息*/
        public void UpdateCreateTime(Content content,DateTime dateTime)
        {
            typeof(Content).GetProperty(nameof(Content.createTime), BindingFlags.Public | BindingFlags.Instance)
                .SetValue(content, dateTime);
           

        }
        public void UpdatePublishTime(Content content, DateTime dateTime)
        {
            typeof(Content).GetProperty(nameof(Content.PublishTime), BindingFlags.Public | BindingFlags.Instance)
                .SetValue(content, dateTime);
        }


    }
}
