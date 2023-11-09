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
    /// Логика взаимодействия для WindowQuest3.xaml
    /// </summary>
    public partial class WindowQuest3 : Window
    {
        public WindowQuest3()
        {
            InitializeComponent();
            Manager.MyFrame = MyFrame;
        }

        private void step1_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Step1());
        }

        private void step2_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Step2());
        }

        private void step3_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Step3());
        }

        private void step4_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Step4());
        }

        private void step5_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Step5());
        }

        private void quest4_Click(object sender, RoutedEventArgs e)
        {
            WindowQuest4 window3 = new WindowQuest4();
            window3.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            WindowQuest2 window1 = new WindowQuest2();
            window1.Show();
            this.Close();
        }
    }
}
