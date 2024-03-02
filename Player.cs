using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes_Methods_Hongfei
{
    public abstract class Player
    {
        string _name;
        string _number;

        protected Player(string name, string number)
        {
            _name=name;
            _number=number;
        }

        protected Player()
        {

        }

        public string Name { get => _name; set => _name=value; }
        public string Number { get => _number; set => _number=value; }

        public override string ToString()
        {
            return $"{_name}, {_name}";
        }
    }
}
