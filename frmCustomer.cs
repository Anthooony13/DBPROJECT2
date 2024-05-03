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
    public partial class frmCustomer : Form
    {
        DataTable DTable;

        SqlDataAdapter DAdapter;
        SqlCommand DCommand;
        BindingSource DBindingSource;

        Boolean CancelUpdates;

        int idcolumn = 0;
        private object dgvCust;
        private object bNavCust;

        public frmCustomer()
        {
            InitializeComponent();
        }
        private void frmCustomers_Load(object sender, EventArgs e)
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
                this.DCommand = new SqlCommand("spGetAllCustomers", Globals.sqlconn);
                this.DAdapter = new SqlDataAdapter(this.DCommand);

                this.DTable = new DataTable();

                this.DAdapter.Fill(DTable);

                this.DBindingSource = new BindingSource();
                this.DBindingSource.DataSource = DTable;

                dgvCust.DataSource = DBindingSource;
                this.bNavCust.BindingSource = this.DBindingSource;
            }
            this.CancelUpdates = false;
        }
        private void FormatGrid()
        {
            this.dgvCust.Columns["idCustomer"].Visible = false;
            this.dgvCust.Columns["nameCustomer"].HeaderText = "Login Name";
            this.dgvCust.Columns["addressCustomer"].HeaderText = "Address";
            this.dgvCust.Columns["emailCustomer"].HeaderText = "Email";
            this.dgvCust.Columns["contactCustomer"].HeaderText = "Contact";

            this.BackColor = Globals.gDialogBackgroundColor;

            this.dgvCust.BackgroundColor = Globals.gGridOddRowColor;
            this.dgvCust.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvCust.EnableHeadersVisualStyles = false;
            this.dgvCust.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;
        }

        private void dgvCust_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            {

                long customerid = 0;
                long newcustomerid;

                if (this.CancelUpdates == false && this.dgvCust.CurrentRow != null)

                {

                    if (Globals.glOpenSqlConn())

                    {

                        DataGridViewRow row = dgvCust.CurrentRow;

                        String custname = row.Cells["nameCustomer"].Value == DBNull.Value ? ""

                        : row.Cells["nameCustomer"].Value.ToString().ToUpper();

                        String custadd = row.Cells["addressCustomer"].Value == DBNull.Value ? ""

                        : row.Cells["addressCustomer"].Value.ToString();

                        String custemail = row.Cells["emailCustomer"].Value == DBNull.Value ? ""

                        : row.Cells["emailCustomer"].Value.ToString();

                        String custnum = row.Cells["contactCustomer"].Value == DBNull.Value ? ""

                        : row.Cells["contactCustomer"].Value.ToString();




                        if (row.Cells["nameCustomer"].Value == DBNull.Value)

                        {

                            csMessageBox.Show("Please encode a valid user name", "Warning",

                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            dgvCust.CancelEdit();

                        }

                        else

                        {

                            try

                            {

                                SqlCommand cmd = new SqlCommand("spCustomersAddEdit", Globals.sqlconn);

                                cmd.CommandType = CommandType.StoredProcedure;

                                if (row.Cells[this.idcolumn].Value == DBNull.Value)

                                    customerid = 0;

                                else

                                    customerid = Convert.ToInt64(row.Cells[this.idcolumn].Value);

                                cmd.Parameters.AddWithValue("@cid", customerid);

                                cmd.Parameters.AddWithValue("@cname", custname);

                                cmd.Parameters.AddWithValue("@caddress", custadd);

                                cmd.Parameters.AddWithValue("@cemail", custemail);

                                cmd.Parameters.AddWithValue("@cnum", custnum);



                                SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);

                                DataTable dt = new DataTable();

                                dAdapt.Fill(dt);

                                newcustomerid = long.Parse(dt.Rows[0][0].ToString());

                                if (customerid == 0)
                                    row.Cells["idCustomer"].Value = newcustomerid;
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

        private void EditGrid()
        {
            this.dgvCust.Columns["idCustomer"].Visible = true;
            this.dgvCust.Columns["nameCustomer"].HeaderText = "Login Name";
            this.dgvCust.Columns["addressCustomer"].HeaderText = "Address";
            this.dgvCust.Columns["emailCustomer"].HeaderText = "Email";
            this.dgvCust.Columns["contactCustomer"].HeaderText = "Contact";

            this.BackColor = Globals.gDialogBackgroundColor;

            this.dgvCust.BackgroundColor = Globals.gGridOddRowColor;
            this.dgvCust.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvCust.EnableHeadersVisualStyles = false;
            this.dgvCust.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvCust_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvCust_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            bool cancel = true;

            DataGridViewRow row = this.dgvCust.CurrentRow;
            String name = row.Cells["nameCustomer"].Value.ToString().Trim();

            if (row.Cells[idcolumn].Value != DBNull.Value &&
               csMessageBox.Show("Delete the user:" + name, "Please confirm.",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Globals.glOpenSqlConn())
                {

                    SqlCommand cmd = new SqlCommand("dbo.spCustomersDelete", Globals.sqlconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cid", Convert.ToInt64(row.Cells[idcolumn].Value));
                    cmd.ExecuteNonQuery();

                    cancel = false;

                }
                Globals.glCloseSqlConn();
            }
            else e.Cancel = true;
        }

        private void dgvCust_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))

            {

                e.Graphics.DrawString(

                    String.Format("{0,10}", (e.RowIndex + 1).ToString()),

                    e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);

            }
        }

        private void dgvCust_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int firstDisplayedCellIndex = dgvCust.FirstDisplayedCell.RowIndex;

            int lastDisplayedCellIndex = firstDisplayedCellIndex + dgvCust.DisplayedRowCount(true);


            Graphics Graphics = dgvCust.CreateGraphics();

            int measureFirstDisplayed = (int)(Graphics.MeasureString(firstDisplayedCellIndex.ToString(), dgvCust.Font).Width);

            int measureLastDisplayed = (int)(Graphics.MeasureString(lastDisplayedCellIndex.ToString(), dgvCust.Font).Width);


            int rowHeaderWitdh = System.Math.Max(measureFirstDisplayed, measureLastDisplayed);

            dgvCust.RowHeadersWidth = rowHeaderWitdh + 40;
        }


    }
}
