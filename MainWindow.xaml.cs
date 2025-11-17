using System.Collections.Generic;
using System.Windows;
using Documents_Lukashevich.Classes;

namespace Documents_Lukashevich
{
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public List<DocumentContext> AllDocuments;
        public enum pages { main, add }

        public MainWindow()
        {
            InitializeComponent();
            init = this;
            AllDocuments = new DocumentContext().AllDocuments();
            OpenPages(pages.main);
        }

        public void OpenPages(pages pages)
        {
            switch (pages)
            {
                case pages.main:
                    frame.Navigate(new Pages.Main());
                    break;
                case pages.add:
                    frame.Navigate(new Pages.Add());
                    break;
            }
        }
    }
}