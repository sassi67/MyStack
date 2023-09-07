using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public abstract class MyStackBase<T> : IMyStack<T>
    {
        protected int count = 0;
        public int Count { get { return count; } }

        public abstract void Clear();
        public abstract bool Contains(T elem);
        public abstract T Peek();
        public abstract T Pop();
        public abstract void Push(T elem);
    }
}
