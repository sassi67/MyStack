using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public abstract class MyStackBase<T> : IMyStack<T>
    {
        protected int count;
        public int Count { get { return count; } }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T item)
        {
            throw new NotImplementedException();
        }

        T IMyStack<T>.Peek()
        {
            throw new NotImplementedException();
        }

        T IMyStack<T>.Pop()
        {
            throw new NotImplementedException();
        }
    }

}
