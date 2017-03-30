using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingWork {
    class Program {
        static void Main(string[] args) {

            #region Queue Testing
            var x = new Queue<int>(new []{0, 3, 4, 6, 1, 3, 5, 2, 3});

            x.Enqueue(2);

            while (x.Count != 0) {
                Console.WriteLine(x.Dequeue().ToString());
            }

            Console.ReadLine();
            #endregion

            #region Stack Testing
            var y = new Stack<int>(new[] { 5, 3, 4, 7, 1, 3, 9, 0, 0, 1, 6 });

            y.Push(2);

            while (y.Count != 0) {
                Console.WriteLine(y.Pop().ToString());
            }

            Console.ReadLine();
            #endregion

        }
    }
}
