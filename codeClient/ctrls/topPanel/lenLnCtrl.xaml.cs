using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace nsVicoClient.ctrls
{
    /// <summary>
    /// Interaction logic for lenLnCtrl.xaml
    /// </summary>
    public partial class lenLnCtrl : UserControl
    {
        public lenLnCtrl()
        {
            InitializeComponent();
        }
        public void setValue(double value)
        {
            if (value < 0)
                value = 0;
            else if (value > 100)
                value = 100;
            imgLn.Width = value;
        }
    }
}
