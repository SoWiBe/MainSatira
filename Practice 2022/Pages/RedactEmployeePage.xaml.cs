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
    /// Логика взаимодействия для RedactEmployeePage.xaml
    /// </summary>
    public partial class RedactEmployeePage : Page
    {
        private Employees _employees;
        public RedactEmployeePage(Employees employee)
        {
            InitializeComponent();
            _employees = employee;
            cmbPositions.ItemsSource = CalculatingEntities.GetContext().Positions.ToList();
            DataContext = _employees;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Pages.EmployeesPage());
        }

        private void btnRedact_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateInfo())
            {
                CalculatingEntities.GetContext().Employees.Add(_employees);
                CalculatingEntities.GetContext().SaveChanges();
                MessageBox.Show("Редактирование завершено!!!");
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

        }

        private void cmbPositions_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            _employees.ID_Position = (cmbPositions.SelectedItem as Positions).ID_Position;
        }
    }
}
