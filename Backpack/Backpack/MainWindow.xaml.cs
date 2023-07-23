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

namespace Backpack
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int maxW = Convert.ToInt32(ReadW.Text);
            int maxN = Convert.ToInt32(ReadN.Text);

            string[] numbers = ReadI.Text.Split(' ');

            int[,] arr = new int[maxN, 2];

            for (int i = 0; i < numbers.Length; i++)
            {
                arr[i / maxN, i % 2] = int.Parse(numbers[i]);
                ReadI.Text += numbers[i] + "  ";
            }
            ReadI.Text += "\n";

            Backpack(maxW, maxN, arr);
        }
        private void Backpack(int maxW, int maxN, int[,] arr)
        {
            int sum = 0;
            int countItem = 0;
            List<int> numbersItem = new List<int>();

        }
    }
}
