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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        DesktopTaskEntities1 db = new DesktopTaskEntities1();
        public AdminPage()
        {
            InitializeComponent();
            LoadData();
        }
        
        public void LoadData()
        {
           
            
            StudentDataGrid.ItemsSource = db.Students.Select(x => new {id=x.StudentID,Name = x.StudentName,Address=x.StudentAddress,DepName=x.Department.DepartmentName}).ToList();
        }
        

        private void SearchButton(object sender, RoutedEventArgs e)
        {            
                if (txtSearch.Text == "")
                {
                    MessageBox.Show("Field is empty");
                }
                var em = db.Students.Where(stu => stu.StudentName.Contains(txtSearch.Text)).ToList();
                StudentDataGrid.ItemsSource = em;
                

            
        }

        private void DeleteButton(object sender, RoutedEventArgs e)
        {
            int DId = int.Parse(txtStudentID.Text);
            var ex = db.Students.FirstOrDefault(E => E.StudentID == DId);
            if (ex != null)
            {
                db.Students.Remove(ex);
                db.SaveChanges();
                MessageBox.Show("Record Deleted Successfully");
            }
            else
            {
                MessageBox.Show("This ID Not Found");
            }
        }

        private void EditButton(object sender, RoutedEventArgs e)
        {
            Department ex = new Department();
            string DId = txtDepartment.Text;
            ex = db.Departments.FirstOrDefault(x => x.DepartmentName == DId);
            if (ex != null)
            {
                //ternary operator
                ex.DepartmentName = txtDepartment.Text == "" ? ex.DepartmentName : txtDepartment.Text;
                //db.Expenses.AddOrUpdate(ex);
                db.SaveChanges();

                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("There is no Data !");
            }
        }


       
    }
}
