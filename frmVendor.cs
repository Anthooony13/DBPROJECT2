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
    public partial class frmVendor : Form
    {

        DataTable DTable;

        SqlDataAdapter DAdapter;
        SqlCommand DCommand;
        BindingSource DBindingSource;

        Boolean CancelUpdates;

        int idcolumn = 0;
        private object dgvVen;
        private object bNavVen;
        private int vendorid;

        public frmVendor()
        {
            InitializeComponent();
        }

        private void frmVendors_Load(object sender, EventArgs e)
        {
            this.CancelUpdates = true;
            this.BindMainGrid();
            this.FormatGrid();
            this.CancelUpdates = false;
        }

        private void BindMainGrid()
        {
            this.CancelUpdates = true;
            if (Globals.glOpenSqlConn())
            {
                this.DCommand = new SqlCommand("spGetAllVendors", Globals.sqlconn);
                this.DAdapter = new SqlDataAdapter(this.DCommand);

                this.DTable = new DataTable();

                this.DAdapter.Fill(DTable);

                this.DBindingSource = new BindingSource();
                this.DBindingSource.DataSource = DTable;

                dgvVen.DataSource = DBindingSource;
                this.bNavVen.BindingSource = this.DBindingSource;
            }
            this.CancelUpdates = false;
        }
        private void FormatGrid()
        {
            this.dgvVen.Columns["idVendor"].Visible = false;
            this.dgvVen.Columns["nameVendor"].HeaderText = "Login Name";
            this.dgvVen.Columns["addressVendor"].HeaderText = "Address";
            this.dgvVen.Columns["emailVendor"].HeaderText = "Email";
            this.dgvVen.Columns["contactVendor"].HeaderText = "Contact";

            this.BackColor = Globals.gDialogBackgroundColor;

            this.dgvVen.BackgroundColor = Globals.gGridOddRowColor;
            this.dgvVen.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvVen.EnableHeadersVisualStyles = false;
            this.dgvVen.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;
        }

        private void dgvVen_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))

            {

                e.Graphics.DrawString(

                    String.Format("{0,10}", (e.RowIndex + 1).ToString()),

                    e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);

            }
        }

        private void dgvVen_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int firstDisplayedCellIndex = dgvVen.FirstDisplayedCell.RowIndex;

            int lastDisplayedCellIndex = firstDisplayedCellIndex + dgvVen.DisplayedRowCount(true);


            Graphics Graphics = dgvVen.CreateGraphics();

            int measureFirstDisplayed = (int)(Graphics.MeasureString(firstDisplayedCellIndex.ToString(), dgvVen.Font).Width);

            int measureLastDisplayed = (int)(Graphics.MeasureString(lastDisplayedCellIndex.ToString(), dgvVen.Font).Width);


            int rowHeaderWitdh = System.Math.Max(measureFirstDisplayed, measureLastDisplayed);

            dgvVen.RowHeadersWidth = rowHeaderWitdh + 40;

        }

        private void dgvVen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            {

                long venomerid = 0;
                long newvenomerid;

                if (this.CancelUpdates == false && this.dgvVen.CurrentRow != null)

                {

                    if (Globals.glOpenSqlConn())

                    {

                        DataGridViewRow row = dgvVen.CurrentRow;

                        String venname = row.Cells["nameVendor"].Value == DBNull.Value ? ""

                        : row.Cells["nameVendor"].Value.ToString().ToUpper();

                        String venadd = row.Cells["addressVendor"].Value == DBNull.Value ? ""

                        : row.Cells["addressVendor"].Value.ToString();

                        String venemail = row.Cells["emailVendor"].Value == DBNull.Value ? ""

                        : row.Cells["emailVendor"].Value.ToString();

                        String vennum = row.Cells["contactVendor"].Value == DBNull.Value ? ""

                        : row.Cells["contactVendor"].Value.ToString();




                        if (row.Cells["nameVendor"].Value == DBNull.Value)

                        {

                            csMessageBox.Show("Please encode a valid user name", "Warning",

                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            object value = dgvVen.CancelEdit();

                        }

                        else

                        {

                            try

                            {

                                SqlCommand cmd = new SqlCommand("spVendorAddEdit", Globals.sqlconn);

                                cmd.CommandType = CommandType.StoredProcedure;

                                if (row.Cells[this.idcolumn].Value == DBNull.Value)

                                    vendorid = 0;

                                else

                                    vendorid = Convert.ToInt64(row.Cells[this.idcolumn].Value);

                                cmd.Parameters.AddWithValue("@vid", vendorid);

                                cmd.Parameters.AddWithValue("@vname", venname);

                                cmd.Parameters.AddWithValue("@vaddress", venadd);

                                cmd.Parameters.AddWithValue("@vemail", venemail);

                                cmd.Parameters.AddWithValue("@vnum", vennum);



                                SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);

                                DataTable dt = new DataTable();

                                dAdapt.Fill(dt);

                                newvenomerid = long.Parse(dt.Rows[0][0].ToString());dgvVen

                                if (venomerid == 0)
                                    row.Cells["idVendor"].Value = newvenomerid;
                            }

                            catch (Exception ex)

                            {
                                csMessageBox.Show("Exception Error:" + ex.Message,

                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }

                        }
                        Globals.glCloseSqlConn();
                    }
                    Globals.glCloseSqlConn();
                }

            }
        }

        private void dgvVen_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvVen_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            bool cancel = true;

            DataGridViewRow row = this.dgvVen.CurrentRow;
            String name = row.Cells["nameVendor"].Value.ToString().Trim();

            if (row.Cells[idcolumn].Value != DBNull.Value &&
               csMessageBox.Show("Delete the user:" + name, "Please confirm.",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Globals.glOpenSqlConn())
                {

                    SqlCommand cmd = new SqlCommand("dbo.spVendorsDelete", Globals.sqlconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vid", Convert.ToInt64(row.Cells[idcolumn].Value));
                    cmd.ExecuteNonQuery();

                    cancel = false;

                }
                Globals.glCloseSqlConn();
            }
            else e.Cancel = true;
        }
        private void EditGrid()
        {
            this.dgvVen.Columns["idVendor"].Visible = true;
            this.dgvVen.Columns["nameVendor"].HeaderText = "Login Name";
            this.dgvVen.Columns["addressVendor"].HeaderText = "Address";
            this.dgvVen.Columns["emailVendor"].HeaderText = "Email";
            this.dgvVen.Columns["contactVendor"].HeaderText = "Contact";

            this.BackColor = Globals.gDialogBackgroundColor;

            this.dgvVen.BackgroundColor = Globals.gGridOddRowColor;
            this.dgvVen.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvVen.EnableHeadersVisualStyles = false;
            this.dgvVen.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;
        }
    }
}
