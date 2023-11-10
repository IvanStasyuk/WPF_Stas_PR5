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
    /// Логика взаимодействия для DataGridJobs.xaml
    /// </summary>
    public partial class DataGridJobs : Page
    {
        public DataGridJobs()
        {
            InitializeComponent();
            List<InformationJobs> infolist = new List<InformationJobs>
            {
                new InformationJobs { Job_ID="1", Job_Date="28/04/2015", User_ID="Admin", Issue_Subject="Intial Logged Job", Screen_Object="Intial Logged Job", Futher_Information="Intial Logged Job", Job_Status="Closed" },
                new InformationJobs { Job_ID="2", Job_Date="28/04/2015", User_ID="User", Issue_Subject="Test2", Screen_Object="Test2", Futher_Information="Test2", Job_Status="Open" },
            };
            InformationJobs.ItemsSource = infolist;
        }
    }
}
