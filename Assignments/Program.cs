using Assignments;
Patient patients = new(1, "Rahul", 19, "Fever");
try
{
    patients.AddPatientsDetails(patients);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
/*
CallRecord cr1 = new CallRecord(111, 7896576340, "1.30pm");
CallRecord cr2 = new CallRecord(222, 9876576340, "9.30pm");
CallRecord cr3 = new CallRecord(333, 6789036340, "10pm");
List<CallRecord> callRecords = new()
{
    cr1, cr2, cr3
};
void CallHistory(long phNo)
{
    foreach (var i in callRecords)
    {
        if(i.phNo == phNo)
        {
            Console.WriteLine("CallId: {0} \n CallTime: {1} \n", i.callId, i.callTime);
            break;
        }
        else { Console.WriteLine("PhoneNo is not Found");
            break;
        }
    }
}
CallHistory(8921);

//Console.WriteLine("Ente the number to search");


//var n =Convert.ToInt64( Console.ReadLine());
//CallHistory(n);
//TotalCalls();


//void TotalCalls()
//{
//    Dictionary<long, int> num = new();
//    int count = 1;
//    foreach (var item in callRecords)
//    {
//        if (!num.ContainsKey(item.PhoneNumber))
//        {
//            num[item.PhoneNumber] = count;
//        }
//        else
//        {
//            num[item.PhoneNumber] += 1;
//        }
//    }
//    foreach (var item in num)
//    {
//        Console.WriteLine("Phone Number: {0} Number of Calls: {1}", item.Key, item.Value);
//    }
//}
/*
Customer c1 = new Customer(1, "Anju", 9067542367, 5000);
Customer c2 = new Customer(2, "Pooja", 7865439870, 8000);
Customer c3 = new Customer(3, "Sreethumol", 8890765437, 10000);

Dictionary<int, Customer> cust = new Dictionary<int, Customer>();
cust.Add(1, c1);
cust.Add(2, c2);
cust.Add(3, c3);
FindCustomer(8890765437);
DisplayCustomerDetails();
 void FindCustomer(double phNo)
{
foreach (var i in cust.Values)
    {
    if(i.PhNo == phNo)
        {
            Console.WriteLine("Name:" + i.Name);
            Console.WriteLine("Balance:" + i.Balance);
            break;
        }
    else
        {
            Console.WriteLine("Customer not Found \n");
            break;
        }
    }
}
void DisplayCustomerDetails()
{
    foreach (var i in cust.Values)
    {
       
        Console.WriteLine("\n Id : {0} \n Name : {1} \n PhoneNo: {2} \n Balance: {3} \n ", i.CustId, i.Name, i.PhNo, i.Balance);
    }
}
/*
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