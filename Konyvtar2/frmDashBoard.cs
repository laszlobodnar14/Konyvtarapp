using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Konyvtar2
{
    public partial class frmDashBoard : Form
    {
        SqlCommand cmd= new SqlCommand();
        string sql;
        DBConnection conn= new DBConnection();
        public frmDashBoard()
        {
            InitializeComponent();
        }
        private int totalStudent()
        {
            SqlDataReader DR;
            int counter = 0;
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open) {
                    sql = "SELECT * FROM StudentDetail";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    DR = cmd.ExecuteReader();
                    while ( DR.Read() ) {
                        counter++;
                    }
                    DR.Close();
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
            return counter;
        }
        private int totalCategory()
        {
            SqlDataReader DR;
            int counter = 0;
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    sql = "SELECT * FROM CategoryDetail";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    DR = cmd.ExecuteReader();
                    while (DR.Read())
                    {
                        counter++;
                    }
                    DR.Close();
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
            return counter;
        }

        private int totalPublisher()
        {
            SqlDataReader DR;
            int counter = 0;
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    sql = "SELECT * FROM BindingDetail";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    DR = cmd.ExecuteReader();
                    while (DR.Read())
                    {
                        counter++;
                    }
                    DR.Close();
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
            return counter;
        }
        private int totalBook()
        {
            SqlDataReader DR;
            int counter = 0;
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    sql = "SELECT * FROM Book_Detail";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    DR = cmd.ExecuteReader();
                    while (DR.Read())
                    {
                        counter++;
                    }
                    DR.Close();
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
            return counter;
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            lblTotalStudent.Text += totalStudent();
            lbKiadok.Text += totalPublisher();
            lbKonyvek.Text += totalBook();
            lblCategory.Text += totalCategory();
            btnhome.Enabled = false;
            
            
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            frmPublish publish = new frmPublish();
            publish.Show();
            Dispose();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            Dispose();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBook book = new frmBook();
            book.Show();
            Dispose( );
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent student = new frmStudent();
            student.Show(); 
            Dispose( );
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmDetail detail = new frmDetail();
            detail.Show();
            Dispose( );

        }
    }
}
