﻿using System;
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
    /// Логика взаимодействия для WindowQuest5B.xaml
    /// </summary>
    public partial class WindowQuest5B : Window
    {
        public WindowQuest5B()
        {
            InitializeComponent();
            Manager.MyFrame = MyFrame;
            Manager.MyFrame.Navigate(new DataGridJobs());
        }

        private void quest6_Click(object sender, RoutedEventArgs e)
        {
            WindowQuest6 window6 = new WindowQuest6();
            window6.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            WindowQuest5 window5 = new WindowQuest5();
            window5.Show();
            this.Close();
        }
    }
}
