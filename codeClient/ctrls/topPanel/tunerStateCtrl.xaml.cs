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
using nsDataMgr;

namespace nsVicoClient.ctrls
{
    /// <summary>
    /// tunerStateCtrl.xaml 的交互逻辑
    /// </summary>
    public partial class tunerStateCtrl : UserControl
    {
        public tunerStateCtrl()
        {
            InitializeComponent();
            valmoWin.dv.MldPr[594].addHandle(handleRefreshLight);
            this.Visibility = Visibility.Hidden;
        }
        public int state
        {

            set
            {
                if (value == 0)
                {
                    rec0.Fill = App.Current.TryFindResource("lightGreen") as SolidColorBrush;
                    rec1.Fill = App.Current.TryFindResource("lbFore") as SolidColorBrush;
                }
                else if (value == 1)
                {
                    rec0.Fill = App.Current.TryFindResource("lbFore") as SolidColorBrush;
                    rec1.Fill = App.Current.TryFindResource("lightGreen") as SolidColorBrush;
                }
                else
                {
                    rec0.Fill = App.Current.TryFindResource("lbFore") as SolidColorBrush;
                    rec1.Fill = App.Current.TryFindResource("lbFore") as SolidColorBrush;
                }
            }
        
        }
        void handleRefreshLight(objUnit obj)
        {
            if (obj.value == 0)
            {
                rec0.Fill = App.Current.TryFindResource("lightGreen") as SolidColorBrush;
                rec1.Fill = App.Current.TryFindResource("lbFore") as SolidColorBrush;
            }
            else if (obj.value == 1)
            {
                rec0.Fill = App.Current.TryFindResource("lbFore") as SolidColorBrush;
                rec1.Fill = App.Current.TryFindResource("lightGreen") as SolidColorBrush;
            }
            else
            {
                rec0.Fill = App.Current.TryFindResource("lbFore") as SolidColorBrush;
                rec1.Fill = App.Current.TryFindResource("lbFore") as SolidColorBrush;
            }
        
        }
    }
}
