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

namespace Practice_2022.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        private Employees employee = new Employees();
        public AddEmployeePage()
        {
            InitializeComponent();
            cmbPositions.ItemsSource = CalculatingEntities.GetContext().Positions.ToList();
            DataContext = employee;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Pages.EmployeesPage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateInfo())
            {
                CalculatingEntities.GetContext().Employees.Add(employee);
                CalculatingEntities.GetContext().SaveChanges();
                MessageBox.Show(employee.FIO + " был добавлен в систему!");
            }
        }

        private bool ValidateInfo()
        {
            if (txtEmail.Text == "" || txtPhone.Text == "" || txtFio.Text == "" || cmbPositions.SelectedItem == null)
                return false;
            return true;
        }

        private void cmbPositions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            employee.ID_Position = (cmbPositions.SelectedItem as Positions).ID_Position;
        }
    }
}
