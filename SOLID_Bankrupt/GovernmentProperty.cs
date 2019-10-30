using System;

namespace Project
{
    public class GovernmentProperty : Property
    {
        public GovernmentProperty(int salePrice, int rentalPrice) : base(salePrice, rentalPrice)
        {
        }

        public override void Buy()
        {
            throw new Exception("This property is never available for sale");
        }
    }
}