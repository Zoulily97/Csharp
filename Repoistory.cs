namespace Csharp
{
    //作业：
    //定义一个仓库（Repoistory）类，用于存取对象，其中包含：
    //一个int类型的常量version
    //一个静态只读的字符串connection，以后可用于连接数据库
    //思考Respoitory应该是static类还是实例类更好
    //考虑求助（Problem）的以下方法 / 属性，哪些适合实例，哪些适合静态，然后添加到类中：
    //Publish()：发布一篇求助，并将其保存到数据库
    //Load(int Id)：根据Id从数据库获取一条求助
    //Delete(int Id)：根据Id删除某个求助
    //repoistory：可用于在底层实现上述方法和数据库的连接操作等

    public class Repoistory//存取对象
    {
        const int version = 1;
        static readonly string connection;
        static int id;
    }
}
