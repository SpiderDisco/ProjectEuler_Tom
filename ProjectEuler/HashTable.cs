using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class HashTable
    {
        private int currentSize;
        private int resizeCount;
        private Tuple<string,string>[] array;
        private int[] primes;
        public HashTable()
        {
            primes = new int[] { 11, 23, 47, 97, 197, 389, 787, 1579, 3163, 6329, 12659, 25321 };
            array = new Tuple<string, string>[11];
            resizeCount = 0;
            currentSize = 0;
        }
        public bool Insert(string key, string value)
        {
            int currentPos = GetIndex(key);
            if (array[currentPos]!=null)
                return false;

            array[currentPos] = new Tuple<string,string>(key,value);
            currentSize++;
            if (currentSize > array.Length / 2)
                ReHash();
            return true;
        }
        public string GetValue(string key)
        {
            int currentPos = GetIndex(key);
            return array[currentPos].Item2;
        }
        int GetIndex(string key)
        {
            int offset = 1;
            int currentPos = Hash(key);
            while (array[currentPos] != null)
            {
                currentPos += offset;
                offset += 2;
                if (currentPos >= array.Length)
                    currentPos -= array.Length;
            }
            return currentPos;
        }
        void ReHash()
        {
            Console.WriteLine("resize");
            Tuple<string,string>[] oldArray = array;
            array = new Tuple<string, string>[primes[++resizeCount]];
            currentSize = 0;
            foreach (Tuple<string, string> kvp in oldArray)
            {
                if (kvp!=null)
                {
                    Insert(kvp.Item1, kvp.Item2);
                }
            }
        }
        int Hash(string key)
        {
            int hashVal = key.GetHashCode() % array.Length;
            if (hashVal < 0)
                hashVal += array.Length;
            return hashVal;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (Tuple<string, string> kvp in array)
            {
                if(kvp!=null)
                    str.AppendLine(kvp.Item1 + ", " + kvp.Item2);
                else
                    str.AppendLine("---, ---");
            }
            return str.ToString();
        }
    }
}
