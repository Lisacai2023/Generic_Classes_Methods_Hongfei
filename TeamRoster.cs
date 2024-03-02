using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes_Methods_Hongfei
{
    internal class TeamRoster<T> where T : Player
    {
        public List<T> _roster = new List<T>();


        public void AddPlayer(T player)
        {
            _roster.Add(player);

        }

        public void DisplayPlayes()
        {
            foreach (var player in _roster)
            {
                if (player is FootBallPlayer)
                {
                    var seahawks = player as FootBallPlayer;
                    Console.WriteLine($"Name : {player.Name}, Number : {player.Number},YardsRun : {seahawks.YardsRun}");

                }
                else if (player is BaseballPlayer)
                {
                    var mariners = player as BaseballPlayer;
                    Console.WriteLine($"Name : {player.Name}, Number : {player.Number}, BattingAverage : {mariners.BattingAverage}");

                }

            }
        }

        


    }



}
