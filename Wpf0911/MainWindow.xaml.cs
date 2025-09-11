using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf0911
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(T1.Text);
            string result = " ";
            for (int i = 1; i <=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    result += $"{i}*{j}={i*j}".PadLeft(15);
                }
                result += "\n";

            }
           T2.Text = result;

        }
    }
}