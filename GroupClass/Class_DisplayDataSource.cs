using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsDataSystem
{
    public class Class_DisplayDataSource
    {
        public static string DataSource ()
        {
            return "select Registry AS [Registry Date], Patient AS[Patient Name], Room, Physician AS[Attending Physician], ADMITTING_DIAGNOSIS AS [Admitting Diagnosis],Emergency AS[Admitted By]," +
        " DateModified AS[Date Modified], ADMISSION_DATE AS [Admission Date/Time], CHIEF_COMPLAIN AS [Chief Complaints], Prepared AS [Abstract Prepared By],CLINICAL_HISTORY AS [Clinical History and Pertinent P E], COURSEINWARD AS [Course in the ward]," +
        " PROCEDURE_DONE AS [Procedure's Done], Disposition, FINAL_DIAGNOSIS AS [Final Diagnosis], LICENSE AS [License no], PTR AS [PTR no], HOSPITAL_NO AS [Hospital no]," +
        " PastMedicalHistory AS[Past Medical History], FamilyHistory AS[Family History], PSocialHistory AS[Personal/Social History], ReviewSystem AS[Review System], " +
        " PhysicalExam AS[Physical Examination], Surgery AS[Surgeon], Anesthesiology, Gender, Status, Age, Address, UserID AS[Last Modified],  " +
        " DISCHARGE_DATE AS [Discharge Date/Time],   ID AS[Entry no.] " +
        " From TBL_MEDICAL_ABSTRACT  ORDER BY ID DESC";
        }
      

    }
}
