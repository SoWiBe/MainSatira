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
    /// Логика взаимодействия для Employees.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        public EmployeesPage()
        {
            InitializeComponent();
            SetItemSource();
            cmbFilter.ItemsSource = CalculatingEntities.GetContext().Positions.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (gridEmployees.SelectedItem == null)
            {
                ShowMessage();
                return;
            }
                
            CalculatingEntities.GetContext().Employees.Remove(CalculatingEntities.GetContext().Employees.Remove(gridEmployees.SelectedItem as Employees));
            CalculatingEntities.GetContext().SaveChanges();
            SetItemSource();
        }

        private void SetItemSource()
        {
            gridEmployees.ItemsSource = CalculatingEntities.GetContext().Employees.ToList();
        }

        private void btnRedact_Click(object sender, RoutedEventArgs e)
        {
            if (gridEmployees.SelectedItem == null)
            {
                ShowMessage();
                return;
            }

            FrameManager.MainFrame.Navigate(new Pages.RedactEmployeePage(gridEmployees.SelectedItem as Employees));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Pages.AddEmployeePage());
        }

        private void ShowMessage()
        {
            MessageBox.Show("Вы не выбрали исполнителя!");
        }

        private void cmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridEmployees.ItemsSource = CalculatingEntities.GetContext().Employees.ToList().Where(x => x.ID_Position == (cmbFilter.SelectedItem as Positions).ID_Position);
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtSearch.Text == "")
                gridEmployees.ItemsSource = CalculatingEntities.GetContext().Employees.ToList();
            else
                gridEmployees.ItemsSource = CalculatingEntities.GetContext().Employees.Where(x => x.FIO.Contains(txtSearch.Text)).ToList();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            gridEmployees.ItemsSource = CalculatingEntities.GetContext().Employees.ToList();
        }

        private void btnTasks_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Pages.TasksPage(gridEmployees.SelectedItem as Employees));
        }
    }
}
