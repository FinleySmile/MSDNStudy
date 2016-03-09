using System.Collections;
using System.Collections.Generic;

namespace WhereConstraintTest
{
    public class GenericList<T> : IEnumerable<T>
    {
        protected Node Head;
        protected Node Current;

        protected class Node
        {
            public Node _next;
            public T _data;

            public Node(T t)
            {
                _next = null;
                _data = t;
            }

            public Node Next
            {
                get { return _next; }
                set { _next = value; }
            }

            public T Data
            {
                get { return _data; }
                set { _data = value; }
            }
        }

        public void AddHead(T data)
        {
            Node  node = new Node(data);
            node.Next = Head;
            Head = node;
        }

        public GenericList()
        {
            Head = null;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Current = Head;
            while (Current != null)
            {
                yield return Current.Data;
                Current = Current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}