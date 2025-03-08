using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordsDataSystem
{
    public partial class Form1: Form
    {
        readonly string PDFConnection = "Data Source=Bernice\\Sqlexpress;Initial Catalog=DB_PatientDataForm;Integrated Security=True;Encrypt=False";
        public Form1()
        {
            InitializeComponent();
            DisplayData();
            PatientHistory_guna2DataGridView1.BringToFront();
        }
        #region
        private void BTN_EXIT_Click ( object sender, EventArgs e )
        {
            Application.Exit();
            Dispose();
        }

        private void BTN_Maximize_Click ( object sender, EventArgs e )
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        private void BTN_Minimiz_Click ( object sender, EventArgs e )
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ExitApps ()
        {
            DialogResult close = MessageBox.Show("Are you sure?", "Logout Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.Yes)
            {
                Application.Exit();
                this.Dispose();
            }
        }
        private void BTN_Logout_Click ( object sender, EventArgs e )
        {
            ExitApps();
        }

        private void exitToolStripMenuItem1_Click ( object sender, EventArgs e )
        {
            Application.Exit();
            this.Dispose();
        }

        private void exitToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            ExitApps();
        }
        #endregion
        private void DisplayData ()
        {
            using (var con = new SqlConnection(PDFConnection))
            {
                con.Open();
                using ( var cmd = new SqlCommand("Select DateRegister AS[Date Register], Name AS[Patient Name], HospitalNo, Attending AS[Attending Physician], " +
                    "RoomNo, Status, Age, gender  From TBL_PatientHistory", con))
                {
                    using ( var sda = new SqlDataAdapter(cmd))
                    {
                        using (var dt = new DataTable())
                        {
                            sda.Fill(dt);

                            PatientHistory_guna2DataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }
        private void BTN_Homepage_Click ( object sender, EventArgs e )
        {
            PatientHistory_guna2DataGridView1.BringToFront();
        }
        private void PatientHistory ()
        {
            var open = new PatientHistory();open.ShowDialog();
        }

        private void BTN_PatientHistory_Click ( object sender, EventArgs e )
        {
            PatientHistory();
        }

        private void createPatientHistoryToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            PatientHistory();
        }

        private void BTN_MedicalAbstract_Click ( object sender, EventArgs e )
        {
            var open = new MedicalAbstract(); open.ShowDialog();
        }

        private void createMedicalAbstractToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            var open = new MedicalAbstract(); open.ShowDialog();
        }

        private void BTN_ERTransfer_Click ( object sender, EventArgs e )
        {
            var open = new ERForms(); open.ShowDialog();
            ER_guna2DataGridView1.BringToFront();
        }

        private void createERTransferToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void BTN_MedicalCertificate_Click ( object sender, EventArgs e )
        {

        }

        private void createMedicalCertificateToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void BTN_SummaryReport_Click ( object sender, EventArgs e )
        {

        }

        private void BTN_All_user_Click ( object sender, EventArgs e )
        {
            var open = new AlluserAccountForm();open.ShowDialog();
        }
        #region ToolStrip
        private void refreshToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            DisplayData();
            PatientHistory_guna2DataGridView1.BringToFront();
        }

        private void removeToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void Form_ERTransferToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void Form_medicalAbstractToolStripMenuItem1_Click ( object sender, EventArgs e )
        {

        }

        private void Form_MedicalCertificateToolStripMenuItem1_Click ( object sender, EventArgs e )
        {

        }

        private void Form_PatientHistoryToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void Edit_eRTransferToolStripMenuItem1_Click ( object sender, EventArgs e )
        {

        }

        private void Edit_medicalAbstractToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void Edit_patientHistoryToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void Edit_patientHistoryToolStripMenuItem2_Click ( object sender, EventArgs e )
        {

        }

        #endregion

    }
}
