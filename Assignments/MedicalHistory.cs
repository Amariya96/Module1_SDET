using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public MedicalHistory(int patientId, int recordId, string? description, string? date)
        {
            PatientId = patientId;
            RecordId = recordId;
            Description = description;
            Date = date;
        }

        public int PatientId { get; set; }
        public int RecordId { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }

        public static List<MedicalHistory> medicalHistory = new List<MedicalHistory>();
        public static void CreateFile()
        {
            FileStream fs = new FileStream("D:\\Training Works\\Basic Solution\\Assignments\\PatientRecords\\PatientMedicalReport.txt"
                , FileMode.Create, FileAccess.Write);
            fs.Close();
        }
        public static void MedicalHistoryDetails(MedicalHistory medicalhist)
        {
            FileInfo fi = new FileInfo("D:\\Training works\\Basic Solution\\Assignments\\PatientRecords\\PatientMedicalReport.txt");
            if (!fi.Exists)
            {
                CreateFile();
            }
            else
            {
                medicalHistory.Add(medicalhist);
                Console.WriteLine("Medical  details added");
                FileStream fs = new FileStream("D:\\Training works\\Basic Solution\\Assignments\\PatientRecords\\PatientMedicalReport.txt"
                   , FileMode.Append, FileAccess.Write);


                StreamWriter sw = new StreamWriter(fs);
                sw.Write(medicalhist.PatientId + "\t");
                sw.Write(medicalhist.RecordId + "\t");

                sw.Write(medicalhist.Description + "\t");
                sw.Write(medicalhist.Date + "\t");
                sw.Write(" ");
                sw.Flush();
                sw.Close();
                fs.Close();
            }


        }
        public static void ViewDetails()
        {
            FileStream fs = new FileStream("D:\\Training Works\\Basic Solution\\Assignments\\PatientRecords\\PatientMedicalReport.txt"
                , FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadToEnd();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
    }
}
