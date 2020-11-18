using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Suggest:Content, IAgree, IDisagree
    {
        public void Agree(User voter)
        {
            throw new NotImplementedException();
        }

        public void Disagree()
        {
            throw new NotImplementedException();
        }

        //标题,内容，作者，评论，赞，踩

        public override void Publish()
        {
            Console.WriteLine("不需要消耗帮帮币");
        }

    }
}
