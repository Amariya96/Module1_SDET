using Assignments;
//TourismDestination.DestinationDetails();
TouristDestination.Destinations();



/*
using System.Reflection;
class Program
{
    public delegate double BonusCalculation(Employee emp);
    public static void Main(string[] args)
    {

        BonusCalculation bon = Employee.BonusCalculation;
        Employee emp = new Employee(1, "anu", 3);
        Employee emp1 = new Employee(2, "ammu", 4);
        Employee emp2 = new Employee(3, "achu", 5);

        BonusCalculation bon2 = Employee.EmployeeCreate;
        Console.WriteLine("Id :{0}\n Name :{1}\n Performance Rating: {2}\n Normal Bonus : {3}\n Retention Bonus: {4}\n", emp.EmployeeId, emp.EmployeeName, emp.PerformanceRating, bon(emp), bon2(emp));
        Console.WriteLine("Id :{0}\n Name :{1}\n Performance Rating: {2}\n Normal Bonus : {3}\n Retention Bonus: {4}\n", emp1.EmployeeId, emp1.EmployeeName, emp1.PerformanceRating, bon(emp1), bon2(emp1));
        Console.WriteLine("Id :{0}\n Name :{1}\n Performance Rating: {2}\n Normal Bonus : {3}\n Retention Bonus: {4}\n", emp2.EmployeeId, emp2.EmployeeName, emp2.PerformanceRating, bon(emp2), bon2(emp2));
    }
}
/*
class Program
{

    public delegate void EventNotification(HotelEvent eve);
    static int capacity = 1997;
    public static void Main(string[] args)
    {
        while (true)
        {
            HotelEvent eve = new HotelEvent();
            Console.WriteLine("Enter the event name");
            string? eventName = Console.ReadLine();
            Console.WriteLine("Enter the event date");
            string? eventDate = Console.ReadLine();
            Console.WriteLine("Enter the Location");
            string? eventLocation = Console.ReadLine();
            eve.EventName = eventName;
            eve.EventDate = eventDate;
            eve.Location = eventLocation;
            eve.Capacity = capacity;
            if (capacity < 2000)
            {
                EventNotification notification = HotelEvent.EventNotification;
                notification(eve);
            }
            else
            {

                EventNotification notify = HotelEvent.EventCapacity;
                notify(eve);
                Environment.Exit(0);

            }
            Console.WriteLine("Do you want to continue\n1.yes\n2.no");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                continue;
            }
            else if (option == 2)
            {
                Environment.Exit(0);


            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }

}





/*
using Assignments.ExceptionMessages;
using static Assignments.Product;

var typ1 = "MI";
var typ2 = 1010;
var typ3 = "OnePlus";
Product<string>.AddProduct(1, ref typ1, 100, 2);
Product<int>.AddProduct(2, ref typ2, 50, 3);
Product<string>.UpdateProduct(1, typ3);
Product<string>.DeleteProduct(2);
Product<string>.SearchProduct(1);

/*
var typ1 = "single";
var typ2 = 2;
RoomReservation<string>.BookRoom(123, ref typ1);
RoomReservation<int>.BookRoom(101, ref typ2);
RoomReservation<string>.CancelRoom(101);


/*
MedicalHistory medicalHistory = new(123, 432, "Cold", "20-10-23");

MedicalHistory medicalHistory1 = new(453, 1232, "Vomiting", "21-01-22");

MedicalHistory medicalHistory2 = new(6783, 332, "Heart Attack", "13-03-21");
int option, choice;
do
{

    Console.WriteLine("1.Add Medical Details \n 2. View Patient Details\n 3.Exit Order");
    Console.WriteLine("Choose option");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:

            MedicalHistory.MedicalHistoryDetails(medicalHistory1);
            MedicalHistory.MedicalHistoryDetails(medicalHistory2);
            MedicalHistory.MedicalHistoryDetails(medicalHistory);

            break;

        case 2:


            MedicalHistory.ViewDetails();
            break;

        case 3:
            Environment.Exit(0);
            break;
    }
    Console.WriteLine("Do You Want To Continue Press 1 for continue");
    option = Convert.ToInt32(Console.ReadLine());
} while (option == 1);
/*
int option, choice;
do
{
    Console.WriteLine("1.Add Patient \n 2. View Details \n 3. Exit");
    Console.WriteLine("Choose Option");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter PatientId:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Patient Name:");
             string? name = Console.ReadLine();
                        Console.WriteLine("Enter Age");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter diagnosis");
                        string? diagnosis = Console.ReadLine();
                        Patient patient = new(id, name, age, diagnosis);
                        patient.PatientDetails(patient);


                        break;

                    case 2:
                        Patient.ViewDetails();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;
                }
            Console.WriteLine("Do You Want To Continue Press 1 for continue");
               option = Convert.ToInt32(Console.ReadLine());
            } while (option == 1);
   
/*
MedicalRecord medicalRecord = new(111, 20000, 1201,null, 24, "HeadAche");
try
{
    medicalRecord.Validate(medicalRecord);
}
catch(InvalidPatientRecordException pr)
{
    Console.WriteLine(pr.Message);
}
catch(InvalidMedicalRecordException dr)
{
    Console.WriteLine(dr.Message);
}
/*
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

Student student = new Student("Amal", 26, 30, 45);
Console.WriteLine("Average score of " + student.studentName + " " + "is" + " " + student.CalculateAverage());
Student student1 = new Student("Vimal", 55, 40, 65);
Console.WriteLine("Average score of " + student1.studentName + " " + "is" + " " + student1.CalculateAverage());
Student student2 = new Student("Sahal", 65, 70, 45);
Console.WriteLine("Average score of " + student2.studentName + " " + "is" + " " + student2.CalculateAverage());
*/