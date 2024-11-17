using System;
using System.Collections.Generic;
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
using static DesktopProject.AdminPage;

namespace DesktopProject
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
       
        DesktopTaskEntities1 db = new DesktopTaskEntities1();

        public LogIn()
        {
            InitializeComponent();
        }

        private void SignUpButton(object sender, RoutedEventArgs e)
        {
            SignUp sign = new SignUp();
            this.NavigationService.Navigate(sign);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string AdminEmail = "YoussefGad77@gmail.com";
            string AdminPassword = "Joo_Gad777";
            if (txtemail.Text == AdminEmail && txtpass.Text == AdminPassword)
            {
                AdminPage admin = new AdminPage();
                this.NavigationService.Navigate(admin);
                MessageBox.Show("done");
            }
            else if(txtemail.Text != AdminEmail && txtpass.Text == AdminPassword)
            {
                MessageBox.Show("wrong password");
            }
            else if (txtemail.Text == AdminEmail && txtpass.Text != AdminPassword)
            {
                MessageBox.Show("wrong password");
            }
            else 
            {
                var StudentEmail = db.Students.FirstOrDefault(E => txtemail.Text == E.Email);

                if (StudentEmail != null && txtpass.Text == StudentEmail.StudentPassword)
                {
                    ApplicationPage app = new ApplicationPage();
                    this.NavigationService.Navigate(app);
                }

            }

        }
    }
}

