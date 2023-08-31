using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public abstract class MyStackBase : IMyStack<int>
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

        public int Peek()
        {
            throw new NotImplementedException();
        }

        public int Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(int item)
        {
            throw new NotImplementedException();
        }
    }

}
