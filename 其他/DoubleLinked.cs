using System;
using System.Collections;

namespace Csharp.其他
{
    //用泛型改造二分查找、堆栈和双向链表
    public class DoubleLinked<T>: IEnumerable
    {
        public T value;

        public DoubleLinked<T> Next { get; set; }
        public DoubleLinked<T> Previous { get; set; }

        public T Content { get; set; }



        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        //在节点后插入节点node
        public void AddAfter(DoubleLinked<T> node)
        {
            //1 2] 3 4
            if (this.Next != null)
            {
                node.Next = this.Next;
                //  node.Previous = this;
                this.Next.Previous = node;
                //  this.Next = node;
            }

            node.Previous = this;
            this.Next = node;


        }

        //在该节点前插入节点node
        public void InsretBefor(DoubleLinked<T> node)
        {
            if (this.Previous != null)
            {
                node.Previous = this.Previous;
                this.Previous.Next = node;
            }
            node.Next = this;
            this.Previous = node;
        }

        //删除当前节点
        public void Delete()
        { //  1 2- 【3】
            DoubleLinked<T> oldPre = this.Previous;
            DoubleLinked<T> oldNex = this.Next;
            if (oldPre != null)
            {
                oldPre.Next = oldNex;

            }
            if (oldNex != null)
            {
                oldNex.Previous = oldPre;
            }
            this.Previous = this.Next = null;




            //if (this.Previous != null && this.Next != null)
            //{
            //    this.Previous.Next = this;
            //    this.Next.Previous = this;
            //}
            //else if (this.Previous == null)
            //{
            //   Next= Previous = null;
            //}
            //else
            //{
            //    Next = Previous = null;
            //}




        }
        //交换节点
        public void Swap(DoubleLinked<T> targetNode)
        {

            DoubleLinked<T> prethis = this.Previous;
            DoubleLinked<T> nextthis = this.Next;
            this.Delete();
            if (nextthis == targetNode)
            {
                targetNode.AddAfter(this);
            }
            else if (prethis == targetNode)
            {
                targetNode.InsretBefor(this);
            }
            else /*if (nextthis != targetNode && prethis != targetNode)*/
            {
                targetNode.AddAfter(this);
                targetNode.Delete();
                if (prethis == null)
                {
                    nextthis.InsretBefor(targetNode);
                }
                else
                {
                    prethis.AddAfter(targetNode);

                }
            }








        }
    }
}
