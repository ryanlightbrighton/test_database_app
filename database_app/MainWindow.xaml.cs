using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace database_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "server=WOPR\\SQLEXPRESS;Database=sars_3; uid=;pwd=;Integrated Security=true";
                conn.Open();
                SqlCommand sqlcmd = conn.CreateCommand();
                sqlcmd.CommandText = "select * from t_adopter";
                SqlDataReader sqlreader = sqlcmd.ExecuteReader();
                while (sqlreader.Read())
                {
                    tb1.Text = sqlreader["email"].ToString();
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
