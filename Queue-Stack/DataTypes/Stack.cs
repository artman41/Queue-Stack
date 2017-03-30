using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingWork.DataTypes {
    public class Stack<T> {

        private List<T> _objects = new List<T>();
        private List<T> Objects {
            get { return _objects;}
            set { _objects = value; }
        }

        public int Length => Objects.Count;  

        public Stack() {
            
        }

        public Stack(T[] objs) {
            Push(objs);
        }

        public Stack<T> Push(T obj) {
            Objects.Add(obj);
            return this;
        }

        public Stack<T> Push(T[] objs) {
            foreach (var o in objs) {
               Push(o);
            }
            return this;
        }

        public T Pop() {
            T x = Objects.Last();
            Objects.Remove(x);
            return x;
        }
    }
}
