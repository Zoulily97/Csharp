using Csharp.文章;
using System;
using System.Collections.Generic;

namespace Csharp
{

    //3、实例化文章和意见建议，调用他们：
    // 1、继承自父类的属性和方法
    // 2、自己的属性和方法
    public class Article : Content, IAgree
    {
        //标题,内容，关键字，评论，作者，赞，踩
        private string[] comments;
        public string[] Comments { get => comments; set => comments = value; }

        //一篇文章可以有多个评论
        public IList<Comment> Comment { get; set; }
        // 每个文章和评论都有一个评价
        public IList<Appraise> Appraise { get; set; }
        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
        public IList<Keyword> Keyword { get; set; }
        // public User Author { get; set; }
        public void Agree(User voter)
        {
            voter.HelpMoney++;
            //   Author.HelpMoney++;
            //点赞数量++
        }

        public override void Publish()
        {
            PublishTime = DateTime.Now;
            //Console.WriteLine("需要消耗一个帮帮币");
        }
        public void Search(string keword)
        {

        }
        //public Article(string title)
        //{
        //    this.Title=title;
        //}


    }
}
