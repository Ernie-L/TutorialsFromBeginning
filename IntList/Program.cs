using System;

namespace IntList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class NodeSimple
    {
        public int id;
        public string name;
        public NodeSimple Next;
    }


    public class Node
    {
        private Node _next;
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }

        private int _id;
        public int ID { get { return _id; } set { _id = value; } }

        public string Name { get; set; }

        public Node Find(int id)
        {
            if (ID == id)
                return this;
            if (_next != null)
                return _next.Find(id);

            return null;
        }
    }
}
