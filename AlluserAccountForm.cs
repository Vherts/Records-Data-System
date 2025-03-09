using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordsDataSystem
{
    public partial class AlluserAccountForm: Form
    {
        readonly string PDFConnection = "Data Source=Bernice\\Sqlexpress;Initial Catalog=DB_PatientDataForm;Integrated Security=True;Encrypt=False";
        public AlluserAccountForm()
        {
            InitializeComponent();
            DIsplayUser();
        }
        public void DIsplayUser ()
        {
            using ( var con = new SqlConnection(PDFConnection))
            {
                con.Open();
                using (var cmd = new SqlCommand("SELECT Photo, DateRegister AS[Register], Role, Fullname, Position, Username, Password, RePassword AS[Re-Type Password] FROM TBL_UserAccount", con))
                {
                    using ( var sda = new SqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        sda.Fill(dt);

                        guna2DataGridView1.DataSource = dt;
                    }

                }
            }
        }
        public void AddUser ()
        {
            using ( var con = new SqlConnection(PDFConnection))
            {

                string Insert = "Insert Into TBL_UserAccount (Fullname, Username, Password, RePassword, Role, DateRegister)" +
                    "VALUES  (@Fullname, @Username, @Password, @RePassword, @Role, @DateRegister)";
                con.Open();
                using ( var cmd = new SqlCommand(Insert, con))
                {
                    cmd.Parameters.AddWithValue("@Fullname", txt_UserFullname.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Username", txt_User.Text.ToString());
                    cmd.Parameters.AddWithValue("@Password", txt_UserPass.Text.ToString());
                    cmd.Parameters.AddWithValue("@RePassword", txt_UserRetypePass.Text.ToString());
                    cmd.Parameters.AddWithValue("@Role", Cmb_UserRole.Text.ToString());
                    cmd.Parameters.AddWithValue("@DateRegister", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Account Created");
                    con.Close();
                    this.Close();

                }
            }
        }
        private void BTN_CreateUser_Click ( object sender, EventArgs e )
        {
            AddUser();
        }
    }
}
