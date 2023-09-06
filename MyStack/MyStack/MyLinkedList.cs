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
        private MyNode<T> _head;
        private MyNode<T> _tail;
        public int Count
        {
            get
            {
                int cnt = 0;
                MyNode<T> temp = _head;
                while (temp != null)
                {
                    cnt++;
                    temp = temp.Next;
                }
                return cnt;
            }
        }

        public MyNode<T> First
        {
            get
            {
                return _head;
            }
        }

        public MyNode<T> Last
        {
            get
            {
                return _tail;
            }
        }

        public MyLinkedList() { }
        public MyLinkedList(IEnumerable<T> collection) { }

        public void Clear()
        {
            _head = null;
            _tail = null;
        }

        public MyNode<T> AddLast(T elem)
        {
            if (elem == null) return null;
            MyNode<T> myNode = new MyNode<T>(elem);
            if (_head == null)
            {
                _head = myNode;
                _tail = myNode;
                return myNode;
            } 
            _tail.Next = myNode;
            _tail = _tail.Next;
            return myNode;
        }

        public MyNode<T> AddFirst(T elem)
        {
            if (elem == null) return null;
            MyNode<T> myNode = new MyNode<T>(elem);
            if (_head == null)
            {
                _head = myNode;
                _tail = myNode;
                return myNode;
            }
            myNode.Next = _head;
            _head = myNode;
            return myNode;
        }

        public bool Contains(T elem)
        {
            if(elem == null || _head == null) return false;
            MyNode<T> temp = _head;
            while (temp.Next != null) 
            {
                if(temp.Data.Equals(elem)) return true;
                temp = temp.Next;
            }
            return false;
        }

        public MyNode<T> RemoveLast()
        {
            if (_head == null) return null;
            MyNode<T> rtn = _tail; 
            if (_head == _tail)
            {
                Clear();
                return rtn;
            }
            MyNode<T> temp = _head;
            for (int i = 0; i < Count - 2; i++) 
            {
                temp = temp.Next;
            }
            temp.Next = null; 
            _tail = temp; 
            return rtn;
        }

        public MyNode<T> AddAfter(MyNode<T> node, T elem)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }
            if(_head == null)
            {
                throw new InvalidOperationException("Unexisting node");
            }
            if(_head.Next == null) 
            {
                if (_head.Data.Equals(node.Data))
                {
                    return AddLast(elem);
                }
                throw new InvalidOperationException("Unexisting node");
            }
            MyNode<T> temp = _head;
            while (temp.Next != null)
            {
                if (temp.Next.Data.Equals(node.Data))
                {
                    MyNode<T> newNode = new MyNode<T>(elem);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                    return newNode;
                }
                temp = temp.Next;
            }
            throw new InvalidOperationException("Unexisting node");
        }
    }
}
