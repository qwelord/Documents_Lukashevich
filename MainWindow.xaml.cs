using System.Windows;
using System.Collections.Generic;
using Documents_Lukashevich.Classes;

namespace Documents_Lukashevich
{
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public List<DocumentContext> AllDocuments = new DocumentContext().AllDocuments();
        public enum pages { main, add, responsibles }

        public MainWindow()
        {
            InitializeComponent();
            init = this;
            OpenPages(pages.main);
        }

        public void OpenPages(pages _pages)
        {
            if (_pages == pages.main)
                frame.Navigate(new Pages.Main());
            else if (_pages == pages.add)
                frame.Navigate(new Pages.Add());
            else if (_pages == pages.responsibles)
                frame.Navigate(new Pages.Responsibles());
        }
    }
}