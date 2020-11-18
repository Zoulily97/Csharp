using Csharp.其他;
using Csharp.文章;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {



            //C# 单元测试 双向链表
            #region
            /*作业：为之前作业添加单元测试，包括但不限于：
                     数组中找到最大值
                     找到100以内的所有质数
                     猜数字游戏
                     二分查找
                     栈的压入弹出
                     继续完成双向链表的测试和开发，实现：
                     node3.InsertAfter(node1); 场景
                     InerstBefore()：在某个节点前插入
                      Delete()：删除某个节点
                     [选] Swap()：交互某两个节点
                     [选] FindBy()：根据节点值查找到某个节点
            */
            #endregion

            //泛型：声明/使用/约束/继承
            #region
            /*作业：
             改造Entity类，让其Id可以为任意类型
             用泛型改造二分查找、堆栈和双向链表
             用泛型改造“取数组中最大值”（提示：IComparable）
             用代码演示泛型接口的协变/逆变*/
            int[] seek = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            Console.WriteLine(SomeArray.BinarySeek1(seek, 17));
            //MimicStack<object> mimicStack1 = new MimicStack<object>();
            // mimicStack1.Push(1);
            // mimicStack1.Push("1234");
            // mimicStack1.Push("中国");
            // mimicStack1.Push('@');
            // mimicStack1.Push(5);
            // //  mimicStack1.Push(6);//溢出
            // mimicStack1.Pop();
            // mimicStack1.Pop();
            // mimicStack1.Pop();
            // mimicStack1.Pop();
            // mimicStack1.Pop();
            // mimicStack1.Pop();
            //int[] seek1 = { 1, 11, 13, 15, 17, 193, 5, 7, 10};
            //Console.WriteLine( SomeArray<int>.getMaxArray(seek1));

            // 生成对应的Node节点
            DoubleLinked<object> d1 = new DoubleLinked<object>();
            DoubleLinked<object> d2= new DoubleLinked<object>();
            DoubleLinked<object> d3 = new DoubleLinked<object>();
            DoubleLinked<object> d4 = new DoubleLinked<object>();
            DoubleLinked<object> d5 = new DoubleLinked<object>();
            //构造节点内容
            d1.value = "123";
            d2.value = 234;
            d3.value = "lw";
            d4.value = 999;
            d5.value = "语言";
            //链接节点
            d1.AddAfter(d2);
            d2.AddAfter(d3);
            d3.AddAfter(d4);
            d4.AddAfter(d5);






           
        




            #endregion

            // 集合：List / Dictionary ……
            #region
            /*
             * 在现有作业的基础上，观察一起帮的文章板块，以此为蓝本，补充（如果还没有的话）声明：
               评论（Comment）类
               评价（Appraise）类：包括“赞（Agree）”和“踩（Disagree）”
                关键字（Keyword）类
            并构建以下关系：
               一篇文章可以有多个评论
               一个评论必须有一个它所评论的文章
                每个文章和评论都有一个评价
               一篇文章可以有多个关键字，一个关键字可以对应多篇文章

             */
            #endregion

            //git
            #region
            /* 作业：
           使用VS git完成：
             1、新建两个分支，如：hotfix和t1
             2、切换到hotfix，在hotfix上进行若干提交
             3、修改hotfix上再上一次的提交后重新提交
             4、讲hotfix上的修改合并到master上
             5、删除hotfix分支
             6、将上述修改全部push到远程仓库，确保远程仓库和本地具有相同的分支
             7、在远程仓库新建一个分支faq
             8、在本地跟踪远程分支faq
             9、在远程和本地faq上交错的提交更改，然后merge
             使用VS和github
             1、将其他某个同学添加成collaborator，让其能够直接push到你的repository
             2、在github上fork一个项目成员的repoistory
             3、克隆到本地，review其代码，进行一处修改（bug fix/ refactor / feature等均可），提交推送
             4、发起 一个 pull request
             5、当其他项目成员发起pull request时，检查并完成其请求*/

            // SomeArray.ArraySort();


            #endregion

            //C#进阶：集合：foreach背后
            #region
            //让之前的双向链表，能够：被foreach迭代
            #endregion

            //扩展（extension）方法
            #region
            //调用扩展方法Max()：能够返回之前双向链表中存贮着最大值的节点
            #endregion

            // C#进阶 ： 委托和事件 匿名方法 / Lambda / 闭包
            #region
            /*
             声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
                使用：
                  方法
                  匿名方法
                  lambda表达式
                  给上述委托赋值，并运行该委托
                  声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出*/
            //Person.ExecuteWeituo();
            #endregion

            // C#进阶 Linq-1：where/order/group/select
            #region
            /*作业：
             在之前“文章/评价/评论/用户/关键字”对象模型的基础上，添加相应的数据，然后完成以下操作：

             找出“飞哥”发布的文章

             找出2019年1月1日以后“小鱼”发布的文章
            \
             按发布时间升序/降序排列显示文章

             统计每个用户各发布了多少篇文章

             找出包含关键字“C#”或“.NET”的文章

             找出评论数量最多的文章

             找出每个作者评论数最多的文章*/
            /*
                        //作者
                        User fg = new User { Name = "飞哥", Id = 1, };
                        User xuaoyu = new User { Name = "小鱼", Id = 2 };
                        IEnumerable<User> teachers = new List<User> { fg, xuaoyu };
                        // //文章
                        Keyword k1 = new Keyword { Word = "C#"  };
                        Keyword k2 = new Keyword { Word = ".NET" };
                        Keyword k3 = new Keyword { Word = "C#1" };
                        Keyword k4 = new Keyword { Word = "C#" };
                        Keyword k5 = new Keyword { Word = "C#2"};
                        IEnumerable<Keyword> keywords = new List<Keyword>
                        {
                            k1,k2,k3,k4,k5
                        };


                        Article articleCsharp = new Article() { Title = "C#学习",Author = fg, Keyword = new List<Keyword>() { k1, k2 } };
                        Article articleCsharp2 = new Article() { Title = "C#学习从入门到放弃", Author = fg , Keyword = new List<Keyword>() { k5, k4, k3 } };
                        Article articlejava = new Article() { Title = "JAVA学习", Author = fg , Keyword = new List<Keyword>() { k5, k4, k3 } };
                        Article articleui = new Article() { Title = "UI学习", Author = xuaoyu , Keyword = new List<Keyword>() { k5, k4, k3 } };
                        Article articleps = new Article() { Title = "PS学习", Author = xuaoyu , Keyword = new List<Keyword>() { k5, k4, k3 } };
                        Article articleai = new Article() { Title = "测试学习", Author = xuaoyu , Keyword = new List<Keyword>() { k5, k4, k3 } };
                        IEnumerable<Article> articles = new List<Article> { articleCsharp, articleCsharp2,articlejava, articleui, articleps, articleai };

                        //articleCsharp2.Keyword = new List<Keyword>() { k1, k2 };
                        //articleCsharp.Keyword = new List<Keyword>() { k5, k4, k3 };

                        foreach (var item in articleCsharp.Keyword)
                        {
                            Console.WriteLine(item.Word);
                        }

                        var result = from a in articles
                                     where a.Author.Name== "飞哥"
                                     select a;
                        foreach (var item in result)
                        {
                            Console.WriteLine("飞哥发布的文章" + item.Title);
                        }

                        //找出2019年1月1日以后“小鱼”发布的文章
                       // articleCsharp
                       ContentService fb = new ContentService();//ContentService，其中有一个发布（Publish()）方法：
                        fb.Publish(articleCsharp);
                        fb.Publish(articleui);
                        fb.Publish(articleps);
                        fb.Publish(articleai);
                        articleui.UpdatePublishTime(articleui, new DateTime(2018,9,9));//修改articleui发布时间  
                        articleps.UpdatePublishTime(articleps, new DateTime(2019, 9, 19));
                        articleai.UpdatePublishTime(articleai, new DateTime(2019, 9, 29));
                        var result1 = from a in articles
                                      where a.Author == xuaoyu && a.PublishTime > new DateTime(2019, 1, 1)
                                      select a;
                        foreach (var item in result1)
                        {
                            Console.WriteLine($"2019年1月1日以后“小鱼”发布文章：《《{ item.Title}》》");//ps 测试

                        }
                        // 按发布时间升序 / 降序排列显示文章
                        var result2 = from a in articles
                                      orderby a.PublishTime descending
                                      select a;
                        foreach (var item in result2)
                        {
                            Console.WriteLine($"文章{item.Title}发布时间 {item.PublishTime}");
                        }

                        //统计每个用户各发布了多少篇文章

                        var result3 = from a in articles
                                      group a by a.Author
                                    //接下来对分组结果集再运算（统计）
                                    into ga  //into类似于命名，将之前的结果集命名为：gm
                                      select new  //利用投影
                                      {
                                          AuthorName = ga.Key.Name,
                                          num=ga.Count()

                                      };
                        foreach (var item in result3)
                        {
                            Console.WriteLine($"作者名：{item.AuthorName},有{item.num}文章");

                        }

                        //找出包含关键字“C#”或“.NET”的文章
                        //var result4 = from a in articles
                        //              where a.Title.Contains("C#") || a.Title.Contains(".NET")
                        //              select a;
                        //foreach (var item in result4)
                        //{
                        //    Console.WriteLine($"关键字包含C#,.NET的文章是<<{item.Title}>>");
                        //}


                        Console.WriteLine("11111");

                        var result41 = from a in articles
                                       where a.Keyword.Any(k => k.Word == "C#")|| a.Keyword.Any(k => k.Word == ".NET")
                                       select a;
                        foreach (var item in result41)
                        {
                            Console.WriteLine( item.Title);
                        }


                        //var result40 = from k in keywords
                        //               where k.Word.Contains("C#") || k.Word.Contains("NET")
                        //               select new {
                        //                   k.Word,
                        //                   k.Articles
                        //               };
                        //foreach (var item in result40)
                        //{
                        //    Console.WriteLine($"关键字包含C#,.NET的文章是<<{item}>>");
                        //}

                        //评论
                        Comment comment1 = new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
                        Comment comment2 = new Comment { Article = articleui, Title = "小鱼老师说的好" };
                        Comment comment3 = new Comment { Article = articleui, Title = "小鱼老师说的特好" };
                        Comment comment4 = new Comment { Article = articleui, Title = "小鱼老师说的特别好" };
                        Comment comment5 = new Comment { Article = articleui, Title = "小鱼老师说的特别别好" };
                        Comment comment6 = new Comment { Article = articleCsharp2, Title = "飞哥说得好" };
                        Comment comment7 = new Comment { Article = articlejava, Title = "飞哥articlejava说得好" };
                        Comment comment8 = new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
                        Comment comment9 = new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
                        Comment comment10 = new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
                        Comment comment11= new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
                        Comment comment12= new Comment { Article = articleCsharp, Title = "飞哥说的特别好" };
                        Comment comment13 = new Comment { Article = articleCsharp2, Title = "飞哥说得好" };


                     //   articleCsharp2.Comment = new List<Comment>() { comment1,comment2};


                        IEnumerable<Comment> comments = new List<Comment> { comment1, comment2, comment3, comment4, comment5, comment6, comment7, comment8, comment9, comment10, comment11, comment12, comment13 };
                        //找出评论数量最多的文章
                        var result5 = from c in comments
                                      group c by c.Article//分组依据
                                      into gc
                                      select new
                                      {
                                          title = gc.Key.Title,
                                          commentnum = gc.Count()
                                      };

                        foreach (var item in result5)
                        {
                            if (item.commentnum == result5.Max(g => g.commentnum))
                            {
                                Console.WriteLine($"数量最多的文章<{item.title}>的评论有{item.commentnum}篇");
                            }
                        }

                        //找出每个作者评论数最多的文章

                        var result7 = from c in comments
                                      join a in articles
                                      on c.Article equals a
                                      group c by c.Article
                                      into gc
                                      select new
                                      {
                                          articl = gc.Key.Title,
                                          cnum = gc.Count(),
                                          author = gc.Key.Author

                                      };
                        foreach (var item in result7)
                        {
                            //if (item.cnum == result7.Max(g => g.cnum))
                            //{
                            Console.WriteLine($"评论作者{item.author.Name}---评论数多的文章是---{item.articl}----评论数量是{item.cnum}");
                            //}
                        }

                        var result8 = from i in result7
                                      group i by i.author;


                        foreach (var item in result8)
                        {
                            var kkk = from i in item
                                      orderby i.cnum descending
                                      select i;
                            Console.WriteLine($"{kkk.First().author.Name}的{kkk.First().articl}文章第一是{kkk.First().cnum}");
                        }


                        */










            #endregion


        }








        private static void Con(string passeord)
        {
            string Str = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz~!@#$%^&*()_+";

            if (passeord.Length > 6)
            {
                for (int i = 0; i < passeord.Length; i++)
                {
                    if (!Str.Contains(passeord[i]))
                    {
                        Console.WriteLine("输入有误");
                        break;
                    }

                }
                Console.WriteLine("正确" + passeord);
            }
            else
            {
                Console.WriteLine("输入有误");
            }

        }
        /// <summary>
        /// 构造一个能装任何数据的数组，并完成数据的读写
        /// </summary>
        private static void GetanyArray()
        {
            object[] annyArray = new object[5] { 2.344, 1123, 2345, "中文", true };
            for (int i = 0; i < annyArray.Length; i++)
            {
                Console.WriteLine(annyArray[i]);


            }
        }
        /// <summary>
        /// 遍历100 内所有质数
        /// </summary>
        private static void ZhiNum()
        {
            bool flag;//声明一个bool值用来判断是否是素数
            for (int i = 2; i < 101; i++)// 1、遍历100 内所有数
            {
                //每次循环都把flag的值设置为true,
                flag = true;
                //2、开始第二次循环,让 i 依次除与 2 和小于它的数,当i= 2时(j < i 条件不成立),直接跳出循环输出:素数 2
                for (int j = 2; j < i; j++)
                {
                    //当 i 可以被 j 整除时跳出该循环,该数不是素数,不做输出
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("素数 " + i);
                }
            }
        }

        // 定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
        //最小值min（默认为1）
        //相邻两个元素之间的最大差值gap（默认为5）
        //元素个数length（默认为10个）
        /// <summary>
        /// 生成数组的方法,元素随机生成从小到大排列
        /// </summary>
        private static void GetArray()
        {
            //给随机数组赋值
            int[] arryasc = new int[10];
            Random Rvalue = new Random();
            for (int i = 1; i < 10; i++)
            {
                arryasc[i + 1] = Rvalue.Next(0, 100) + arryasc[i];

                Console.WriteLine(arryasc[i]);
            }
            //冒泡排序
            for (int i = 0; i < arryasc.Length; i++)
            {
                //从小到大 
                for (int j = 0; j < arryasc.Length - 1; j++)
                {
                    if (arryasc[j] > arryasc[j + 1])
                    {
                        int temp = arryasc[j];
                        arryasc[j] = arryasc[j + 1];
                        arryasc[j + 1] = temp;

                    }

                }

            }

        }

        /// <summary>
        /// 通过二分查找法在一个有序数组中找到某个值的下标，找不到返回 - 1
        /// </summary>
        private static void BinarySearch()
        {


        }

        private static void Login()
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


    }
}



