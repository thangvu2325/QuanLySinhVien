using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm
{
    public class SingleNode<T>
    {
        public T data;
        public SingleNode<T> next;

        public SingleNode(T item)
        {
            data = item;
            next = null;
        }
    }
}
