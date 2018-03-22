using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Tang : Fish
    {
        public bool ShortTermMemoryLoss;

        public Tang(string name, int weight, string color, bool shortTermMemoryLoss) : base(name, weight, color)
        {
            ShortTermMemoryLoss = shortTermMemoryLoss;
        }

        public override int Feed()
        {
            return Weight++;
        }

        public override string Status()
        {
            return $"{Name}, weight: {Weight}, color {Color}, short-term memory loss: {ShortTermMemoryLoss}";
        }
    }
}
