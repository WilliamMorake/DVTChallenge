using System;
using System.Collections.Generic;
using System.Linq;

namespace DVTElevatorChallenge
{
    // Implementation of a simple Priority Queue using a Dictionary
    public class PriorityQueue<TKey, TValue> where TKey : IComparable<TKey>
    {
        private SortedDictionary<TKey, Queue<TValue>> queue = new SortedDictionary<TKey, Queue<TValue>>();

        public void Enqueue(TValue value, TKey priority)
        {
            if (!queue.ContainsKey(priority))
            {
                queue.Add(priority, new Queue<TValue>());
            }
            queue[priority].Enqueue(value);
        }

        public (TValue, TKey) Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Priority queue is empty.");
            }
            var firstKey = queue.Keys.First();
            var value = queue[firstKey].Dequeue();
            if (queue[firstKey].Count == 0)
            {
                queue.Remove(firstKey);
            }
            return (value, firstKey);
        }

        public bool IsEmpty => queue.Count == 0;
    }

}
