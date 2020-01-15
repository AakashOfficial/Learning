using System;
using System.Collections.Generic;

namespace PriorityQueue {
    
    // all the function of priority queue is implemented in this
    class PriorityQueue<T>   where T : IEquatable<T> {

        private class PriorityNode {
            public int priority { get; private set; }
            public T data { get; private set; } 
            public PriorityNode(int priority,T data) {
                this.priority=++priority;
                this.data =data ;
            }
        }

        int temp;

        T answer;

        private IList<PriorityNode> list;
        IDictionary<int, IList<PriorityNode>> elements;
        PriorityNode Pnode1;
        public int count;
        //constructor
        public PriorityQueue() {
            elements = new Dictionary<int, IList<PriorityNode>>();
        }     

        //enqueue method for insertion of data
        public void Enqueue(int priority, T item) {
            if (!elements.TryGetValue(priority, out list)) {
                list = new List<PriorityNode>();
                temp = 0;
                elements.Add(priority,list);
            }
            Pnode1 = new PriorityNode(temp,item);
            list.Add(Pnode1);
            temp = Pnode1.priority; 
            count++;
        }
        //check whether element is prsent or not
          public bool Contains(T item)
        {
            bool isContain = false;
            foreach (KeyValuePair<int, IList<PriorityNode>> kvp in elements)
            {
                foreach (var value in kvp.Value)
                {
                    if (item.Equals(value.data))
                    {
                        return true;
                    }
                }
            }
            return isContain;
        }
        //remove the element from the priority queue
        public int Dequeue()
        {
            if (elements.Count == 0)
                throw new Exception("No items to Dequeue: ");
                 var keys = GetHighestPriority();                         
                 elements[keys].RemoveAt(0);              
                count--;
                return keys;
        }        
        // print the priority queue
        public void Print()
        {
            foreach (KeyValuePair<int, IList<PriorityNode>> kvp in elements)
            {                
                foreach(var output in kvp.Value)
                { 
                    Console.WriteLine("key= "+kvp.Key+" value = "+output.priority+" "+output.data);
                }
            }  
        }
        //print the top highest element in priority queue
        public T Peek()
        {
            if (count == 0) throw new InvalidOperationException("Queue is empty.");
            foreach (KeyValuePair<int, IList<PriorityNode>> kvp in elements)
            {
                foreach (var output in kvp.Value)
                {  
                   answer = output.data;
                    break;
                }
                break;
            }
            return answer;
                 
        }
                //print highest priority form queue
            private int GetHighestPriority()
            {
                int priority = 0;
                foreach (KeyValuePair<int, IList<PriorityNode>> kvp in elements)
                {
                    if (priority < kvp.Key)
                    {
                        priority = kvp.Key;
                    }
                }
            
            
            return priority;
            }
        //end of all function

        }
    }