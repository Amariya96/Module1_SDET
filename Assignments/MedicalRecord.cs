using Assignments.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalRecord : Patient
    {

        public MedicalRecord(int recId, double treCost, int patientId, string? patientName, int age, string? diagnosis) : base(patientId, patientName, age, diagnosis)
        {
            RecId = recId;
            TreCost = treCost;
        }

        public int RecId { get; set; }
        public double TreCost { get; set; }

        List<MedicalRecord> medicalRecords = new List<MedicalRecord>();
        public void Validate(MedicalRecord medicalRecord)
        {

            if (PatientName == null || Diagnosis == null)
            {
                throw new InvalidPatientRecordException(ExcepMess.excep[1]);
            }
            else if (TreCost < 0)
            {
                throw new InvalidDataException(ExcepMess.excep[2]);
            }
            else
            {
                medicalRecords.Add(medicalRecord);
                Console.WriteLine("Patient Details Added");
            }
        }    
    }
}
