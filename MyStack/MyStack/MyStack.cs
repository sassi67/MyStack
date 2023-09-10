using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class MyStack<T> : MyStackBase<T>, IEnumerable<T>
    {
        public override void Clear()
        {
            linkedList.Clear();
        }

        public override bool Contains(T elem)
        {
            return linkedList.Contains(elem);
        }

        public override T Peek()
        {
            return linkedList.Last.Data;
        }

        public override T Pop()
        {
            T rtn = linkedList.Last.Data;
            linkedList.RemoveLast();
            return rtn;
        }

        public override void Push(T elem)
        {
            linkedList.AddLast(elem);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            
            return linkedList.GetEnumerator();
        }

        public T this[int i]
        {
            get
            {
                if(i < 0  || i >= linkedList.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return linkedList[i].Data;
            }
        }

    }
}
