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
    public partial class frmSignUp : Form
    {
        private DBConnection conn = new DBConnection();
        private SqlCommand cmd = new SqlCommand();
        string sql;
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int isAdmin =0;
            if (cmbUserType.Text == "Admin")
            {
                isAdmin = 1;
            }
            else
            {
                isAdmin = 0;
            }
            try
            {
                conn.connection().Open();
                if (conn.connection().State == ConnectionState.Open)
                {
                    if (txtUserName.Text.Length == 0 || txtFullName.Text.Length == 0 || txtPasswd.Text.Length == 0 || txtConfPasswd.Text.Length == 0 )
                    {
                        MessageBox.Show("Egy vagy több mező üres!");
                    }
                    else if(txtPasswd.Text != txtConfPasswd.Text)
                    {
                        MessageBox.Show("A jelszavak nem egyeznek meg!");
                    }
                    else
                    {
                        sql = "INSERT INTO tblStaff(Staff_Member_ID, FullName, User_Name, SPassword, is_Admin, Designation) " +
                     "VALUES('" + txtID.Text + "','" + txtFullName.Text + "','" + txtUserName.Text + "','" + txtPasswd.Text + "'," + isAdmin + ",'" + cmbDesignation.Text + "')";

                        cmd.Connection = conn.connection();
                        cmd.CommandText = sql;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(" Fiok Sikeresen létrehozva ");
                            txtFullName.Clear();
                            txtUserName.Clear();
                            txtPasswd.Clear();
                            txtConfPasswd.Clear();
                            cmbDesignation.ResetText();
                            cmbUserType.ResetText();    
                        }
                        else
                        {
                            MessageBox.Show("A felhasználó nem jött létre");
                        }
                    }
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
                conn.connection().Close();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPasswd.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswd.UseSystemPasswordChar= true;
            }
        }

        private void chkConfShowPasswd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfShowPasswd.Checked)
            {
                txtConfPasswd.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfPasswd.UseSystemPasswordChar=  true;
            }
        }
    }
}
