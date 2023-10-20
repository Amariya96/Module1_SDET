using Assignments;
Console.WriteLine("1.Electronic product 2. Digital product 3. Clothing product");
switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        ElectronicProducts ep = new ElectronicProducts(7, "Laptop", 90000, 2);
        ep.DisplayProduct();
        ep.DisplayWarrantyPeriod();
        break;

        case 2:
        DigitalProducts dp = new DigitalProducts("PDF", 2, " ProName", 25000, 1);
        dp.DisplayProduct();
        dp.DisplayWarrantyPeriod();
        dp.DisplayDigitalProducts();
        break;
        case 3:
        ClothingProducts cp = new ClothingProducts("M", "Skirt", 999, 3);
        cp.DisplayClothingProducts();
        cp.DisplayClothingProducts();
        break;
}