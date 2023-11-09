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
using static WPF_Stas_PR5.Manager;

namespace WPF_Stas_PR5
{
    /// <summary>
    /// Логика взаимодействия для DataGrid.xaml
    /// </summary>
    public partial class DataGrid : Page
    {
        public DataGrid()
        {
            InitializeComponent();
            List<InformationClass> infolist = new List<InformationClass>
            {
                new InformationClass { Place="Вход офис", Point="У двери", Serial_Number="55434403", IP_Address="192_168_201_83", MAC_Address="00_60_35_22_52", Connection_Status="Подключено", Date_and_time_Detector="2016/06/24 04:04:28" },
            };
            InformationGrid.ItemsSource = infolist;
        }
    }
}
