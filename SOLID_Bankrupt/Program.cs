using System;

namespace Project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Board board = new Board();

            Player p1 = new Player(PlayeType.Impulsive);
            Player p2 = new Player(PlayeType.Random);


            p1.Buy();
            p2.Buy();

        }
    }
}
