using System.Windows;

namespace Currency_Converter_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Constructors

        //public MainWindow()
        //{
        //    InitializeComponent();
        //}

        ////loading next page automaticly after specified time
        //private void Currency_Convert_Loaded(object sender, RoutedEventArgs e)
        //{
        //    //set timer
        //    DispatcherTimer dt = new DispatcherTimer();
        //    dt.Tick += Dt_Tick; ;
        //    dt.Interval = new TimeSpan(0, 0, 10);
        //    dt.Start();
        //}

        //private void Dt_Tick(object sender, EventArgs e)
        //{
        //    navFrame.NavigationService.Navigate(new Uri("SignInMain.xaml", UriKind.Relative));
        //}
        public MainWindow()
        {
            InitializeComponent();
            //Navigate(typeof(SignInMain));
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //     btn = (Button)e.OriginalSource;
        //    Navigate(btn.Tag as Type);
        //}

        //private void Navigate(Type viewType)
        //{
        //    UserControl uc;
        //    if (Views.ContainsKey(viewType))
        //    {
        //        uc = Views[viewType];
        //    }
        //    else
        //    {
        //        uc = (UserControl)Activator.CreateInstance(viewType);
        //        Views[viewType] = uc;
        //    }
        //    MyContentControl.Content = uc;
        //}
        //private Dictionary<Type, UserControl> Views = new Dictionary<Type, UserControl>();
    }
}

}
