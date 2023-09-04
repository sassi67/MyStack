using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{

    public class MyLinkedList<T>
    {
        public int Count { get; set; }

        public MyNode<T> First
        {
            get
            {
                return null;
            }
        }

        public MyNode<T> Last
        {
            get
            {
                return null;
            }
        }

        public MyLinkedList() { }
        public MyLinkedList(IEnumerable<T> collection) { }

        public void Clear()
        {

        }

        public MyNode<T> AddLast(T elem)
        {
            return null;
        }

        public MyNode<T> AddFirst(T elem)
        {
            return null;
        }

        public bool Contains(T elem)
        {
            return false;
        }

        public MyNode<T> RemoveLast()
        {
            return null;
        }

        public MyNode<T> AddAfter(MyNode<T> node, T elem)
        {
            return null;
        }
    }
}
