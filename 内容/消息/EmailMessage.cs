using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class EmailMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("EmailMessage");
        }
    }
}
