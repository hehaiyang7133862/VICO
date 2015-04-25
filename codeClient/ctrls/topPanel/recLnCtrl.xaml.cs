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
    /// Interaction logic for recLnCtrl.xaml
    /// </summary>
    public partial class recLnCtrl : UserControl
    {
        List<double> lnValueLst = new List<double>();
        objUnit objBasic ;
        Image[] imgLn = new Image[20];
        public recLnCtrl()
        {
            InitializeComponent();
            imgLn[0] = img0;
            imgLn[1] = img1;
            imgLn[2] = img2;
            imgLn[3] = img3;
            imgLn[4] = img4;
            imgLn[5] = img5;
            imgLn[6] = img6;
            imgLn[7] = img7;
            imgLn[8] = img8;
            imgLn[9] = img9;
            imgLn[10] = img10;
            imgLn[11] = img11;
            imgLn[12] = img12;
            imgLn[13] = img13;
            imgLn[14] = img14;
            imgLn[15] = img15;
            imgLn[16] = img16;
            imgLn[17] = img17;
            imgLn[18] = img18;
            imgLn[19] = img19;
        }
        public void setBasicObj(objUnit obj)
        {
            objBasic = obj;
        }
        public void addValue(int value)
        {
            if (value == 0)
                return;
            if (lnValueLst.Count < 20)
            {
                if (imgLn[lnValueLst.Count] != null)
                    imgLn[lnValueLst.Count].Visibility = Visibility.Visible;
            }
            else
            {
                lnValueLst.RemoveAt(0);
            }
            lnValueLst.Add(value);

            if (objBasic != null && objBasic.valueNew != 0)
            {
                for (int i = 0; i < lnValueLst.Count; i++)
                {
                    if (imgLn[i] != null)
                    {
                        if (lnValueLst[i] / objBasic.value < 0.9)
                        {
                            Canvas.SetTop(imgLn[i], 15);
                        }
                        else if (lnValueLst[i] / objBasic.value > 1.1)
                        {
                            Canvas.SetTop(imgLn[i], 0);
                        }
                        else
                        {
                            Canvas.SetTop(imgLn[i], getCurPos(lnValueLst[i], objBasic.value));
                        }

                    }
                }
            }
        }
        double getCurPos(double pos, double basicValue)
        {
            //return -75*pos/basicValue + 52.5;
            return 82.5 - 75 * pos / basicValue;
        }
    }
}
