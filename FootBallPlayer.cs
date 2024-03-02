using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes_Methods_Hongfei
{
    internal class FootBallPlayer : Player
    {
        int _yardsRun;


        public FootBallPlayer(string name, string number, int yardsRun) : base(name, number)
        {
            _yardsRun=yardsRun;
        }

        public FootBallPlayer()
        {

        }

        public int YardsRun { get => _yardsRun; set => _yardsRun=value; }

        public override string ToString()
        {
            return $"{_yardsRun}";
        }
    }
}
