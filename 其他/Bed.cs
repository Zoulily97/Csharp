using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    struct Bed////源栈同学的床位
    {
        public  int id;
        internal string Room { get; set; }
        public bool HasBooked;
        public Bed(int number)  //结构类型是 值类型 。而值类型要求其所有成员必须有值！
        {
            id = number;
            Room = "席梦思";
            HasBooked = false;

        }

    }

    class Bed1
    {
        public  int id;
        internal string Room { get; set; }
        public bool HasBooked;
        public Bed1()  
        {
           

        }
    }
}
