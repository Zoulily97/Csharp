using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    //设计一个类FactoryContext，保证整个程序运行过程中，无论如何，
    //外部只能获得它的唯一的一个实例化对象。（提示：设计模式之单例）
    class FactoryContext
    {
        private  readonly static FactoryContext _context = new FactoryContext();
        //private FactoryContext _context;
        private FactoryContext()//私有，调用者不能new
        {
           
        }
        public FactoryContext GetInstance()
        {
            //if (_context == null)
            //{
            //    _context = new FactoryContext();
               
            //}
            ////else nothing
            
                return _context;
            
        }
    }
}
