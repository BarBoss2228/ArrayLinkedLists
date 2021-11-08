using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedLists
{
    public class DoublyNode
    {
        public int Value { get; set; }
        public DoublyNode Next { get; set; }
        public DoublyNode Previous { get; set; }
        public DoublyNode(int value)
        {
            Value = value;
            Next = null;
            Previus = null;
        }
    }
}
