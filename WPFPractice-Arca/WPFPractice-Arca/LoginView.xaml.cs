using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFPractice_Arca
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            this.Title = "TRS - LOG IN";
            okButton.Click += OkButton_Click;
            cancelButton.Click += CancelButton_Click;

        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string userName = userNameTextBox.Text;
            string userPass = passTextBox.Password.ToString();

            string connectionString;
            SqlConnection con;
            connectionString = @"Data Source=DESKTOP-83NBMNA;Initial Catalog=testArca;Integrated Security=True;";
            con = new SqlConnection(connectionString);
            
            SqlCommand cmd = default(SqlCommand);
            cmd = new SqlCommand("SELECT username, password FROM Users WHERE username = @username AND password = @password", con);

            SqlParameter dbUser = new SqlParameter("@username", SqlDbType.VarChar);
            SqlParameter dbPass = new SqlParameter("@password", SqlDbType.VarChar);

            dbUser.Value = userName;
            dbPass.Value = userPass;
            cmd.Parameters.Add(dbUser);
            cmd.Parameters.Add(dbPass);

            cmd.Connection.Open();

            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if(reader.Read() == true)
            {
                MessageBox.Show("Succesful login!");
                MainView newView = new MainView(userName);
                newView.Show();
                Close();
            }



            con.Close();

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
