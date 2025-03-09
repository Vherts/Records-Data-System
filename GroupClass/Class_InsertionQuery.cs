using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsDataSystem
{
    public class Class_InsertionQuery
    {
        public static string InsertRecordsHis ()
        {
            return "Insert into TBL_MEDICAL_ABSTRACT (" +
                "Registry, " +
                "Patient, " +
                "Gender, " +
                "Status, " +
                "Age, " +
                "Hospital_no, " +
                "Room, " +
                "Physician, " +
                "Chief_Complain, " +
                //"Clinical_history, " +
                "PastMedicalHistory, " +
                "FamilyHistory, " +
                "PSocialHistory, " +
                "ReviewSystem " +
                "Admitting_Diagnosis, " +
                "Emergency, " +
                "PhysicalExam, " +
                "Surgery, " +
                "Anesthesiology, " +
                "UserID, " +
                "BP," +
                "RR," +
                "HR," +
                "Temp." +
                "Weight," +
                "Height," +
                //"DateModified" +
                ") " +
                "Values " +
                "( " +
                "@Registry, " +
                "@Patient, " +
                "@Gender, " +
                "@Status, " +
                "@Age, " +
                "@Hospital_no, " +
                "@Room, " +
                "@Physician, " +
                "@Chief_Complain, " +
                //"@Clinical_History, " +
                "@PastMedicalHistory, " +
                "@FamilyHistory," +
                "@PSocialHistory, " +
                "@ReviewSystem " +
                "@Admitting_Diagnosis, " +
                "@Emergency, " +
                "@PhysicalExam, " +
                "@Surgery, " +
                "@Anesthesiology, " +
                "@UserID," +
                "@BP," +
                "@RR," +
                "@HR," +
                "@Temp," +
                "@Height," +
                "@Weight " +
                //"@DateMOdified" +
                ")";
        }
    }
}
