namespace Assignments
{
    internal interface IProduct
    {
        double Price { get; set; }
        string ProName { get; set; }
        double Quantity { get; set; }

        double ProductValue();
        void SetPrice(double newPrice);
    }
}