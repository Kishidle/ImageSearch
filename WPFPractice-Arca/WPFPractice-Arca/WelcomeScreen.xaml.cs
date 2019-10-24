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
using System.Windows.Shapes;

namespace WPFPractice_Arca
{
    /// <summary>
    /// Interaction logic for WelcomeScreen.xaml
    /// </summary>
    public partial class WelcomeScreen : Window
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            testButton.Click += testButton_Click;

            buttonTest();
        }

        private void buttonTest()
        {
            
        }

        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test message");
            this.Close();
        }
    }
}
