using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public class Counter<T>
    {
        private Dictionary<T, int> Container = new Dictionary<T, int>();

        public bool IsStarted { get { return Container.Count > 0; } }
        public T MostUsed
        {
            get
            {
                T val = Container.Keys.ElementAt(0);
                int Used = -1;

                foreach (KeyValuePair<T, int> Pair in Container)
                {
                    if (Pair.Value > Used)
                    {
                        val = Pair.Key;
                        Used = Pair.Value;
                    }
                }

                return val;
            }
        }

        public Counter()
        {

        }

        public void Add(T val)
        {
            if (!Container.ContainsKey(val))
                Container.Add(val, 1);
            else
                Container[val] = Container[val] + 1;
        }

        public void Clear()
        {
            Container.Clear();
        }
    }
}
