using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes_Methods_Hongfei
{
    internal class BaseballPlayer : Player
    {
        double _battingAverage;

        public BaseballPlayer(string name, string number,double battingAverage) : base(name, number)
        {
            _battingAverage = battingAverage;
        }

        public double BattingAverage { get => _battingAverage; set => _battingAverage=value; }

    }
}
