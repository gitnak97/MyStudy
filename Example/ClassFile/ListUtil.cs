using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class ListUtil
    {
        private Dictionary<string, FoodCount> _foodCounts = new Dictionary<string, FoodCount>();

        public FoodCount this[string key]
        {
            get
            {
                if (!_foodCounts.ContainsKey(key))
                    _foodCounts[key] = new FoodCount();

                return _foodCounts[key];
            }

            set => _foodCounts[key] = value;
        }


        public IEnumerator<KeyValuePair<string, FoodCount>> GetEnumerator()
        {
            return _foodCounts.GetEnumerator();
        }
    }

    class FoodCount
    {
        private int count;
        public int Count { get => count; set => count = value; }
    }
}
