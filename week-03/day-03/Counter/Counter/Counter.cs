using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    class Counter
    {
        public int Value;
        public string stringValue;

        public Counter(int Value = 0)
        {
            this.Value = Value;
        }

        public int Add(int number)
        {
            return Value = Value + number;
        }
        public int Add()
        {
            return Value += 1;
        }
        public string Get()
        {
            return stringValue = Value.ToString();
        }
        public int Reset()
        {
            return Value = 0;
        }



        //we can Add(number) to this counter another whole number
        //or we can Add() without parameters just increasing the counter's value by one
        //and we can Get() the current value as string
        //also we can Reset() the value to the initial value
    }
}
