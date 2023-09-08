using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public abstract class MyStackBase<T> : IMyStack<T>
    {
        protected MyLinkedList<T> linkedList = new MyLinkedList<T>();
        public int Count { get { return linkedList.Count; } }

        public abstract void Clear();
        public abstract bool Contains(T item);
        public abstract T Peek();
        public abstract T Pop();
        public abstract void Push(T item);
    }

}
