using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Save_cursor__game_
{
    public partial class Registration : Form
    {
        DataBase _dataBase = new DataBase();
        Autorization autorizationForm;
        public Registration(Autorization aoutorization)
        {
            autorizationForm = aoutorization;
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            textBoxLogin.MaxLength = 40;
            textBoxPassword.MaxLength = 40;
            textBoxPassword.PasswordChar = '*';
            AcceptButton = btSignIn;
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (login == null || login == "") return;
            _dataBase.OpenConnection();
            try
            {
                if (IsUserExist(login))
                {
                    lbAlert.Visible = true;
                }
                else
                {
                    string query = $"INSERT INTO  register (login_user, password_user, score) VALUES (@login_user, @password_user, @score)";

                    using (SqlCommand command = new SqlCommand(query, _dataBase.GetConnection()))
                    {
                        command.Parameters.Add(new SqlParameter("@login_user", SqlDbType.NVarChar, 50) { Value = login });
                        command.Parameters.Add(new SqlParameter("@password_user", SqlDbType.NVarChar, 100) { Value = password});
                        command.Parameters.Add(new SqlParameter("@score", SqlDbType.Int) { Value = 0 });

                        if (command.ExecuteNonQuery() == 1)
                        {
                            this.Close();
                            autorizationForm.Show();

                        }
                        else MessageBox.Show("Something went wrong");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error :" + ex.Message); }
            finally
            {
                _dataBase.CloseConnection();
            }
        }
        private Boolean IsUserExist(string login)
        {
            string query = $"SELECT login_user FROM register WHERE login_user = @login_user";

            using (SqlCommand command = new SqlCommand(query, _dataBase.GetConnection()))
            {
                command.Parameters.Add(new SqlParameter("@login_user", SqlDbType.NVarChar, 50) { Value = login });
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

    }
}
