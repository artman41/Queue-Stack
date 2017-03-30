using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingWork.DataTypes {
    public class Queue<T> {

        private List<T> _objects = new List<T>();
        private List<T> Objects {
            get { return _objects;}
            set { _objects = value; }
        }

        public int Length => Objects.Count;  

        public Queue() {
            
        }

        public Queue(T[] objs) {
            Enqueue(objs);
        }

        public Queue<T> Enqueue(T obj) {
            Objects.Insert(0, obj);
            return this;
        }

        public Queue<T> Enqueue(T[] objs, bool lr=true) {
            foreach (var o in lr ? objs : objs.Reverse()) {
               Enqueue(o);
            }
            return this;
        }

        public T Dequeue() {
            T x = Objects.Last();
            Objects.Remove(x);
            return x;
        }
    }
}
