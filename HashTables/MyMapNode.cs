using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class MyMapNode<K,V>
    {
        //Initializing
        private int size;
        private LinkedList<KeyValue<K, V>>[] items;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="size"></param>
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        /// <summary>
        /// Get and Set the Key and Value property
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        public class KeyValue<K, V>
        {
            public K key { get; set; }
            public V value { get; set; }
        }
        /// <summary>
        /// GetArrayIndex() to find the index by getting hashcode through the inputkey 
        /// </summary>
        /// <param name="key">to get the hashcode</param>
        /// <returns>index to assing the value</returns>
        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % this.size;
            
            return Math.Abs(position);
        }

        /// <summary>
        /// Get() to get the value
        /// </summary>
        /// <param name="key">to check the key is present or not,if present return the value</param>
        /// <returns>value</returns>
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }

        /// <summary>
        /// Add() method to add the key-value
        /// </summary>
        /// <param name="key">to calculate hashcode</param>
        /// <param name="value">to set at index</param>
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { key = key, value = value };
            linkedList.AddLast(item);
        }


        /// <summary>
        /// GetLinkedList() to assing the value at that perticular(calculated) index
        /// </summary>
        /// <param name="position">input form the GetArrayIndex() method</param>
        /// <returns>llist</returns>

        public LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        /// <summary>
        /// Calculating the Frequency of words
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int GetFrequencyOfWords(V value)
        {
            int count = 0;
            if (items == null)
            {
                Console.WriteLine("Hash Table is Empty!");
                return 0;
            }
            for (int i = 0; i < items.Length; i++)
            {
                LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(i);
                foreach (KeyValue<K, V> item in linkedList)
                {
                    if (item.value.Equals(value))
                        count++;
                }
            }
            return count;
        }

       
    }
}
