using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Save_cursor__game_
{
    public partial class Autorization : Form
    {
        DataBase _dataBase = new DataBase();
        static public string user_name = "";
        public Autorization()
        {
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            
            textBoxLogin.MaxLength = 40;
            textBoxPassword.MaxLength = 40;
            textBoxPassword.PasswordChar = '*';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            string query = $"SELECT login_user, password_user FROM register WHERE login_user = @login_user AND password_user = @password_user";

            try
            {
                _dataBase.OpenConnection();
                using (SqlCommand command = new SqlCommand(query, _dataBase.GetConnection()))
                {
                    command.Parameters.Add(new SqlParameter("@login_user", SqlDbType.NVarChar, 50) { Value = login });
                    command.Parameters.Add(new SqlParameter("@password_user", SqlDbType.NVarChar, 100) { Value = password });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            user_name = login;
                            StartMenu.nameLabel.Visible = true;
                            btnLogIn.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            btnLogIn.DialogResult = DialogResult.None;
                            lbAlert.Visible = true;
                            StartMenu.nameLabel.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            finally
            { 
                _dataBase.CloseConnection();
            }
         }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration(this);
            this.Hide();
            registration.ShowDialog();
            this.Show();
        }
    }
}
