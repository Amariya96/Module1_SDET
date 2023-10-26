using System;
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
    }
}
