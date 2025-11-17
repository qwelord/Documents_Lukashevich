using Documents_Lukashevich.Classes;
using System.Windows;
using System.Windows.Controls;

namespace Documents_Lukashevich.Pages
{
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
            CreatedUI();
        }

        public void CreatedUI()
        {
            parent.Children.Clear();
            foreach (DocumentContext document in MainWindow.init.AllDocuments)
                parent.Children.Add(new Elements.Item(document));
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow.init.Close();
        }

        private void AddDocuments(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.add);
        }

        private void ManageResponsibles(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(MainWindow.pages.responsibles);
        }
    }
}