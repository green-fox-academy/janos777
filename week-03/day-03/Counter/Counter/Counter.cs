using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    class Counter
    {
        public int DefaultValue;
        public int CurrentValue;
        public string stringValue;

        public Counter(int DefaultValue = 0)
        {
            this.DefaultValue = DefaultValue;
            CurrentValue = DefaultValue;
        }

        public int Add(int number)
        {
            return CurrentValue = CurrentValue + number;
        }
        public int Add()
        {
            return CurrentValue += 1;
        }
        public string Get()
        {
            return stringValue = CurrentValue.ToString();
        }
        public int Reset()
        {
            return CurrentValue = DefaultValue;
        }



        //we can Add(number) to this counter another whole number
        //or we can Add() without parameters just increasing the counter's value by one
        //and we can Get() the current value as string
        //also we can Reset() the value to the initial value
    }
}
