using System;
using System.Windows;
using System.Windows.Input;
using Installior.View;

namespace Installior
{
    public partial class MainWindow : Window
    {
        public static MainWindow Components { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            Components = this;
        }



        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            PagePlace.Content = new StartPage();
        }

        private void ToolBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ToolBar_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
