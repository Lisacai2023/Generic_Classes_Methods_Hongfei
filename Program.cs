namespace Generic_Classes_Methods_Hongfei
{
    //Generic_Classes_Methods
    //Hongfei
    //Week8
    internal class Program
    {
        static TeamRoster<FootBallPlayer> seahawks = new TeamRoster<FootBallPlayer>();
        static TeamRoster<BaseballPlayer> mariners = new TeamRoster<BaseballPlayer>();



        static void Main(string[] args)
        {

            AddPlayerToTeamRoster();
            Console.WriteLine("FootBallPlayer Roster:");
            seahawks.DisplayPlayes();
            Console.WriteLine("BaseBallPlayer Roster:");
            mariners.DisplayPlayes();

            FootBallPlayer p1 = new FootBallPlayer();
            FootBallPlayer p2 = new FootBallPlayer();
            Swap(p1, p2);
            seahawks.DisplayPlayes();



        }

        public static void AddPlayerToTeamRoster()
        {
            seahawks.AddPlayer(new FootBallPlayer("Bander", "10", 10));
            seahawks.AddPlayer(new FootBallPlayer("Jason", "7", 30));
            mariners.AddPlayer(new BaseballPlayer("Sam", "9", 8000));
            mariners.AddPlayer(new BaseballPlayer("Joe", "6", 7000));
        }

        public static void Swap<T>(T t1, T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }


        //public static void Display()
        //{
        //    foreach(Player player in seahawks)
        //    {
        //        Console.WriteLine(player);
        //    }
        //}









    }
}
