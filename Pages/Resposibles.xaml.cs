using Documents_Lukashevich.Classes;
using Documents_Lukashevich.Model;
using System.Windows;
using System.Windows.Controls;

namespace Documents_Lukashevich.Pages
{
    public partial class Responsibles : Page
    {
        public Responsibles()
        {
            InitializeComponent();
            LoadResponsibles();
        }

        private void LoadResponsibles()
        {
            dgResponsibles.ItemsSource = new ResponsibleContext().GetAllResponsibles();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.main);
        }

        private void AddResponsible(object sender, RoutedEventArgs e)
        {
            string фио = ShowInputDialog("Введите ФИО ответственного:", "Добавление ответственного");
            if (!string.IsNullOrEmpty(фио))
            {
                new ResponsibleContext().AddResponsible(фио);
                LoadResponsibles();
            }
        }

        private void EditResponsible(object sender, RoutedEventArgs e)
        {
            Responsible responsible = (Responsible)((Button)sender).DataContext;
            string новоеФИО = ShowInputDialog("Введите новое ФИО:", "Изменение ответственного", responsible.ФИО);
            if (!string.IsNullOrEmpty(новоеФИО))
            {
                new ResponsibleContext().UpdateResponsible(responsible.Код, новоеФИО);
                LoadResponsibles();
            }
        }

        private void DeleteResponsible(object sender, RoutedEventArgs e)
        {
            Responsible responsible = (Responsible)((Button)sender).DataContext;
            if (MessageBox.Show($"Удалить ответственного {responsible.ФИО}?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                new ResponsibleContext().DeleteResponsible(responsible.Код);
                LoadResponsibles();
            }
        }

        private string ShowInputDialog(string prompt, string title, string defaultValue = "")
        {
            Window window = new Window
            {
                Title = title,
                Width = 300,
                Height = 150,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            StackPanel stackPanel = new StackPanel { Margin = new Thickness(10) };

            TextBlock textBlock = new TextBlock { Text = prompt, Margin = new Thickness(0, 0, 0, 10) };
            TextBox textBox = new TextBox { Text = defaultValue, Margin = new Thickness(0, 0, 0, 10) };
            Button button = new Button { Content = "OK", Width = 80, HorizontalAlignment = HorizontalAlignment.Center };

            button.Click += (s, e) => { window.DialogResult = true; window.Close(); };

            stackPanel.Children.Add(textBlock);
            stackPanel.Children.Add(textBox);
            stackPanel.Children.Add(button);

            window.Content = stackPanel;

            bool? result = window.ShowDialog();
            return result == true ? textBox.Text : "";
        }
    }
}