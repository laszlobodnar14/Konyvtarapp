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

namespace Konyvtar2
{
    public partial class frmDetail : Form
    {
        private DBConnection conn = new DBConnection();
        private SqlCommand cmd = new SqlCommand();
        private string sql;
        public frmDetail()
        {
            InitializeComponent();
        }

        private void frmDetail_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                conn.connection().Open();
                if (conn.connection().State== ConnectionState.Open )
                {
                    sql = "SELECT * FROM CategoryDetail";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    sqlDataAdapter.SelectCommand = cmd;
                    sqlDataAdapter.Fill(dt);
                    dgvDetail.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
            finally
            {
                conn.connection().Close();
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            frmDashBoard home = new frmDashBoard();
            home.Show();
            Dispose();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBook book = new frmBook();
            book.Show();
            Dispose();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent student = new frmStudent();
            student.Show();
            Dispose();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    
                    sql = "INSERT INTO CategoryDetail(Catagory_ID, Category_Name) VALUES (@CatagoryID, @CategoryName)";

                    
                    SqlCommand cmd = new SqlCommand(sql, conn.connection());

                    
                    cmd.Parameters.AddWithValue("@CatagoryID", txtID.Text); 
                    cmd.Parameters.AddWithValue("@CategoryName", txtName.Text); 

                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error: Category was not added");
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
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    
                    sql = "DELETE FROM CategoryDetail WHERE Catagory_ID = @CatagoryID";

                    
                    SqlCommand cmd = new SqlCommand(sql, conn.connection());

                    
                    cmd.Parameters.AddWithValue("@CatagoryID", txtID.Text); 

                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error: Category was not deleted");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                   
                    sql = "UPDATE CategoryDetail SET Category_Name = @CategoryName WHERE Catagory_ID = @CatagoryID";

                   
                    SqlCommand cmd = new SqlCommand(sql, conn.connection());

                   
                    cmd.Parameters.AddWithValue("@CategoryName", txtName.Text); 
                    
                    cmd.Parameters.AddWithValue("@CatagoryID", txtID.Text); 

                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error: Category was not updated");
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

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            frmPublish publish = new frmPublish();
            publish.Show();
            Dispose();
        }
    }
}
