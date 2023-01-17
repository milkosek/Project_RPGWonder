using System.Collections.Generic;
using System.Diagnostics;

namespace RPGWonder
{
    /// <summary>
    /// Represents a combo box object that contains a key and value.
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]

    public class ComboBoxObject
    {
        public string Key;
        public string Value;

        public ComboBoxObject() { }

        /// <summary>
        /// Creates a new combo box object with the specified key and value.
        /// </summary>
        /// <param name="key">The key of the combo box object.</param>
        /// <param name="value">The value of the combo box object.</param>
        public ComboBoxObject(string key, string value)
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        public override bool Equals(object obj)
        {
            return obj is ComboBoxObject @object &&
                   EqualityComparer<string>.Default.Equals(Key, @object.Key) &&
                   EqualityComparer<string>.Default.Equals(Value, @object.Value);
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        public override int GetHashCode()
        {
            int hashCode = 206514262;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Key);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            return hashCode;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }

        /// <summary>
        /// Returns a string that represents the current object for debugging purposes.
        /// </summary>
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
