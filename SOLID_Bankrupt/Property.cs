namespace Project
{

    public class Property
    {
        public int SalePrice { get; }
        public int RentalPrice { get; }
        public Property(int salePrice, int rentalPrice)
        {
            SalePrice = salePrice;
            RentalPrice = rentalPrice;
        }
    }
}