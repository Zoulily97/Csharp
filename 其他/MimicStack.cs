using System;

namespace Csharp
{
    //自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
    //出栈Pop()，弹出栈顶数据
    //入栈Push()，可以一次性压入多个数据
    //出 / 入栈检查，
    //如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
    //如果已弹出所有数据，提示“栈已空”
    //用泛型改造二分查找、堆栈和双向链表
    class MimicStack<T>
    {
        private T[] container = new T[5];//定义一个容器
        int top = 0;//栈顶
        public void Push(T value)//入栈
        {
            if (top == container.Length)
            {
                Console.WriteLine("栈溢出");
            }
            else
            {
                Console.WriteLine("压入" + value);
                container[top] = value;
                top++;
            }
        }
        public void  Pop()//出
        {

            if (top == 0)
            {
                Console.WriteLine("栈已空");
            }
            else 
            {
                
                T result =container[top-1];
                Console.WriteLine(result + "弹出");
                top--;
                  
                
            }
            
         //  return 1;
        }
    }
}
