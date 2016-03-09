using System;

namespace WhereConstraintTest
{
    public class SortedList<T> : GenericList<T> where T : IComparable<T>
    {
        public void BubbleSort()
        {
            if (null == Head || Head.Next == null)
            {
                return;
            }
            bool swapped ;
            do
            {
                Node previous = null;
                Node current = Head;
                swapped = false;

                while (current.Next != null)
                {
                    if (current.Data.CompareTo(current.Next.Data) > 0)
                    {
                        Node temp = current.Next;
                        current.Next = current.Next.Next;
                        temp.Next = current;

                        if (previous == null)
                        {
                            Head = temp;
                        }
                        else
                        {
                            previous.Next = temp;
                        }
                        previous = temp;
                        swapped = true;

                    }
                    else
                    {
                        previous = current;
                        current = current.Next;
                    }
                }

            } while (swapped);
        }
    }
}