using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_Stas_PR5
{
    internal class Manager
    {
        public static Frame MyFrame;

        public class InformationClass
        {
            public string Place { get; set; }
            public string Point { get; set; }
            public string Serial_Number { get; set; }
            public string IP_Address { get; set; }
            public string MAC_Address { get; set; }
            public string Connection_Status { get; set; }
            public string Date_and_time_Detector { get; set; }
        }
    }
}
