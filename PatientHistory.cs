using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace RecordsDataSystem
{
    public partial class PatientHistory: Form
    {
        readonly string PDFConnection = "Data Source=bernice\\sqlexpress;Initial Catalog=MRDSystem;Integrated Security=True;Encrypt=False";
        public PatientHistory()
        {
            InitializeComponent();
            panel1.BringToFront(); // Bring this panel to the front
        }
        //private void SaveHistory ()
        //{
        //    PHistory ph = new PHistory();
        //    ph.Name = txt_PatientName.Text.Trim().ToUpper();
        //    ph.HospitalNo = int.Parse(txt_HospitalNo.Text);
        //    ph.Physician = txt_Physcian.Text.Trim().ToUpper();
        //    ph.Room = txt_Room.Text.ToString();
        //}
        private void AddHistoryRecords ()
        {
            if (txt_PatientName.Text == string.Empty || txt_HospitalNo.Text == string.Empty)
            {
                MessageBox.Show("Field is empty, please input a data", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (var con = new SqlConnection(PDFConnection))
                {
                    con.Open();
                    string query = Class_InsertionQuery.InsertRecordsHis();
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Patient", txt_PatientName.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Physician", txt_Physcian.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Room", txt_Room.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Hospital_No", int.Parse(txt_HospitalNo.Text));
                        cmd.Parameters.AddWithValue("@Status", cmb_Status.Text);
                        cmd.Parameters.AddWithValue("@Age", txt_Age.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Gender", cmb_Gender.Text);
                        cmd.Parameters.AddWithValue("@Chief_Complain", txt_ChiefComplaints.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@HistoryofIllness", txt_PresentIlleness.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@PastMedicalHistory", txt_MedicalHistory.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@FamilyHistory", txt_FamilyHistory.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@PSocialHistory", txt_SocialHistory.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@ReviewSystem", txt_ReviewHistory.Text.ToUpper());

                        cmd.Parameters.AddWithValue("@BP", txt_BP.Text);
                        cmd.Parameters.AddWithValue("@RR", txt_RR.Text);
                        cmd.Parameters.AddWithValue("@HR", txt_HR.Text);
                        cmd.Parameters.AddWithValue("@Temp", txt_Temp);
                        cmd.Parameters.AddWithValue("@Height", txt_Height.Text);
                        cmd.Parameters.AddWithValue("@Weight", txt_Weight.Text);

                        cmd.Parameters.AddWithValue("@Discharge_Date", txt_DateDischarged.Text);
                        cmd.Parameters.AddWithValue("@Surgery", txt_Surgeon.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Anesthesiology", txt_Anesth.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@UserID", Lbl_UserName.Text);


                        cmd.Parameters.AddWithValue("@Registry", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        ClearTextHistory();
                        MessageBox.Show("Patient Save!");
                        con.Dispose();

                    }
                }
            }
        }
        private void BTN_Save_Click ( object sender, EventArgs e )
        {
            AddHistoryRecords();
        }
        private void AddHistoryRecordsAndClose ()
        {
            if (txt_PatientName.Text == string.Empty || txt_HospitalNo.Text == string.Empty)
            {
                MessageBox.Show("Field is empty, please input a data", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (var con = new SqlConnection(PDFConnection))
                {
                    con.Open();
                    string query = Class_InsertionQuery.InsertRecordsHis();
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Patient", txt_PatientName.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Physician", txt_Physcian.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Room", txt_Room.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Hospital_No", int.Parse(txt_HospitalNo.Text));
                        cmd.Parameters.AddWithValue("@Status", cmb_Status.Text);
                        cmd.Parameters.AddWithValue("@Age", txt_Age.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Gender", cmb_Gender.Text);
                        cmd.Parameters.AddWithValue("@Chief_Complain", txt_ChiefComplaints.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@HistoryofIllness", txt_PresentIlleness.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@PastMedicalHistory", txt_MedicalHistory.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@FamilyHistory", txt_FamilyHistory.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@PSocialHistory", txt_SocialHistory.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@ReviewSystem", txt_ReviewHistory.Text.ToUpper());

                        cmd.Parameters.AddWithValue("@BP", txt_BP.Text);
                        cmd.Parameters.AddWithValue("@RR", txt_RR.Text);
                        cmd.Parameters.AddWithValue("@HR", txt_HR.Text);
                        cmd.Parameters.AddWithValue("@Temp", txt_Temp);
                        cmd.Parameters.AddWithValue("@Height", txt_Height.Text);
                        cmd.Parameters.AddWithValue("@Weight", txt_Weight.Text);

                        cmd.Parameters.AddWithValue("@Discharge_Date", txt_DateDischarged.Text);
                        cmd.Parameters.AddWithValue("@Surgery", txt_Surgeon.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Anesthesiology", txt_Anesth.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@UserID", Lbl_UserName.Text);


                        cmd.Parameters.AddWithValue("@Registry", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        ClearTextHistory();
                        MessageBox.Show("Patient Save!");
                        con.Dispose();
                        this.Close();
                    }
                }
            }
        }
        private void BTN_SaveAndClose_Click ( object sender, EventArgs e )
        {
            AddHistoryRecordsAndClose();
            
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
