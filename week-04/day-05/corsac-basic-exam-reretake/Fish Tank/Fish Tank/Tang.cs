using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Tang : Fish
    {
        private bool ShortTermMemoryLoss;

        public Tang(string name, int weight, string color, bool shortTermMemoryLoss) : base(name, weight, color, 1)
        {
            ShortTermMemoryLoss = shortTermMemoryLoss;
        }

        public override string Status()
        {
            return base.Status() + $", short-term memory loss: {ShortTermMemoryLoss}";
        }
    }
}
