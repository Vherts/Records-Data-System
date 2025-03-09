using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordsDataSystem
{
    public class Class_DataGridViewResizingColumns
    {
        public static void ResizeColumnWidth ( DataGridView gridView )
        {
            if (gridView == null) return;

            gridView.Columns["Age"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            gridView.Columns["Room"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            gridView.Columns["Patient Name"].DefaultCellStyle.Padding = new Padding(0, 0, 0, 5);
            gridView.Columns["Registry Date"].DefaultCellStyle.Padding = new Padding(0, 0, 0, 5);

            gridView.Columns["Chief Complaints"].Width = 400;
            gridView.Columns["Admitting Diagnosis"].Width = 400;
            gridView.Columns["Clinical History and Pertinent P E"].Width = 200;
            gridView.Columns["Course in the ward"].Width = 200;
            gridView.Columns["Final Diagnosis"].Width = 200;
            gridView.Columns["Registry Date"].Width = 120;
            gridView.Columns["Patient Name"].Width = 180;
            gridView.Columns["Age"].Width = 50;
            gridView.Columns["Attending Physician"].Width = 250;
            gridView.Columns["Abstract Prepared By"].Width = 200;
            gridView.Columns["Room"].Width = 50;
            gridView.Columns["Admitted By"].Width = 200;

            gridView.EnableHeadersVisualStyles = false;
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }
    }
}
