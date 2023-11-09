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
    /// Логика взаимодействия для WindowQuest4.xaml
    /// </summary>
    public partial class WindowQuest4 : Window
    {
        public WindowQuest4()
        {
            InitializeComponent();
            Manager.MyFrame = MyFrame;
        }

        private void Quest4Home_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Quest4Home());
        }

        private void Quest4Inbox_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Quest4Inbox());
        }

        private void Quest4SentItems_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Quest4SentItems());
        }

        private void Quest4Spam_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Quest4Spam());
        }

        private void Quest4Settings_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new Quest4Settings());
        }

        private void quest5_Click(object sender, RoutedEventArgs e)
        {
            WindowQuest5 window4 = new WindowQuest5();
            window4.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            WindowQuest3 window2 = new WindowQuest3();
            window2.Show();
            this.Close();
        }
    }
}
