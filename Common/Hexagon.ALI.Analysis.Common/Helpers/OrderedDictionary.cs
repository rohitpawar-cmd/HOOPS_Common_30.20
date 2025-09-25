using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Hexagon.ALI.Analysis.Common.Helpers
{
    // Source from https://referencesource.microsoft.com/#System.ServiceModel.Internals/System/Runtime/Collections/OrderedDictionary.cs,6c358d08d62d3514
    // System.Collections.Specialized.OrderedDictionary is NOT generic.
    // This class is essentially a generic wrapper for OrderedDictionary.

    public class OrderedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary
    {
        OrderedDictionary privateDictionary;

        public OrderedDictionary()
        {
            this.privateDictionary = new OrderedDictionary();
        }

        public OrderedDictionary(IDictionary<TKey, TValue> dictionary)
        {
            if (dictionary != null)
            {
                this.privateDictionary = new OrderedDictionary();

                foreach (KeyValuePair<TKey, TValue> pair in dictionary)
                {
                    this.privateDictionary.Add(pair.Key, pair.Value);
                }
            }
        }

        public int Count { get => this.privateDictionary.Count; }

        public bool IsReadOnly { get => false; }

        public TValue this[TKey key]
        {
            get
            {
                if (key == null)
                {
                    throw new ArgumentNullException("key");
                }

                if (this.privateDictionary.Contains(key))
                {
                    return (TValue)this.privateDictionary[key];
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
            set
            {
                if (key == null)
                {
                    throw new ArgumentNullException("key");
                }

                this.privateDictionary[key] = value;
            }
        }

        public ICollection<TKey> Keys
        {
            get
            {
                List<TKey> keys = new List<TKey>(this.privateDictionary.Count);

                foreach (TKey key in this.privateDictionary.Keys)
                {
                    keys.Add(key);
                }

                return keys;
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                List<TValue> values = new List<TValue>(this.privateDictionary.Count);

                foreach (TValue value in this.privateDictionary.Values)
                {
                    values.Add(value);
                }

                return values;
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item) => Add(item.Key, item.Value);

        public void Add(TKey key, TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }

            this.privateDictionary.Add(key, value);
        }

        public void Clear() => this.privateDictionary.Clear();

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            if (item.Key == null || !this.privateDictionary.Contains(item.Key))
            {
                return false;
            }
            else
            {
                return this.privateDictionary[item.Key].Equals(item.Value);
            }
        }

        public bool ContainsKey(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }

            return this.privateDictionary.Contains(key);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("arrayIndex");
            }

            if (array.Rank > 1 || arrayIndex >= array.Length || array.Length - arrayIndex < this.privateDictionary.Count)
            {
                throw new AccessViolationException();
            }

            int index = arrayIndex;
            foreach (DictionaryEntry entry in this.privateDictionary)
            {
                array[index] = new KeyValuePair<TKey, TValue>((TKey)entry.Key, (TValue)entry.Value);
                index++;
            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (DictionaryEntry entry in this.privateDictionary)
            {
                yield return new KeyValuePair<TKey, TValue>((TKey)entry.Key, (TValue)entry.Value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            if (Contains(item))
            {
                this.privateDictionary.Remove(item.Key);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remove(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }

            if (this.privateDictionary.Contains(key))
            {
                this.privateDictionary.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }

            bool keyExists = this.privateDictionary.Contains(key);
            value = keyExists ? (TValue)this.privateDictionary[key] : default(TValue);

            return keyExists;
        }

        void IDictionary.Add(object key, object value) => this.privateDictionary.Add(key, value);

        void IDictionary.Clear() => this.privateDictionary.Clear();

        bool IDictionary.Contains(object key) => this.privateDictionary.Contains(key);

        IDictionaryEnumerator IDictionary.GetEnumerator() => this.privateDictionary.GetEnumerator();

        bool IDictionary.IsFixedSize { get => ((IDictionary)this.privateDictionary).IsFixedSize; }

        bool IDictionary.IsReadOnly { get => this.privateDictionary.IsReadOnly; }

        ICollection IDictionary.Keys { get => this.privateDictionary.Keys; }

        void IDictionary.Remove(object key) => this.privateDictionary.Remove(key);

        ICollection IDictionary.Values { get => this.privateDictionary.Values; }

        object IDictionary.this[object key] { get => this.privateDictionary[key]; set => this.privateDictionary[key] = value; }

        void ICollection.CopyTo(Array array, int index) => this.privateDictionary.CopyTo(array, index);

        int ICollection.Count { get => this.privateDictionary.Count; }

        bool ICollection.IsSynchronized { get => ((ICollection)this.privateDictionary).IsSynchronized; }

        object ICollection.SyncRoot { get => ((ICollection)this.privateDictionary).SyncRoot; }
    }
}

