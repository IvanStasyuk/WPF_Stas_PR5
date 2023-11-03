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

namespace WPF_Stas_PR5
{
    /// <summary>
    /// Логика взаимодействия для WindowQuest2.xaml
    /// </summary>
    public partial class WindowQuest2 : Window
    {
        public WindowQuest2()
        {
            InitializeComponent();
            Manager.MyFrame = MyFrame;
        }

        private void Case1_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Case1());
        }

        private void Case2_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Case2());
        }

        private void Case3_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Case3());
        }

        private void Case4_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Case4());
        }

        private void Case5_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Case5());
        }
    }
}
