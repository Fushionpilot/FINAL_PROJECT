
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FINAL_PROJECT;
using System.Data.SQLite;

namespace FINAL_PROJECT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string username = loginText_box.Text.Trim();
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("please enter both username and password");
                return;
            }

            using (SQLiteConnection conn = Database.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    long count = (long)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                        MainMenuForm menuForm = new MainMenuForm();
                        menuForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password");
                    }
                }
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Database.EnsureDatabaseExists();
            Database.EnsureUsersTableExists();
        }
    }

}

