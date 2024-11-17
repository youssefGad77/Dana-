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

namespace DesktopProject
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        DesktopTaskEntities1 db = new DesktopTaskEntities1();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpButton(object sender, RoutedEventArgs e)
        {
            if(txtName.Text != "" && txtmail.Text != "" && txtPass.Text != "" && txtCPass.Text != "")
            {
                Student ex = new Student();
                ex.StudentName = txtName.Text;
                ex.Email = txtmail.Text;
                ex.StudentPassword = txtPass.Text;
                db.Students.Add(ex);
                db.SaveChanges();
                MessageBox.Show("Data added Succesfully");
                LogIn log = new LogIn();
                this.NavigationService.Navigate(log);
            }
            else if (txtName.Text == "" && txtmail.Text != "" && txtPass.Text != "" && txtCPass.Text != "")
            {
                MessageBox.Show("Please fill the name text Box");
            }
            else if (txtName.Text != "" && txtmail.Text == "" && txtPass.Text != "" && txtCPass.Text != "")
            {
                MessageBox.Show("Please fill the email text Box");
            }
            else if (txtName.Text != "" && txtmail.Text != "" && txtPass.Text == "" && txtCPass.Text != "")
            {
                MessageBox.Show("Please fill the Password text Box");
            }
            else if (txtName.Text != "" && txtmail.Text != "" && txtPass.Text != "" && txtCPass.Text == "")
            {
                MessageBox.Show("Please RE-Enter The Password");
            }
            else
            {
                MessageBox.Show("ana t3bt mnkk y3mmm");
            }
            if(txtCPass.Text != txtPass.Text)
            {
                MessageBox.Show("Please enter same password");
            }



        }
    }
}
