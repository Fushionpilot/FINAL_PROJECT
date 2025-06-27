using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FINAL_PROJECT
{

    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
        }
        

        private void Register_Load(object sender, EventArgs e)
        {
            Database.EnsureDatabaseExists();
            Database.EnsureUsersTableExists();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (!yearsCheckBox.Checked)
            {
                MessageBox.Show("Registration is only allowed if you are 21 years old");
                return;
            }

            string username = registerText_box.Text.Trim();
            string password = password_regtextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty");
                return;
            }

            using (SQLiteConnection conn = Database.GetConnection())
            {
                string query = "INSERT INTO users (username, password) VALUES (@username, @password)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");
                        this.Close();
                    }
                    catch (SQLiteException ex)
                    {
                        if (ex.Message.Contains("UNIQUE"))
                            MessageBox.Show("Such a login already exists");
                        else
                            MessageBox.Show("ERROR: " + ex.Message);
                    }
                }
            }
        }

        
    }
}
