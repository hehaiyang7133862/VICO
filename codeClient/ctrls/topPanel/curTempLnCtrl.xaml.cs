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
    /// Interaction logic for curTempLnCtrl.xaml
    /// </summary>
    public partial class curTempLnCtrl : UserControl
    {
        public curTempLnCtrl()
        {
            InitializeComponent();
        }
        public void setValue(double curValue)
        {
            Canvas.SetLeft(pgnLn, curValue * 1.11 - 3);
        }
    }
}
