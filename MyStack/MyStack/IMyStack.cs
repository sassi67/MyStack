using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public interface IMyStack<T>
    {
        void Clear();
        void Push (T item);
        T Pop ();
        T Peek ();
        bool Contains(T item);

    }
}
