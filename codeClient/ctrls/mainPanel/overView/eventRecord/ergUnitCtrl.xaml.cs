using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using nsVicoClient;

namespace nsVicoClient.ctrls
{
    /// <summary>
    /// Interaction logic for ergUnitCtrl.xaml
    /// </summary>
    public partial class ergUnitCtrl : UserControl
    {
        public recUnit erObj;
        private Popup pop;
        private AlarmHelpCtrl ahCtrl;

        public ergUnitCtrl()
        {
            InitializeComponent();

            pop = new Popup();
            pop.AllowsTransparency = true;
            ahCtrl = new AlarmHelpCtrl();
            pop.Child = ahCtrl;
            pop.PlacementTarget = cvsMain;
            pop.Placement = PlacementMode.Relative;
            pop.VerticalOffset = 40;
            pop.HorizontalOffset = 0;
            pop.StaysOpen = false;
        }

        public void setValue(recUnit ErObj)
        {
            this.erObj = ErObj;

            if (erObj != null)
            {
                tbType.Visibility = Visibility.Visible;
                btnHelp.Visibility = Visibility.Visible; 
                lbSerialNum.Content= erObj.serialNum;
                lbUserName.Content = erObj.UserName;
                tbType.SelectedIndex = (int)erObj.type;

                object obj = TryFindResource(ErObj.serialNum);
                if (obj != null)
                {
                    lbDes.SetResourceReference(Label.ContentProperty, ErObj.serialNum);
                }
                else
                {
                    lbDes.Content = ErObj.serialNum;
                }
                lbDtStart.Content = erObj.ActiveTime.ToString();
                lbPalteNum.Content = erObj.Shots;
                lbOldValue.Content = erObj.OldValue;
                lbNewValue.Content = erObj.NewValue;
                
                if (erObj.type ==  recType.operateType)
                {
                    lbOldValue.Visibility = Visibility.Visible;
                    lbNewValue.Visibility = Visibility.Visible;
                }
                else
                {
                    lbOldValue.Visibility = Visibility.Hidden;
                    lbNewValue.Visibility = Visibility.Hidden; 
                }

                if (erObj.type == recType.alarmType)
                {
                    btnHelp.Visibility = Visibility.Visible;
                }
                else
                {
                    btnHelp.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                tbType.Visibility = Visibility.Hidden;
                btnHelp.Visibility = Visibility.Hidden; 
                lbSerialNum.Content = "";
                lbUserName.Content = "";
                lbDes.Content = "";
                lbDtStart.Content = "";
                lbPalteNum.Content = "";
                lbOldValue.Content = "";
                lbNewValue.Content = "";
            }
        }

        private void btnHelp_MouseUp(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;

            if (erObj.type == recType.alarmType)
            {
                string serNum = erObj.serialNum.Substring(3, 3);
                try
                {
                    Convert.ToInt32(serNum);
                }
                catch
                {
                    MessageBox.Show("Error!");

                    return;
                }

                ahCtrl.init("AA_C" + serNum, "AA_E" + serNum, "AA_R" + serNum);
                pop.IsOpen = true;
            }
        }

        private void btnHelp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
    }
}
