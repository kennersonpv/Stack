using System.Collections.Generic;

namespace Stack
{
    partial class Program
    {
        public class Stack
        {
            private readonly List<object> ts;

            public Stack()
            {
                ts = new List<object>();
            }
        
            public void Push(object obj)
            {
                ts.Add(obj);
            }

            public object Pop()
            {
                var obj = ts[ts.Count - 1];
                ts.Remove(obj);
                return obj;
            }

            public void Clear()
            {
                ts.Clear();
            }
        }
    }
}
