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
using TacoEditor.GameProject;

namespace TacoEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += OnMainWindowLoaded;
        }

        private void OnMainWindowLoaded(object sender, RoutedEventArgs args)
        {
            Loaded -= OnMainWindowLoaded;
            OpenProjectBrowserDialg();
        }

        private void OpenProjectBrowserDialg()
        {
            var projectBrowser = new ProjectBrowserDialg();
            if (projectBrowser.ShowDialog() == false)
            {
                Application.Current.Shutdown();
            } else
            {

            }
        }
    }
}
