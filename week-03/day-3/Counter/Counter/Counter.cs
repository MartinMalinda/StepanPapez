using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    public class Counter
    {
        public int Value { get; set; } = 0;

        public Counter()
        {
            this.Value = default;
        }
        public Counter(int value)
        {
            this.Value = value;
        }

        public void Add(int number)
        {
            Value += number;
        }
        public void Add()
        {
            Value++;
        }
        public string Get()
        {
            return Convert.ToString(Value);
        }
        public void Reset()
        {
            Value = default;
        }
    }
}
