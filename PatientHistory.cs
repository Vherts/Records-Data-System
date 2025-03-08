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
        readonly string PDFConnection = "Data Source=Bernice\\Sqlexpress;Initial Catalog=DB_PatientDataForm;Integrated Security=True;Encrypt=False";
        public PatientHistory()
        {
            InitializeComponent();
            PanelPage1_flowLayoutPanel1.BringToFront();
        }
        //private void SaveHistory ()
        //{
        //    PHistory ph = new PHistory();
        //    ph.Name = txt_PatientName.Text.Trim().ToUpper();
        //    ph.HospitalNo = int.Parse(txt_HospitalNo.Text);
        //    ph.Physician = txt_Physcian.Text.Trim().ToUpper();
        //    ph.Room = txt_Room.Text.ToString();
        //}
        private void BTN_Save_Click ( object sender, EventArgs e )
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
                    string query = " Insert INTO TBL_PatientHistory (Name, HospitalNo, Attending, RoomNo, Status, Age, gender, DateRegister)" +
                        "VALUES (@Name, @HospitalNo, @Attending, @RoomNo, @Status, @Age, @gender, @DateRegister)";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txt_PatientName.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Attending", txt_Physcian.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@RoomNo", txt_Room.Text);
                        cmd.Parameters.AddWithValue("@HospitalNo", int.Parse(txt_HospitalNo.Text));
                        cmd.Parameters.AddWithValue("@Status", txt_Status.Text);
                        cmd.Parameters.AddWithValue("@Age", txt_Age.Text);
                        cmd.Parameters.AddWithValue("@Gender", txt_Gender.Text);
                        cmd.Parameters.AddWithValue("@DateRegister", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Patient Save!");
                        con.Dispose();
                        this.Close();
                    }
                }
            }
        }

        private void BTN_Page1_Click ( object sender, EventArgs e )
        {
            PanelPage1_flowLayoutPanel1.BringToFront();
        }

        private void BTN_Page2_Click ( object sender, EventArgs e )
        {
            //PanelPage2_flowLayoutPanel3.BringToFront();
        }
    }
}
