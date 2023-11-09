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
    /// Логика взаимодействия для WindowQuest5.xaml
    /// </summary>
    public partial class WindowQuest5 : Window
    {
        public WindowQuest5()
        {
            InitializeComponent();
            Manager.MyFrame = MyFrame;
            Manager.MyFrame.Navigate(new DataGrid());
        }

        private void quest5b_Click(object sender, RoutedEventArgs e)
        {
            WindowQuest5B window6b = new WindowQuest5B();
            window6b.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            WindowQuest4 window3 = new WindowQuest4();
            window3.Show();
            this.Close();
        }
    }
}
