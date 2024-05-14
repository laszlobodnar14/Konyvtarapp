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

namespace Konyvtar2
{
    public partial class Form1 : Form
    {
        private string sql;
        private SqlCommand cmd = new SqlCommand();
        DBConnection conn = new DBConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar= true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlDataReader DR;
            try
            {
                conn.connection().Open();
               if(conn.connection().State == ConnectionState.Open ) {
                    string user_name = txtUserName.Text;
                    string password = txtPassWord.Text;
                    int counter = 0;
                    if(user_name.Length==0 || password.Length==0)
                    {
                        MessageBox.Show("Egy vagy tobb mezo nincs kitoltve");
                    }
                    else
                    {
                        sql = "SELECT User_Name, SPassword FROM tblStaff WHERE User_Name = '" + user_name + "' AND SPassword = '" + password + "'";

                        cmd.Connection = conn.connection();
                        cmd.CommandText = sql;
                        DR = cmd.ExecuteReader();
                        while(DR.Read())
                        {
                            counter++;
                        }
                        DR.Close();
                        if(counter == 1) {
                            MessageBox.Show("Logged in Successfully");
                            frmDashBoard home = new frmDashBoard();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid info");
                        }
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmSignUp signUp = new frmSignUp();
            signUp.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
