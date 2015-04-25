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
    /// Interaction logic for tmpSetBar.xaml
    /// </summary>
    public partial class tmpSetBar : UserControl
    {
        public tmpSetBar()
        {
            InitializeComponent();
            valmoWin.dv.TmpPr[10].addHandle(refreshTmpValue);
            valmoWin.dv.TmpPr[18].addHandle(refreshTmpValue);
            valmoWin.dv.TmpPr[26].addHandle(refreshTmpValue);
            valmoWin.dv.TmpPr[34].addHandle(refreshTmpValue);
            valmoWin.dv.TmpPr[42].addHandle(refreshTmpValue);
            valmoWin.dv.TmpPr[50].addHandle(refreshTmpValue);
            valmoWin.dv.TmpPr[16].addHandle(refreshTmpValue);
            valmoWin.dv.TmpPr[24].addHandle(refreshTmpValue);
            valmoWin.dv.TmpPr[32].addHandle(refreshTmpValue);
            valmoWin.dv.TmpPr[40].addHandle(refreshTmpValue);
            valmoWin.dv.TmpPr[48].addHandle(refreshTmpValue);
            valmoWin.dv.TmpPr[56].addHandle(refreshTmpValue);
        }
        bool isMouseDown = false;
        Point mousePoint;
        //bool flagTmpKeepingState = true;//true 表示待机温度  false表示机器加热
        private bool flagTmpKeepingState
        {
            set
            {
                if (value)//true 表示待机温度
                {
                    imgKeepingDown.Opacity = 1;
                    imgHeatingDown.Opacity = 0;
                }
                else// false表示机器加热
                {
                    imgKeepingDown.Opacity = 0;
                    imgHeatingDown.Opacity = 1;
                }
                refreshTmpValue(null);
            }
            get
            {
                return imgKeepingDown.Opacity == 1;
            }
        }
        private void imgHeatingValue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = true;
            imgHeatingValueDown.Opacity = 1;
            cvsValue.Opacity = 1;
            lnFlag.Opacity = 1;
            mousePoint = e.GetPosition(this.cvsBackWin);
            lbHeatingValue.Content = ((279 - Canvas.GetTop(cvsHeatingLine)) * 400.0 / 253).ToString("0.0");
            //Console.WriteLine(Canvas.GetTop(cvsHeatingLine));
        }

        private void imgHeatingValue_MouseLeave(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            imgHeatingValueDown.Opacity = 0;
            cvsValue.Opacity = 0;
            lnFlag.Opacity = 0;
            refreshTmpValue(null);
        }
        private void imgHeatingValue_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = false;
            imgHeatingValueDown.Opacity = 0;
            cvsValue.Opacity = 0;
            lnFlag.Opacity = 0;
            double curValue = Double.Parse(lbHeatingValue.Content.ToString());
            if (!flagTmpKeepingState)
            {
                valmoWin.dv.TmpPr[10].vDblNew = curValue;
                valmoWin.dv.TmpPr[18].vDblNew = curValue;
                valmoWin.dv.TmpPr[26].vDblNew = curValue;
                valmoWin.dv.TmpPr[34].vDblNew = curValue;
                valmoWin.dv.TmpPr[42].vDblNew = curValue;
                valmoWin.dv.TmpPr[50].vDblNew = curValue;
            }
            else
            {
                valmoWin.dv.TmpPr[16].vDblNew = curValue;
                valmoWin.dv.TmpPr[24].vDblNew = curValue;
                valmoWin.dv.TmpPr[32].vDblNew = curValue;
                valmoWin.dv.TmpPr[40].vDblNew = curValue;
                valmoWin.dv.TmpPr[48].vDblNew = curValue;
                valmoWin.dv.TmpPr[56].vDblNew = curValue;
            }

            refreshTmpValue(null);
        }

        private void cvsBackWin_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = false;
        }

        private void cvsBackWin_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    Point theMousePoint = e.GetPosition(this.cvsBackWin);
                    double lnTop = Canvas.GetTop(cvsHeatingLine);
                    double tmpTop = lnTop + theMousePoint.Y - mousePoint.Y;

                    if (tmpTop <= 26)
                        tmpTop = 26;
                    else if (tmpTop >= 279)
                        tmpTop = 279;
                    double value = (279 - tmpTop) * 400.0 / 253;
                    if (value - (int)value > 0.25 && value - (int)value < 0.75)
                        setValue((int)value + 0.5);
                    else if (value - (int)value > 0.75)
                        setValue((int)value + 1);
                    else
                        setValue((int)value);
                    //setValue((279 - tmpTop) * 400.0 / 253);
                    mousePoint = theMousePoint;
                }
            }
        }

        private void lbUsual_MouseDown(object sender, MouseButtonEventArgs e)
        {
            flagTmpKeepingState = true;
        }

        private void lbHeating_MouseDown(object sender, MouseButtonEventArgs e)
        {
            flagTmpKeepingState = false;
        }
        private void setValue(double value)
        {
            Canvas.SetTop(cvsHeatingLine, 279 - value * 253.0 / 400);
            lbHeatingValue.Content = value.ToString("0.0");
            imgValueLn.Height = 270 - value * 253.0 / 400;
        }
        private void refreshTmpValue(objUnit obj)
        {
            double max = 0;
            if (!flagTmpKeepingState)
            {
                double[] curValue = new double[6];
                curValue[0] = valmoWin.dv.TmpPr[10].vDbl;
                curValue[1] = valmoWin.dv.TmpPr[18].vDbl;
                curValue[2] = valmoWin.dv.TmpPr[26].vDbl;
                curValue[3] = valmoWin.dv.TmpPr[34].vDbl;
                curValue[4] = valmoWin.dv.TmpPr[42].vDbl;
                curValue[5] = valmoWin.dv.TmpPr[50].vDbl;
                max = curValue[0];
                for (int i = 1; i < 6; i++)
                {
                    if (max < curValue[i])
                        max = curValue[i];
                }
            }
            else
            {
                double[] curValue = new double[6];
                curValue[0] = valmoWin.dv.TmpPr[16].vDbl;
                curValue[1] = valmoWin.dv.TmpPr[24].vDbl;
                curValue[2] = valmoWin.dv.TmpPr[32].vDbl;
                curValue[3] = valmoWin.dv.TmpPr[40].vDbl;
                curValue[4] = valmoWin.dv.TmpPr[48].vDbl;
                curValue[5] = valmoWin.dv.TmpPr[56].vDbl;
                max = curValue[0];
                for (int i = 1; i < 6; i++)
                {
                    if (max < curValue[i])
                        max = curValue[i];
                }
            }
            setValue(max);
        }
        private void cvsBackWin_MouseLeave(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
        public void setSecLenth(int value)
        {
            if (value == 4)
            {
                lnFlag.X2 = 469;
                Canvas.SetLeft(cvsValue, 563);
            }
            else if (value == 5)
            {
                lnFlag.X2 = 571;
                Canvas.SetLeft(cvsValue, 665);
            }
            else
            {
                lnFlag.X2 = 674;
                Canvas.SetLeft(cvsValue, 768);
            }
        }

        private void imgKeepingDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (imgKeepingDown.Opacity == 1)
            {
                imgKeepingDown.Opacity = 0;
                flagTmpKeepingState = false;

            }
            else
            {
                imgKeepingDown.Opacity = 1;
                flagTmpKeepingState = true;
            }
        }
    }
}
