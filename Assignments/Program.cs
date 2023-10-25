using Assignment;
using Assignments;


LifeInsurance l1 = new("Policy1", 123, 8999, 60);
Console.WriteLine("Policy Name : {0} \t Policy Id : {1} \t Age : {2} \n", l1.PolicyName, l1.PolicyId, l1.Age);
Console.WriteLine("Updated Premium" + l1.CalculatePremium());

CarInsurance car1 = new CarInsurance("Policy 2", 133, 10000, "Petrol");
Console.WriteLine("Policy Name : {0} \t Policy Id : {1} \t Fuel Type : {2} \n", car1.PolicyName, car1.PolicyId, car1.FuelType);
Console.WriteLine("Updated Premium" + car1.CalculatePremium());
/*
AbstarctInsurancePolicy ip= new AbstarctInsurancePolicy("Monthly Policy", 1, 1000);
ip.RenewPolicy(100000);
ip.RenewPolicy();


/*
Circle c = new Circle();
c.Radius = 12;
Rectangle r = new Rectangle();
r.length = 10;
r.breadth = 20;
c.Draw();
r.Draw();



/*

Employee emp= new Employee(1,"Anu", "Shaju", 9);
emp.DisplayInfo();

/*
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
*/