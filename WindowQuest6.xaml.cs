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
    /// Логика взаимодействия для WindowQuest6.xaml
    /// </summary>
    public partial class WindowQuest6 : Window
    {
        public WindowQuest6()
        {
            InitializeComponent();
            Manager.MyFrame = MyFrame;
            Manager.MyFrame.Navigate(new PageQuestEmpty());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            WindowQuest5B window5B = new WindowQuest5B();
            window5B.Show();
            this.Close();
        }

        private void QuestHome_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new PageQuest1());
        }

        private void QuestSetter_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new PageQuest2());
        }

        private void QuestCloud_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new PageQuest3());
        }

        private void QuestSettings_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new PageQuest4());
        }

        private void QuestInfo_Click(object sender, RoutedEventArgs e)
        {
            Manager.MyFrame.Navigate(new PageQuest5());
        }
    }
}
