using System;

namespace Project
{
    public class House : Property
    {
        public House(int salePrice, int rentalPrice) : base(salePrice, rentalPrice)
        {
        }

        public override void Buy()
        {
            base.Buy();
            Console.WriteLine("Sucess");
        }
    }
}