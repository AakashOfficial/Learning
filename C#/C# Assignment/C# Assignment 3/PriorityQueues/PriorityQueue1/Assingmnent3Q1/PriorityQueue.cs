using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue {
    
    // all the function of priority queue is implemented in this Class
    class PriorityQueue<T>   where T : IEquatable<T> {
        public int count;
        private IDictionary<int, IList<T>> elements;
        IList<T> list;
        T temp;
        
        //constructor 
        public PriorityQueue() {
            elements = new Dictionary<int, IList<T>>();
            list = new List<T>();
        }

        public PriorityQueue(IDictionary<int,List<T>> element):this () {
            elements = new Dictionary<int, IList<T>>();
            list = new List<T>();
        }

        //enqueue method for insertion of data
        public void Enqueue(int priority, T item) {
            if (!elements.TryGetValue(priority, out list)) {
                list = new List<T>();
                elements.Add(priority, list);
            }
            list.Add(item);
            count++;
        }

        //check whether element is prsent or not
        public bool Contains(T item) {
            bool isContain = false;
            foreach (KeyValuePair<int, IList<T>> kvp in elements) {
                foreach (var value in kvp.Value) {
                    if (item.Equals(value)) {
                        return true;
                    }
                }
            }
            return isContain;
        }

        //remove the element from the priority queue
        public int Dequeue() {
            if (elements.Count == 0)
                throw new Exception("No items to Dequeue:");
                var keys = GetHighestPriority();
                elements[keys].RemoveAt(0);
                count--;
                return keys;
        }       
        
        // print the priority queue
        public void Print() {
            foreach (KeyValuePair<int, IList<T>> kvp in elements) {
                foreach(var value in kvp.Value) {
                    Console.WriteLine("key = {0} value = {1} ", kvp.Key,value);
                }
            }
        }

        //print the top highest element in priority queue
        public T Peek() {
            if (count == 0) throw new InvalidOperationException("Queue is empty.");

            foreach (KeyValuePair<int, IList<T>> kvp in elements) {
                foreach (var value in kvp.Value) {
                    temp=value;
                    break;
                }
                break;
            }
            return temp;
        }

        //print highest priority form queue
        private int GetHighestPriority() {
            int priority = 0;
            foreach (KeyValuePair<int, IList<T>> kvp in elements) {
                if (priority < kvp.Key) {
                    priority = kvp.Key; 
                }
            }
            return priority;
        }
    }
}