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
           
        }

        public override bool Contains(T elem)
        {
            return false;
        }

        public override T Peek()
        {
            return null;
        }

        public override T Pop()
        {
            return null;   
        }

        public override void Push(T elem)
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return null;
        }

        public T this[int i]
        {
            get
            {
                return null;
            }
        }

    }
}
