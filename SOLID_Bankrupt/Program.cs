using System;
using SOLID_Bankrupt;

namespace Project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Board b = new Board();
            Game match = new Game(b);

        }
    }
}
