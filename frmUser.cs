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

namespace DBPROJECT
{
    public partial class frmUser : Form
    {
        DataTable DTable;
        //DataSet DTable;
        SqlDataAdapter DAdapter;
        SqlCommand DCommand;
        BindingSource DBindingSource;
        int idcolumn = 0;
        public frmUser()
        {
            InitializeComponent();
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            this.BindMainGrid();
            this.FormatGrid();
        }
        private void BindMainGrid()
        {
            if (Globals.glOpenSqlConn())
            {
                this.DCommand = new SqlCommand("spGetAllUsers", Globals.sqlconn);
                this.DAdapter = new SqlDataAdapter(this.DCommand);

                this.DTable = new DataTable();

                this.DAdapter.Fill(DTable);

                this.DBindingSource = new BindingSource();
                this.DBindingSource.DataSource = DTable;

                dgvMain.DataSource = DBindingSource;
                this.bNavMain.BindingSource = this.DBindingSource;
            }
        }
        private void FormatGrid()
        {
            this.dgvMain.Columns["id"].Visible = false;
            this.dgvMain.Columns["loginname"].HeaderText = "Login Name";
            this.dgvMain.Columns["active"].HeaderText = "Active";
            this.dgvMain.Columns["mustchangepwd"].HeaderText = "Must Change PWD";
            this.dgvMain.Columns["email"].HeaderText = "Email";
            this.dgvMain.Columns["smtphost"].HeaderText = "SMTP Host";
            this.dgvMain.Columns["smtpport"].HeaderText = "SMTP Port";
            this.dgvMain.Columns["gender"].HeaderText = "Gender";
            this.dgvMain.Columns["birthdate"].HeaderText = "BirthDay";

            this.BackColor = Globals.gDialogBackgroundColor;

            this.dgvMain.BackgroundColor = Globals.gGridOddRowColor;
            this.dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;
        }

        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))

            {

                e.Graphics.DrawString(

                    String.Format("{0,10}", (e.RowIndex + 1).ToString()),

                    e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);

            }
        }

        private void dgvMain_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int firstDisplayedCellIndex = dgvMain.FirstDisplayedCell.RowIndex;

            int lastDisplayedCellIndex = firstDisplayedCellIndex + dgvMain.DisplayedRowCount(true);



            Graphics Graphics = dgvMain.CreateGraphics();

            int measureFirstDisplayed = (int)(Graphics.MeasureString(firstDisplayedCellIndex.ToString(), dgvMain.Font).Width);

            int measureLastDisplayed = (int)(Graphics.MeasureString(lastDisplayedCellIndex.ToString(), dgvMain.Font).Width);



            int rowHeaderWitdh = System.Math.Max(measureFirstDisplayed, measureLastDisplayed);

            dgvMain.RowHeadersWidth = rowHeaderWitdh + 40;
        }

        private void dgvMain_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int row;

            row = this.dgvMain.SelectedRows[0].Index + 1;

            if (csMessageBox.Show("Delete Row # " + row.ToString(), "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                if (this.dgvMain.SelectedRows.Count > 0)

                    e.Cancel = false;

                else e.Cancel = true;

            }
            else e.Cancel = true;
        }
    }
}
