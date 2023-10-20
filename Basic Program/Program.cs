
using Basic_Program;
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



