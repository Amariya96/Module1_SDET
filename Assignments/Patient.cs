﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
        public int PatientId { get; set; }
        public string? PatientName { get; set; }
        public int Age { get; set; }
        public string? Diagnosis { get; set; }

        List<Patient> patientsDetails = new List<Patient>();

        public Patient(int patientId, string? patientName, int age, string? diagnosis)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Diagnosis = diagnosis;
        }

        public void AddPatientsDetails(Patient patient)
        {
            if ((patient.Age < 0 || patient.Age > 120))
            {
                throw new ArgumentException("Age should be between 0 and 120");
            }
            else if
                (patient.PatientName == "" || patient.Diagnosis == "")
            {

                throw new ArgumentException("Patient name and Diagnosiss should not be null");
            }
            else
            {
                patientsDetails.Add(patient);
                Console.WriteLine("Patient details added");

            }
        }
            public void CreateFilePatient()
            {
                FileStream fs = new FileStream("D:\\Training works\\Basic Solution\\Assignments\\PatientRecords\\PatientDetails.txt", FileMode.Create, FileAccess.Write);
               fs.Close();
            }
            public void PatientDetails(Patient patient)
        {
            FileInfo fi = new FileInfo("D:\\Training works\\Basic Solution\\Assignments\\PatientRecords\\PatientDetails.txt");
             if(!fi.Exists)
            {
                CreateFilePatient();
            }
             else
            {
                patientsDetails.Add(patient);
                Console.WriteLine("Patient Details Added");
                FileStream fs = new FileStream("D:\\Training works\\Basic Solution\\Assignments\\PatientRecords\\PatientDetails.txt",FileMode.Append,FileAccess.Write);

                StreamWriter sw= new StreamWriter(fs);
                sw.Write(patient.PatientId + "\t");
                sw.Write(patient.PatientName + "\t");
                sw.Write(patient.Age + "\t");
                sw.Write(patient.Diagnosis + "\t");
                sw.Write("");
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }
        public static void ViewDetails()
        {
            FileStream fs = new FileStream("D:\\Training works\\Basic Solution\\Assignments\\PatientRecords\\PatientDetails.txt"
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
