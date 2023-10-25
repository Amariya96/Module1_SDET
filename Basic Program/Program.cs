
using Basic_Program;

GenericCollection gc = new GenericCollection();
//gc.ListHandling();
gc.DictionaryHandling();

//NonGenericCollection nonGenericCollection = new NonGenericCollection();
//nonGenericCollection.ArrayListHandling();
//nonGenericCollection.StackHandling();
//nonGenericCollection.QueueHandling();
//nonGenericCollection.HashTableHandling();
//nonGenericCollection.SortedListHandling();

/*
BankDetails bank = new BankDetails(1, 5465767687L, "Anu", "InActive");
BankDetailsNew bank1 = new(1, 5465767687L, "Anu", "InActiveS");

BankDetails.WelcomeMessage();

Console.WriteLine("1. CustId 2. AccNo 3. Name");
int ch= Convert.ToInt32(Console.ReadLine());
switch(ch)
{
    case 1:
        Console.WriteLine("CustId :");
        bank1.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
        break;
    case 2:
        Console.WriteLine("AccNo :");
        bank1.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
        break;
    case 3:
        Console.WriteLine("Name :");
        bank1.GetAccDetails(Console.ReadLine());
        break;
        default: Console.WriteLine("Enter bet 1-3");
        break;
}
BankDetails.ExitMessage();

*/



/*
Doctor doc = new Doctor();
doc.AddNewDoctor(1, "Ele");
doc.DisplayDoctorDetails();
doc.ModifyDoctor(2, "Manu");
doc.DisplayDoctorDetails();
doc.BookApp(3, "Ravi");
doc.DelApp("Ravi");




/*
EV ev = new();
ev.Vehnum = 444;
ev.Brand = "Honda";
ev.Model = "2023";
ev.Display();
Console.WriteLine(ev.setTypeForVeh());


PV pv = new();
pv.Vehnum = 888;
pv.Brand = "Maruthi";
pv.Model = "2022";
pv.Display();
Console.WriteLine(pv.setTypeForVeh());

*/

/*

  Console.WriteLine("1. TS 2. NTS 3. SD");
switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff ts = new TeachingStaff();
        ts.Staffid = 111;
        ts.Name = "Ravi";
        ts.Dept = "CS";
        ts.Specializations = " OS,DBMS";
        ts.Sem = 4;
        ts.DisplayTSStaffDetails();
        break;

    case 2:
        NonTeachingStaff nts = new NonTeachingStaff();
        nts.Staffid = 111;
        nts.Name = "Ravi";
        nts.Dept = "CS";
        nts.Responsibilities = "Att, Sal";
        nts.Experience = 4;
        nts.DisplayStaffDetails();
        nts.DisplayNTStaffDetails();
        break;

case 3:
        StudentDetails sd = new StudentDetails();
        sd.RollNo = 4;
        sd.StudName = "Ravi";
        sd.City = "Trivandrum";
        sd.ColId = "1";
        sd.ColName = "Anupama";
        sd.ColType = "CSE";
        sd.DisplayStudentDetails();
        sd.DisplayCollegeDetails();
        break;
}
*/


