using System.Collections.Generic;
using System.Diagnostics;

namespace RPGWonder
{
    /// <summary>
    /// Represents an item in a combo box (a drop-down list of selectable items).
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class ComboBoxObject
    {
        public string Key;
        public string Value;

        /// <summary>
        /// Initializes a new instance of the ComboBoxObject class.
        /// </summary>
        public ComboBoxObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ComboBoxObject class with the specified key and value.
        /// </summary>
        /// <param name="key">The unique identifier for the item.</param>
        /// <param name="value">The string that is displayed in the combo box for the item.</param>
        public ComboBoxObject(string key, string value)
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current ComboBoxObject.
        /// Two ComboBoxObject instances are considered equal if they have the same key and value.
        /// </summary>
        /// <param name="obj">The object to compare with the current ComboBoxObject.</param>
        /// <returns>true if the specified object is equal to the current ComboBoxObject; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return obj is ComboBoxObject @object &&
                   EqualityComparer<string>.Default.Equals(Key, @object.Key) &&
                   EqualityComparer<string>.Default.Equals(Value, @object.Value);
        }

        /// <summary>
        /// Serves as the default hash function for the ComboBoxObject class.
        /// </summary>
        /// <returns>A hash code for the current ComboBoxObject instance.</returns>
        public override int GetHashCode()
        {
            int hashCode = 206514262;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Key);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            return hashCode;
        }

        /// <summary>
        /// Returns the string that is displayed in the combo box for the item.
        /// </summary>
        /// <returns>The value of the ComboBoxObject instance as a string.</returns>
        public override string ToString()
        {
            return Value.ToString();
        }

        /// <summary>
        /// Gets the string that is displayed in the debugger for the ComboBoxObject instance.
        /// </summary>
        /// <returns>The string that is displayed in the debugger for the ComboBoxObject instance.</returns>
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
