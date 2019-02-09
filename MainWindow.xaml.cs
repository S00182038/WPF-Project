using System.Windows;

namespace Currency_Converter_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


        }
        //Open the registration window
        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            var reg = new Registration(); //create  new registration form.
            reg.Show(); //show the new form.
            this.Close(); // close the current form.
        }

        private void NextClicked(object sender, RoutedEventArgs e)
        {
            SignInMain page1 = new SignInMain();
            this.Content = page1;
        }
    }
}
