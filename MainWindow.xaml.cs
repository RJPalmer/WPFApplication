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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            var bc = new BrushConverter();
            basePanel1.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
        }
        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Currently changes the backgroun button green
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingButton_Click(object sender, RoutedEventArgs e)
        {
            basePanel1.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
        }
    }
}
