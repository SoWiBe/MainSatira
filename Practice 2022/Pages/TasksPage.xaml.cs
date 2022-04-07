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
    /// Логика взаимодействия для TasksPage.xaml
    /// </summary>
    public partial class TasksPage : Page
    {
        Employees _employee;
        public TasksPage(Employees employee)
        {
            InitializeComponent();
            this._employee = employee;
            Control_Tasks control_Tasks = CalculatingEntities.GetContext().Control_Tasks.Where(x => x.ID_Employee == _employee.ID_Employee).First();
            geidTasks.ItemsSource = CalculatingEntities.GetContext().Tasks.ToList().Where(x => x.ID_Task == control_Tasks.ID_Task);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new Pages.EmployeesPage());
        }
    }
}
