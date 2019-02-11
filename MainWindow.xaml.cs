using LoadingIndicators.WPF;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Currency_Converter_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Constructors

        public MainWindow()
        {
            this.ViewModel = new MainWindowViewModel();
            InitializeComponent();
        }
        #region loading indicator
        private MainWindowViewModel ViewModel
        {
            get { return (DataContext as MainWindowViewModel); }
            set { DataContext = value; }
        }

        // Handlers
        private void LoadingIndicator_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            LoadingIndicator li = (LoadingIndicator)sender;

            if (li.SpeedRatio == 1.0)
            {
                li.SpeedRatio = 0.3;
            }
            else
            {
                li.SpeedRatio = 1.0;
            }
        }
        // Classes
        class MainWindowViewModel : INotifyPropertyChanged
        {
            // Variables
            double speedratio;

            // Properties
            public double SpeedRatio
            {
                get { return speedratio; }
                set
                {
                    if (speedratio != value)
                    {
                        speedratio = value;
                        OnPropertyChanged("SpeedRatio");
                        OnPropertyChanged("SpeedRatioText");
                    }
                }
            }
            public string SpeedRatioText
            {
                get { return this.SpeedRatio.ToString(); }
            }

            // Events
            public event PropertyChangedEventHandler PropertyChanged;

            // Protected
            protected void OnPropertyChanged(string propertyname)
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
                }
            }

            // Constructors
            public MainWindowViewModel()
            {
                this.SpeedRatio = 1.0;

            }

        }
        #endregion
        //loading next page automaticly after specified time
        private void Currency_Convert_Loaded(object sender, RoutedEventArgs e)
        {
            //set timer
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += Dt_Tick; ;
            dt.Interval = new TimeSpan(0, 0, 10);
            dt.Start();
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            SignInMain page1 = new SignInMain();
            this.Content = page1;
        }
    }

}
