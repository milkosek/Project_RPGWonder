using System.Collections.Generic;

namespace RPGWonder
{
    /// <summary>
    /// A generic dictionary that provides safe methods for setting and retrieving values.
    /// </summary>
    /// <typeparam name="T1">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="T2">The type of the values in the dictionary.</typeparam>
    public class Safedict<T1, T2> : Dictionary<T1, T2>
    {
        /// <summary>
        /// Sets the value associated with a given key in the dictionary.
        /// If the key doesn't exist, it adds a new key-value pair to the dictionary.
        /// Otherwise, it updates the value associated with the existing key.
        /// </summary>
        /// <param name="key">The key to set or update.</param>
        /// <param name="value">The value to associate with the key.</param>
        public void Set(T1 key, T2 value)
        {
            if (!ContainsKey(key))
            {
                Add(key, value);
            }
            else
            {
                this[key] = value;
            }
        }

        /// <summary>
        /// Gets the value associated with a given key from the dictionary.
        /// If the key doesn't exist, it returns the default value for the type.
        /// </summary>
        /// <param name="key">The key to look up.</param>
        /// <returns>The value associated with the key, or the default value if the key doesn't exist.</returns>
        public T2 Get(T1 key)
        {
            if (!ContainsKey(key))
            {
                return default;
            }
            else
            {
                return this[key];
            }
        }
    }
}