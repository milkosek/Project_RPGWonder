using System.Collections.Generic;
using System.Diagnostics;

namespace RPGWonder
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class ComboBoxObject
    {
        public string Key;
        public string Value;

        public ComboBoxObject()
        {
        }

        public ComboBoxObject(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is ComboBoxObject @object &&
                   EqualityComparer<string>.Default.Equals(Key, @object.Key) &&
                   EqualityComparer<string>.Default.Equals(Value, @object.Value);
        }

        public override int GetHashCode()
        {
            int hashCode = 206514262;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Key);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            return hashCode;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
