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
            

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // int n = Convert.ToInt32(T1.Text);
            int n;
            List<int>prime = new List<int>();
            if (!int.TryParse(T1.Text,out n )||n<=1)
            {
                MessageBox.Show("請輸入大於2的整數","輸入錯誤");
                return;
            }
            T2.Clear();
            string OutputText = $"小於等於{n}的質數有 ";
            for(int  i=2;i<=n;i++)
            {
                if (Iprime(i))
                {
                    prime.Add(i);
                }
            }
            foreach (int p in prime)
            {
                OutputText += $"{p}  ";
            }
            T2.Text = OutputText;



        }
        private bool Iprime(int p)
        {
            for (int i = 2; i < p; i++)
            {
                if (p % i == 0) return false;
            }
            return true;
        }
    }
}