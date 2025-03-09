using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordsDataSystem.GroupClass
{
    public class Class_DataGridViewColumnToHide
    {
        public static void ColomnToHide ( DataGridView ColumnHide )
        {
            ColumnHide.Columns["License no"].Visible = false;
            ColumnHide.Columns["PTR no"].Visible = false;
            ColumnHide.Columns["Hospital no"].Visible = false;
            ColumnHide.Columns["Entry no."].Visible = false;
            ColumnHide.Columns["Address"].Visible = false;

            ColumnHide.Columns["Anesthesiology"].Visible = false;
            ColumnHide.Columns["Surgeon"].Visible = false;

            ColumnHide.Columns["Gender"].Visible = false;
            ColumnHide.Columns["Status"].Visible = false;

            ColumnHide.Columns["Past Medical History"].Visible = false;
            ColumnHide.Columns["Family History"].Visible = false;
            ColumnHide.Columns["Personal/Social History"].Visible = false;
            ColumnHide.Columns["Review System"].Visible = false;
            ColumnHide.Columns["Physical Examination"].Visible = false;

            ColumnHide.Columns["Procedure's Done"].Visible = false;
            ColumnHide.Columns["Disposition"].Visible = false;
        }
    }
}
