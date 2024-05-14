using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konyvtar2
{
    public partial class frmStudent : Form
    {
        private DBConnection conn = new DBConnection();
        private SqlCommand cmd = new SqlCommand();
        private string sql;
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            btnStudent.Enabled = false;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    sql = "SELECT * FROM StudentDetail";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(dt);
                    dgvStudent.DataSource = dt;
                    
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn.connection().State == ConnectionState.Open)
                {
                    conn.connection().Close();
                }
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    conn.connection().Open();
                    if (conn.connection().State == ConnectionState.Open)
                    {
                        if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtPhone.Text))
                        {
                            MessageBox.Show("Egy vagy több cella üres");
                        }
                        else
                        {
                            sql = "INSERT INTO StudentDetail(StudentID, Full_Name, Gender, Date_Of_Birth, Department, Phone_Number) VALUES (@StudentID, @FullName, @Gender, @DateOfBirth, @Department, @PhoneNumber)";
                            cmd.Connection = conn.connection();
                            cmd.CommandText = sql;
                            cmd.Parameters.AddWithValue("@StudentID", txtID.Text);
                            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                            cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                            cmd.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text);
                            cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text);
                            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);

                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Diák sikeresen hozzáadva");
                                ClearTextBoxes();
                                LoadStudentData(); 
                            }
                            else
                            {
                                MessageBox.Show("Diák hozzáadása sikertelen, kérjük próbálja újra");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn.connection().State == ConnectionState.Open)
                    {
                        conn.connection().Close();
                    }
                }
            }
        }


        private void ClearTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void LoadStudentData()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    sql = "SELECT * FROM StudentDetail";
                    cmd.Connection = conn.connection();
                    cmd.CommandText = sql;
                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(dt);
                    dgvStudent.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.connection().State== ConnectionState.Open)
                {
                    conn.connection().Close();
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                
                DialogResult result = MessageBox.Show("Biztosan törölni szeretné ezt a diákot?", "Diák törlése", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            conn.connection().Open();
                            if (conn.connection().State == ConnectionState.Open)
                            {
                                
                                int rowIndex = dgvStudent.SelectedRows[0].Index;
                                int studentID = Convert.ToInt32(dgvStudent.Rows[rowIndex].Cells["StudentID"].Value);

                                
                                sql = "DELETE FROM StudentDetail WHERE StudentID = @StudentID";
                                cmd.Connection = conn.connection();
                                cmd.CommandText = sql;
                                cmd.Parameters.AddWithValue("@StudentID", studentID);

                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Diák sikeresen törölve");
                                    LoadStudentData(); 
                                }
                                else
                                {
                                    MessageBox.Show("Diák törlése sikertelen");
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (conn.connection().State == ConnectionState.Open)
                            {
                                conn.connection().Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Először válassza ki a törlendő diákot a táblázatból");
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (dgvStudent.SelectedRows.Count > 0)
            {
                try
                {
                    conn.connection().Open();
                    if (conn.connection().State == ConnectionState.Open)
                    {
                        
                        string sql = "UPDATE StudentDetail SET Full_Name = @FullName, Gender = @Gender, Date_Of_Birth = @DateOfBirth, Department = @Department, Phone_Number = @PhoneNumber WHERE StudentID = @StudentID";

                        
                        SqlCommand cmd = new SqlCommand(sql, conn.connection());

                        
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text.Trim());
                        cmd.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text.Trim());
                        cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text.Trim());
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@StudentID", txtID.Text.Trim());

                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Diák adatai sikeresen frissítve.");
                            LoadStudentData(); 
                        }
                        else
                        {
                            MessageBox.Show("Hiba: A diák adatainak frissítése nem sikerült.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Hiba: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba: " + ex.Message);
                }
                finally
                {
                    
                    if (conn.connection().State == ConnectionState.Open)
                    {
                        conn.connection().Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Először válassza ki a szerkesztendő diákot a táblázatból.");
            }
        }









        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmDetail Detail = new frmDetail();
            Detail.Show();
            Dispose();

        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            frmPublish Publisher = new frmPublish();
            Publisher.Show();
            Dispose();
        }
    }
}
