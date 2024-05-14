using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konyvtar2
{
    public partial class frmBook : Form
    {
        private DBConnection conn = new DBConnection();
        private SqlCommand cmd = new SqlCommand();
        private string sql;
        public frmBook()
        {
            InitializeComponent();
        }
        private void loadCategory()
        {
            SqlDataReader reader;
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    sql = "SELECT * FROM CategoryDetail";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbCategory.Items.Add(reader.GetValue(1).ToString());
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.connection().Close();
            }
        }
        private void loadPublisher()
        {
            SqlDataReader reader;
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    sql = "SELECT * FROM BindingDetail";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbPublisher.Items.Add(reader.GetValue(1).ToString());
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.connection().Close();
            }
        }
        private void frmBook_Load(object sender, EventArgs e)
        {
            loadCategory();
            loadPublisher();
            btnBook.Enabled = false;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    sql = "SELECT * FROM Book_Detail";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(dt);
                    dgvBook.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.connection().Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex >= 0)
            {
                txtID.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
                txtTitle.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
                cmbCategory.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
                cmbPublisher.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
                txtPubYear.Text = dgvBook.CurrentRow.Cells[4].Value.ToString();
                txtACopy.Text = dgvBook.CurrentRow.Cells[5].Value.ToString();
                txtCCopy.Text = dgvBook.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            frmDashBoard dashBoard = new frmDashBoard();
            dashBoard.Show();
            Dispose();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            Dispose( );
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlDataReader reader;
            string catID = "", pubID = "";
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    sql = "SELECT Category_Name FROM CategoryDetail WHERE Category_Name = '" + cmbCategory.Text + "'";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        catID = reader.GetString(0);
                    }
                    reader.Close();

                    sql = "SELECT Binding_Name FROM BindingDetail WHERE Binding_Name = '" + cmbPublisher.Text + "'";
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pubID = reader.GetString(0);
                    }
                    reader.Close();

                    if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtPubYear.Text))
                    {
                        MessageBox.Show("One or more fields are empty");
                    }
                    else
                    {
                        sql = "INSERT INTO Book_Detail(id, Book_Title, Category_Name, Binding_Name, Publication_Year, Actual_No_Of_Copy, Current_No_Of_Copy)" +
                            "VALUES('" + txtID.Text + "','" + txtTitle.Text + "','" + cmbCategory.Text + "','" + cmbPublisher.Text + "'," + int.Parse(txtPubYear.Text) + "," + int.Parse(txtACopy.Text) + ",'" + txtCCopy.Text + "')";
                        cmd.CommandText = sql;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Book Added Successfully");
                            txtID.Clear();
                            txtTitle.Clear();
                            txtPubYear.Clear();
                            txtACopy.Clear();
                            txtCCopy.Clear();
                            cmbPublisher.ResetText();
                            cmbCategory.ResetText();
                            sql = "SELECT * FROM Book_Detail";
                            cmd.CommandText = sql;
                            dataAdapter.SelectCommand = cmd;
                            dataAdapter.Fill(dt);
                            dgvBook.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Error: Book was not added");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.connection().Close();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    sql = "DELETE FROM Book_Detail WHERE id ='" + txtID.Text + "'";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Book Deleted");
                        txtID.Clear();
                        txtTitle.Clear();
                        txtPubYear.Clear();
                        txtACopy.Clear();
                        txtCCopy.Clear();
                        cmbPublisher.ResetText();
                        cmbCategory.ResetText();
                        sql = "SELECT * FROM Book_Detail";
                        cmd.CommandText = sql;
                        dataAdapter.SelectCommand = cmd;
                        dataAdapter.Fill(dt);
                        dgvBook.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Error: Book was not deleted");
                    }
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.connection().Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlDataReader reader;
            int pubID = 0,  catID = 0;
            try
            {
                conn.connection().Open();
                if(conn.connection().State == ConnectionState.Open)
                {
                    sql = "SELECT Catagory_ID FROM CategoryDetail WHERE Category_Name = '" + cmbCategory.Text + "'";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        catID = reader.GetInt32(0);
                    }
                    reader.Close();

                    sql = "SELECT Binding_ID FROM BindingDetail WHERE Binding_Name = '" + cmbPublisher.Text + "'";
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pubID = reader.GetInt32(0);
                    }
                    reader.Close();

                    if (txtID.Text.Length == 0 || txtTitle.Text.Length == 0 || txtPubYear.Text.Length == 0)
                    {
                        MessageBox.Show("One or more fields are empty");
                    }
                    else
                    {
                        sql = "Update Book_Detail SET Book_Title= '" + txtTitle.Text + "', Category_Name = " + catID + ", Binding_Name=" + pubID + ", publication_Year= " + int.Parse(txtPubYear.Text) +
                            ", Actual_No_Of_Copy=" + int.Parse(txtACopy.Text) + ", Current_No_Of_Copy=" + int.Parse(txtCCopy.Text) + "WHERE id ='" + txtID.Text + "'";
                        cmd.CommandText = sql;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Book Updated");
                            txtID.Clear();
                            txtTitle.Clear();
                            txtPubYear.Clear();
                            txtACopy.Clear();
                            txtCCopy.Clear();
                            cmbPublisher.ResetText();
                            cmbCategory.ResetText();
                            sql = "SELECT * FROM Book_Detail";
                            cmd.CommandText = sql;
                            dataAdapter.SelectCommand = cmd;
                            dataAdapter.Fill(dt);
                            dgvBook.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Error: Book was not updated");
                        }
                    }
                }
            }   
            catch(SqlException ex) { MessageBox.Show(ex.ToString()); }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() );
            }
            finally
            {
                conn.connection().Close();
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent student = new frmStudent();
            student.Show();
            Dispose();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmDetail category = new frmDetail();
            category.Show();
            Dispose();
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            frmPublish publish = new frmPublish();
            publish.Show();
            Dispose();
        }
    }
}
