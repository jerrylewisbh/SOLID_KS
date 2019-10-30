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

            Property prop1 = new House(10, 10);

            prop1.Buy();

            Property prop2 = new GovernmentProperty(10,10);

            if(!(prop2 is  GovernmentProperty))
            {
                prop2.Buy();
            }

        }
    }
}
