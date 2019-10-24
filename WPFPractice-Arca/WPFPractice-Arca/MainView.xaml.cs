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
using System.Threading;
using System.Windows.Threading;


namespace WPFPractice_Arca
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView(string userName)
        {
            InitializeComponent();
            this.Title = "Traffic and Revenue System";
            dateLabel.Content = DateTime.Today.ToString("MM/dd/yyyy");
            userLabel.Content += userName;

            //Thread ticker for time label
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            
            
           
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Content = DateTime.Now.ToString("HH:mm:ss tt");

            CommandManager.InvalidateRequerySuggested();
        }

        
    }
}
