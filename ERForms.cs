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
    public partial class ERForms: Form
    {
        public ERForms()
        {
            InitializeComponent();
        }

        private void BTN_Close_Click ( object sender, EventArgs e )
        {
            this.Close();
        }

        private void BTN_Save_Click ( object sender, EventArgs e )
        {

        }

        private void ERForms_Load ( object sender, EventArgs e )
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
