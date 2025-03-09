using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordsDataSystem
{
    public partial class Update_PatientHistory: Form
    {
        public Update_PatientHistory()
        {
            InitializeComponent();
        }

        private void BTN_UpdateAndClose_Click ( object sender, EventArgs e )
        {
            InsertDataHistory();
            ClearTextHistory();
            this.Close();
        }
        private void InsertDataHistory ()
        {

        }
        private void ClearTextHistory ()
        {
            txt_PatientName.Text = string.Empty;
            txt_HospitalNo.Text = string.Empty;
            txt_Physcian.Text = string.Empty;
            txt_Age.Text = string.Empty;
            cmb_Gender.SelectedIndex = 0;
            txt_Room.Text = string.Empty;
            cmb_Status.SelectedIndex = 0;
            txt_ChiefComplaints.Text = string.Empty;
            txt_FamilyHistory.Text = string.Empty;
            txt_MedicalHistory.Text = string.Empty;
            txt_PresentIlleness.Text = string.Empty;
            txt_ReviewHistory.Text = string.Empty;
            txt_SocialHistory.Text = string.Empty;
            txt_BP.Text = string.Empty;
            txt_RR.Text = string.Empty;
            txt_HR.Text = string.Empty;
            txt_Temp.Text = string.Empty;
            txt_Weight.Text = string.Empty;
            txt_Height.Text = string.Empty;
            txt_APhysician.Text = string.Empty;
            txt_EvaluationDiagnosis.Text = string.Empty;
            txt_DateDischarged.Text = string.Empty;
            txt_Surgeon.Text = string.Empty;
            txt_Anesth.Text = string.Empty;
            txt_EvaluationDiagnosis.Text = string.Empty;
            cmb_ER_Physician.SelectedIndex = 0;
            txt_FinalDiagnosis.Text = string.Empty;


        }
    }
}
