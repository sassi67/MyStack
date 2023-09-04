using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class MyNode<T> 
    {

        public MyNode(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public MyNode<T> Next { get; set; }

        public override bool Equals(object? obj)
        {
            // https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0#system-object-equals(system-object)
            return false; 
        }
    }
}
