using System;

namespace Project
{

    public enum PlayeType
    {
        Random, Impulsive

    }
    public class Player
    {
        private PlayeType type;
        public Player(PlayeType type)
        {
            this.type = type;
        }

        public void Buy()
        {
            switch (type)
            {
                case PlayeType.Impulsive:
                    Console.WriteLine("IMPULSIVE BUYING");
                    break;
                case PlayeType.Random:
                    Console.WriteLine("RANDOM BUYING");
                    break;
            }
        }
    }
}