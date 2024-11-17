using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
using System.Xml.Linq;

namespace DesktopProject
{
    /// <summary>
    /// Interaction logic for ApplicationPage.xaml
    /// </summary>
    public partial class ApplicationPage : Page
    {
        DesktopTaskEntities1 db = new DesktopTaskEntities1();
        public ApplicationPage()
        {
            InitializeComponent();
        }
        private void SaveButton(object sender, RoutedEventArgs e)
        {
            string SName = txtNamee.Text;
            var ex = db.Students.FirstOrDefault(x => x.StudentName == SName);
            ex.StudentName = txtNamee.Text;
            ex.StudentAddress = txtAddress.Text;
            ex.StudentAge = int.Parse(txtAge.Text);

            string DepName = txtDepartment.Text;
           var ex2 = db.Departments.FirstOrDefault(x => x.DepartmentName == DepName);
            ex2.DepartmentName = txtDepartment.Text;
            //db.Students.AddOrUpdate(ex);
            //db.Departments.AddOrUpdate(ex2);
            //db.SaveChanges();
            db.SaveChanges();

            MessageBox.Show("Data added Succesfully");
           

        }
    }
}
